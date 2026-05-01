

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
    internal partial interface INpgsqlLineSingleTypeline
    {
    }
    
    internal partial class NpgsqlLineSingleTypeline : INpgsqlLineSingleTypeline
    {


#region TestData

        private readonly NpgsqlLineline0M[] _testData = new NpgsqlLineline0M[]
        {
            new NpgsqlLineline0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.80301809815863d, b: 0.9266881607007651d, c: 0.7149994280004011d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.07625442289450779d, b: 0.013806740841905918d, c: 0.1728080967976071d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7534824865462353d, b: 0.2955888209531543d, c: 0.5774948907175138d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.983534401693258d, b: 0.7583643378683054d, c: 0.9018738350297867d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8402247984114313d, b: 0.7587493403929902d, c: 0.3500058227651196d),
},
            new NpgsqlLineline0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5217655116646346d, b: 0.8989435978150835d, c: 0.14230472176100306d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6484360176227288d, b: 0.9288671499730154d, c: 0.4072062864023014d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7530614473695618d, b: 0.33256314237369555d, c: 0.8404344697648755d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.23106765229284154d, b: 0.7165479101957506d, c: 0.8070744676994622d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9150312960101382d, b: 0.007865283723499705d, c: 0.005146437658487324d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4730700185354544d, b: 0.6639155912560226d, c: 0.3831475355071653d),
},
            new NpgsqlLineline0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.993263309952322d, b: 0.8404404690328339d, c: 0.20009580759291967d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8219610196703626d, b: 0.7650787506496277d, c: 0.4787997440276075d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.13815987301059274d, b: 0.5995455417918002d, c: 0.1922968669300451d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4065976252583262d, b: 0.8027451233272874d, c: 0.04284553223861165d),
},
            new NpgsqlLineline0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.48141410429915166d, b: 0.3544220177103876d, c: 0.5377585741429896d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2664118719267078d, b: 0.08303560985600711d, c: 0.019813902408741146d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6351516864125287d, b: 0.19495723131288434d, c: 0.34415991856441563d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9821573208140805d, b: 0.33005992121520544d, c: 0.07698639456208511d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.37293476124235314d, b: 0.21286709965610673d, c: 0.9870678175075902d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.43798516201820525d, b: 0.005409510159946063d, c: 0.1311044192654205d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7193354436081989d, b: 0.3550427663341075d, c: 0.47703829922611585d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6476059756588357d, b: 0.8621106395541727d, c: 0.9700752350622478d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7272085579061206d, b: 0.66248557234747d, c: 0.5526167938370233d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.024728771384082027d, b: 0.6838022348414496d, c: 0.5494471881648136d),
},
            new NpgsqlLineline0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13717542434104302d, b: 0.2638003071495628d, c: 0.8599262825028579d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6440051851855405d, b: 0.12861532657818897d, c: 0.6392738750315129d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9660741519409087d, b: 0.69507128110587d, c: 0.6963860608817874d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.19764483408088074d, b: 0.9088081051207798d, c: 0.5681001631252732d),
},
            new NpgsqlLineline0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.15071305077206498d, b: 0.4256462230106961d, c: 0.018912515019112952d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7594741794530471d, b: 0.10777939266322667d, c: 0.5310577740335213d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6569884140587979d, b: 0.08436500407937741d, c: 0.9273357827544688d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.02075218855213523d, b: 0.8701436885219421d, c: 0.05625054884915437d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6446511873866461d, b: 0.17285946557970921d, c: 0.8311276418792509d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5607136366279223d, b: 0.8022846374155164d, c: 0.19576351049637686d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2269176647787654d, b: 0.3268668698536099d, c: 0.004409429471926241d),
},
            new NpgsqlLineline0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.938651523330411d, b: 0.26379028022908657d, c: 0.042532851611154054d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6463771677439561d, b: 0.7444306429669462d, c: 0.28813531659752756d),
},
            new NpgsqlLineline0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.41381431067343466d, b: 0.8576895555388644d, c: 0.3567190106472139d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7354879415272696d, b: 0.8992158741147714d, c: 0.5457939498581434d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6922872138319738d, b: 0.13916839240064227d, c: 0.6215042502169298d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1546097074842988d, b: 0.8724650412187777d, c: 0.8956619887775565d),
},
            new NpgsqlLineline0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.35528920648888407d, b: 0.08220843040939696d, c: 0.7964998482285491d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7734553904487695d, b: 0.11417991580228337d, c: 0.014279614630467341d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4000527456582351d, b: 0.5301366697927766d, c: 0.4101089445598809d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3157593018192594d, b: 0.8905642137097416d, c: 0.11154832857002583d),
},
            new NpgsqlLineline0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0868117362137587d, b: 0.23333502627973124d, c: 0.44627804188762743d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4904972551359068d, b: 0.2686150017584934d, c: 0.32839116500766763d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.761372411324164d, b: 0.7320090135415865d, c: 0.9909320451332476d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.24735418733289838d, b: 0.5408993714500852d, c: 0.10451911903609334d),
},
            new NpgsqlLineline0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6203105444243723d, b: 0.056508410849816615d, c: 0.19456880915602892d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6175320017548539d, b: 0.34423723013614227d, c: 0.7291532590619001d),
},
            new NpgsqlLineline0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10379704433530668d, b: 0.9741587014486277d, c: 0.5642263353525108d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10271035164560038d, b: 0.7550093286018134d, c: 0.953212555887412d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6897916277230715d, b: 0.3014270637873975d, c: 0.18370319076008879d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2850988965416481d, b: 0.12427625139838017d, c: 0.3066266550546207d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.16162896690754325d, b: 0.11101869238580242d, c: 0.7551218233859848d),
},
            new NpgsqlLineline0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.05605948939887606d, b: 0.6642831146369054d, c: 0.4236562761614844d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6068118606025893d, b: 0.8858345825598009d, c: 0.1883198978987406d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5315006192969512d, b: 0.9423012835032273d, c: 0.5538287035469264d),
},
            new NpgsqlLineline0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.40505433045888983d, b: 0.9367114311322425d, c: 0.3776746495821738d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.33992234614407035d, b: 0.28401631621958523d, c: 0.06700574712911311d),
},
            new NpgsqlLineline0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.18325547866202696d, b: 0.2800255513706029d, c: 0.4737915075783622d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.08712962879958064d, b: 0.8129052675542658d, c: 0.645400927350327d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6370468578471309d, b: 0.8549020195747297d, c: 0.9547366138257681d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6313415466796332d, b: 0.6358030982585514d, c: 0.13828998522998726d),
},
            new NpgsqlLineline0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.006459848441813243d, b: 0.1452994671974619d, c: 0.06016849631085164d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5569719740853305d, b: 0.9923844185646915d, c: 0.9961643054078678d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8008828448451255d, b: 0.3756293828722782d, c: 0.912553678920435d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.06951388832682504d, b: 0.23544469108605437d, c: 0.9657031777566621d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.05249221967563378d, b: 0.9696533889755888d, c: 0.9650921936268883d),
},
            new NpgsqlLineline0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21146224695333748d, b: 0.5847771031989529d, c: 0.9359872226085224d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5770957134952924d, b: 0.9669192692886d, c: 0.9040988574551408d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8590147696952394d, b: 0.708720225792386d, c: 0.6516628989021941d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8257759559288864d, b: 0.11852820151138532d, c: 0.025047026696644825d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 178,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8003910650769868d, b: 0.07007640271960247d, c: 0.1349681574326672d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9754509804508246d, b: 0.10448208245294666d, c: 0.34899896274279085d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.33694439625642214d, b: 0.9971582164802738d, c: 0.863317963336483d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7303109203006445d, b: 0.42560566917285725d, c: 0.5096819648806223d),
},
            new NpgsqlLineline0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6154083368103249d, b: 0.17945860847119266d, c: 0.2319595217993583d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4730700185354544d, b: 0.6639155912560226d, c: 0.3831475355071653d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4065976252583262d, b: 0.8027451233272874d, c: 0.04284553223861165d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.024728771384082027d, b: 0.6838022348414496d, c: 0.5494471881648136d)));
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllineline0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlLine), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqllineline0mi_id", 
                methodParametrName: "npgsqllineline0mi_id", 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 39;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 105, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 71, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 169, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 132, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 132, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 90, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLineline0M.AssertModel(models[0],_testData[9], false);NpgsqlLineline0M.AssertModel(models[1],_testData[10], false);NpgsqlLineline0M.AssertModel(models[2],_testData[11], false);NpgsqlLineline0M.AssertModel(models[3],_testData[12], false);NpgsqlLineline0M.AssertModel(models[4],_testData[13], false);NpgsqlLineline0M.AssertModel(models[5],_testData[14], false);NpgsqlLineline0M.AssertModel(models[6],_testData[15], false);NpgsqlLineline0M.AssertModel(models[7],_testData[16], false);NpgsqlLineline0M.AssertModel(models[8],_testData[17], false);NpgsqlLineline0M.AssertModel(models[9],_testData[18], false);NpgsqlLineline0M.AssertModel(models[10],_testData[19], false);NpgsqlLineline0M.AssertModel(models[11],_testData[20], false);NpgsqlLineline0M.AssertModel(models[12],_testData[21], false);NpgsqlLineline0M.AssertModel(models[13],_testData[22], false);NpgsqlLineline0M.AssertModel(models[14],_testData[23], false);NpgsqlLineline0M.AssertModel(models[15],_testData[24], false);NpgsqlLineline0M.AssertModel(models[16],_testData[25], false);NpgsqlLineline0M.AssertModel(models[17],_testData[26], false);NpgsqlLineline0M.AssertModel(models[18],_testData[27], false);NpgsqlLineline0M.AssertModel(models[19],_testData[28], false);NpgsqlLineline0M.AssertModel(models[20],_testData[29], false);NpgsqlLineline0M.AssertModel(models[21],_testData[30], false);NpgsqlLineline0M.AssertModel(models[22],_testData[31], false);NpgsqlLineline0M.AssertModel(models[23],_testData[32], false);NpgsqlLineline0M.AssertModel(models[24],_testData[33], false);NpgsqlLineline0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlLineline0M.AssertModel(models[0],_testData[29], false);NpgsqlLineline0M.AssertModel(models[1],_testData[30], false);NpgsqlLineline0M.AssertModel(models[2],_testData[31], false);NpgsqlLineline0M.AssertModel(models[3],_testData[32], false);NpgsqlLineline0M.AssertModel(models[4],_testData[33], false);NpgsqlLineline0M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.80301809815863d, b: 0.9266881607007651d, c: 0.7149994280004011d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07625442289450779d, b: 0.013806740841905918d, c: 0.1728080967976071d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7534824865462353d, b: 0.2955888209531543d, c: 0.5774948907175138d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.983534401693258d, b: 0.7583643378683054d, c: 0.9018738350297867d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8402247984114313d, b: 0.7587493403929902d, c: 0.3500058227651196d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5217655116646346d, b: 0.8989435978150835d, c: 0.14230472176100306d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6484360176227288d, b: 0.9288671499730154d, c: 0.4072062864023014d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7530614473695618d, b: 0.33256314237369555d, c: 0.8404344697648755d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23106765229284154d, b: 0.7165479101957506d, c: 0.8070744676994622d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9150312960101382d, b: 0.007865283723499705d, c: 0.005146437658487324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4730700185354544d, b: 0.6639155912560226d, c: 0.3831475355071653d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.993263309952322d, b: 0.8404404690328339d, c: 0.20009580759291967d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8219610196703626d, b: 0.7650787506496277d, c: 0.4787997440276075d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13815987301059274d, b: 0.5995455417918002d, c: 0.1922968669300451d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4065976252583262d, b: 0.8027451233272874d, c: 0.04284553223861165d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48141410429915166d, b: 0.3544220177103876d, c: 0.5377585741429896d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2664118719267078d, b: 0.08303560985600711d, c: 0.019813902408741146d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6351516864125287d, b: 0.19495723131288434d, c: 0.34415991856441563d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9821573208140805d, b: 0.33005992121520544d, c: 0.07698639456208511d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37293476124235314d, b: 0.21286709965610673d, c: 0.9870678175075902d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43798516201820525d, b: 0.005409510159946063d, c: 0.1311044192654205d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7193354436081989d, b: 0.3550427663341075d, c: 0.47703829922611585d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6476059756588357d, b: 0.8621106395541727d, c: 0.9700752350622478d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7272085579061206d, b: 0.66248557234747d, c: 0.5526167938370233d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.024728771384082027d, b: 0.6838022348414496d, c: 0.5494471881648136d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13717542434104302d, b: 0.2638003071495628d, c: 0.8599262825028579d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6440051851855405d, b: 0.12861532657818897d, c: 0.6392738750315129d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9660741519409087d, b: 0.69507128110587d, c: 0.6963860608817874d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19764483408088074d, b: 0.9088081051207798d, c: 0.5681001631252732d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15071305077206498d, b: 0.4256462230106961d, c: 0.018912515019112952d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7594741794530471d, b: 0.10777939266322667d, c: 0.5310577740335213d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6569884140587979d, b: 0.08436500407937741d, c: 0.9273357827544688d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02075218855213523d, b: 0.8701436885219421d, c: 0.05625054884915437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6446511873866461d, b: 0.17285946557970921d, c: 0.8311276418792509d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5607136366279223d, b: 0.8022846374155164d, c: 0.19576351049637686d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2269176647787654d, b: 0.3268668698536099d, c: 0.004409429471926241d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.938651523330411d, b: 0.26379028022908657d, c: 0.042532851611154054d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6463771677439561d, b: 0.7444306429669462d, c: 0.28813531659752756d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.41381431067343466d, b: 0.8576895555388644d, c: 0.3567190106472139d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7354879415272696d, b: 0.8992158741147714d, c: 0.5457939498581434d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6922872138319738d, b: 0.13916839240064227d, c: 0.6215042502169298d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1546097074842988d, b: 0.8724650412187777d, c: 0.8956619887775565d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.35528920648888407d, b: 0.08220843040939696d, c: 0.7964998482285491d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7734553904487695d, b: 0.11417991580228337d, c: 0.014279614630467341d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4000527456582351d, b: 0.5301366697927766d, c: 0.4101089445598809d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3157593018192594d, b: 0.8905642137097416d, c: 0.11154832857002583d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0868117362137587d, b: 0.23333502627973124d, c: 0.44627804188762743d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4904972551359068d, b: 0.2686150017584934d, c: 0.32839116500766763d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.761372411324164d, b: 0.7320090135415865d, c: 0.9909320451332476d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24735418733289838d, b: 0.5408993714500852d, c: 0.10451911903609334d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6203105444243723d, b: 0.056508410849816615d, c: 0.19456880915602892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6175320017548539d, b: 0.34423723013614227d, c: 0.7291532590619001d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10379704433530668d, b: 0.9741587014486277d, c: 0.5642263353525108d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10271035164560038d, b: 0.7550093286018134d, c: 0.953212555887412d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6897916277230715d, b: 0.3014270637873975d, c: 0.18370319076008879d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2850988965416481d, b: 0.12427625139838017d, c: 0.3066266550546207d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16162896690754325d, b: 0.11101869238580242d, c: 0.7551218233859848d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05605948939887606d, b: 0.6642831146369054d, c: 0.4236562761614844d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6068118606025893d, b: 0.8858345825598009d, c: 0.1883198978987406d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5315006192969512d, b: 0.9423012835032273d, c: 0.5538287035469264d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40505433045888983d, b: 0.9367114311322425d, c: 0.3776746495821738d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33992234614407035d, b: 0.28401631621958523d, c: 0.06700574712911311d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18325547866202696d, b: 0.2800255513706029d, c: 0.4737915075783622d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08712962879958064d, b: 0.8129052675542658d, c: 0.645400927350327d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6370468578471309d, b: 0.8549020195747297d, c: 0.9547366138257681d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6313415466796332d, b: 0.6358030982585514d, c: 0.13828998522998726d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.006459848441813243d, b: 0.1452994671974619d, c: 0.06016849631085164d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5569719740853305d, b: 0.9923844185646915d, c: 0.9961643054078678d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8008828448451255d, b: 0.3756293828722782d, c: 0.912553678920435d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06951388832682504d, b: 0.23544469108605437d, c: 0.9657031777566621d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05249221967563378d, b: 0.9696533889755888d, c: 0.9650921936268883d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21146224695333748d, b: 0.5847771031989529d, c: 0.9359872226085224d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5770957134952924d, b: 0.9669192692886d, c: 0.9040988574551408d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8590147696952394d, b: 0.708720225792386d, c: 0.6516628989021941d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8257759559288864d, b: 0.11852820151138532d, c: 0.025047026696644825d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8003910650769868d, b: 0.07007640271960247d, c: 0.1349681574326672d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9754509804508246d, b: 0.10448208245294666d, c: 0.34899896274279085d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33694439625642214d, b: 0.9971582164802738d, c: 0.863317963336483d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7303109203006445d, b: 0.42560566917285725d, c: 0.5096819648806223d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6154083368103249d, b: 0.17945860847119266d, c: 0.2319595217993583d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.80301809815863d, b: 0.9266881607007651d, c: 0.7149994280004011d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07625442289450779d, b: 0.013806740841905918d, c: 0.1728080967976071d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7534824865462353d, b: 0.2955888209531543d, c: 0.5774948907175138d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.983534401693258d, b: 0.7583643378683054d, c: 0.9018738350297867d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8402247984114313d, b: 0.7587493403929902d, c: 0.3500058227651196d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5217655116646346d, b: 0.8989435978150835d, c: 0.14230472176100306d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6484360176227288d, b: 0.9288671499730154d, c: 0.4072062864023014d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7530614473695618d, b: 0.33256314237369555d, c: 0.8404344697648755d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23106765229284154d, b: 0.7165479101957506d, c: 0.8070744676994622d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9150312960101382d, b: 0.007865283723499705d, c: 0.005146437658487324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4730700185354544d, b: 0.6639155912560226d, c: 0.3831475355071653d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.993263309952322d, b: 0.8404404690328339d, c: 0.20009580759291967d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8219610196703626d, b: 0.7650787506496277d, c: 0.4787997440276075d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13815987301059274d, b: 0.5995455417918002d, c: 0.1922968669300451d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4065976252583262d, b: 0.8027451233272874d, c: 0.04284553223861165d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48141410429915166d, b: 0.3544220177103876d, c: 0.5377585741429896d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2664118719267078d, b: 0.08303560985600711d, c: 0.019813902408741146d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6351516864125287d, b: 0.19495723131288434d, c: 0.34415991856441563d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9821573208140805d, b: 0.33005992121520544d, c: 0.07698639456208511d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37293476124235314d, b: 0.21286709965610673d, c: 0.9870678175075902d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43798516201820525d, b: 0.005409510159946063d, c: 0.1311044192654205d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7193354436081989d, b: 0.3550427663341075d, c: 0.47703829922611585d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6476059756588357d, b: 0.8621106395541727d, c: 0.9700752350622478d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7272085579061206d, b: 0.66248557234747d, c: 0.5526167938370233d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.024728771384082027d, b: 0.6838022348414496d, c: 0.5494471881648136d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13717542434104302d, b: 0.2638003071495628d, c: 0.8599262825028579d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6440051851855405d, b: 0.12861532657818897d, c: 0.6392738750315129d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9660741519409087d, b: 0.69507128110587d, c: 0.6963860608817874d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19764483408088074d, b: 0.9088081051207798d, c: 0.5681001631252732d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15071305077206498d, b: 0.4256462230106961d, c: 0.018912515019112952d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7594741794530471d, b: 0.10777939266322667d, c: 0.5310577740335213d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6569884140587979d, b: 0.08436500407937741d, c: 0.9273357827544688d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02075218855213523d, b: 0.8701436885219421d, c: 0.05625054884915437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6446511873866461d, b: 0.17285946557970921d, c: 0.8311276418792509d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5607136366279223d, b: 0.8022846374155164d, c: 0.19576351049637686d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2269176647787654d, b: 0.3268668698536099d, c: 0.004409429471926241d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.938651523330411d, b: 0.26379028022908657d, c: 0.042532851611154054d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6463771677439561d, b: 0.7444306429669462d, c: 0.28813531659752756d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.41381431067343466d, b: 0.8576895555388644d, c: 0.3567190106472139d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7354879415272696d, b: 0.8992158741147714d, c: 0.5457939498581434d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6922872138319738d, b: 0.13916839240064227d, c: 0.6215042502169298d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1546097074842988d, b: 0.8724650412187777d, c: 0.8956619887775565d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.35528920648888407d, b: 0.08220843040939696d, c: 0.7964998482285491d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7734553904487695d, b: 0.11417991580228337d, c: 0.014279614630467341d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4000527456582351d, b: 0.5301366697927766d, c: 0.4101089445598809d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3157593018192594d, b: 0.8905642137097416d, c: 0.11154832857002583d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0868117362137587d, b: 0.23333502627973124d, c: 0.44627804188762743d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4904972551359068d, b: 0.2686150017584934d, c: 0.32839116500766763d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.761372411324164d, b: 0.7320090135415865d, c: 0.9909320451332476d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24735418733289838d, b: 0.5408993714500852d, c: 0.10451911903609334d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6203105444243723d, b: 0.056508410849816615d, c: 0.19456880915602892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6175320017548539d, b: 0.34423723013614227d, c: 0.7291532590619001d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10379704433530668d, b: 0.9741587014486277d, c: 0.5642263353525108d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10271035164560038d, b: 0.7550093286018134d, c: 0.953212555887412d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6897916277230715d, b: 0.3014270637873975d, c: 0.18370319076008879d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2850988965416481d, b: 0.12427625139838017d, c: 0.3066266550546207d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16162896690754325d, b: 0.11101869238580242d, c: 0.7551218233859848d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05605948939887606d, b: 0.6642831146369054d, c: 0.4236562761614844d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6068118606025893d, b: 0.8858345825598009d, c: 0.1883198978987406d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5315006192969512d, b: 0.9423012835032273d, c: 0.5538287035469264d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40505433045888983d, b: 0.9367114311322425d, c: 0.3776746495821738d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33992234614407035d, b: 0.28401631621958523d, c: 0.06700574712911311d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18325547866202696d, b: 0.2800255513706029d, c: 0.4737915075783622d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08712962879958064d, b: 0.8129052675542658d, c: 0.645400927350327d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6370468578471309d, b: 0.8549020195747297d, c: 0.9547366138257681d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6313415466796332d, b: 0.6358030982585514d, c: 0.13828998522998726d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.006459848441813243d, b: 0.1452994671974619d, c: 0.06016849631085164d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5569719740853305d, b: 0.9923844185646915d, c: 0.9961643054078678d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8008828448451255d, b: 0.3756293828722782d, c: 0.912553678920435d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06951388832682504d, b: 0.23544469108605437d, c: 0.9657031777566621d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05249221967563378d, b: 0.9696533889755888d, c: 0.9650921936268883d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21146224695333748d, b: 0.5847771031989529d, c: 0.9359872226085224d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5770957134952924d, b: 0.9669192692886d, c: 0.9040988574551408d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8590147696952394d, b: 0.708720225792386d, c: 0.6516628989021941d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8257759559288864d, b: 0.11852820151138532d, c: 0.025047026696644825d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8003910650769868d, b: 0.07007640271960247d, c: 0.1349681574326672d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9754509804508246d, b: 0.10448208245294666d, c: 0.34899896274279085d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33694439625642214d, b: 0.9971582164802738d, c: 0.863317963336483d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7303109203006445d, b: 0.42560566917285725d, c: 0.5096819648806223d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6154083368103249d, b: 0.17945860847119266d, c: 0.2319595217993583d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllineline0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLineline0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
FROM public.binary_npgsqllineline0m m
LEFT JOIN public.binary_npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLineline0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLineline0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI), typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLineline0MI>();
                var models2 = new List<NpgsqlLineline0MI>();
                await ((INpgsqlLineSingleTypeline)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MI>();
                var models2 = new List<NpgsqlLineline0MI>();
                ((INpgsqlLineSingleTypeline)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

