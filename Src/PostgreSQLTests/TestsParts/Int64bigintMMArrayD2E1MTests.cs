

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
    internal partial interface IInt64MArraybigintMMArrayD2
    {
    }
    
    internal partial class Int64MArraybigintMMArrayD2 : IInt64MArraybigintMMArrayD2
    {


#region TestData

        private readonly Int64bigintMMArrayD2E1M[] _testData = new Int64bigintMMArrayD2E1M[]
        {
            new Int64bigintMMArrayD2E1M
{
    Id = 6,
    Value = 
new System.Int64[,] { { 6311039267929806032L, 5410304349573273015L, }, { 3812139759011629932L, 4639098837123100425L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int64[,] { { 7850505490274164419L, 6704116685745748142L, }, { 2250014053631627162L, 1136753477696327615L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Int64[,] { { 8141758756399837790L, 5597484351331233371L, }, { 1304671687978384752L, 7364125741907902796L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 3188476630778055510L, 2581821753408910693L, }, { 5455373056802098398L, 3835468968500048215L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Int64[,] { { 3453497788333547550L, 821888671068913648L, }, { 5118240346761342453L, 460005129048103772L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Int64[,] { { 58930818916198062L, 5050002708521213100L, }, { 8378555399912224213L, 5712661131749213175L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Int64[,] { { 8494321880047443855L, 1158062937363565368L, }, { 6372087122238116286L, 2166957473199169763L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 1377710149992160495L, 3853130219738584068L, }, { 5650960327747557395L, 3641169786396155080L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Int64[,] { { 553315959435238644L, 3750048332424190605L, }, { 843464370667116026L, 759585127304296924L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 1171780602149895741L, 5057108505178329709L, }, { 6827777891743743042L, 4522554551666738521L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Int64[,] { { 2046203202211102823L, 4979691485129625717L, }, { 7503746531916753577L, 3188272091218867433L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Int64[,] { { 5049626050916637581L, 4647702545537475231L, }, { 3459932585138877542L, 7626325181604772626L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Int64[,] { { 1741046605536743421L, 5150592916445989316L, }, { 7113057552671659509L, 5665673850776159643L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int64[,] { { 4279925017851095152L, 3521803662032801193L, }, { 1198504073083882436L, 5556029027671906633L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Int64[,] { { 2200908372295626136L, 7447123834887421098L, }, { 7698009102752097176L, 4912154925987969855L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 1868194991278940887L, 5127604539137479491L, }, { 8738523955533304773L, 3025146275224282844L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Int64[,] { { 4917251917997217757L, 8244503097384285322L, }, { 5764555635325221955L, 3358143371086780779L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 2730068508078644196L, 374449091891928130L, }, { 4470338356586324260L, 766306548353947756L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int64[,] { { 4673326705031387477L, 4760193048965762227L, }, { 6671223462526938388L, 70725126952668056L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Int64[,] { { 3758588330289652898L, 5703552851918480113L, }, { 6494845515571401710L, 698066127360995350L, }, },
    NullableValue = 
new System.Int64[,] { { 4369864039361427917L, 8002276560057906372L, }, { 6639067439346703702L, 5512422944159914964L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6052097519678251505L, 8630617558994476053L, }, { 6746552925179284023L, 733146748609293538L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Int64[,] { { 1934886337218307141L, 373513822243587900L, }, { 4771399807857893914L, 6145971729661350207L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int64[,] { { 7496733306195946219L, 5533770991276489747L, }, { 1817366529508446989L, 8105936356063032731L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Int64[,] { { 1961043516391618039L, 3747071729699282709L, }, { 5593993967484653688L, 5826010177477790830L, }, },
    NullableValue = 
new System.Int64[,] { { 600647081843191016L, 8920547030042598860L, }, { 408895205744011804L, 8772171123382031091L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Int64[,] { { 5559748147969666062L, 563399271975545879L, }, { 4606533090017271397L, 6414167916140439737L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Int64[,] { { 8877884576150857553L, 4953617703600984651L, }, { 2800564263391295552L, 7167985034989557985L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Int64[,] { { 8856060260770995791L, 5786136588687757152L, }, { 1783717971389890284L, 8320313047889974510L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 5476055267501979884L, 275430058483227147L, }, { 8632357337398042773L, 6778392623874696039L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Int64[,] { { 3624583557203968572L, 3305170390969796655L, }, { 4161342406231360442L, 6638014507873931297L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int64[,] { { 3767661591851443547L, 5318380432096614872L, }, { 9177942143989810150L, 955544018316838638L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Int64[,] { { 2109439888320501056L, 3548132037889513804L, }, { 2123745429862025839L, 1132141100042022386L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4315258232148649495L, 7959657780638547741L, }, { 1508295885964080594L, 4529875865330879884L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Int64[,] { { 8966362765820513941L, 8912649141729064440L, }, { 321547767647175833L, 8712610643038111474L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Int64[,] { { 4036528254839214382L, 4168142999176520333L, }, { 2216486549168541200L, 5148615553876406517L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Int64[,] { { 2664886774624444133L, 688633791358852566L, }, { 6428566963863418145L, 606894968648750622L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Int64[,] { { 4180358788928298447L, 4759337786951849282L, }, { 5450245393235767960L, 1932740579500586794L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int64[,] { { 2268902680983434158L, 1823632802624797332L, }, { 1131477758769885547L, 8073285073963329083L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Int64[,] { { 5314953975837860137L, 4278314781681911571L, }, { 1336366311728986365L, 4557065452168271733L, }, },
    NullableValue = 
new System.Int64[,] { { 3002676348222996376L, 5078553726733625392L, }, { 4737191794941667203L, 8736373540396715437L, }, },
},
    NullableValue = 
new System.Int64[,] { { 9005999812056806572L, 2780857344508016154L, }, { 8729538124643270916L, 4942946350301352927L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Int64[,] { { 6836347781663219562L, 1986170339795609831L, }, { 6758132409108483132L, 6619467227677542371L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Int64[,] { { 3088737835220704234L, 812696063204002957L, }, { 1534574309991502866L, 1694368584935433633L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Int64[,] { { 8501472888302215663L, 2716876988610424796L, }, { 1285309526980835362L, 5555371352705880587L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6803242678461122933L, 5209624059000877043L, }, { 1560942652229577421L, 3817007491755098099L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int64[,] { { 115563887599938493L, 3566384802450310998L, }, { 8406233050248839900L, 3762597097951929366L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 1214569703580930755L, 712810638504532586L, }, { 6728732003493346271L, 4475265166131221154L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Int64[,] { { 3521805871816704661L, 4997425479737822503L, }, { 4543443443181955836L, 5144836275988415419L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int64[,] { { 2323559988615805211L, 8649880583604127767L, }, { 8951470928552877050L, 3400833277733811887L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Int64[,] { { 8772869670832372197L, 2419934043059865876L, }, { 6397074484453008461L, 4650532968083620992L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 8799439674158469418L, 5747354939559432428L, }, { 8821431218724205376L, 9219897469233345152L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int64[,] { { 5263019331215740287L, 112206874812170840L, }, { 3100569685711090699L, 6733700139476703486L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Int64[,] { { 5642979438948158080L, 8405387701202147707L, }, { 1418269532589323486L, 7682729939137759305L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Int64[,] { { 5043287491479018324L, 1347240074699415660L, }, { 7147434973724895752L, 8429638173989542990L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 3287582715550126348L, 5994677808695243605L, }, { 2365501710827053471L, 1942583871957669129L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int64[,] { { 4232466698671147358L, 1758462971090935828L, }, { 6455568550401169193L, 3382748812570093996L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Int64[,] { { 6909060032858973151L, 5898322347376417506L, }, { 2194889406644016733L, 3602442436954279931L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Int64[,] { { 2885625508935754704L, 9215429319933368725L, }, { 6907377782542574385L, 1548568934221812078L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Int64[,] { { 6943445017850564923L, 3510902017368403886L, }, { 3945550920383843044L, 5922165644807366765L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Int64[,] { { 3511779973643502235L, 6418173773308643882L, }, { 4898464860428282493L, 4797861976867229794L, }, },
    NullableValue = 
new System.Int64[,] { { 5536241730378320162L, 4201656260699780375L, }, { 7615616182977319644L, 3241379122501530805L, }, },
},
    NullableValue = 
new System.Int64[,] { { 138475053388086854L, 8170178414793819055L, }, { 6270285460489375031L, 2420192837742287647L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Int64[,] { { 2237872958225373108L, 827740184743234860L, }, { 8592268052829976842L, 3376007931931620780L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 3917285461589585086L, 2411807621351531494L, }, { 8139381933691299388L, 8018262564254655219L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int64[,] { { 5269257480768390901L, 3273342808828888765L, }, { 1362875345239344147L, 4411302269763031169L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Int64[,] { { 7810010080537969286L, 5729034286256939302L, }, { 4420260882621913548L, 3409078078602774636L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Int64[,] { { 8215744499597529119L, 5158389240451472692L, }, { 6099651633125181021L, 601332244139217013L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 2480773265111486552L, 8754751035123102780L, }, { 5614150223296385258L, 635754357893152169L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int64[,] { { 1049168142766741151L, 4558583817854274677L, }, { 7000277103551547785L, 1916276272830529649L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Int64[,] { { 3581434469772222700L, 1081729745140085325L, }, { 1543090176121147644L, 5116505271568514327L, }, },
    NullableValue = 
new System.Int64[,] { { 2375313245237830796L, 7365843790409522010L, }, { 4791422948606376110L, 2411234501057122019L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Int64[,] { { 2091414385973171738L, 1201887131590457841L, }, { 5745787018632434176L, 2772612325332001131L, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1mi(
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd2e1mi_id", 
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
                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                System.Int64[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 1171780602149895741L, 5057108505178329709L, }, { 6827777891743743042L, 4522554551666738521L, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Int64[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 1868194991278940887L, 5127604539137479491L, }, { 8738523955533304773L, 3025146275224282844L, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd2e1mi_id", 
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
                System.Int64[,] nullable = null;
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 2730068508078644196L, 374449091891928130L, }, { 4470338356586324260L, 766306548353947756L, }, }));
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 6052097519678251505L, 8630617558994476053L, }, { 6746552925179284023L, 733146748609293538L, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[,] nullable = null;
                nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD2E1M> models = null;

                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD2E1M> models = null;

                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 121;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 146, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 110, query1, 149, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 130, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 130, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 100, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 10, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
FROM public.binary_int64bigintmmarrayd2e1m m
LEFT JOIN public.binary_int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI), typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintMMArrayD2E1MI>();
                var models2 = new List<Int64bigintMMArrayD2E1MI>();
                await ((IInt64MArraybigintMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MI>();
                var models2 = new List<Int64bigintMMArrayD2E1MI>();
                ((IInt64MArraybigintMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

