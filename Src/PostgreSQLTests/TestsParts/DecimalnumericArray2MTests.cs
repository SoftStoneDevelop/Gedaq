

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.274694229401527m,

0.571380979096314m,

0.196200466867454m,

0.825801778325823m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.609029746004616m,

0.0674521755724571m,

0.173735593233955m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.442550107355576m,

0.902852199306851m,

0.762126744217172m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.215224738336449m,

0.491445482152638m,

0.954628228946325m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34828306194289m,

0.511038535453482m,

0.297639960450672m,

0.722579965507877m,

},
},
            new DecimalnumericArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.415176589706285m,

0.710772832337427m,

0.0775543170462492m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14846701538279m,

0.972045692617042m,

0.206799353479662m,

0.677249103694386m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.660833788394895m,

0.474445835183908m,

0.209701050778765m,

0.872970389984712m,

},
},
            new DecimalnumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0297858673527823m,

0.302155501190902m,

0.846227607650644m,

0.157938230395492m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27865037852198m,

0.0538638366808426m,

0.955316069920522m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.128652155999375m,

0.089172937335069m,

0.91437852285533m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.169000568258711m,

0.266398178968696m,

0.933490133877177m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.997024697582884m,

0.929298602454892m,

0.623276911194297m,

0.174286056255315m,

},
},
            new DecimalnumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.826047015080137m,

0.763118443038201m,

0.489442062474794m,

0.552696443468496m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.273625575115406m,

0.917223219532381m,

0.383927977273299m,

0.228037103105826m,

},
},
            new DecimalnumericArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.136817998291721m,

0.825712278473225m,

0.239834202676101m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.244167972369507m,

0.887806183924866m,

0.841596361988184m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.905102375923856m,

0.645669635323916m,

0.198181318520935m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.838100586750635m,

0.340893532904871m,

0.79111589722082m,

0.165611252735727m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.52239895875659m,

0.0764859914492166m,

0.993305542274008m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.733131620266163m,

0.595094041427132m,

0.091576708120874m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0176423191099012m,

0.52169150675439m,

0.513663039517426m,

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
0.797893295249541m,

0.580731943847186m,

0.246754112673879m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.140085151734074m,

0.0739167422149686m,

0.224748155901834m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.143190821686887m,

0.842603564853353m,

0.43027734694288m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.194472926084212m,

0.324110083189141m,

0.00700507719353183m,

0.316612302442441m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.684193092021569m,

0.0931531966132535m,

0.160832995147664m,

0.288214792119701m,

},
},
            new DecimalnumericArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.505957229932792m,

0.577988736169818m,

0.301251139522976m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.653234296719757m,

0.721850611562864m,

0.506341078203303m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78126219323457m,

0.480005590688836m,

0.902915479728613m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.121508726380442m,

0.750237526499655m,

0.728716351456872m,

},
},
            new DecimalnumericArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.935449783263171m,

0.438939146435849m,

0.416098693599155m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.963869213022615m,

0.401070294389212m,

0.232370020581148m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.80657729202537m,

0.989930051751963m,

0.842332090222824m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.666738557961268m,

0.526436553371251m,

0.396125797137444m,

0.738466784753904m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.232281949205779m,

0.428756447546537m,

0.714819282100241m,

0.716953463551144m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.997562486762613m,

0.14879595837267m,

0.746902249506395m,

},
},
            new DecimalnumericArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0548215895327047m,

0.666600974641638m,

0.386230410680617m,

0.518201731148049m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.469978694811968m,

0.660782832459407m,

0.621170838816757m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.565495601125248m,

0.714581736741955m,

0.701672362520415m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.989455056382364m,

0.558300599627516m,

0.407049199371864m,

},
},
            new DecimalnumericArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.882498368377775m,

0.344335329496231m,

0.905463771340015m,

0.0808991170632632m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.657921875835123m,

0.0795400607799731m,

0.807587937698267m,

0.278050860555759m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.497988878745131m,

0.965976907697408m,

0.876983752688905m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.029232883587235m,

0.222997030569649m,

0.189365065337016m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.228323407455716m,

0.262871776207637m,

0.480298794348063m,

},
},
            new DecimalnumericArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.556214962842049m,

0.26716975502032m,

0.797146053499615m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.722349209291524m,

0.551542077280646m,

0.342153293655143m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.181983038914886m,

0.227899698669317m,

0.86880483555048m,

0.816080676954562m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.352117420320072m,

0.701969673595266m,

0.422378308548512m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.681630088054275m,

0.72931881136327m,

0.78058532204406m,

},
},
            new DecimalnumericArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.324531421213874m,

0.0720521044233274m,

0.704630424967765m,

0.889493941170845m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.538265718509875m,

0.277007486435966m,

0.74500167351583m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0333321628567569m,

0.278708048638176m,

0.857928509043659m,

},
},
            new DecimalnumericArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0466603769850271m,

0.239762578320362m,

0.123262780781803m,

0.825158427652229m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.185106345140075m,

0.16432452445403m,

0.589374737818584m,

0.0255164614938092m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.401522337665577m,

0.232709905326013m,

0.155183724321082m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.443158204385097m,

0.832975517467863m,

0.841080171982034m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0517476473619403m,

0.451178131261263m,

0.989110173463488m,

0.356507745030385m,

},
},
            new DecimalnumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.490828735980817m,

0.230643207614824m,

0.851332866351371m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.047178685360163m,

0.903882458368087m,

0.808780017899864m,

0.645038061645319m,

},
},
            new DecimalnumericArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.050400543441496m,

0.183982238090081m,

0.777247890222352m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40682314134823m,

0.219593981355441m,

0.630323152145858m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.624804740719431m,

0.223725379063843m,

0.326877448520611m,

0.207871157047515m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.383921454019566m,

0.608418084838867m,

0.572914877941323m,

0.114036662001199m,

},
},
            new DecimalnumericArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0945518340147972m,

0.822215784200118m,

0.472731239161967m,

0.653809770666686m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0441837450918768m,

0.839763316327531m,

0.820661230166396m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.703218331523802m,

0.438300575507779m,

0.11733853688559m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0998863745231706m,

0.763805265822634m,

0.968653346000796m,

0.710963422119272m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.768878233440098m,

0.193686390055311m,

0.440805056994725m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0441510818283971m,

0.321328576226176m,

0.400748382410659m,

0.319244060699566m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.870045717203988m,

0.857659978833079m,

0.725099773134808m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.440988518609045m,

0.792573916608717m,

0.491481759444895m,

},
},
            new DecimalnumericArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.624995384392046m,

0.644196718514916m,

0.479214945435552m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.113217507894608m,

0.672029929961436m,

0.12833628735908m,

0.6643038698522m,

},
},
            new DecimalnumericArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.154865591813909m,

0.442462741789398m,

0.704840697926379m,

0.13268522364617m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.570236306176399m,

0.371790344290607m,

0.944027952213828m,

0.742288875700164m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.373315711840563m,

0.345316310855713m,

0.105226705862961m,

},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[32],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 89, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 114, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 146, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 117, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 7, query2))
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[33],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 89, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[32],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 24, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[34], false);
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
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                DecimalnumericArray2M.AssertModel(models[0],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[14], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[15], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[16], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[17], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[18], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[19], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[15],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[16],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[17],_testData[29], false);
                DecimalnumericArray2M.AssertModel(models[18],_testData[30], false);
                DecimalnumericArray2M.AssertModel(models[19],_testData[31], false);
                DecimalnumericArray2M.AssertModel(models[20],_testData[32], false);
                DecimalnumericArray2M.AssertModel(models[21],_testData[33], false);
                DecimalnumericArray2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

