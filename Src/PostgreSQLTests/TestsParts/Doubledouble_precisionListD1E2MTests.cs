

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
    internal partial interface IDoubleListdouble_precisionListD1
    {
    }
    
    internal partial class DoubleListdouble_precisionListD1 : IDoubleListdouble_precisionListD1
    {


#region TestData

        private readonly Doubledouble_precisionListD1E2M[] _testData = new Doubledouble_precisionListD1E2M[]
        {
            new Doubledouble_precisionListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.21016603301074122d,

0.8799517990282087d,

0.06669231007718224d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.32038121107722317d,

0.4219435203904255d,

0.02034574957633961d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5550039464338404d,

0.7181015041828843d,

0.10201430850432669d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9664747635745111d,

0.533929120640806d,

0.895583865443589d,

0.5205781931812345d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6479540219269604d,

0.4671239285806911d,

0.5611234645491731d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6753780343022232d,

0.7493395800385693d,

0.4211935828708009d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13507691451169368d,

0.11097472660852159d,

0.6351155514274799d,

0.9717455244552989d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.23166300794789718d,

0.3004026832374975d,

0.03133435706290677d,

0.5258620786906687d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.41565949836568106d,

0.041219395871381126d,

0.7249917463214599d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3479957313141617d,

0.8290275424240351d,

0.43943672386358335d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1927330041551113d,

0.628411533630616d,

0.15894522493062502d,

0.13110817564750132d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31888704763161657d,

0.21801491989971722d,

0.28435142884267084d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9371651719668833d,

0.9852090061854561d,

0.40317428273195566d,

0.3587560418764709d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8006059862405169d,

0.4456301812131205d,

0.7127645765822734d,

0.725260075436895d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8932730015063443d,

0.33970770946771234d,

0.3555162554256365d,

0.6711376721429442d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7960630283738566d,

0.3211217624924245d,

0.9969746353203575d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.16839749953123972d,

0.9869605095399941d,

0.049614331107153964d,

0.33645560877247316d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9672758074083643d,

0.38263066221030284d,

0.6501800966910939d,

0.6845326855248038d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2292718756600921d,

0.1789132489090539d,

0.8039415668466935d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6448027184767486d,

0.6702910287012421d,

0.5638554504152121d,

0.6112866144969316d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6359098850935295d,

0.15920456925696524d,

0.033446205166826615d,

0.29536937647488126d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9279723779932396d,

0.6000133056534596d,

0.007488884786821193d,

0.46190936071100397d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2148463004335206d,

0.27173690471643397d,

0.14116338237714288d,

0.4525482836381538d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7851662583332609d,

0.23640416317556734d,

0.834997599322813d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6300834934935734d,

0.12747843744186682d,

0.6498393208768445d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7460376577283695d,

0.05788761257905384d,

0.14795295383896068d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10387923285990419d,

0.8375575221329093d,

0.07782615716929675d,

0.8634122343272903d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6788159189771579d,

0.3735936015932718d,

0.7915166693238633d,

0.5882917677562772d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.18914213626063614d,

0.23983304291375185d,

0.2248474117839251d,

0.004626643100230643d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6477663871284257d,

0.9629565946581706d,

0.1841668559669578d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6428696692039985d,

0.339780502480417d,

0.3274102438176435d,

0.47670813749555974d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6396707557199606d,

0.857230044168495d,

0.8675623302469025d,

0.5194943775021003d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5053657934074383d,

0.3843753211771759d,

0.14893267017670297d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7297668848030403d,

0.9431268080031573d,

0.0023269168865825973d,

0.4716473332976241d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12348089921806771d,

0.15558929519938058d,

0.15730754210683406d,

0.4400206754196361d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5709388010856628d,

0.49493227536306783d,

0.46806087387609285d,

0.34649528294539955d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8852762254150305d,

0.5076510874653228d,

0.0721858523825245d,

0.8275435457837796d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7304848223644244d,

0.953247997049898d,

0.18776922448409517d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13707950427720672d,

0.6234383349955909d,

0.8347580636312121d,

0.5195414391749468d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2912842972881813d,

0.642835030339977d,

0.6224759609066284d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4769335067453293d,

0.005903470207031414d,

0.4629252609701844d,

0.9615943592784648d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3151046441002485d,

0.7214841150321972d,

0.8737797334853326d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6605316859470037d,

0.5458788825927954d,

0.09480432520584736d,

0.8845609040304292d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2895665436759519d,

0.9876618112245478d,

0.9949881017576949d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7871919635127862d,

0.7902910811133997d,

0.7892036586468086d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19099505945343287d,

0.2943790879211138d,

0.03621084526533236d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1926973300956143d,

0.6957421386078481d,

0.614786569463541d,

0.3110986693122998d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2823069840352399d,

0.7814152492656831d,

0.8689723703416188d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5952366236711841d,

0.27419148448630015d,

0.6383484164305091d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1604571309453673d,

0.5068378280214098d,

0.22526971313499877d,

0.547214248374954d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09321134386847907d,

0.12473039318909551d,

0.17267271078517588d,

0.34113925833279835d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.11231646393080019d,

0.8968856071053489d,

0.42492408627227485d,

0.00806204760497975d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7325598521187926d,

0.5325429331013323d,

0.07221991022462715d,

0.18853901545200213d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4286455808756223d,

0.0034535792818016775d,

0.0712990105287542d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.25677175868152313d,

0.10485231758351166d,

0.3175785702285132d,

0.6826607278797411d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2847616646331792d,

0.5756280572567071d,

0.5411018541387408d,

0.4252095666871466d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28670234459440447d,

0.8466134031624751d,

0.8748947114255247d,

0.2747647984672592d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9874376572937269d,

0.32299360358347273d,

0.3475111777493316d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.41830789478411523d,

0.31053367857610414d,

0.5729608362050029d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8376766538154606d,

0.6499538763805515d,

0.9383697745880885d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5937515009157276d,

0.09542552324795328d,

0.1681340035670622d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9560089654201243d,

0.47250681062134026d,

0.41906220448649245d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6118596053648994d,

0.3212723956473491d,

0.47047863543443846d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5957134935794236d,

0.28937261002476955d,

0.2466620540898823d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.44264745174401443d,

0.2024706327752286d,

0.0163479790496478d,

0.643919014355864d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.39827299791921267d,

0.8391053085742533d,

0.6442572585151627d,

0.26723186093076967d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6089645125089799d,

0.2915110248753777d,

0.0024627904828821157d,

0.8639830755000507d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08129400441265622d,

0.01367434831737191d,

0.8720791053159325d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.11518844539548723d,

0.4715782784356215d,

0.5163350045903943d,

0.6315389223331265d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07844502197609382d,

0.6776918998206636d,

0.3520943118552996d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7921671208035076d,

0.29936354711323643d,

0.649843868469926d,

0.7529158890901199d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6049929385594293d,

0.6397831005138878d,

0.03569628879137754d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3395461443575285d,

0.803497994902436d,

0.19958615752654785d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2730374314767319d,

0.9263237751325537d,

0.19631817854168354d,

0.24930423922934453d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.006961954355362288d,

0.3068377765708393d,

0.4443826470995804d,

0.6855044877610752d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18765516611526478d,

0.9301283871726994d,

0.045019514171772856d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6290861278684666d,

0.49424721825803275d,

0.2678584059243717d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7339930136978853d,

0.7841017811896965d,

0.602575380040673d,

0.666391377472407d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.37011698861459197d,

0.8411065032364199d,

0.1745879420214348d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8458296416255808d,

0.4125684221586936d,

0.4339819179526093d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6886408260621235d,

0.3841930739205808d,

0.08381758430567277d,

0.2422343943356836d,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
INSERT INTO public.doubledouble_precisionlistd1e2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)), 
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
                methodParametrName: "doubledouble_precisionlistd1e2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                methodParametrName: "doubledouble_precisionlistd1e2mi_id", 
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
                List<Doubledouble_precisionListD1E2M> models = null;

                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionListD1E2M> models = null;

                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr2.Value = 131;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[3], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 139, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 139, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 122, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 122, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 172, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 153, query1, 159, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 13, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 29, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatch(connection, 66, 29))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[12], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[13], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[14], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[15], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[16], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[17], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[18], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[19], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[20], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[21], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[22], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[23], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models =  ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[20], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[21], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[22], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[23], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MI),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionListD1E2M),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
FROM public.binary_doubledouble_precisionlistd1e2m m
LEFT JOIN public.binary_doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models =  ((IDoubleListdouble_precisionListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI), typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models1 = new List<Doubledouble_precisionListD1E2MI>();
                var models2 = new List<Doubledouble_precisionListD1E2MI>();
                await ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MI>();
                var models2 = new List<Doubledouble_precisionListD1E2MI>();
                ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

