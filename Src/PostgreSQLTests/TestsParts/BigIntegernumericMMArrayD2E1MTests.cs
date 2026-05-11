

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
    internal partial interface IBigIntegerMArraynumericMMArrayD2
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD2 : IBigIntegerMArraynumericMMArrayD2
    {


#region TestData

        private readonly BigIntegernumericMMArrayD2E1M[] _testData = new BigIntegernumericMMArrayD2E1M[]
        {
            new BigIntegernumericMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5636717487089459571L),
new System.Numerics.BigInteger(2171795110201926167L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5279135857474566075L),
new System.Numerics.BigInteger(853444368834729792L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3219870730037084876L),
new System.Numerics.BigInteger(7856402732163991593L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8483256840740019864L),
new System.Numerics.BigInteger(8827430664931864768L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1818893229620207976L),
new System.Numerics.BigInteger(5261475047461439636L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2614071901358998197L),
new System.Numerics.BigInteger(4107296968900280106L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3582030134030062374L),
new System.Numerics.BigInteger(8997987372416563402L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1005909381881549911L),
new System.Numerics.BigInteger(2551497208575778984L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1968335370782650517L),
new System.Numerics.BigInteger(8909035125779684523L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6462276337599787462L),
new System.Numerics.BigInteger(6906118077853341932L), } },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1059596848873709211L),
new System.Numerics.BigInteger(3145078056806413119L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2048922144730063107L),
new System.Numerics.BigInteger(252026191415229613L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7583786267838688092L),
new System.Numerics.BigInteger(265593009617782932L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1171395525527218326L),
new System.Numerics.BigInteger(8678518901850028493L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6509268465294083133L),
new System.Numerics.BigInteger(5621572184233184209L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1110242663387754947L),
new System.Numerics.BigInteger(220058361440791279L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6782713217334660975L),
new System.Numerics.BigInteger(373984538066623299L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(615184368551503341L),
new System.Numerics.BigInteger(505272325021434853L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2856621549377473115L),
new System.Numerics.BigInteger(8941531827420062002L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6935762104244726130L),
new System.Numerics.BigInteger(3343299760077904987L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7506463382745631741L),
new System.Numerics.BigInteger(7514075185400188086L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(76378013746786183L),
new System.Numerics.BigInteger(7426263795061277422L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6839328938066331935L),
new System.Numerics.BigInteger(2155672876109677100L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5459565685136406065L),
new System.Numerics.BigInteger(4260623370787479845L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6424266964732244950L),
new System.Numerics.BigInteger(7938507154310057159L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7919493196853558421L),
new System.Numerics.BigInteger(2279146157381712401L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(266911566115743298L),
new System.Numerics.BigInteger(6845322397220358972L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6227052766798206101L),
new System.Numerics.BigInteger(6637924340598371926L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5122000060791269244L),
new System.Numerics.BigInteger(2264238369887893489L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8437085972900274743L),
new System.Numerics.BigInteger(1031586515196708621L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4310575457554608297L),
new System.Numerics.BigInteger(6711446093134571425L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8515126132541285571L),
new System.Numerics.BigInteger(1844174274002095330L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6734256658733706289L),
new System.Numerics.BigInteger(8623198576863576131L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1135950366836343718L),
new System.Numerics.BigInteger(1003731089666194675L), } },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6760189907212506665L),
new System.Numerics.BigInteger(2652116754728787464L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1851223457018308847L),
new System.Numerics.BigInteger(3793856487502377170L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1689737252660065679L),
new System.Numerics.BigInteger(4287758791174241939L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2861943092465595926L),
new System.Numerics.BigInteger(7709886144779677253L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6937423208535551000L),
new System.Numerics.BigInteger(6932623213700222531L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4679258741124894058L),
new System.Numerics.BigInteger(7742099775666063263L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1172770350183846665L),
new System.Numerics.BigInteger(7390937489308207445L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1353641004880818388L),
new System.Numerics.BigInteger(1340774201635933861L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7638950353007411861L),
new System.Numerics.BigInteger(8108999162052043951L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7379192228508548557L),
new System.Numerics.BigInteger(1077646729588839976L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2365050006134640464L),
new System.Numerics.BigInteger(2616630396237937182L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8588857301215247014L),
new System.Numerics.BigInteger(2771134291107694038L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(9219659984135327055L),
new System.Numerics.BigInteger(6506082865527483124L), } },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6800344965839907283L),
new System.Numerics.BigInteger(2028251893798603821L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2667599453581864656L),
new System.Numerics.BigInteger(5519815963764782982L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4873354410493211500L),
new System.Numerics.BigInteger(7548788209251354144L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7921943223121205436L),
new System.Numerics.BigInteger(7485577753304402375L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7293225518286139475L),
new System.Numerics.BigInteger(5305437602787557332L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4464148502131492236L),
new System.Numerics.BigInteger(7442293311896251717L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7109301264082959710L),
new System.Numerics.BigInteger(6992748298711944395L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7341106666354525140L),
new System.Numerics.BigInteger(7592567357993170495L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(775706353638363858L),
new System.Numerics.BigInteger(2686930878892945652L), } },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7309256549375967930L),
new System.Numerics.BigInteger(5518397433357713377L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5868901033039960396L),
new System.Numerics.BigInteger(2270608930251110508L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(913134457692511217L),
new System.Numerics.BigInteger(5613039289345202094L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3809816301629215506L),
new System.Numerics.BigInteger(1293565678213370930L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2523311268745292249L),
new System.Numerics.BigInteger(5142825657920548614L), } },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6043041975005180504L),
new System.Numerics.BigInteger(617298886926567729L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(4304593366028743973L),
new System.Numerics.BigInteger(1015331411012279184L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6566288343503269797L),
new System.Numerics.BigInteger(2199118420865616646L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(7414801493151379430L),
new System.Numerics.BigInteger(3834903210841873929L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(5717974574263358350L),
new System.Numerics.BigInteger(3703254001396252902L), } },
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(629424767959877296L),
new System.Numerics.BigInteger(177272299503624627L), } },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(173997087300299084L),
new System.Numerics.BigInteger(6681521180865812761L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8245789755883751423L),
new System.Numerics.BigInteger(2806625912960897359L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1858479420868214151L),
new System.Numerics.BigInteger(1209880163445850464L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8337541489651233595L),
new System.Numerics.BigInteger(5924775637481403178L), } },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(6698925724453477540L),
new System.Numerics.BigInteger(8102719288011635565L), } },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 176,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8232728346392715292L),
new System.Numerics.BigInteger(3515255345382575408L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3693977517703474596L),
new System.Numerics.BigInteger(814716710450174983L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 185,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(3411335978361074351L),
new System.Numerics.BigInteger(9154090736583561514L), } },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 194,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(8471321953937205971L),
new System.Numerics.BigInteger(6031087849544235382L), } },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(1514199025139126143L),
new System.Numerics.BigInteger(4104738206725206041L), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 203,
    Value = 
new System.Numerics.BigInteger[,] { {
new System.Numerics.BigInteger(2215257585550419381L),
new System.Numerics.BigInteger(8669797212922356593L), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)), 
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
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
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
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 88, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 68, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 131, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 82, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 166, 131))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 37, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MI),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1M),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
FROM public.binary_bigintegernumericmmarrayd2e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI), typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

