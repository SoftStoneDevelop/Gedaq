

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxboxE0M[] _testData = new NpgsqlBoxboxE0M[]
        {
            new NpgsqlBoxboxE0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6023145200131429d,right: 0.48646598883010095d,bottom: 0.2562750822447334d,left: 0.08926414092929591d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6448413664700725d,right: 0.9197494562050708d,bottom: 0.23949782568211675d,left: 0.4310386946225362d),
},
            new NpgsqlBoxboxE0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8024601874910157d,right: 0.5643841546180308d,bottom: 0.4770720910056503d,left: 0.019290820981529677d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8910350294122469d,right: 0.547754923867447d,bottom: 0.7535789852239793d,left: 0.44806565491530115d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7268684408651807d,right: 0.7972768213614567d,bottom: 0.4735643142374366d,left: 0.28737862342798726d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7328639652442533d,right: 0.5322017680842455d,bottom: 0.2459983903080678d,left: 0.4033008847604125d),
},
            new NpgsqlBoxboxE0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8732017507137337d,right: 0.9617608696416812d,bottom: 0.018316116344741618d,left: 0.2521946984702196d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7686962973430639d,right: 0.853036890014588d,bottom: 0.42330250735309494d,left: 0.18101573166810336d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9166653012908065d,right: 0.775425712051567d,bottom: 0.12753480044728904d,left: 0.2700485872843629d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.563641076823527d,right: 0.8388690761161651d,bottom: 0.3010788936653155d,left: 0.6756478172134953d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8013036679490604d,right: 0.8487928819146048d,bottom: 0.5741338090208069d,left: 0.14627386408653598d),
},
            new NpgsqlBoxboxE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9638501925539908d,right: 0.5848298919246987d,bottom: 0.6893772756543445d,left: 0.3654867910795705d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5912943908657189d,right: 0.9060545665618767d,bottom: 0.35772672993872656d,left: 0.7251427943666721d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9473778144850428d,right: 0.5276765852104345d,bottom: 0.34094464867590024d,left: 0.1076455729797604d),
},
            new NpgsqlBoxboxE0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5672900775694835d,right: 0.26371590205221596d,bottom: 0.1935614021175628d,left: 0.21671543748107103d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5204274873909576d,right: 0.8437342422788706d,bottom: 0.4639951956456576d,left: 0.4706564687161422d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6223944143037577d,right: 0.661110743861663d,bottom: 0.36259266968341164d,left: 0.36926296106285095d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.541791309498215d,right: 0.6382043853856222d,bottom: 0.1849961027349809d,left: 0.2130702760337675d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7022902008366716d,right: 0.30843671438218867d,bottom: 0.25633187281376457d,left: 0.27595326889022065d),
},
            new NpgsqlBoxboxE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.27344500127665616d,right: 0.20253785692951543d,bottom: 0.031549836888591476d,left: 0.08087537711609649d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.822569263367373d,right: 0.9133213408049663d,bottom: 0.3415528360260188d,left: 0.7817710481314194d),
},
            new NpgsqlBoxboxE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.979053216534088d,right: 0.8739522941017396d,bottom: 0.10780564838519213d,left: 0.583728248072594d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9923463117599856d,right: 0.46895001357309063d,bottom: 0.7420624367038925d,left: 0.30163896270288115d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.882585999180515d,right: 0.6636362638225978d,bottom: 0.6796268618683539d,left: 0.43108681892107636d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6239630752993385d,right: 0.9350815047113368d,bottom: 0.10940658726860908d,left: 0.5371185179449977d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8567365189661669d,right: 0.939762646201971d,bottom: 0.6979797168742354d,left: 0.19383320109978985d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5310337048092599d,right: 0.8711507425120038d,bottom: 0.4557404992599393d,left: 0.19010781291023082d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7836741050153336d,right: 0.9245755140958283d,bottom: 0.6228837690459451d,left: 0.22128536259039244d),
},
            new NpgsqlBoxboxE0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5512471980310718d,right: 0.37583048075283676d,bottom: 0.30068015603244735d,left: 0.05677705058741278d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.19702765847774828d,right: 0.9822423851474055d,bottom: 0.11911635472156434d,left: 0.19524929784696787d),
},
            new NpgsqlBoxboxE0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7402804068842755d,right: 0.808793389006529d,bottom: 0.3594433903495067d,left: 0.14142162819737347d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5733924075628567d,right: 0.37929147865049895d,bottom: 0.15370690354614813d,left: 0.24517244666321236d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9473238339223444d,right: 0.2987807698494923d,bottom: 0.182471131699956d,left: 0.2452273894571647d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8031421171061798d,right: 0.9509725354475803d,bottom: 0.013709902159485199d,left: 0.9439713056026489d),
},
            new NpgsqlBoxboxE0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6001314342238029d,right: 0.8646691077471343d,bottom: 0.004940200212144696d,left: 0.4594188668151441d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6815353583775052d,right: 0.3320413260571389d,bottom: 0.44648689079004034d,left: 0.07874654922121915d),
},
            new NpgsqlBoxboxE0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4205438246126947d,right: 0.586752557114691d,bottom: 0.2883432045494968d,left: 0.18859552021007564d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7272181483438862d,right: 0.70447032818533d,bottom: 0.1858876031651513d,left: 0.34167262300190326d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6905729422710825d,right: 0.7637489223015227d,bottom: 0.2765093861984087d,left: 0.22847021906177578d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7590160391566219d,right: 0.5940874758563793d,bottom: 0.2268592909542686d,left: 0.5276431661639884d),
},
            new NpgsqlBoxboxE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9785135940845129d,right: 0.46346811702170876d,bottom: 0.837523673615045d,left: 0.021669903044252647d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46650994843223015d,right: 0.9374603279614108d,bottom: 0.09224541293625388d,left: 0.0005177494749462053d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.13737025974490968d,right: 0.9791833934775789d,bottom: 0.013183295079158386d,left: 0.15108274032291125d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8617107560884694d,right: 0.9670619186447765d,bottom: 0.7403552361502203d,left: 0.6935151861483086d),
},
            new NpgsqlBoxboxE0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.36501359805870337d,right: 0.8770670169040148d,bottom: 0.12043928657975533d,left: 0.5331964022880864d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8781209274695626d,right: 0.8911277474394071d,bottom: 0.3556482086304399d,left: 0.17496854366742876d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7167256605933144d,right: 0.3097704229206265d,bottom: 0.26156435785124943d,left: 0.20827824485538693d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9481024892444915d,right: 0.9150334428554219d,bottom: 0.5568934756409175d,left: 0.6833927307717063d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7427464552953981d,right: 0.5289788488768499d,bottom: 0.6201752238694809d,left: 0.23437551970896564d),
},
            new NpgsqlBoxboxE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6352592146397424d,right: 0.7756727266011127d,bottom: 0.24139793996603776d,left: 0.5692016245167312d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.751326245115756d,right: 0.7971556311756149d,bottom: 0.6866310009189523d,left: 0.4444431725813275d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.2183766507857624d,right: 0.6863551966085737d,bottom: 0.13949731244477115d,left: 0.616031796716399d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3127637548320049d,right: 0.8570653323625309d,bottom: 0.19885201502379402d,left: 0.467130477490298d),
},
            new NpgsqlBoxboxE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9326757713589511d,right: 0.40648360083385027d,bottom: 0.11687545821059897d,left: 0.11546677650123904d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.48440014067886705d,right: 0.479090513139088d,bottom: 0.3404193777650595d,left: 0.1864447556051081d),
},
            new NpgsqlBoxboxE0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.14396979476802874d,right: 0.6317878860100317d,bottom: 0.12348006286388014d,left: 0.11495365483199993d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8420304679926379d,right: 0.6211600238030037d,bottom: 0.20563126250857644d,left: 0.012806135842049038d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5185764101021844d,right: 0.26616780172078225d,bottom: 0.21255204627994329d,left: 0.0819286510733751d),
},
            new NpgsqlBoxboxE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9299577980062355d,right: 0.5252306624956556d,bottom: 0.41165694203276726d,left: 0.044498181452421126d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9308075523267719d,right: 0.838001279108305d,bottom: 0.8582868457302791d,left: 0.40313181737694437d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.481983802596342d,right: 0.8077944656138254d,bottom: 0.34695347451796654d,left: 0.5084760951759411d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.985591946732033d,right: 0.4620361344413336d,bottom: 0.9023120560123759d,left: 0.4590394633594108d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9428409519441808d,right: 0.426903973812231d,bottom: 0.3551232134902532d,left: 0.22056957468360905d),
},
            new NpgsqlBoxboxE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2339672344090462d,right: 0.6474587962771388d,bottom: 0.011603459469574307d,left: 0.6121392646626981d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.42670632712867484d,right: 0.250118034325872d,bottom: 0.21321146050485462d,left: 0.0005525278194827843d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1796678649382355d,right: 0.0278374168589951d,bottom: 0.09106463594034298d,left: 0.01164424431939004d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.08728389936303549d,right: 0.7565184731090127d,bottom: 0.0838252893358189d,left: 0.5583097041353331d),
},
            new NpgsqlBoxboxE0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49532373490669557d,right: 0.4008962871157209d,bottom: 0.1710976029631609d,left: 0.22691727174515774d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8650664977121069d,right: 0.8519375335287311d,bottom: 0.6453162994992778d,left: 0.48318422656286675d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8510175373750531d,right: 0.22946085851261333d,bottom: 0.508800467611279d,left: 0.03837357914716233d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3845982950295731d,right: 0.7639461758478266d,bottom: 0.0758584444707453d,left: 0.4000879346347209d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7088928325496554d,right: 0.889012587109874d,bottom: 0.4732916060519077d,left: 0.4270452397844674d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.501145947219987d,right: 0.8568000073277606d,bottom: 0.2968552895888865d,left: 0.6940207039626116d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5150749881409287d,right: 0.6690921451756441d,bottom: 0.37025801164196315d,left: 0.0996546918358524d),
},
            new NpgsqlBoxboxE0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6955547011103778d,right: 0.5437670924518611d,bottom: 0.6214161802701895d,left: 0.021893864166694366d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.497969518091118d,right: 0.6215596579223406d,bottom: 0.13901763097298703d,left: 0.5018007838366639d),
},
            new NpgsqlBoxboxE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8070727511415857d,right: 0.8201155882711134d,bottom: 0.21968895585784842d,left: 0.13221205461464847d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9897769882054779d,right: 0.6690894981451905d,bottom: 0.7940181219927451d,left: 0.4182089579121455d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49983278087077376d,right: 0.6702549043511526d,bottom: 0.006760800207045503d,left: 0.09758687424555035d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8013036679490604d,right: 0.8487928819146048d,bottom: 0.5741338090208069d,left: 0.14627386408653598d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9473778144850428d,right: 0.5276765852104345d,bottom: 0.34094464867590024d,left: 0.1076455729797604d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7022902008366716d,right: 0.30843671438218867d,bottom: 0.25633187281376457d,left: 0.27595326889022065d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.822569263367373d,right: 0.9133213408049663d,bottom: 0.3415528360260188d,left: 0.7817710481314194d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7836741050153336d,right: 0.9245755140958283d,bottom: 0.6228837690459451d,left: 0.22128536259039244d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxboxe0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxboxe0mi_id", 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 38;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 21, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 48, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 11, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 23, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 130, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 29, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 62))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 29, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[18], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[19], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[20], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[21], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[13],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[14],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[15],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6023145200131429d,right: 0.48646598883010095d,bottom: 0.2562750822447334d,left: 0.08926414092929591d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6448413664700725d,right: 0.9197494562050708d,bottom: 0.23949782568211675d,left: 0.4310386946225362d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8024601874910157d,right: 0.5643841546180308d,bottom: 0.4770720910056503d,left: 0.019290820981529677d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8910350294122469d,right: 0.547754923867447d,bottom: 0.7535789852239793d,left: 0.44806565491530115d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7268684408651807d,right: 0.7972768213614567d,bottom: 0.4735643142374366d,left: 0.28737862342798726d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7328639652442533d,right: 0.5322017680842455d,bottom: 0.2459983903080678d,left: 0.4033008847604125d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8732017507137337d,right: 0.9617608696416812d,bottom: 0.018316116344741618d,left: 0.2521946984702196d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7686962973430639d,right: 0.853036890014588d,bottom: 0.42330250735309494d,left: 0.18101573166810336d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9166653012908065d,right: 0.775425712051567d,bottom: 0.12753480044728904d,left: 0.2700485872843629d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.563641076823527d,right: 0.8388690761161651d,bottom: 0.3010788936653155d,left: 0.6756478172134953d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8013036679490604d,right: 0.8487928819146048d,bottom: 0.5741338090208069d,left: 0.14627386408653598d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9638501925539908d,right: 0.5848298919246987d,bottom: 0.6893772756543445d,left: 0.3654867910795705d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5912943908657189d,right: 0.9060545665618767d,bottom: 0.35772672993872656d,left: 0.7251427943666721d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9473778144850428d,right: 0.5276765852104345d,bottom: 0.34094464867590024d,left: 0.1076455729797604d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5672900775694835d,right: 0.26371590205221596d,bottom: 0.1935614021175628d,left: 0.21671543748107103d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5204274873909576d,right: 0.8437342422788706d,bottom: 0.4639951956456576d,left: 0.4706564687161422d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6223944143037577d,right: 0.661110743861663d,bottom: 0.36259266968341164d,left: 0.36926296106285095d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.541791309498215d,right: 0.6382043853856222d,bottom: 0.1849961027349809d,left: 0.2130702760337675d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7022902008366716d,right: 0.30843671438218867d,bottom: 0.25633187281376457d,left: 0.27595326889022065d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27344500127665616d,right: 0.20253785692951543d,bottom: 0.031549836888591476d,left: 0.08087537711609649d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.822569263367373d,right: 0.9133213408049663d,bottom: 0.3415528360260188d,left: 0.7817710481314194d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.979053216534088d,right: 0.8739522941017396d,bottom: 0.10780564838519213d,left: 0.583728248072594d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9923463117599856d,right: 0.46895001357309063d,bottom: 0.7420624367038925d,left: 0.30163896270288115d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.882585999180515d,right: 0.6636362638225978d,bottom: 0.6796268618683539d,left: 0.43108681892107636d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6239630752993385d,right: 0.9350815047113368d,bottom: 0.10940658726860908d,left: 0.5371185179449977d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8567365189661669d,right: 0.939762646201971d,bottom: 0.6979797168742354d,left: 0.19383320109978985d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5310337048092599d,right: 0.8711507425120038d,bottom: 0.4557404992599393d,left: 0.19010781291023082d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7836741050153336d,right: 0.9245755140958283d,bottom: 0.6228837690459451d,left: 0.22128536259039244d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5512471980310718d,right: 0.37583048075283676d,bottom: 0.30068015603244735d,left: 0.05677705058741278d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19702765847774828d,right: 0.9822423851474055d,bottom: 0.11911635472156434d,left: 0.19524929784696787d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7402804068842755d,right: 0.808793389006529d,bottom: 0.3594433903495067d,left: 0.14142162819737347d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5733924075628567d,right: 0.37929147865049895d,bottom: 0.15370690354614813d,left: 0.24517244666321236d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9473238339223444d,right: 0.2987807698494923d,bottom: 0.182471131699956d,left: 0.2452273894571647d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8031421171061798d,right: 0.9509725354475803d,bottom: 0.013709902159485199d,left: 0.9439713056026489d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6001314342238029d,right: 0.8646691077471343d,bottom: 0.004940200212144696d,left: 0.4594188668151441d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6815353583775052d,right: 0.3320413260571389d,bottom: 0.44648689079004034d,left: 0.07874654922121915d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4205438246126947d,right: 0.586752557114691d,bottom: 0.2883432045494968d,left: 0.18859552021007564d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7272181483438862d,right: 0.70447032818533d,bottom: 0.1858876031651513d,left: 0.34167262300190326d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6905729422710825d,right: 0.7637489223015227d,bottom: 0.2765093861984087d,left: 0.22847021906177578d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7590160391566219d,right: 0.5940874758563793d,bottom: 0.2268592909542686d,left: 0.5276431661639884d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9785135940845129d,right: 0.46346811702170876d,bottom: 0.837523673615045d,left: 0.021669903044252647d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46650994843223015d,right: 0.9374603279614108d,bottom: 0.09224541293625388d,left: 0.0005177494749462053d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13737025974490968d,right: 0.9791833934775789d,bottom: 0.013183295079158386d,left: 0.15108274032291125d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8617107560884694d,right: 0.9670619186447765d,bottom: 0.7403552361502203d,left: 0.6935151861483086d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.36501359805870337d,right: 0.8770670169040148d,bottom: 0.12043928657975533d,left: 0.5331964022880864d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8781209274695626d,right: 0.8911277474394071d,bottom: 0.3556482086304399d,left: 0.17496854366742876d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7167256605933144d,right: 0.3097704229206265d,bottom: 0.26156435785124943d,left: 0.20827824485538693d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9481024892444915d,right: 0.9150334428554219d,bottom: 0.5568934756409175d,left: 0.6833927307717063d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7427464552953981d,right: 0.5289788488768499d,bottom: 0.6201752238694809d,left: 0.23437551970896564d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6352592146397424d,right: 0.7756727266011127d,bottom: 0.24139793996603776d,left: 0.5692016245167312d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.751326245115756d,right: 0.7971556311756149d,bottom: 0.6866310009189523d,left: 0.4444431725813275d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2183766507857624d,right: 0.6863551966085737d,bottom: 0.13949731244477115d,left: 0.616031796716399d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3127637548320049d,right: 0.8570653323625309d,bottom: 0.19885201502379402d,left: 0.467130477490298d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9326757713589511d,right: 0.40648360083385027d,bottom: 0.11687545821059897d,left: 0.11546677650123904d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48440014067886705d,right: 0.479090513139088d,bottom: 0.3404193777650595d,left: 0.1864447556051081d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.14396979476802874d,right: 0.6317878860100317d,bottom: 0.12348006286388014d,left: 0.11495365483199993d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8420304679926379d,right: 0.6211600238030037d,bottom: 0.20563126250857644d,left: 0.012806135842049038d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5185764101021844d,right: 0.26616780172078225d,bottom: 0.21255204627994329d,left: 0.0819286510733751d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9299577980062355d,right: 0.5252306624956556d,bottom: 0.41165694203276726d,left: 0.044498181452421126d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9308075523267719d,right: 0.838001279108305d,bottom: 0.8582868457302791d,left: 0.40313181737694437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.481983802596342d,right: 0.8077944656138254d,bottom: 0.34695347451796654d,left: 0.5084760951759411d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.985591946732033d,right: 0.4620361344413336d,bottom: 0.9023120560123759d,left: 0.4590394633594108d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9428409519441808d,right: 0.426903973812231d,bottom: 0.3551232134902532d,left: 0.22056957468360905d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2339672344090462d,right: 0.6474587962771388d,bottom: 0.011603459469574307d,left: 0.6121392646626981d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42670632712867484d,right: 0.250118034325872d,bottom: 0.21321146050485462d,left: 0.0005525278194827843d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1796678649382355d,right: 0.0278374168589951d,bottom: 0.09106463594034298d,left: 0.01164424431939004d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08728389936303549d,right: 0.7565184731090127d,bottom: 0.0838252893358189d,left: 0.5583097041353331d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49532373490669557d,right: 0.4008962871157209d,bottom: 0.1710976029631609d,left: 0.22691727174515774d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8650664977121069d,right: 0.8519375335287311d,bottom: 0.6453162994992778d,left: 0.48318422656286675d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8510175373750531d,right: 0.22946085851261333d,bottom: 0.508800467611279d,left: 0.03837357914716233d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3845982950295731d,right: 0.7639461758478266d,bottom: 0.0758584444707453d,left: 0.4000879346347209d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7088928325496554d,right: 0.889012587109874d,bottom: 0.4732916060519077d,left: 0.4270452397844674d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.501145947219987d,right: 0.8568000073277606d,bottom: 0.2968552895888865d,left: 0.6940207039626116d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5150749881409287d,right: 0.6690921451756441d,bottom: 0.37025801164196315d,left: 0.0996546918358524d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6955547011103778d,right: 0.5437670924518611d,bottom: 0.6214161802701895d,left: 0.021893864166694366d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.497969518091118d,right: 0.6215596579223406d,bottom: 0.13901763097298703d,left: 0.5018007838366639d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8070727511415857d,right: 0.8201155882711134d,bottom: 0.21968895585784842d,left: 0.13221205461464847d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9897769882054779d,right: 0.6690894981451905d,bottom: 0.7940181219927451d,left: 0.4182089579121455d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49983278087077376d,right: 0.6702549043511526d,bottom: 0.006760800207045503d,left: 0.09758687424555035d))));//Value

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
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6023145200131429d,right: 0.48646598883010095d,bottom: 0.2562750822447334d,left: 0.08926414092929591d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6448413664700725d,right: 0.9197494562050708d,bottom: 0.23949782568211675d,left: 0.4310386946225362d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8024601874910157d,right: 0.5643841546180308d,bottom: 0.4770720910056503d,left: 0.019290820981529677d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8910350294122469d,right: 0.547754923867447d,bottom: 0.7535789852239793d,left: 0.44806565491530115d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7268684408651807d,right: 0.7972768213614567d,bottom: 0.4735643142374366d,left: 0.28737862342798726d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7328639652442533d,right: 0.5322017680842455d,bottom: 0.2459983903080678d,left: 0.4033008847604125d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8732017507137337d,right: 0.9617608696416812d,bottom: 0.018316116344741618d,left: 0.2521946984702196d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7686962973430639d,right: 0.853036890014588d,bottom: 0.42330250735309494d,left: 0.18101573166810336d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9166653012908065d,right: 0.775425712051567d,bottom: 0.12753480044728904d,left: 0.2700485872843629d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.563641076823527d,right: 0.8388690761161651d,bottom: 0.3010788936653155d,left: 0.6756478172134953d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8013036679490604d,right: 0.8487928819146048d,bottom: 0.5741338090208069d,left: 0.14627386408653598d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9638501925539908d,right: 0.5848298919246987d,bottom: 0.6893772756543445d,left: 0.3654867910795705d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5912943908657189d,right: 0.9060545665618767d,bottom: 0.35772672993872656d,left: 0.7251427943666721d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9473778144850428d,right: 0.5276765852104345d,bottom: 0.34094464867590024d,left: 0.1076455729797604d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5672900775694835d,right: 0.26371590205221596d,bottom: 0.1935614021175628d,left: 0.21671543748107103d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5204274873909576d,right: 0.8437342422788706d,bottom: 0.4639951956456576d,left: 0.4706564687161422d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6223944143037577d,right: 0.661110743861663d,bottom: 0.36259266968341164d,left: 0.36926296106285095d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.541791309498215d,right: 0.6382043853856222d,bottom: 0.1849961027349809d,left: 0.2130702760337675d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7022902008366716d,right: 0.30843671438218867d,bottom: 0.25633187281376457d,left: 0.27595326889022065d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27344500127665616d,right: 0.20253785692951543d,bottom: 0.031549836888591476d,left: 0.08087537711609649d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.822569263367373d,right: 0.9133213408049663d,bottom: 0.3415528360260188d,left: 0.7817710481314194d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.979053216534088d,right: 0.8739522941017396d,bottom: 0.10780564838519213d,left: 0.583728248072594d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9923463117599856d,right: 0.46895001357309063d,bottom: 0.7420624367038925d,left: 0.30163896270288115d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.882585999180515d,right: 0.6636362638225978d,bottom: 0.6796268618683539d,left: 0.43108681892107636d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6239630752993385d,right: 0.9350815047113368d,bottom: 0.10940658726860908d,left: 0.5371185179449977d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8567365189661669d,right: 0.939762646201971d,bottom: 0.6979797168742354d,left: 0.19383320109978985d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5310337048092599d,right: 0.8711507425120038d,bottom: 0.4557404992599393d,left: 0.19010781291023082d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7836741050153336d,right: 0.9245755140958283d,bottom: 0.6228837690459451d,left: 0.22128536259039244d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5512471980310718d,right: 0.37583048075283676d,bottom: 0.30068015603244735d,left: 0.05677705058741278d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19702765847774828d,right: 0.9822423851474055d,bottom: 0.11911635472156434d,left: 0.19524929784696787d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7402804068842755d,right: 0.808793389006529d,bottom: 0.3594433903495067d,left: 0.14142162819737347d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5733924075628567d,right: 0.37929147865049895d,bottom: 0.15370690354614813d,left: 0.24517244666321236d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9473238339223444d,right: 0.2987807698494923d,bottom: 0.182471131699956d,left: 0.2452273894571647d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8031421171061798d,right: 0.9509725354475803d,bottom: 0.013709902159485199d,left: 0.9439713056026489d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6001314342238029d,right: 0.8646691077471343d,bottom: 0.004940200212144696d,left: 0.4594188668151441d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6815353583775052d,right: 0.3320413260571389d,bottom: 0.44648689079004034d,left: 0.07874654922121915d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4205438246126947d,right: 0.586752557114691d,bottom: 0.2883432045494968d,left: 0.18859552021007564d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7272181483438862d,right: 0.70447032818533d,bottom: 0.1858876031651513d,left: 0.34167262300190326d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6905729422710825d,right: 0.7637489223015227d,bottom: 0.2765093861984087d,left: 0.22847021906177578d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7590160391566219d,right: 0.5940874758563793d,bottom: 0.2268592909542686d,left: 0.5276431661639884d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9785135940845129d,right: 0.46346811702170876d,bottom: 0.837523673615045d,left: 0.021669903044252647d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46650994843223015d,right: 0.9374603279614108d,bottom: 0.09224541293625388d,left: 0.0005177494749462053d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13737025974490968d,right: 0.9791833934775789d,bottom: 0.013183295079158386d,left: 0.15108274032291125d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8617107560884694d,right: 0.9670619186447765d,bottom: 0.7403552361502203d,left: 0.6935151861483086d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.36501359805870337d,right: 0.8770670169040148d,bottom: 0.12043928657975533d,left: 0.5331964022880864d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8781209274695626d,right: 0.8911277474394071d,bottom: 0.3556482086304399d,left: 0.17496854366742876d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7167256605933144d,right: 0.3097704229206265d,bottom: 0.26156435785124943d,left: 0.20827824485538693d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9481024892444915d,right: 0.9150334428554219d,bottom: 0.5568934756409175d,left: 0.6833927307717063d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7427464552953981d,right: 0.5289788488768499d,bottom: 0.6201752238694809d,left: 0.23437551970896564d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6352592146397424d,right: 0.7756727266011127d,bottom: 0.24139793996603776d,left: 0.5692016245167312d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.751326245115756d,right: 0.7971556311756149d,bottom: 0.6866310009189523d,left: 0.4444431725813275d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2183766507857624d,right: 0.6863551966085737d,bottom: 0.13949731244477115d,left: 0.616031796716399d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3127637548320049d,right: 0.8570653323625309d,bottom: 0.19885201502379402d,left: 0.467130477490298d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9326757713589511d,right: 0.40648360083385027d,bottom: 0.11687545821059897d,left: 0.11546677650123904d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48440014067886705d,right: 0.479090513139088d,bottom: 0.3404193777650595d,left: 0.1864447556051081d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.14396979476802874d,right: 0.6317878860100317d,bottom: 0.12348006286388014d,left: 0.11495365483199993d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8420304679926379d,right: 0.6211600238030037d,bottom: 0.20563126250857644d,left: 0.012806135842049038d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5185764101021844d,right: 0.26616780172078225d,bottom: 0.21255204627994329d,left: 0.0819286510733751d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9299577980062355d,right: 0.5252306624956556d,bottom: 0.41165694203276726d,left: 0.044498181452421126d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9308075523267719d,right: 0.838001279108305d,bottom: 0.8582868457302791d,left: 0.40313181737694437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.481983802596342d,right: 0.8077944656138254d,bottom: 0.34695347451796654d,left: 0.5084760951759411d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.985591946732033d,right: 0.4620361344413336d,bottom: 0.9023120560123759d,left: 0.4590394633594108d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9428409519441808d,right: 0.426903973812231d,bottom: 0.3551232134902532d,left: 0.22056957468360905d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2339672344090462d,right: 0.6474587962771388d,bottom: 0.011603459469574307d,left: 0.6121392646626981d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42670632712867484d,right: 0.250118034325872d,bottom: 0.21321146050485462d,left: 0.0005525278194827843d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1796678649382355d,right: 0.0278374168589951d,bottom: 0.09106463594034298d,left: 0.01164424431939004d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08728389936303549d,right: 0.7565184731090127d,bottom: 0.0838252893358189d,left: 0.5583097041353331d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49532373490669557d,right: 0.4008962871157209d,bottom: 0.1710976029631609d,left: 0.22691727174515774d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8650664977121069d,right: 0.8519375335287311d,bottom: 0.6453162994992778d,left: 0.48318422656286675d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8510175373750531d,right: 0.22946085851261333d,bottom: 0.508800467611279d,left: 0.03837357914716233d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3845982950295731d,right: 0.7639461758478266d,bottom: 0.0758584444707453d,left: 0.4000879346347209d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7088928325496554d,right: 0.889012587109874d,bottom: 0.4732916060519077d,left: 0.4270452397844674d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.501145947219987d,right: 0.8568000073277606d,bottom: 0.2968552895888865d,left: 0.6940207039626116d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5150749881409287d,right: 0.6690921451756441d,bottom: 0.37025801164196315d,left: 0.0996546918358524d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6955547011103778d,right: 0.5437670924518611d,bottom: 0.6214161802701895d,left: 0.021893864166694366d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.497969518091118d,right: 0.6215596579223406d,bottom: 0.13901763097298703d,left: 0.5018007838366639d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8070727511415857d,right: 0.8201155882711134d,bottom: 0.21968895585784842d,left: 0.13221205461464847d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9897769882054779d,right: 0.6690894981451905d,bottom: 0.7940181219927451d,left: 0.4182089579121455d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49983278087077376d,right: 0.6702549043511526d,bottom: 0.006760800207045503d,left: 0.09758687424555035d))));//Value

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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxboxe0m m
LEFT JOIN public.binary_npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI), typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

