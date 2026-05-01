

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
0.144564626986708m,

0.207352441383741m,

0.945946791908708m,

0.015370031475951m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.825042667486684m,

0.559637277083618m,

0.573750970199303m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.358925498042501m,

0.565151675517642m,

0.647401215291506m,

0.268484584577379m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.926446788776143m,

0.656393956432496m,

0.0287575006366532m,

0.136730406686159m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0699083988038359m,

0.40715479720872m,

0.490277524340748m,

},
},
            new DecimalnumericArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.739499791532888m,

0.950341765525019m,

0.77099782947398m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.488569777752996m,

0.159656403375617m,

0.81843691657275m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.655934030326631m,

0.908177818756257m,

0.0468234497482581m,

0.256240555947417m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.150991866944491m,

0.139231944272405m,

0.533119053560415m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.262036748943857m,

0.90784769773062m,

0.491744655176088m,

0.159735876568182m,

},
},
            new DecimalnumericArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0758080943354614m,

0.632396482101576m,

0.67619128486617m,

0.212921119783302m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.914397639037442m,

0.161975021628063m,

0.939634917850659m,

0.621000236404777m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.339387823705698m,

0.271636672455203m,

0.758673864764879m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.709483274611827m,

0.331004203413383m,

0.208988140140669m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0219465910566743m,

0.988385459086553m,

0.639832903984948m,

0.44468164436685m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.848817272464336m,

0.674414790706394m,

0.40638299232426m,

0.563008804315589m,

},
},
            new DecimalnumericArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.979235564706761m,

0.389782180137833m,

0.10282259501008m,

0.12031412439281m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.775292013411163m,

0.478500021884028m,

0.517428046385789m,

0.806243133196723m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.831562388256061m,

0.832719854679602m,

0.838340265248914m,

},
},
            new DecimalnumericArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.657914889438824m,

0.178712449421885m,

0.903452104719236m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.601847559546462m,

0.537855142030101m,

0.571050628940487m,

},
},
            new DecimalnumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.272651353055965m,

0.974764005790312m,

0.554081218680147m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.283206432830555m,

0.124963348126796m,

0.574624833659116m,

0.673814663126698m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.712186330659128m,

0.139063903861932m,

0.281895968437444m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.278530967835643m,

0.0169684982716516m,

0.550390416610871m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.690062322049582m,

0.520422323651918m,

0.671397453628106m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.157168006062015m,

0.385877886873126m,

0.0999895028430765m,

0.931628066756956m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.590373690780471m,

0.207609718072972m,

0.800153091530675m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0453867598880718m,

0.453327968781944m,

0.383995147257167m,

0.324278277792074m,

},
},
            new DecimalnumericArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.551672081859627m,

0.152352115114175m,

0.970769769932892m,

0.951624293637162m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.523765715454309m,

0.0130009296212371m,

0.856393498172798m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.352186575182887m,

0.562030753160788m,

0.96268652631614m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.80885049376722m,

0.67428129550586m,

0.821375078800764m,

0.176019851582928m,

},
},
            new DecimalnumericArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.920700060076767m,

0.454960650210076m,

0.435258849302846m,

0.0421701596970477m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.553420350772727m,

0.624574757808836m,

0.0902267844734277m,

0.700810874719754m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.537293359947995m,

0.547946663103735m,

0.952541950372848m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.265559005071037m,

0.950869056565436m,

0.196193106740066m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.580791574493264m,

0.545009645058711m,

0.364485147992273m,

0.73421092565356m,

},
},
            new DecimalnumericArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.971848501399291m,

0.410117733509902m,

0.801344896003488m,

0.805023774144899m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.400647134237138m,

0.187848253920967m,

0.892733795068839m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.60497283801099m,

0.202998527686694m,

0.714611240817113m,

0.329918623079192m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.866528928183142m,

0.588050287749671m,

0.0121043346605848m,

0.334481288013162m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0993800785110233m,

0.764784247778064m,

0.82281579850321m,

0.183678197020679m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.484647513293982m,

0.989758331143634m,

0.0544789115827113m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.228760063375341m,

0.822971962202164m,

0.365174368841973m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14896178043069m,

0.758689338844355m,

0.658308849076989m,

0.592427437755761m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108559119262714m,

0.80300908380004m,

0.586073750207351m,

0.0338991459145848m,

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
0.696673465458127m,

0.203265346631145m,

0.304240431397284m,

0.643062735143797m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.466557606124994m,

0.43295568386842m,

0.306262184241419m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.436366336824962m,

0.979403157227436m,

0.0786156378538762m,

},
},
            new DecimalnumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.419255420531122m,

0.673696786630952m,

0.482659458975447m,

0.685211467141435m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.67519821003654m,

0.530396477597983m,

0.873084880805941m,

0.220426791758495m,

},
},
            new DecimalnumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.63749048814469m,

0.636372747260053m,

0.409645299238607m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.754841033860446m,

0.32478204029238m,

0.0418599885188873m,

0.958946024708199m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.733046408028554m,

0.199476455100771m,

0.405522810890155m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.620602307402946m,

0.94543747861135m,

0.199916964825885m,

},
},
            new DecimalnumericArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.949956307841916m,

0.612154193747287m,

0.903925932180885m,

0.854597839682003m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.310871176117236m,

0.358672585774298m,

0.504583847160213m,

},
},
            new DecimalnumericArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.173929695335057m,

0.141630638703234m,

0.879824714846739m,

0.830410963771198m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.458857419354593m,

0.577245998023431m,

0.81827502600282m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.243817158596754m,

0.792080584039759m,

0.717106334314574m,

0.885680764595458m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.28854698620805m,

0.807137866682217m,

0.37177978202457m,

0.102604909932428m,

},
},
            new DecimalnumericArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.588440474355326m,

0.690446430852965m,

0.666291475951106m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.807404043483097m,

0.651869870189955m,

0.929743840098522m,

0.254412890565033m,

},
},
            new DecimalnumericArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.174718627855922m,

0.156063679030927m,

0.893928688841443m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.53715501272949m,

0.174726424302209m,

0.989436522095211m,

0.400016452470366m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.766191917548064m,

0.750054376088032m,

0.0995895879301054m,

0.871856126791715m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.97439883418005m,

0.446003280746426m,

0.437079515160609m,

0.111611132529483m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.599681519113837m,

0.438048585757561m,

0.602236573106827m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.377089613652344m,

0.0794497383686723m,

0.293025534435205m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.229559570278826m,

0.0936569172698025m,

0.751773947926994m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.666992101194993m,

0.10053154825712m,

0.139840315038178m,

},
},
            new DecimalnumericArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.601931860805171m,

0.65937340128051m,

0.0869219412876361m,

0.275624118016596m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.294085146505191m,

0.401061762611436m,

0.0353620261595841m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.760524994976476m,

0.90090998137442m,

0.080169818235976m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.433462744086651m,

0.744297539541295m,

0.321677345449616m,

},
},
            new DecimalnumericArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.411774052231147m,

0.495563836471759m,

0.427519165213239m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.206063640342178m,

0.739776090765085m,

0.984648160496388m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.9845614852024m,

0.685365786071522m,

0.579827697073239m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.192798714262293m,

0.307947555881468m,

0.485900258389674m,

0.976835478827429m,

},
},
            new DecimalnumericArray2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.136083266605369m,

0.745999982760634m,

0.855371471311594m,

0.184990864394097m,

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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr2.Value = 125;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 80, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 133, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 125, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 83, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 111, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 26, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 39, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 11, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[34], false);
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
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
DecimalnumericArray2M.AssertModel(models[0],_testData[1], false);DecimalnumericArray2M.AssertModel(models[1],_testData[2], false);DecimalnumericArray2M.AssertModel(models[2],_testData[3], false);DecimalnumericArray2M.AssertModel(models[3],_testData[4], false);DecimalnumericArray2M.AssertModel(models[4],_testData[5], false);DecimalnumericArray2M.AssertModel(models[5],_testData[6], false);DecimalnumericArray2M.AssertModel(models[6],_testData[7], false);DecimalnumericArray2M.AssertModel(models[7],_testData[8], false);DecimalnumericArray2M.AssertModel(models[8],_testData[9], false);DecimalnumericArray2M.AssertModel(models[9],_testData[10], false);DecimalnumericArray2M.AssertModel(models[10],_testData[11], false);DecimalnumericArray2M.AssertModel(models[11],_testData[12], false);DecimalnumericArray2M.AssertModel(models[12],_testData[13], false);DecimalnumericArray2M.AssertModel(models[13],_testData[14], false);DecimalnumericArray2M.AssertModel(models[14],_testData[15], false);DecimalnumericArray2M.AssertModel(models[15],_testData[16], false);DecimalnumericArray2M.AssertModel(models[16],_testData[17], false);DecimalnumericArray2M.AssertModel(models[17],_testData[18], false);DecimalnumericArray2M.AssertModel(models[18],_testData[19], false);DecimalnumericArray2M.AssertModel(models[19],_testData[20], false);DecimalnumericArray2M.AssertModel(models[20],_testData[21], false);DecimalnumericArray2M.AssertModel(models[21],_testData[22], false);DecimalnumericArray2M.AssertModel(models[22],_testData[23], false);DecimalnumericArray2M.AssertModel(models[23],_testData[24], false);DecimalnumericArray2M.AssertModel(models[24],_testData[25], false);DecimalnumericArray2M.AssertModel(models[25],_testData[26], false);DecimalnumericArray2M.AssertModel(models[26],_testData[27], false);DecimalnumericArray2M.AssertModel(models[27],_testData[28], false);DecimalnumericArray2M.AssertModel(models[28],_testData[29], false);DecimalnumericArray2M.AssertModel(models[29],_testData[30], false);DecimalnumericArray2M.AssertModel(models[30],_testData[31], false);DecimalnumericArray2M.AssertModel(models[31],_testData[32], false);DecimalnumericArray2M.AssertModel(models[32],_testData[33], false);DecimalnumericArray2M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));
DecimalnumericArray2M.AssertModel(models[0],_testData[3], false);DecimalnumericArray2M.AssertModel(models[1],_testData[4], false);DecimalnumericArray2M.AssertModel(models[2],_testData[5], false);DecimalnumericArray2M.AssertModel(models[3],_testData[6], false);DecimalnumericArray2M.AssertModel(models[4],_testData[7], false);DecimalnumericArray2M.AssertModel(models[5],_testData[8], false);DecimalnumericArray2M.AssertModel(models[6],_testData[9], false);DecimalnumericArray2M.AssertModel(models[7],_testData[10], false);DecimalnumericArray2M.AssertModel(models[8],_testData[11], false);DecimalnumericArray2M.AssertModel(models[9],_testData[12], false);DecimalnumericArray2M.AssertModel(models[10],_testData[13], false);DecimalnumericArray2M.AssertModel(models[11],_testData[14], false);DecimalnumericArray2M.AssertModel(models[12],_testData[15], false);DecimalnumericArray2M.AssertModel(models[13],_testData[16], false);DecimalnumericArray2M.AssertModel(models[14],_testData[17], false);DecimalnumericArray2M.AssertModel(models[15],_testData[18], false);DecimalnumericArray2M.AssertModel(models[16],_testData[19], false);DecimalnumericArray2M.AssertModel(models[17],_testData[20], false);DecimalnumericArray2M.AssertModel(models[18],_testData[21], false);DecimalnumericArray2M.AssertModel(models[19],_testData[22], false);DecimalnumericArray2M.AssertModel(models[20],_testData[23], false);DecimalnumericArray2M.AssertModel(models[21],_testData[24], false);DecimalnumericArray2M.AssertModel(models[22],_testData[25], false);DecimalnumericArray2M.AssertModel(models[23],_testData[26], false);DecimalnumericArray2M.AssertModel(models[24],_testData[27], false);DecimalnumericArray2M.AssertModel(models[25],_testData[28], false);DecimalnumericArray2M.AssertModel(models[26],_testData[29], false);DecimalnumericArray2M.AssertModel(models[27],_testData[30], false);DecimalnumericArray2M.AssertModel(models[28],_testData[31], false);DecimalnumericArray2M.AssertModel(models[29],_testData[32], false);DecimalnumericArray2M.AssertModel(models[30],_testData[33], false);DecimalnumericArray2M.AssertModel(models[31],_testData[34], false);
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

