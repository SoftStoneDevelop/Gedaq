

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07447995069526336d,

0.834504716977717d,

0.6190033430271903d,

0.6124435331240061d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5002965271751099d,

0.9057493496959298d,

0.7622694793312885d,

0.1913116876025106d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6860147556569417d,

0.5254894135888382d,

0.09185211405048344d,

0.4668800563971004d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7202369785056116d,

0.9413769855168911d,

0.5575078393631405d,

0.6778524232736218d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7610835912652955d,

0.9267005995188282d,

0.820918960351529d,

0.8485547187840459d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.897689308647462d,

0.3220664102710217d,

0.13694931966077384d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9898734102769313d,

0.605996555923592d,

0.6500117638365004d,

0.46890563515723793d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7714557099303875d,

0.3179573512803934d,

0.11200494019492913d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.49153948524528923d,

0.6721014166776889d,

0.6734486592880491d,

0.027638558274334923d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07209400068068794d,

0.19614206304184156d,

0.7813918032792389d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4438709085017646d,

0.9163886855461023d,

0.9690285086357086d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.18555383553906868d,

0.20364707371090796d,

0.11511312470401114d,

0.6616851587791938d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6185149922763273d,

0.6202127697129577d,

0.6379859818575512d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5023224299173503d,

0.9370055913335209d,

0.48047415808152505d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20119035959727238d,

0.21555072096881012d,

0.8403725594516158d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7743696210021067d,

0.31492694232659735d,

0.6476650282130099d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9214994728876278d,

0.4553259583994901d,

0.7356232356153938d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06833852348189784d,

0.4957179719533703d,

0.19531829986624438d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8430649045696587d,

0.33697641099601183d,

0.6028476176186481d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33190639033219693d,

0.43254105308247215d,

0.7788511086943245d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6763411195150825d,

0.6742116605861618d,

0.8898706300877252d,

0.23982506895232303d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.007642144430104025d,

0.6019352204728029d,

0.15889432307054896d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8170434914590741d,

0.500232038213353d,

0.1860744061221684d,

0.7410246673081026d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.04774146766406262d,

0.4051451396502853d,

0.4956360647009711d,

0.4574175576757896d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9033182961507448d,

0.6239909306571024d,

0.10042296358181269d,

0.8589001571684918d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6094996266309465d,

0.6364409002148795d,

0.9689905841652631d,

0.08680363213452025d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9743123559563038d,

0.3517638354314132d,

0.26364103549493945d,

0.47493985848588505d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2505034836935456d,

0.6391736370970614d,

0.5254608081096106d,

0.2676324964853254d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7281318628511861d,

0.7844796079832737d,

0.4277954212229247d,

0.10225982716071158d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2825024524533618d,

0.1609312319968509d,

0.5267369550905149d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7043615657601048d,

0.41147781293667174d,

0.9065528773101368d,

0.955746921412911d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.46241033848816016d,

0.6469183392625069d,

0.43417160763597384d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7984006250305847d,

0.1196129787371305d,

0.5864224806019839d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.018231233833092886d,

0.797489146278682d,

0.5424567866091086d,

0.8126546383685556d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8956507026678565d,

0.40367970519341345d,

0.11894310188695323d,

0.38192802403939907d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.652509748870564d,

0.1443644990370827d,

0.884741583631807d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3923868900120394d,

0.4824165379561647d,

0.8007118444252176d,

0.7181910556473845d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7903759269706907d,

0.034297482518868994d,

0.974822396129437d,

0.0047690066139497445d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8544117227288143d,

0.07277162128358794d,

0.35817856008813154d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2538321069038111d,

0.16494436337813279d,

0.7499088406343006d,

0.717863830186657d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.057968884855286285d,

0.24055046747413722d,

0.15593494487773119d,

0.39283584774674485d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9560779562740055d,

0.7315333661873631d,

0.7858082672508889d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6319555493025136d,

0.5253355910343283d,

0.761592789358451d,

0.6113484310535662d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21366779722693519d,

0.01448806595802754d,

0.44225456007433195d,

0.07983366740069353d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.973855646636766d,

0.6361369683409719d,

0.8569718657151766d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5001587158925052d,

0.853504820882785d,

0.4164963124930797d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7953681761703326d,

0.28079802498955675d,

0.14971676233410414d,

0.7675019787275528d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.34345212765346755d,

0.5685940908207028d,

0.028849846981683025d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.30459381179506073d,

0.7491063915172633d,

0.10033558905473539d,

0.9474389777539947d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4450741702765064d,

0.7747854954356577d,

0.45078780843775823d,

0.05980713864905862d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9753182384788907d,

0.5203965644984694d,

0.3369566305081698d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11551505446382115d,

0.25964582803595637d,

0.45705146730346d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10353594362445617d,

0.8822858206042593d,

0.7495856083752463d,

0.7697627395062141d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5988946895952612d,

0.1024273569725287d,

0.619077446408619d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5589259485843239d,

0.9984650579811355d,

0.2542448266409699d,

0.7519030135912924d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10133200931367681d,

0.45071274146181195d,

0.5791584818317046d,

0.42300812622069084d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.765130306207797d,

0.26772497699094977d,

0.8802874116054572d,

0.8727604592246385d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3277866528196076d,

0.49593310588127315d,

0.9152348534119453d,

0.7822571616523871d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.41417811904820456d,

0.8384361614242717d,

0.08231939075901928d,

0.8158904591997069d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.177997169567082d,

0.749052714501506d,

0.08395346789325653d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12485183497686192d,

0.9139522578646287d,

0.5709517114993471d,

0.17056022387745007d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6459448246242286d,

0.8736788331847306d,

0.15953962005979017d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10780487097565228d,

0.8384818042328815d,

0.24042358650279771d,

0.8752344701358432d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.670501828857992d,

0.16650938543481497d,

0.946272387806735d,

0.44286663090764355d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7549378244224202d,

0.3840621189911403d,

0.20625705270006678d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.052743143694613415d,

0.27987980059277406d,

0.18117877595461762d,

0.5413071399286596d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.23501618544634373d,

0.030553111611432704d,

0.40649473680031833d,

0.3039557758408866d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.24156602086828838d,

0.11700952538903242d,

0.5642914422832439d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6786557647043912d,

0.7024531227963858d,

0.24315967756770818d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.776565993298671d,

0.014617387706756912d,

0.9811179969344486d,

0.6806667274058117d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6018801325875391d,

0.6341291229183503d,

0.9882878934901159d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21727463873241526d,

0.15104274205868284d,

0.8593598615491324d,

0.7978181288904913d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2628889459035598d,

0.19806288281144324d,

0.9084637176981761d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1121421946342982d,

0.8598184786472456d,

0.5902746913462285d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7002032999303186d,

0.6312855681701148d,

0.5614107184996678d,

0.21953789994456674d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1389458439653306d,

0.03755548417527066d,

0.8635119663238695d,

0.6444954845769648d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6834653768973896d,

0.4472771593905813d,

0.5730208816841603d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7188646567555304d,

0.3672636842975435d,

0.36839787427764936d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.007323010710255096d,

0.9542973996785525d,

0.2277346410735991d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07222948984199784d,

0.4359475055080768d,

0.709232921610485d,

0.7419498401959274d,

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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[33],_testData[34], false);
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
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 169, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 40, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
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
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 146, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[34], false);
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
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 52, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[34], false);
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
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 39, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatch(connection, 110, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[34], false);
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
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

