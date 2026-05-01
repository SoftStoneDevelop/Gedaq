

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
    internal partial interface IDoubleArraydouble_precisionArray
    {
    }
    
    internal partial class DoubleArraydouble_precisionArray : IDoubleArraydouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray1M[] _testData = new Doubledouble_precisionArray1M[]
        {
            new Doubledouble_precisionArray1M
{
    Id = 3,
    Value = 
new System.Double[4]
{
0.1469104840778529d,
0.6899797977200011d,
0.26879833052387625d,
0.6592540980806999d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3008132955668599d,
0.3878173205919738d,
0.18141912730157717d,
0.994175391409295d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 12,
    Value = 
new System.Double[3]
{
0.30997859952317897d,
0.6114059101441903d,
0.8794401311138558d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 6,
    Value = 
new System.Double[4]
{
0.019508891216491797d,
0.5841781854388222d,
0.6744214450353568d,
0.7107505735552009d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 19,
    Value = 
new System.Double[3]
{
0.32182888263806386d,
0.030231419105257618d,
0.5209750845184759d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 22,
    Value = 
new System.Double[4]
{
0.2449261145307453d,
0.1848253510248279d,
0.9892175553453905d,
0.7657530257203481d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 10,
    Value = 
new System.Double[3]
{
0.967003343790777d,
0.7468330840593704d,
0.43102871027619283d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 25,
    Value = 
new System.Double[4]
{
0.5844033582967203d,
0.975548018686958d,
0.4530884769724326d,
0.6564486502438934d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.41887783455373995d,
0.3841377309164007d,
0.9860736530493683d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 32,
    Value = 
new System.Double[3]
{
0.3176588913867202d,
0.42695986635625693d,
0.7709824385772626d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 18,
    Value = 
new System.Double[4]
{
0.5089092298875662d,
0.9461423416158731d,
0.6943265629618285d,
0.2253547246616091d,
},
    NullableValue = 
new System.Double[3]
{
0.46799879494494667d,
0.24165007437044572d,
0.780055564401043d,
},
},
    NullableValue = 
new System.Double[3]
{
0.1258596230752108d,
0.14204100457288626d,
0.2168892370081824d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 41,
    Value = 
new System.Double[4]
{
0.9321371372664364d,
0.4080369000661801d,
0.9719422626130612d,
0.7849829405624951d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8212761829751535d,
0.28973413666616255d,
0.3574970789798265d,
0.6666689225602825d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 50,
    Value = 
new System.Double[4]
{
0.9409576181298424d,
0.5609247051978222d,
0.3044434533242373d,
0.309174951758173d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 24,
    Value = 
new System.Double[3]
{
0.15486644062441868d,
0.9546869731983172d,
0.33386655139947174d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 56,
    Value = 
new System.Double[3]
{
0.18724148610826274d,
0.8537162053341079d,
0.004832109114772165d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.29399635600285623d,
0.5351033132442603d,
0.6749192471811555d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 58,
    Value = 
new System.Double[4]
{
0.8585693196768852d,
0.2196774235580502d,
0.42129924900492555d,
0.5445668044783589d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 29,
    Value = 
new System.Double[4]
{
0.9060529646560994d,
0.8957053986669213d,
0.9066147169043012d,
0.9566264189858702d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.40971892827859224d,
0.5385359718945756d,
0.5427886743428945d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 66,
    Value = 
new System.Double[3]
{
0.9450481865357431d,
0.11831928158722027d,
0.2436349390238256d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.6982092115012394d,
0.7579644003944939d,
0.4368714301369012d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 71,
    Value = 
new System.Double[3]
{
0.16350157336416848d,
0.2067424375370529d,
0.34022028562853046d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 35,
    Value = 
new System.Double[4]
{
0.08761073775685957d,
0.03273078754284775d,
0.1485989615744001d,
0.5306286039828657d,
},
    NullableValue = 
new System.Double[4]
{
0.7467975391757956d,
0.8118579776964131d,
0.006098988564353314d,
0.4401323353007677d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 76,
    Value = 
new System.Double[3]
{
0.4363093908357527d,
0.6302548222894467d,
0.8426771669642216d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.3516852284132981d,
0.36547477248781224d,
0.5647160183101474d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 81,
    Value = 
new System.Double[3]
{
0.9453370767108266d,
0.7803258228885667d,
0.39601303296962853d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 42,
    Value = 
new System.Double[3]
{
0.722168662005832d,
0.259591414440683d,
0.7111968660997533d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.4794765950134d,
0.9211417177819601d,
0.20189126116589928d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 90,
    Value = 
new System.Double[3]
{
0.32782331081556204d,
0.944541422049987d,
0.3243977375189204d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 99,
    Value = 
new System.Double[4]
{
0.637511534430349d,
0.15814394865638326d,
0.6894345356474042d,
0.8441720883947088d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 43,
    Value = 
new System.Double[4]
{
0.48828671030550697d,
0.14386563603794666d,
0.9608751626397417d,
0.7235793905349817d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.33611772200213996d,
0.5469917496796658d,
0.9052193626574457d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 104,
    Value = 
new System.Double[3]
{
0.9022312922706704d,
0.7625326049569381d,
0.5064336090340196d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.5489671035312025d,
0.8301508903084563d,
0.06672643691749525d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 111,
    Value = 
new System.Double[4]
{
0.874515849734403d,
0.4862275737735088d,
0.817774856147027d,
0.045012294289028754d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 44,
    Value = 
new System.Double[4]
{
0.6275551174137693d,
0.12091176784341406d,
0.5864296178567886d,
0.7357339890347925d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.6558393094178463d,
0.7331849961296001d,
0.4335402967581832d,
0.22638232985518436d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 119,
    Value = 
new System.Double[3]
{
0.7962824811224924d,
0.1654364597136173d,
0.1319343443086456d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.45956870510820313d,
0.6169044459899339d,
0.41636204290399137d,
0.33670329913721586d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 126,
    Value = 
new System.Double[3]
{
0.1081846493709927d,
0.40211154822147865d,
0.029176083530281338d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 46,
    Value = 
new System.Double[3]
{
0.9180496066684468d,
0.2905657828684377d,
0.4808158540482862d,
},
    NullableValue = 
new System.Double[4]
{
0.797993239600778d,
0.654075264818214d,
0.7777641890216935d,
0.4807037653034255d,
},
},
    NullableValue = 
new System.Double[4]
{
0.16487238981596275d,
0.5629918818043835d,
0.6687315385185009d,
0.41666444317155815d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 127,
    Value = 
new System.Double[3]
{
0.12608361498970844d,
0.5605456265212265d,
0.5547716593315883d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 128,
    Value = 
new System.Double[4]
{
0.12686516486328836d,
0.05180502723520297d,
0.2039872954058657d,
0.3014485245684284d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 54,
    Value = 
new System.Double[4]
{
0.2682768321674527d,
0.9095751111331067d,
0.42391254448047966d,
0.6745412600058538d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.11130198971891059d,
0.5974245272225525d,
0.6745265423789367d,
0.06897457321718559d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 136,
    Value = 
new System.Double[4]
{
0.5840212236363898d,
0.7244538381506784d,
0.08939108406677598d,
0.5743979149443207d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.05901559256618405d,
0.19899200102199277d,
0.5750323321711868d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 142,
    Value = 
new System.Double[3]
{
0.5167062231015828d,
0.9595192148564246d,
0.1600228690897404d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 59,
    Value = 
new System.Double[3]
{
0.5826171842970459d,
0.039708124946768675d,
0.4686346938136293d,
},
    NullableValue = 
new System.Double[4]
{
0.2233372879575234d,
0.9004763586843378d,
0.6163508145132115d,
0.08986963363097233d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 147,
    Value = 
new System.Double[3]
{
0.22741832839064835d,
0.6921765724908495d,
0.13909640562349823d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 149,
    Value = 
new System.Double[4]
{
0.5787909037276824d,
0.5843968674354157d,
0.23024623867360505d,
0.2803326516880078d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 65,
    Value = 
new System.Double[4]
{
0.5838524776793541d,
0.3067605576020449d,
0.34427928909317007d,
0.6990157361253507d,
},
    NullableValue = 
new System.Double[3]
{
0.30538439271744044d,
0.2269853106548092d,
0.26712259694047646d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 150,
    Value = 
new System.Double[3]
{
0.2969523259344372d,
0.8792337548005406d,
0.23078939428293088d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7911665417858171d,
0.02400358584479756d,
0.04384117530289067d,
0.197910871732617d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 151,
    Value = 
new System.Double[4]
{
0.6792724994397229d,
0.17041911230232432d,
0.7396247850071229d,
0.3758391309732434d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 67,
    Value = 
new System.Double[4]
{
0.7497332132388606d,
0.24305182892212862d,
0.49421709060518604d,
0.529856367161322d,
},
    NullableValue = 
new System.Double[4]
{
0.7657077731356873d,
0.34093456628874474d,
0.7966590355810491d,
0.8608250429204908d,
},
},
    NullableValue = 
new System.Double[4]
{
0.21997223046161096d,
0.5050653310368374d,
0.29327976180595594d,
0.9671247508989653d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 155,
    Value = 
new System.Double[3]
{
0.5660650930160469d,
0.21853758154968084d,
0.3491179889449385d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 162,
    Value = 
new System.Double[3]
{
0.19334778870501446d,
0.49011717960900714d,
0.5494034348719218d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 76,
    Value = 
new System.Double[4]
{
0.2843864901771582d,
0.7141682619184154d,
0.28240148375545615d,
0.05951531652461439d,
},
    NullableValue = 
new System.Double[4]
{
0.6680152047498757d,
0.9136856524482523d,
0.990527366739258d,
0.3254200048683765d,
},
},
    NullableValue = 
new System.Double[3]
{
0.5511819293264265d,
0.29894421020203144d,
0.32832619567589816d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 164,
    Value = 
new System.Double[4]
{
0.5066513844920298d,
0.1231786719047595d,
0.28979420320664495d,
0.040201946873356875d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.7304997126414762d,
0.7129725093518683d,
0.2857394760571972d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 173,
    Value = 
new System.Double[4]
{
0.8132486358490526d,
0.9238306082268274d,
0.4047452444488546d,
0.6343300543005778d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.8969843916905555d,
0.3296349983026242d,
0.29387694187056024d,
0.5430449891732547d,
},
    NullableValue = 
new System.Double[4]
{
0.031878631563069026d,
0.4958730828716609d,
0.7757068932401284d,
0.6523930579101718d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 177,
    Value = 
new System.Double[3]
{
0.29884229540315943d,
0.8922088057100782d,
0.5666329592893392d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8259579007916678d,
0.9984727138278169d,
0.39756791134878966d,
0.9708956125153257d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 186,
    Value = 
new System.Double[4]
{
0.8134650453766689d,
0.7603922013129721d,
0.906175803533696d,
0.995880796182793d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 84,
    Value = 
new System.Double[4]
{
0.16041159611554034d,
0.6286945367800878d,
0.04067676393031938d,
0.019368508370332105d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.48073168003465927d,
0.17099828154503494d,
0.7952535375638771d,
0.4084387944270593d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 188,
    Value = 
new System.Double[4]
{
0.9725229651776173d,
0.4887854192114085d,
0.8901811348261797d,
0.6448175573729259d,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
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

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.41887783455373995d,
0.3841377309164007d,
0.9860736530493683d,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.1258596230752108d,
0.14204100457288626d,
0.2168892370081824d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.8212761829751535d,
0.28973413666616255d,
0.3574970789798265d,
0.6666689225602825d,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                System.Double[] nullable = null;
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.29399635600285623d,
0.5351033132442603d,
0.6749192471811555d,
}));
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.40971892827859224d,
0.5385359718945756d,
0.5427886743428945d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.6982092115012394d,
0.7579644003944939d,
0.4368714301369012d,
}));
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 90, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 12, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 56, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 71, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 71, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 162, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 147))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 127, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[34], false);
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
                await using var cmd = await ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[29], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[30], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[31], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[32], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[33], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[14], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[15], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[19],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[20],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[21],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[22],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[23],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[24],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[25],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[26],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[27],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[28],_testData[29], false);
                Doubledouble_precisionArray1M.AssertModel(models[29],_testData[30], false);
                Doubledouble_precisionArray1M.AssertModel(models[30],_testData[31], false);
                Doubledouble_precisionArray1M.AssertModel(models[31],_testData[32], false);
                Doubledouble_precisionArray1M.AssertModel(models[32],_testData[33], false);
                Doubledouble_precisionArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray1m m
LEFT JOIN public.binary_doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI), typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                await ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleArraydouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

