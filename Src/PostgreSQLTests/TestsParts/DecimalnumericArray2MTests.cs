

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
    internal partial interface IDecimalListnumericArray
    {
    }
    
    internal partial class DecimalListnumericArray : IDecimalListnumericArray
    {


#region TestData

        private readonly DecimalnumericArray2M[] _testData = new DecimalnumericArray2M[]
        {
            new DecimalnumericArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.114106282083894m,

0.311933310259398m,

0.708528907800729m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.233672238288428m,

0.124531377940737m,

0.990962160431247m,

},
},
            new DecimalnumericArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.116022793853176m,

0.697042603637434m,

0.397991553022604m,

0.800194596072748m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.8027994819105m,

0.599695226021867m,

0.266367880305253m,

0.65308204320118m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.597485809755508m,

0.0318736672508828m,

0.758710208600422m,

},
},
            new DecimalnumericArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.434603292997603m,

0.0709790314828521m,

0.649008903012426m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.95669668998522m,

0.671731843500408m,

0.805605006595168m,

0.891151471201665m,

},
},
            new DecimalnumericArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.568561551928892m,

0.752747577578947m,

0.205742818778428m,

0.35469616059818m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.216115981599798m,

0.786421524061812m,

0.495282990133087m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.82047904048337m,

0.610737053590171m,

0.752389839978034m,

0.833936560142531m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0729625111966272m,

0.165104162478732m,

0.474515890026569m,

},
},
            new DecimalnumericArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.119145302547249m,

0.220451331812402m,

0.770678260136134m,

0.217380962239847m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342852124637489m,

0.453694600377427m,

0.410775266569607m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.321808988422092m,

0.804956775307828m,

0.479580083238343m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0973959274128692m,

0.107361769106218m,

0.650338582014314m,

0.927363141151804m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.579830016275444m,

0.930015748961693m,

0.200532236393301m,

0.710823366773899m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.451107505687163m,

0.704503003624557m,

0.10606094421053m,

0.653349596295547m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.324994380512688m,

0.268554584594008m,

0.089270833706029m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.000801910380997084m,

0.637829540475243m,

0.579378060231864m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.616546174261431m,

0.661814154723321m,

0.817015148456928m,

0.995694031502076m,

},
},
            new DecimalnumericArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.594485073610884m,

0.726279264612928m,

0.543274553660457m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00312242030531373m,

0.677536276047091m,

0.942618101022744m,

},
},
            new DecimalnumericArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00106178707687365m,

0.0916050999927137m,

0.189050679171316m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.946745447645144m,

0.0066735906822406m,

0.276266319173883m,

0.147576156971176m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.503162659369835m,

0.334015716895014m,

0.933842062843616m,

0.306533991475672m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.447735400206742m,

0.976592809171491m,

0.658502519689412m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0663361788185972m,

0.593057960892453m,

0.780164008747014m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0756821614395662m,

0.989893900034687m,

0.107761922911973m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.272854812635617m,

0.280001273212184m,

0.182417621692794m,

0.459550459880118m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.291073790981647m,

0.183891272337212m,

0.706176297565009m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.892287779752292m,

0.994070205850846m,

0.35652012784024m,

0.958928702951776m,

},
},
            new DecimalnumericArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88271314661545m,

0.818180804308396m,

0.338831731722414m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.789961796629344m,

0.509167622941332m,

0.39589337125687m,

0.213374809704784m,

},
},
            new DecimalnumericArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.807877468017421m,

0.143293234819787m,

0.118234778678767m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.74630245988668m,

0.0902016060385942m,

0.201134925065098m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.744560800121274m,

0.825102994376693m,

0.16733135095513m,

},
},
            new DecimalnumericArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.96235465123332m,

0.604134068289366m,

0.696600864650376m,

0.649804759497842m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.644260683375538m,

0.815377417412696m,

0.894351607012082m,

0.290095355972322m,

},
},
            new DecimalnumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.243786869568871m,

0.565551513739462m,

0.299950528137651m,

0.810804229614627m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24318428742392m,

0.469035153205508m,

0.162366279011962m,

0.0475757086781666m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.637957655437363m,

0.291063463905903m,

0.455104171761242m,

0.700387833348907m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.266800971770292m,

0.584207987942248m,

0.199195281078552m,

},
},
            new DecimalnumericArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0244928270276746m,

0.846291356525785m,

0.849093796047884m,

0.835154590870732m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.858425174480484m,

0.897689506770503m,

0.0971289891600418m,

0.751663696266002m,

},
},
            new DecimalnumericArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.819757011026988m,

0.714206707918511m,

0.271412734939462m,

0.52733517136493m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.38827435331536m,

0.480731987764907m,

0.370739122775536m,

0.933835553226309m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.590160070551992m,

0.331663603269903m,

0.990906690271657m,

0.0698922348765991m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0919342628617418m,

0.0865744721127948m,

0.791798232348324m,

},
},
            new DecimalnumericArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0234810218124337m,

0.953548040592995m,

0.276302027969538m,

0.615871001682338m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837123626596244m,

0.91152206016189m,

0.343137769581956m,

0.263211329857781m,

},
},
            new DecimalnumericArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.457497794701909m,

0.00810704665216733m,

0.207249701911812m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0235390250296548m,

0.433667268229519m,

0.412916940728424m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.925920398143127m,

0.646114691910252m,

0.14797252686156m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.423530697802015m,

0.55488182430392m,

0.884839885851958m,

},
},
            new DecimalnumericArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.533878586159335m,

0.907267251393784m,

0.957041861871791m,

0.707498257677824m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.762515152650072m,

0.867243153895983m,

0.641797190736878m,

0.643579992280232m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93212416617614m,

0.542650483079601m,

0.969024946989693m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0174099104596663m,

0.513054474834559m,

0.616275781440707m,

0.464608639223074m,

},
},
            new DecimalnumericArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0108107193731634m,

0.284450379817702m,

0.963383001101639m,

0.287416373668516m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.611035828121068m,

0.293689734047426m,

0.0222208067707588m,

0.471751427957879m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.182756146248772m,

0.985016714773111m,

0.104031789927643m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.413777305656018m,

0.498286874956059m,

0.764125536195532m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.531687151374646m,

0.894011244998516m,

0.684194001803772m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.992533818173995m,

0.97172514576634m,

0.62394490263192m,

0.397473894299891m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.52100988034421m,

0.738172112320637m,

0.327958298264702m,

0.352321572975794m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.854239148423461m,

0.546510054309352m,

0.389332093774722m,

},
},
            new DecimalnumericArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.166740681725954m,

0.636049637728191m,

0.6295524154407m,

0.672747201163654m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.781049748862473m,

0.0576069534453739m,

0.32164856822391m,

},
},
            new DecimalnumericArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.738639821039958m,

0.75258536716558m,

0.711701382834332m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.863630134522693m,

0.41564235573948m,

0.000432027494747578m,

0.581164106386941m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.954249599739521m,

0.432536202985097m,

0.74422618975732m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.158407980590004m,

0.319721757664166m,

0.0519889055970705m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.779220674413455m,

0.815582340574527m,

0.0603161658168573m,

},
},
            new DecimalnumericArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.850810815265185m,

0.975397207924536m,

0.465657590858574m,

0.198259053748979m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.445323230513549m,

0.273670325568487m,

0.464981487174066m,

0.870625318287274m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.658651646962074m,

0.591145016746257m,

0.00846016201504684m,

0.542777189784697m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.429350830532085m,

0.237449285595224m,

0.740277791000137m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.705837988958432m,

0.0414520292084418m,

0.427265226725749m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.927216617963337m,

0.716193402045243m,

0.0256222082119292m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.288298602876401m,

0.566055533293777m,

0.812391286691014m,

},
},
            new DecimalnumericArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.927846359122629m,

0.247738399511689m,

0.13095185640555m,

0.974580908082504m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0167305285938m,

0.896274024662126m,

0.42159882538443m,

0.90882162399107m,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
            asPartInterface: typeof(IDecimalListnumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 178;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 150;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 116, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 65, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 14, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 5, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 165, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 65, query1, 178, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 178, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 20, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 156, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                DecimalnumericArray2M.AssertModel(models[0],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[14], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[15], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[16], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[17], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[18], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[19], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[15],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[16],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[17],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[18],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[19],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[20],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[21],_testData[29], false);
                DecimalnumericArray2M.AssertModel(models[22],_testData[30], false);
                DecimalnumericArray2M.AssertModel(models[23],_testData[31], false);
                DecimalnumericArray2M.AssertModel(models[24],_testData[32], false);
                DecimalnumericArray2M.AssertModel(models[25],_testData[33], false);
                DecimalnumericArray2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                DecimalnumericArray2M.AssertModel(models[0],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[30], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[31], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[32], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[33], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray2M),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2m m
LEFT JOIN public.binary_decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models =  ((IDecimalListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models = await ((IDecimalListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI), typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models1 = new List<DecimalnumericArray2MI>();
                var models2 = new List<DecimalnumericArray2MI>();
                await ((IDecimalListnumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MI>();
                var models2 = new List<DecimalnumericArray2MI>();
                ((IDecimalListnumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

