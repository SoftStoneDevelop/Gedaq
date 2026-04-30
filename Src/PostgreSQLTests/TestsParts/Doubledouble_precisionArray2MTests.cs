

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11787566242711811d,

0.4496120749222935d,

0.6096094312909706d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2561964896901908d,

0.867277341382706d,

0.9470539820983479d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.30588875483504685d,

0.6223030188947545d,

0.48515560490446796d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9271377011166237d,

0.7020895554915142d,

0.8644673094989138d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5894069457390906d,

0.7863333634360226d,

0.5033467404875785d,

0.12999296104246316d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.349389778807197d,

0.6711357979092872d,

0.11235384076964694d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4749635561518931d,

0.5879249139225194d,

0.25580785852722376d,

0.15211695313200124d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18838279279916492d,

0.6905314794691182d,

0.3466057888662991d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11523576927052848d,

0.8342209464167901d,

0.8708385160095934d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9273480032994871d,

0.3137080046687766d,

0.5206987462762424d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5371153800856849d,

0.6777038379678737d,

0.695593858275353d,

0.8811630381914625d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.026990909492339732d,

0.3928801438730114d,

0.9536831947496699d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7349056646505367d,

0.09358506132379452d,

0.15037299340103605d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.22533231831346878d,

0.6195711034530992d,

0.48471429365119445d,

0.6168162214044665d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08043282917930938d,

0.1076379780101101d,

0.23216612247256885d,

0.43145088940705556d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47525346043471206d,

0.012364907491278831d,

0.28043314982163037d,

0.6151728226529345d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.005216563088068282d,

0.6894352399120109d,

0.7877786952974867d,

0.5382079850656364d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.38873534949234345d,

0.8260721168761382d,

0.5720846635085115d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8309377082982643d,

0.4155311991416094d,

0.4917919005229848d,

0.623871047042246d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6099691842232091d,

0.21497036986241402d,

0.7424810059517398d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3566202583903393d,

0.8207037626615712d,

0.8256893650054171d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5949854337909822d,

0.000563339860748302d,

0.5484938906923438d,

0.4017475416801598d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6932530697663982d,

0.9698063403860676d,

0.6839048733078305d,

0.717713661578472d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5783881136341973d,

0.779212041158032d,

0.988137938082113d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.542101303259543d,

0.3271076250427384d,

0.4414005320286687d,

0.9586482492114901d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9610013838996657d,

0.6698882400008498d,

0.3325603541050358d,

0.7748783182715091d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6049737874870827d,

0.23010785388637445d,

0.08858740465500525d,

0.9924745885409858d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4761045137974984d,

0.27666502548121874d,

0.14581614344608085d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7092526425280012d,

0.8275483521394312d,

0.5335579936685285d,

0.1742721753293176d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.05369583892036445d,

0.13403178357172174d,

0.40254503732961355d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.979419607680297d,

0.46240328013307885d,

0.8541893155674642d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8310735664346632d,

0.3400436284296301d,

0.1312780234138381d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3374736265226649d,

0.17630060658753988d,

0.16996605024293077d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48218689594164765d,

0.3161447672564103d,

0.8408342963380268d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4153374029359054d,

0.38614117045639673d,

0.7632238380038303d,

0.8673473071999226d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4449733311144224d,

0.7153819728708604d,

0.4822456659879528d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9382249206967441d,

0.0688646139868303d,

0.6504091489810265d,

0.6244491984751116d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4554271734751205d,

0.23796159442768372d,

0.999344616914778d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7901274838849102d,

0.8884678077868996d,

0.7075103593796142d,

0.5898030537196723d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7059645084066636d,

0.6895041116229143d,

0.6244344529235918d,

0.8289706697412046d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.17254007361877077d,

0.6453696264660759d,

0.3011327998003771d,

0.20327518868464212d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19097041311747576d,

0.3748803548721895d,

0.7062293638097634d,

0.9940627178391004d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7960943994675929d,

0.002387352922047059d,

0.5426264753940876d,

0.3929310908154834d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.32107974728209254d,

0.973259175118863d,

0.6076095185626806d,

0.685944569907947d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4810590177831756d,

0.6917070960182936d,

0.49123774706120826d,

0.6656826712358558d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.06809978119360882d,

0.26648865222448925d,

0.6909016707075081d,

0.13114497941439207d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.06887810390481497d,

0.28253435226738544d,

0.36489214905542877d,

0.991056486022643d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.11305330116664158d,

0.5487011249903103d,

0.17253692431767542d,

0.7400892129703078d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9219265150847845d,

0.8653517238510049d,

0.04366834945038578d,

0.716364058027845d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7803233431346994d,

0.3695112345190331d,

0.5169742104268872d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4955558618987721d,

0.11325500982363934d,

0.9470600059223933d,

0.9264588926351888d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5499212244516869d,

0.8044594603894245d,

0.61342408220991d,

0.08111648752228584d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.00566722297526201d,

0.698999285514572d,

0.5034774735995772d,

0.8189555971230651d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.45462496987344736d,

0.22645935125787908d,

0.4408141426324279d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08596137615544441d,

0.08693319118546672d,

0.011983927181646314d,

0.6329129768471607d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.10064386566956351d,

0.7642240786396401d,

0.9124162603573527d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7583237718580057d,

0.9426166075046064d,

0.13143059868639484d,

0.5212260804420525d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9237593670239824d,

0.6297122748311719d,

0.6251521275441133d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6834662044895363d,

0.9179100414267164d,

0.9045663898269081d,

0.33582433331260864d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5542941550297774d,

0.48097756055433016d,

0.4358788245051787d,

0.6294488035730914d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6330925536352969d,

0.510256296223394d,

0.6661878464765384d,

0.5775925092519333d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2893858622660431d,

0.810580721186926d,

0.5405709104756437d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5000499570528043d,

0.3197191210462049d,

0.9404950097444336d,

0.7328523938533169d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5191202145071149d,

0.22304116852581235d,

0.5965505344834697d,

0.41030154985983625d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10163497045414749d,

0.4199845906281018d,

0.8134016735636714d,

0.6915657614248765d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4675906450727826d,

0.6584919766247511d,

0.3596054876242816d,

0.459485485867797d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08898406783021828d,

0.1586811307435263d,

0.14933604724894656d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2105813424971137d,

0.31009977764590835d,

0.10270010530375018d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6162204203031242d,

0.7171324506292653d,

0.13015767510810394d,

0.32110686850962566d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8739943811480755d,

0.10381837271662286d,

0.2582390760791399d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7945222107113392d,

0.9794085669719763d,

0.4671277054842259d,

0.9407254281910266d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13780676154091864d,

0.827975981343546d,

0.21247918260503063d,

0.29895742530633096d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3925401229077893d,

0.16192263368780724d,

0.6264387817040702d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.34178784740680956d,

0.46522488309820276d,

0.9769352715507912d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20132479019062288d,

0.22731469114973024d,

0.05031025074317219d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6736046229642009d,

0.3684423926197097d,

0.632998975131634d,

0.870390077550958d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9838766818007513d,

0.47121298027257186d,

0.06550946948040937d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6684908117659928d,

0.6551226500158898d,

0.5356826798793092d,

0.8190693601494109d,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 4;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 105, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 28, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 98, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 100, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 40, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[30],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 56, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 4, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 61, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[3], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[4], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[25],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[26],_testData[29], false);Doubledouble_precisionArray2M.AssertModel(models[27],_testData[30], false);Doubledouble_precisionArray2M.AssertModel(models[28],_testData[31], false);Doubledouble_precisionArray2M.AssertModel(models[29],_testData[32], false);Doubledouble_precisionArray2M.AssertModel(models[30],_testData[33], false);Doubledouble_precisionArray2M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[30], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[31], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[32], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[33], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MI),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

