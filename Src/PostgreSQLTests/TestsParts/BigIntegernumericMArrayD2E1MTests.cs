

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
    internal partial interface IBigIntegerMArraynumericMArrayD2
    {
    }
    
    internal partial class BigIntegerMArraynumericMArrayD2 : IBigIntegerMArraynumericMArrayD2
    {


#region TestData

        private readonly BigIntegernumericMArrayD2E1M[] _testData = new BigIntegernumericMArrayD2E1M[]
        {
            new BigIntegernumericMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(52156825394129490L),
new System.Numerics.BigInteger(9035689720955947429L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1020388209285840295L),
new System.Numerics.BigInteger(7768331490993094904L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 2,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(312383023182583486L),
new System.Numerics.BigInteger(7560375267284364370L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1449040152507591612L),
new System.Numerics.BigInteger(4259940936801413197L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2028591786270285901L),
new System.Numerics.BigInteger(1839742361842976342L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4593064613046263285L),
new System.Numerics.BigInteger(4420166267178690151L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 3,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4542883354946562471L),
new System.Numerics.BigInteger(6676241909021908170L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7616578402464620913L),
new System.Numerics.BigInteger(2672051086427854902L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1518665047588888688L),
new System.Numerics.BigInteger(1929783135008352958L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(67071130341979657L),
new System.Numerics.BigInteger(4013126224083901041L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2637155674121537527L),
new System.Numerics.BigInteger(6854983074345694876L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(447958949707202570L),
new System.Numerics.BigInteger(912300747636303853L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3962258733180644210L),
new System.Numerics.BigInteger(1871272486476820356L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5242394491880759055L),
new System.Numerics.BigInteger(6152110224782002142L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(670622393678301372L),
new System.Numerics.BigInteger(7294356648605421754L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2358703547103623582L),
new System.Numerics.BigInteger(877693601923243690L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3445825431831728321L),
new System.Numerics.BigInteger(6891265942920772873L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3781355946136314345L),
new System.Numerics.BigInteger(3205801461315419927L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(526027063822160332L),
new System.Numerics.BigInteger(3491472620845932980L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7664537694917193599L),
new System.Numerics.BigInteger(9145719155649272767L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2724892383663984450L),
new System.Numerics.BigInteger(1936194514517431850L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 33,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1887153013812838008L),
new System.Numerics.BigInteger(7581739385438743311L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3400398033063705392L),
new System.Numerics.BigInteger(8129110455226287588L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(9080691266329890100L),
new System.Numerics.BigInteger(1546902229115176024L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2317220143511784350L),
new System.Numerics.BigInteger(3432805257390962304L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8342010268456092070L),
new System.Numerics.BigInteger(8238872735611905740L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8440121721550549981L),
new System.Numerics.BigInteger(4148960322474409461L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4235934208493156252L),
new System.Numerics.BigInteger(2393591398709231852L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7116566715166691446L),
new System.Numerics.BigInteger(4650687735474246855L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6193263422079558428L),
new System.Numerics.BigInteger(1296304456518698476L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1101225975624517789L),
new System.Numerics.BigInteger(9131541735678388770L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2653904300317723902L),
new System.Numerics.BigInteger(5523411288461303322L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6005406881523202699L),
new System.Numerics.BigInteger(832868373177412765L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1963822616086944361L),
new System.Numerics.BigInteger(7731606808141341064L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 51,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3716515229500219552L),
new System.Numerics.BigInteger(467822815663040374L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2813582179018691577L),
new System.Numerics.BigInteger(6104837032203642516L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6232761377252324795L),
new System.Numerics.BigInteger(8995084375613244476L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6674691658740696182L),
new System.Numerics.BigInteger(4234893179479048662L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4508069684829166233L),
new System.Numerics.BigInteger(1719837003264029409L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7916879366801087611L),
new System.Numerics.BigInteger(7727843912150989186L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8672458717531626572L),
new System.Numerics.BigInteger(122361750453111386L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1445570867590577295L),
new System.Numerics.BigInteger(844223844639573255L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3007011127612613187L),
new System.Numerics.BigInteger(6720553044544959762L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5799898637895604833L),
new System.Numerics.BigInteger(2165762630360347091L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6520052196140421316L),
new System.Numerics.BigInteger(5604493277881850484L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5641946016649050326L),
new System.Numerics.BigInteger(9043524479329373941L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7067091084103099957L),
new System.Numerics.BigInteger(8680593821301663224L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5728193203075261066L),
new System.Numerics.BigInteger(3066653342250063233L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5438397015695304767L),
new System.Numerics.BigInteger(3154863627961775540L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5587421125936494523L),
new System.Numerics.BigInteger(5422378814315527019L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4176761739777885875L),
new System.Numerics.BigInteger(930230571838383538L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 62,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(973415046565668757L),
new System.Numerics.BigInteger(8074311858426997979L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8351805026896878424L),
new System.Numerics.BigInteger(1653490218560269242L), } },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7368614993255931913L),
new System.Numerics.BigInteger(7656906245314433824L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2393590510501358718L),
new System.Numerics.BigInteger(8151968033097022333L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1839879558003686663L),
new System.Numerics.BigInteger(2860395356118306138L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(929170396475710432L),
new System.Numerics.BigInteger(1387123562701348890L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5602722930924673930L),
new System.Numerics.BigInteger(5748135505706953683L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8767013423868344981L),
new System.Numerics.BigInteger(3535279139829341356L), } },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2798919165529387186L),
new System.Numerics.BigInteger(452126256911843476L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5784504853437240285L),
new System.Numerics.BigInteger(5227300167269339900L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6449092475421788609L),
new System.Numerics.BigInteger(5649964961988325989L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1030222576447202173L),
new System.Numerics.BigInteger(9222517742682070023L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8375235096618209182L),
new System.Numerics.BigInteger(1385945164566689017L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5411976774385415042L),
new System.Numerics.BigInteger(306366711906945454L), } },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1709444291362954620L),
new System.Numerics.BigInteger(7263087880589622158L), } },
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4417723033943053528L),
new System.Numerics.BigInteger(1825012097003817857L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7633805117711801275L),
new System.Numerics.BigInteger(6436227625547722137L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 76,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1207321616548535877L),
new System.Numerics.BigInteger(9140339061181727878L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(9090557900098288163L),
new System.Numerics.BigInteger(231467406494779295L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 177,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7742768725715606268L),
new System.Numerics.BigInteger(1068926527133809731L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5076355880077796684L),
new System.Numerics.BigInteger(4286655762356615409L), } },
    ModelInner = new BigIntegernumericMArrayD21MI
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8889590621118739505L),
new System.Numerics.BigInteger(4690764561189868659L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3706296723525370175L),
new System.Numerics.BigInteger(7618492175191680668L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMArrayD2E1M
{
    Id = 184,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(410317617658836407L),
new System.Numerics.BigInteger(4861853427575341804L), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmarrayd21mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmarrayd21mi(
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
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmarrayd21mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmarrayd21mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmarrayd21mi_id
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
    bigintegernumericmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
INSERT INTO public.bigintegernumericmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmarrayd21mi_id
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
    bigintegernumericmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmarrayd21mi_id", 
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
                List<BigIntegernumericMArrayD2E1M> models = null;

                models =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMArrayD2E1M> models = null;

                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMArrayD2E1M), typeof(FlatBigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                ((IBigIntegerMArraynumericMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
LEFT JOIN public.bigintegernumericmarrayd21mi mi ON mi.id = m.bigintegernumericmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMArrayD2E1M), typeof(FlatBigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                ((IBigIntegerMArraynumericMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
LEFT JOIN public.bigintegernumericmarrayd21mi mi ON mi.id = m.bigintegernumericmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMArrayD2E1M), typeof(FlatBigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await((IBigIntegerMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
LEFT JOIN public.bigintegernumericmarrayd21mi mi ON mi.id = m.bigintegernumericmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMArrayD2E1M), typeof(FlatBigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await((IBigIntegerMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 173, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 96, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 101, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 165, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
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
FROM public.bigintegernumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 101, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatBigIntegernumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.bigintegernumericmarrayd2e1m m
LEFT JOIN public.bigintegernumericmarrayd21mi mi ON mi.id = m.bigintegernumericmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 8, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 39, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 165);
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((IBigIntegerMArraynumericMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                BigIntegernumericMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                BigIntegernumericMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_bigintegernumericmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMArrayD21MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMArrayD21MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
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
FROM public.binary_bigintegernumericmarrayd2e1m m
LEFT JOIN public.binary_bigintegernumericmarrayd21mi mi ON mi.id = m.bigintegernumericmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IBigIntegerMArraynumericMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA), typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericMArrayD21MIWA>();
                var models2 = new List<BigIntegernumericMArrayD21MIWA>();
                await ((IBigIntegerMArraynumericMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMArrayD21MIWA>();
                var models2 = new List<BigIntegernumericMArrayD21MIWA>();
                ((IBigIntegerMArraynumericMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmarrayd21mi
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
                    BigIntegernumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmarrayd21mi
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
                    BigIntegernumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA), typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
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
                var models1 = new List<BigIntegernumericMArrayD21MIWA>();
                var models2 = new List<BigIntegernumericMArrayD21MIWA>();
                await ((IBigIntegerMArraynumericMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMArrayD21MIWA>();
                var models2 = new List<BigIntegernumericMArrayD21MIWA>();
                ((IBigIntegerMArraynumericMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmarrayd21mi
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
                    BigIntegernumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmarrayd21mi
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
                    BigIntegernumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MI), typeof(BigIntegernumericMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericMArrayD21MI>();
                var models2 = new List<BigIntegernumericMArrayD21MI>();
                await ((IBigIntegerMArraynumericMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMArrayD21MI>();
                var models2 = new List<BigIntegernumericMArrayD21MI>();
                ((IBigIntegerMArraynumericMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA), typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
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
                var models1 = new List<BigIntegernumericMArrayD21MIWA>();
                var models2 = new List<BigIntegernumericMArrayD21MIWA>();
                await ((IBigIntegerMArraynumericMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMArrayD21MIWA>();
                var models2 = new List<BigIntegernumericMArrayD21MIWA>();
                ((IBigIntegerMArraynumericMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

