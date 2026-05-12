

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
    Id = 4,
    Value = 
new System.Int64[,] { { 1005716684360111709L, 3390072824581127444L, }, { 8256226721320384726L, 5816781229184403811L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 587276606570883829L, 930971851000463314L, }, { 4512699463129785804L, 2142938212234237155L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Int64[,] { { 167642221527561214L, 7797461493329480990L, }, { 5258539427099246402L, 2081341519111607426L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Int64[,] { { 1195750153364007251L, 8264633479812016314L, }, { 222337072336448620L, 6336656159968233920L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int64[,] { { 5756031920412205335L, 6184558501482124356L, }, { 1264387648225708674L, 1770719888364324464L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7121860893537065710L, 5584728757331172071L, }, { 3269733940356579935L, 5973179939379069867L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Int64[,] { { 5160698792176569045L, 3728524935832362111L, }, { 2191729845637132131L, 8382943674470820020L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Int64[,] { { 7045757388965497702L, 3887900410864794683L, }, { 5374819383454088120L, 9151789099373904095L, }, },
    NullableValue = 
new System.Int64[,] { { 9132819305735947671L, 4335589097184976571L, }, { 9179770246624041082L, 8460033896925534373L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2217870004403701425L, 6819434011949200879L, }, { 3644440429673758180L, 3675073087422279058L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Int64[,] { { 4274170664991444715L, 4994092993161079391L, }, { 3504812241548005626L, 5160075768817167314L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Int64[,] { { 3289057672510651870L, 6973945554831933990L, }, { 8667306621950521012L, 720484410243710378L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Int64[,] { { 5979462160025401922L, 4821386511723625542L, }, { 6952233243823543573L, 6341996705601609290L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Int64[,] { { 5592843069174122715L, 6281281239010220182L, }, { 7369739691811870416L, 943882448954607990L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Int64[,] { { 5304747993737312246L, 305179725756483636L, }, { 2049523880864154543L, 8012479889454162732L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Int64[,] { { 4541193284264727679L, 1085502429799023970L, }, { 3459470199625779856L, 5892965855637028886L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6096585435018883582L, 2075405208477745106L, }, { 8884477804192256265L, 4767324647467036815L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int64[,] { { 3898057139031566872L, 3084406415690378673L, }, { 4133885475434292730L, 180045218211633170L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int64[,] { { 1359408771173256221L, 5562096398267234747L, }, { 5966913134353504003L, 6178295942810003798L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Int64[,] { { 4793011209225888661L, 350593390573864383L, }, { 3621846023366040903L, 5989824096875468452L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Int64[,] { { 6898663963752724593L, 4006408549022798822L, }, { 6905692270323121081L, 6804589254082064622L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Int64[,] { { 299816502956367851L, 5685433801714101256L, }, { 8844083884744225751L, 8471151227200784624L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Int64[,] { { 7814052846996540048L, 3176225173438443881L, }, { 7184092620879610991L, 7956884749258464964L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Int64[,] { { 4103432688172472505L, 2282180816597575908L, }, { 8140105967823665688L, 2066877168469735332L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 6522475041342707063L, 1978921247528243000L, }, { 2540380541559127722L, 3626149347522236450L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Int64[,] { { 8356803626414868474L, 7958147360557685285L, }, { 8979760920510702315L, 870145348754527186L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Int64[,] { { 7694525999004738314L, 2686567624452660992L, }, { 3497483377617452983L, 7520363011146471422L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Int64[,] { { 1013556177341193142L, 8587427156773061742L, }, { 6261479631473806167L, 4123753249956345049L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Int64[,] { { 7518422941746602029L, 1909538553376797124L, }, { 6729551763409458332L, 5874306609860321306L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Int64[,] { { 8983725026586820598L, 874083063315897092L, }, { 5637746575073824699L, 982772418225232300L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 1340289059159530629L, 8716566847599934414L, }, { 6810507835739951068L, 304788506108651810L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Int64[,] { { 5014926214321383302L, 778791148882245951L, }, { 6112963146022414774L, 5262916157762198815L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 9182802624343380373L, 1278437610142946098L, }, { 644411050519401884L, 2309447286468839454L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int64[,] { { 8287469295330671882L, 3164153670232718499L, }, { 5600207540359691619L, 3032499572245806809L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Int64[,] { { 5167899834273408331L, 1464859145226864584L, }, { 4286163069489032627L, 4990703392705018930L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Int64[,] { { 757611578088486361L, 4661149728232115973L, }, { 8849980346724831371L, 6633350788745746945L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 8955374721258658249L, 4608268537656309254L, }, { 4591364225518311033L, 522607606991140368L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int64[,] { { 590087742789562955L, 4226500873707935792L, }, { 2588469100338979850L, 785570157631997322L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Int64[,] { { 3417089804133165144L, 5099798631349978743L, }, { 6547837158995267096L, 4656439594229562997L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6173085107286838331L, 2052820714459197456L, }, { 3573928347204022774L, 4252765456028296192L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Int64[,] { { 6769515451802259432L, 2812785516507404453L, }, { 6316272957145233127L, 2940170187633436441L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 2601091469612759483L, 7599590675827870001L, }, { 4083317551605193971L, 6818132287333303367L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int64[,] { { 6901600143111072566L, 737399311794555670L, }, { 361793485142640920L, 1282252962007596753L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int64[,] { { 1103049417575100551L, 8655240393829429840L, }, { 1507589629953992772L, 8196579861904179345L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4899236383360638512L, 3113478163761392180L, }, { 2269363224469667897L, 2946377071790338789L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Int64[,] { { 186320681680067634L, 4441134595154629817L, }, { 5525675724611874229L, 3157689553452497231L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Int64[,] { { 7040455403920580794L, 8820611723835778968L, }, { 4828372928349563490L, 9146045432883978678L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int64[,] { { 4376399214943075715L, 3723536103096083566L, }, { 1074098172273708391L, 7326936960793228323L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Int64[,] { { 4220450013643599922L, 5129636600653761070L, }, { 6130032869425203315L, 3291639430195934020L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int64[,] { { 7729584443965277777L, 4198351948212199336L, }, { 3497147270080513871L, 5397050563447436035L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Int64[,] { { 4365699780434531795L, 8480113919306596709L, }, { 2887257554696311348L, 3364599066362750380L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 299927900960272293L, 5941875600090474187L, }, { 2420989419681737198L, 7869287268471236766L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Int64[,] { { 1512118401614197072L, 4652401186105768563L, }, { 6887100500383972884L, 7992817200630049331L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 4792826785600253802L, 6987469470162139625L, }, { 3814863442873850444L, 5714361049029563461L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int64[,] { { 1339572992055631373L, 228118099304852198L, }, { 1237875526335244480L, 6109005276564810630L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Int64[,] { { 3968523396748038438L, 7246194337183088246L, }, { 2738260831633968635L, 3089721945561320088L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Int64[,] { { 5899865210273827054L, 8862470178112670093L, }, { 7545744443109279578L, 5864696634283523769L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Int64[,] { { 9034073364341424757L, 6939982479152406978L, }, { 6515023517874680832L, 4067335600944930707L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Int64[,] { { 5464907003603074259L, 5973130426937008962L, }, { 4641972260874568985L, 4615332169468989108L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 3408188482538166140L, 1516177839850483176L, }, { 1672102659746561914L, 6929706640678719900L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Int64[,] { { 7938691010707242786L, 1521276716395913901L, }, { 8347729831502056117L, 7505109994143148654L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 9078519385143380263L, 714646316319319810L, }, { 5117391139113844907L, 9179227435833711128L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Int64[,] { { 5302346233884725179L, 8231458559219933113L, }, { 1467453375914651965L, 3566120790274216131L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Int64[,] { { 4332324801744674535L, 5149552094585207732L, }, { 5103919574035614110L, 6969852347661662605L, }, },
    NullableValue = 
new System.Int64[,] { { 8640041188763724154L, 4057386403116026527L, }, { 5530513277779538381L, 7643792053353400545L, }, },
},
    NullableValue = 
new System.Int64[,] { { 8472303524393627654L, 6310565021622043941L, }, { 8936894239448768002L, 4124375048501277260L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int64[,] { { 2418224630326480902L, 3701421964215161374L, }, { 5233784703915227305L, 3806583858097485196L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7834932469460308326L, 47406846022564349L, }, { 629355033297799625L, 2886574079492669317L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int64[,] { { 1296169556804441644L, 1063452669226362558L, }, { 8292772340286103582L, 5723645169452035200L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Int64[,] { { 8965506634823150835L, 1795736391871560836L, }, { 8134866680388385345L, 711638088745761027L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Int64[,] { { 6498652943441804937L, 2546637002015748168L, }, { 4758954644502100627L, 4714415411260734019L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 4013817735642601981L, 2347649829657122178L, }, { 2463295409397256407L, 4991152357971721866L, }, },
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
                Assert.That(nullable, Is.Null);
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
new System.Int64[,] { { 6096585435018883582L, 2075405208477745106L, }, { 8884477804192256265L, 4767324647467036815L, }, }));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 112;
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

                    if(resultIndex == 2)
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
                parametr1.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 117, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 146, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 146, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 72, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 83, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 83, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 88, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 41))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 121, 29))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

