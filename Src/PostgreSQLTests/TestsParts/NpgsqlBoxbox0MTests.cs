

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

        private readonly NpgsqlBoxbox0M[] _testData = new NpgsqlBoxbox0M[]
        {
            new NpgsqlBoxbox0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7896915821461215d,right: 0.8157382832210435d,bottom: 0.6086717525379222d,left: 0.2500914327002599d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4353571132565286d,right: 0.25334507161650677d,bottom: 0.015664095312488135d,left: 0.1902802008050718d),
},
            new NpgsqlBoxbox0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9530503856404506d,right: 0.7550016653589016d,bottom: 0.08169987697135495d,left: 0.4801363057010728d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9170987251080424d,right: 0.9622558133770203d,bottom: 0.33359643103758385d,left: 0.6876888978633077d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.70630428838959d,right: 0.9614757645015737d,bottom: 0.3131177715461627d,left: 0.17689732352937715d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5397929236887089d,right: 0.47325592739805566d,bottom: 0.42545895319287597d,left: 0.20083453630963866d),
},
            new NpgsqlBoxbox0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9734879540361149d,right: 0.9430327225934765d,bottom: 0.30954283939606064d,left: 0.5825022821613566d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8554338038060147d,right: 0.6811605465759367d,bottom: 0.7650267535937852d,left: 0.47255356861806375d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4580756467168078d,right: 0.9229286513503899d,bottom: 0.011432318366246697d,left: 0.5849077457321221d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.625130091128072d,right: 0.7546909688503368d,bottom: 0.6225014870468212d,left: 0.6015389867022832d),
},
            new NpgsqlBoxbox0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9223071851885152d,right: 0.8614400096790321d,bottom: 0.44488181931172044d,left: 0.5156038284559223d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7878231440292806d,right: 0.7882831261925468d,bottom: 0.5243579260540979d,left: 0.7080406179138949d),
},
            new NpgsqlBoxbox0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6175981000403273d,right: 0.23611916622971174d,bottom: 0.2855209698506921d,left: 0.12036378659411895d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5384454645740016d,right: 0.5891614170098026d,bottom: 0.1860750249055666d,left: 0.24095928209832818d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5797400304487542d,right: 0.7423100562246553d,bottom: 0.47524896598219746d,left: 0.36388322220816693d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5466412562497311d,right: 0.916227449272836d,bottom: 0.1978312006231585d,left: 0.49408354873850713d),
},
            new NpgsqlBoxbox0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7876243384127681d,right: 0.681961148710539d,bottom: 0.3865303817688234d,left: 0.07981501308090067d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7553431256662454d,right: 0.48261956701457787d,bottom: 0.7090809876820463d,left: 0.43592215462515116d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.40558809699514964d,right: 0.8836668697310321d,bottom: 0.09654833362234216d,left: 0.23957437724692854d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8292761668717257d,right: 0.7225972256968513d,bottom: 0.13121174460142182d,left: 0.4661313954649168d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4643674112271263d,right: 0.48903491573060165d,bottom: 0.25698890308554345d,left: 0.2891623880972498d),
},
            new NpgsqlBoxbox0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4229386763230638d,right: 0.9717745298979173d,bottom: 0.2161608874049772d,left: 0.6197994694990892d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.42408156257009433d,right: 0.9887652662121613d,bottom: 0.35930997037657375d,left: 0.2315174850993158d),
},
            new NpgsqlBoxbox0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8368805599459931d,right: 0.30401272706803373d,bottom: 0.22444490993826993d,left: 0.009274423760969652d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6642922919840952d,right: 0.5351529082967809d,bottom: 0.03024445014911159d,left: 0.3900674808172515d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8011326185295609d,right: 0.8503956401362289d,bottom: 0.16287227012944905d,left: 0.20131415495079907d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9849171490713706d,right: 0.8319644931230813d,bottom: 0.4862809613461092d,left: 0.5828900964850319d),
},
            new NpgsqlBoxbox0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6242566454359163d,right: 0.6150645558280557d,bottom: 0.14163741851794753d,left: 0.04098415795855925d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.44893917971229536d,right: 0.5850533296104602d,bottom: 0.3221092775002059d,left: 0.38368977371040425d),
},
            new NpgsqlBoxbox0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1810698212419034d,right: 0.9845865520508911d,bottom: 0.14051879321867944d,left: 0.1632064630235034d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9036233736061304d,right: 0.1365862041935043d,bottom: 0.052453417962647686d,left: 0.06631507214855925d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8064300834279303d,right: 0.5122809948976341d,bottom: 0.21422247328726707d,left: 0.22632150130280748d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7596334320866933d,right: 0.8909658760512205d,bottom: 0.30754264769476547d,left: 0.027902207755246988d),
},
            new NpgsqlBoxbox0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2179461533131537d,right: 0.9846385775262887d,bottom: 0.20708635507502782d,left: 0.7875019706157589d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6319264528471571d,right: 0.3474486544856651d,bottom: 0.15399901780704306d,left: 0.24472770136518984d),
},
            new NpgsqlBoxbox0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6273880685645612d,right: 0.9468288738282957d,bottom: 0.0027624909079702054d,left: 0.1546913647471191d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6870531904177786d,right: 0.9012718103075733d,bottom: 0.3467072982001985d,left: 0.03815571351503144d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8667423914853203d,right: 0.10574737781341403d,bottom: 0.09615216938479898d,left: 0.07067686187993572d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9562055492721111d,right: 0.8208251537309847d,bottom: 0.08165667121465692d,left: 0.0600652210762761d),
},
            new NpgsqlBoxbox0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.836180940629798d,right: 0.9582802966647788d,bottom: 0.3696446631046566d,left: 0.6319391118382454d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6090121406423161d,right: 0.7362925551327633d,bottom: 0.3268300854874755d,left: 0.32282272000376944d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3657473468007635d,right: 0.8976045388253384d,bottom: 0.35219333199943126d,left: 0.32604087661339287d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8352845593822322d,right: 0.23487659518446125d,bottom: 0.5472938238417241d,left: 0.0814426689678377d),
},
            new NpgsqlBoxbox0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7126998899783985d,right: 0.9638637313857656d,bottom: 0.028802406148772053d,left: 0.5668721598480073d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5490278755157544d,right: 0.37027292060790784d,bottom: 0.4292364027243295d,left: 0.2704874460766681d),
},
            new NpgsqlBoxbox0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4390875219588697d,right: 0.7628789477690197d,bottom: 0.3954073549160304d,left: 0.24726838332709877d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9876420476929931d,right: 0.35268405571743056d,bottom: 0.46700021365197975d,left: 0.16268621028190577d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9121127217877415d,right: 0.8945907516371283d,bottom: 0.576644668811985d,left: 0.791477964631085d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8056825632547913d,right: 0.936975673907622d,bottom: 0.25383123961675413d,left: 0.5635733235282616d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6434309726349198d,right: 0.7570364512197405d,bottom: 0.28141244356592154d,left: 0.6324585016197021d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.1286760400119259d,right: 0.7180890477610979d,bottom: 0.0690909092628762d,left: 0.3401982778514878d),
},
            new NpgsqlBoxbox0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9448034567787554d,right: 0.17731855612131453d,bottom: 0.5441893988257648d,left: 0.05519821932925406d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8227246846619639d,right: 0.9644629343754747d,bottom: 0.4302616717500226d,left: 0.5287357604323581d),
},
            new NpgsqlBoxbox0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.891069409069548d,right: 0.9076431503842706d,bottom: 0.6143692159488443d,left: 0.675490625652012d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5239105216727371d,right: 0.6272978543447627d,bottom: 0.35622358069485716d,left: 0.2860430175286698d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6195179641687162d,right: 0.9218043491747726d,bottom: 0.33675084219481d,left: 0.23104866740041186d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9411631897968382d,right: 0.9017933575553041d,bottom: 0.027815210464919415d,left: 0.5506172765002213d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5113809139884417d,right: 0.5034232520735408d,bottom: 0.2020957453862401d,left: 0.45633493793832136d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8665592182181487d,right: 0.8144962881866677d,bottom: 0.7457370461975146d,left: 0.4947642696244775d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8586576605458808d,right: 0.6623226634838326d,bottom: 0.44479075151743364d,left: 0.4316781636087734d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8421488944895926d,right: 0.4747425671495211d,bottom: 0.41950429337209416d,left: 0.40935408956773567d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.23717901850253476d,right: 0.4276331341613191d,bottom: 0.07980385944209412d,left: 0.2614885890409351d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.620455953514756d,right: 0.2537326039411171d,bottom: 0.3730082682100099d,left: 0.042948229497092205d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9944347292788082d,right: 0.9629610539674859d,bottom: 0.11021356321272602d,left: 0.6260401654518659d),
},
            new NpgsqlBoxbox0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8966417468896206d,right: 0.8929668925011867d,bottom: 0.8499925587701805d,left: 0.8074886551403457d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8934534965823399d,right: 0.9445532746683883d,bottom: 0.18263802921702033d,left: 0.22247618492976307d),
},
            new NpgsqlBoxbox0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6687720418929965d,right: 0.9029561304781268d,bottom: 0.002923144152157442d,left: 0.4583396812538949d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2810543518962245d,right: 0.4622858458167072d,bottom: 0.12358571723606149d,left: 0.3947689740100355d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8079100308217715d,right: 0.30420763260664985d,bottom: 0.25929671049881897d,left: 0.18530533158121631d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8934109488926766d,right: 0.8948510108605985d,bottom: 0.6431690499370808d,left: 0.8696101582019642d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8875055244711647d,right: 0.36513978643811196d,bottom: 0.38075943824473135d,left: 0.25850534963730354d),
},
            new NpgsqlBoxbox0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6680617781277433d,right: 0.5621617489096074d,bottom: 0.030756794913062047d,left: 0.2667352822855843d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9992599297962841d,right: 0.5603557142270907d,bottom: 0.4761716170136807d,left: 0.38772525609253294d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8682653099037325d,right: 0.5102936144690698d,bottom: 0.837934119255016d,left: 0.013413760711661893d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.42680688764508645d,right: 0.9838137600886493d,bottom: 0.13111299038465174d,left: 0.5746969801922724d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7258930667743619d,right: 0.592561218411271d,bottom: 0.4662968882815546d,left: 0.04708282153749066d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7370020948067402d,right: 0.9533926862030363d,bottom: 0.3794677145001213d,left: 0.06058110561759833d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7452565078265749d,right: 0.5012361789459715d,bottom: 0.07944673185112827d,left: 0.47922048538108675d),
},
            new NpgsqlBoxbox0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9829286640469239d,right: 0.9371729327278525d,bottom: 0.5986421941558606d,left: 0.4159190337927634d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.904137563621923d,right: 0.9724943543427012d,bottom: 0.5910967137840646d,left: 0.9233043329017959d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4710913839073312d,right: 0.2767663145215412d,bottom: 0.37088018375058596d,left: 0.04901817042907475d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.30673975691388033d,right: 0.8127606104991545d,bottom: 0.1443727751825843d,left: 0.22259886708706267d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6924127275243314d,right: 0.9943785798411711d,bottom: 0.3154468344935554d,left: 0.1282301442484175d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
INSERT INTO public.npgsqlboxbox0mi(
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
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
                methodParametrName: "npgsqlboxbox0mi_id", 
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
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7878231440292806d,right: 0.7882831261925468d,bottom: 0.5243579260540979d,left: 0.7080406179138949d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.5466412562497311d,right: 0.916227449272836d,bottom: 0.1978312006231585d,left: 0.49408354873850713d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.4643674112271263d,right: 0.48903491573060165d,bottom: 0.25698890308554345d,left: 0.2891623880972498d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.42408156257009433d,right: 0.9887652662121613d,bottom: 0.35930997037657375d,left: 0.2315174850993158d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9849171490713706d,right: 0.8319644931230813d,bottom: 0.4862809613461092d,left: 0.5828900964850319d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.44893917971229536d,right: 0.5850533296104602d,bottom: 0.3221092775002059d,left: 0.38368977371040425d)));
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7596334320866933d,right: 0.8909658760512205d,bottom: 0.30754264769476547d,left: 0.027902207755246988d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
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
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
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
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr2.Value = 21;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 74;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
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
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[34], false);
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 87, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 19, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 68, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 30, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 142, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 34, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[34], false);
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 18, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[25],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[26],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7896915821461215d,right: 0.8157382832210435d,bottom: 0.6086717525379222d,left: 0.2500914327002599d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4353571132565286d,right: 0.25334507161650677d,bottom: 0.015664095312488135d,left: 0.1902802008050718d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9530503856404506d,right: 0.7550016653589016d,bottom: 0.08169987697135495d,left: 0.4801363057010728d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9170987251080424d,right: 0.9622558133770203d,bottom: 0.33359643103758385d,left: 0.6876888978633077d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.70630428838959d,right: 0.9614757645015737d,bottom: 0.3131177715461627d,left: 0.17689732352937715d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5397929236887089d,right: 0.47325592739805566d,bottom: 0.42545895319287597d,left: 0.20083453630963866d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9734879540361149d,right: 0.9430327225934765d,bottom: 0.30954283939606064d,left: 0.5825022821613566d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8554338038060147d,right: 0.6811605465759367d,bottom: 0.7650267535937852d,left: 0.47255356861806375d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4580756467168078d,right: 0.9229286513503899d,bottom: 0.011432318366246697d,left: 0.5849077457321221d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.625130091128072d,right: 0.7546909688503368d,bottom: 0.6225014870468212d,left: 0.6015389867022832d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9223071851885152d,right: 0.8614400096790321d,bottom: 0.44488181931172044d,left: 0.5156038284559223d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7878231440292806d,right: 0.7882831261925468d,bottom: 0.5243579260540979d,left: 0.7080406179138949d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6175981000403273d,right: 0.23611916622971174d,bottom: 0.2855209698506921d,left: 0.12036378659411895d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5384454645740016d,right: 0.5891614170098026d,bottom: 0.1860750249055666d,left: 0.24095928209832818d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5797400304487542d,right: 0.7423100562246553d,bottom: 0.47524896598219746d,left: 0.36388322220816693d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5466412562497311d,right: 0.916227449272836d,bottom: 0.1978312006231585d,left: 0.49408354873850713d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7876243384127681d,right: 0.681961148710539d,bottom: 0.3865303817688234d,left: 0.07981501308090067d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7553431256662454d,right: 0.48261956701457787d,bottom: 0.7090809876820463d,left: 0.43592215462515116d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.40558809699514964d,right: 0.8836668697310321d,bottom: 0.09654833362234216d,left: 0.23957437724692854d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8292761668717257d,right: 0.7225972256968513d,bottom: 0.13121174460142182d,left: 0.4661313954649168d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4643674112271263d,right: 0.48903491573060165d,bottom: 0.25698890308554345d,left: 0.2891623880972498d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4229386763230638d,right: 0.9717745298979173d,bottom: 0.2161608874049772d,left: 0.6197994694990892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42408156257009433d,right: 0.9887652662121613d,bottom: 0.35930997037657375d,left: 0.2315174850993158d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8368805599459931d,right: 0.30401272706803373d,bottom: 0.22444490993826993d,left: 0.009274423760969652d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6642922919840952d,right: 0.5351529082967809d,bottom: 0.03024445014911159d,left: 0.3900674808172515d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8011326185295609d,right: 0.8503956401362289d,bottom: 0.16287227012944905d,left: 0.20131415495079907d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9849171490713706d,right: 0.8319644931230813d,bottom: 0.4862809613461092d,left: 0.5828900964850319d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6242566454359163d,right: 0.6150645558280557d,bottom: 0.14163741851794753d,left: 0.04098415795855925d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44893917971229536d,right: 0.5850533296104602d,bottom: 0.3221092775002059d,left: 0.38368977371040425d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1810698212419034d,right: 0.9845865520508911d,bottom: 0.14051879321867944d,left: 0.1632064630235034d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9036233736061304d,right: 0.1365862041935043d,bottom: 0.052453417962647686d,left: 0.06631507214855925d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8064300834279303d,right: 0.5122809948976341d,bottom: 0.21422247328726707d,left: 0.22632150130280748d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7596334320866933d,right: 0.8909658760512205d,bottom: 0.30754264769476547d,left: 0.027902207755246988d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2179461533131537d,right: 0.9846385775262887d,bottom: 0.20708635507502782d,left: 0.7875019706157589d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6319264528471571d,right: 0.3474486544856651d,bottom: 0.15399901780704306d,left: 0.24472770136518984d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6273880685645612d,right: 0.9468288738282957d,bottom: 0.0027624909079702054d,left: 0.1546913647471191d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6870531904177786d,right: 0.9012718103075733d,bottom: 0.3467072982001985d,left: 0.03815571351503144d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8667423914853203d,right: 0.10574737781341403d,bottom: 0.09615216938479898d,left: 0.07067686187993572d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9562055492721111d,right: 0.8208251537309847d,bottom: 0.08165667121465692d,left: 0.0600652210762761d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.836180940629798d,right: 0.9582802966647788d,bottom: 0.3696446631046566d,left: 0.6319391118382454d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6090121406423161d,right: 0.7362925551327633d,bottom: 0.3268300854874755d,left: 0.32282272000376944d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3657473468007635d,right: 0.8976045388253384d,bottom: 0.35219333199943126d,left: 0.32604087661339287d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8352845593822322d,right: 0.23487659518446125d,bottom: 0.5472938238417241d,left: 0.0814426689678377d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7126998899783985d,right: 0.9638637313857656d,bottom: 0.028802406148772053d,left: 0.5668721598480073d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5490278755157544d,right: 0.37027292060790784d,bottom: 0.4292364027243295d,left: 0.2704874460766681d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4390875219588697d,right: 0.7628789477690197d,bottom: 0.3954073549160304d,left: 0.24726838332709877d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9876420476929931d,right: 0.35268405571743056d,bottom: 0.46700021365197975d,left: 0.16268621028190577d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9121127217877415d,right: 0.8945907516371283d,bottom: 0.576644668811985d,left: 0.791477964631085d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8056825632547913d,right: 0.936975673907622d,bottom: 0.25383123961675413d,left: 0.5635733235282616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6434309726349198d,right: 0.7570364512197405d,bottom: 0.28141244356592154d,left: 0.6324585016197021d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1286760400119259d,right: 0.7180890477610979d,bottom: 0.0690909092628762d,left: 0.3401982778514878d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9448034567787554d,right: 0.17731855612131453d,bottom: 0.5441893988257648d,left: 0.05519821932925406d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8227246846619639d,right: 0.9644629343754747d,bottom: 0.4302616717500226d,left: 0.5287357604323581d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.891069409069548d,right: 0.9076431503842706d,bottom: 0.6143692159488443d,left: 0.675490625652012d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5239105216727371d,right: 0.6272978543447627d,bottom: 0.35622358069485716d,left: 0.2860430175286698d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6195179641687162d,right: 0.9218043491747726d,bottom: 0.33675084219481d,left: 0.23104866740041186d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9411631897968382d,right: 0.9017933575553041d,bottom: 0.027815210464919415d,left: 0.5506172765002213d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5113809139884417d,right: 0.5034232520735408d,bottom: 0.2020957453862401d,left: 0.45633493793832136d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8665592182181487d,right: 0.8144962881866677d,bottom: 0.7457370461975146d,left: 0.4947642696244775d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8586576605458808d,right: 0.6623226634838326d,bottom: 0.44479075151743364d,left: 0.4316781636087734d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8421488944895926d,right: 0.4747425671495211d,bottom: 0.41950429337209416d,left: 0.40935408956773567d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23717901850253476d,right: 0.4276331341613191d,bottom: 0.07980385944209412d,left: 0.2614885890409351d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.620455953514756d,right: 0.2537326039411171d,bottom: 0.3730082682100099d,left: 0.042948229497092205d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9944347292788082d,right: 0.9629610539674859d,bottom: 0.11021356321272602d,left: 0.6260401654518659d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8966417468896206d,right: 0.8929668925011867d,bottom: 0.8499925587701805d,left: 0.8074886551403457d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8934534965823399d,right: 0.9445532746683883d,bottom: 0.18263802921702033d,left: 0.22247618492976307d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6687720418929965d,right: 0.9029561304781268d,bottom: 0.002923144152157442d,left: 0.4583396812538949d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2810543518962245d,right: 0.4622858458167072d,bottom: 0.12358571723606149d,left: 0.3947689740100355d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8079100308217715d,right: 0.30420763260664985d,bottom: 0.25929671049881897d,left: 0.18530533158121631d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8934109488926766d,right: 0.8948510108605985d,bottom: 0.6431690499370808d,left: 0.8696101582019642d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8875055244711647d,right: 0.36513978643811196d,bottom: 0.38075943824473135d,left: 0.25850534963730354d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6680617781277433d,right: 0.5621617489096074d,bottom: 0.030756794913062047d,left: 0.2667352822855843d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9992599297962841d,right: 0.5603557142270907d,bottom: 0.4761716170136807d,left: 0.38772525609253294d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8682653099037325d,right: 0.5102936144690698d,bottom: 0.837934119255016d,left: 0.013413760711661893d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42680688764508645d,right: 0.9838137600886493d,bottom: 0.13111299038465174d,left: 0.5746969801922724d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7258930667743619d,right: 0.592561218411271d,bottom: 0.4662968882815546d,left: 0.04708282153749066d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7370020948067402d,right: 0.9533926862030363d,bottom: 0.3794677145001213d,left: 0.06058110561759833d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7452565078265749d,right: 0.5012361789459715d,bottom: 0.07944673185112827d,left: 0.47922048538108675d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9829286640469239d,right: 0.9371729327278525d,bottom: 0.5986421941558606d,left: 0.4159190337927634d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.904137563621923d,right: 0.9724943543427012d,bottom: 0.5910967137840646d,left: 0.9233043329017959d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4710913839073312d,right: 0.2767663145215412d,bottom: 0.37088018375058596d,left: 0.04901817042907475d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30673975691388033d,right: 0.8127606104991545d,bottom: 0.1443727751825843d,left: 0.22259886708706267d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6924127275243314d,right: 0.9943785798411711d,bottom: 0.3154468344935554d,left: 0.1282301442484175d))));//Value

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
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7896915821461215d,right: 0.8157382832210435d,bottom: 0.6086717525379222d,left: 0.2500914327002599d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4353571132565286d,right: 0.25334507161650677d,bottom: 0.015664095312488135d,left: 0.1902802008050718d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9530503856404506d,right: 0.7550016653589016d,bottom: 0.08169987697135495d,left: 0.4801363057010728d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9170987251080424d,right: 0.9622558133770203d,bottom: 0.33359643103758385d,left: 0.6876888978633077d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.70630428838959d,right: 0.9614757645015737d,bottom: 0.3131177715461627d,left: 0.17689732352937715d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5397929236887089d,right: 0.47325592739805566d,bottom: 0.42545895319287597d,left: 0.20083453630963866d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9734879540361149d,right: 0.9430327225934765d,bottom: 0.30954283939606064d,left: 0.5825022821613566d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8554338038060147d,right: 0.6811605465759367d,bottom: 0.7650267535937852d,left: 0.47255356861806375d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4580756467168078d,right: 0.9229286513503899d,bottom: 0.011432318366246697d,left: 0.5849077457321221d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.625130091128072d,right: 0.7546909688503368d,bottom: 0.6225014870468212d,left: 0.6015389867022832d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9223071851885152d,right: 0.8614400096790321d,bottom: 0.44488181931172044d,left: 0.5156038284559223d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7878231440292806d,right: 0.7882831261925468d,bottom: 0.5243579260540979d,left: 0.7080406179138949d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6175981000403273d,right: 0.23611916622971174d,bottom: 0.2855209698506921d,left: 0.12036378659411895d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5384454645740016d,right: 0.5891614170098026d,bottom: 0.1860750249055666d,left: 0.24095928209832818d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5797400304487542d,right: 0.7423100562246553d,bottom: 0.47524896598219746d,left: 0.36388322220816693d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5466412562497311d,right: 0.916227449272836d,bottom: 0.1978312006231585d,left: 0.49408354873850713d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7876243384127681d,right: 0.681961148710539d,bottom: 0.3865303817688234d,left: 0.07981501308090067d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7553431256662454d,right: 0.48261956701457787d,bottom: 0.7090809876820463d,left: 0.43592215462515116d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.40558809699514964d,right: 0.8836668697310321d,bottom: 0.09654833362234216d,left: 0.23957437724692854d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8292761668717257d,right: 0.7225972256968513d,bottom: 0.13121174460142182d,left: 0.4661313954649168d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4643674112271263d,right: 0.48903491573060165d,bottom: 0.25698890308554345d,left: 0.2891623880972498d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4229386763230638d,right: 0.9717745298979173d,bottom: 0.2161608874049772d,left: 0.6197994694990892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42408156257009433d,right: 0.9887652662121613d,bottom: 0.35930997037657375d,left: 0.2315174850993158d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8368805599459931d,right: 0.30401272706803373d,bottom: 0.22444490993826993d,left: 0.009274423760969652d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6642922919840952d,right: 0.5351529082967809d,bottom: 0.03024445014911159d,left: 0.3900674808172515d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8011326185295609d,right: 0.8503956401362289d,bottom: 0.16287227012944905d,left: 0.20131415495079907d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9849171490713706d,right: 0.8319644931230813d,bottom: 0.4862809613461092d,left: 0.5828900964850319d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6242566454359163d,right: 0.6150645558280557d,bottom: 0.14163741851794753d,left: 0.04098415795855925d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44893917971229536d,right: 0.5850533296104602d,bottom: 0.3221092775002059d,left: 0.38368977371040425d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1810698212419034d,right: 0.9845865520508911d,bottom: 0.14051879321867944d,left: 0.1632064630235034d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9036233736061304d,right: 0.1365862041935043d,bottom: 0.052453417962647686d,left: 0.06631507214855925d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8064300834279303d,right: 0.5122809948976341d,bottom: 0.21422247328726707d,left: 0.22632150130280748d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7596334320866933d,right: 0.8909658760512205d,bottom: 0.30754264769476547d,left: 0.027902207755246988d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2179461533131537d,right: 0.9846385775262887d,bottom: 0.20708635507502782d,left: 0.7875019706157589d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6319264528471571d,right: 0.3474486544856651d,bottom: 0.15399901780704306d,left: 0.24472770136518984d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6273880685645612d,right: 0.9468288738282957d,bottom: 0.0027624909079702054d,left: 0.1546913647471191d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6870531904177786d,right: 0.9012718103075733d,bottom: 0.3467072982001985d,left: 0.03815571351503144d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8667423914853203d,right: 0.10574737781341403d,bottom: 0.09615216938479898d,left: 0.07067686187993572d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9562055492721111d,right: 0.8208251537309847d,bottom: 0.08165667121465692d,left: 0.0600652210762761d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.836180940629798d,right: 0.9582802966647788d,bottom: 0.3696446631046566d,left: 0.6319391118382454d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6090121406423161d,right: 0.7362925551327633d,bottom: 0.3268300854874755d,left: 0.32282272000376944d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3657473468007635d,right: 0.8976045388253384d,bottom: 0.35219333199943126d,left: 0.32604087661339287d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8352845593822322d,right: 0.23487659518446125d,bottom: 0.5472938238417241d,left: 0.0814426689678377d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7126998899783985d,right: 0.9638637313857656d,bottom: 0.028802406148772053d,left: 0.5668721598480073d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5490278755157544d,right: 0.37027292060790784d,bottom: 0.4292364027243295d,left: 0.2704874460766681d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4390875219588697d,right: 0.7628789477690197d,bottom: 0.3954073549160304d,left: 0.24726838332709877d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9876420476929931d,right: 0.35268405571743056d,bottom: 0.46700021365197975d,left: 0.16268621028190577d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9121127217877415d,right: 0.8945907516371283d,bottom: 0.576644668811985d,left: 0.791477964631085d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8056825632547913d,right: 0.936975673907622d,bottom: 0.25383123961675413d,left: 0.5635733235282616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6434309726349198d,right: 0.7570364512197405d,bottom: 0.28141244356592154d,left: 0.6324585016197021d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1286760400119259d,right: 0.7180890477610979d,bottom: 0.0690909092628762d,left: 0.3401982778514878d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9448034567787554d,right: 0.17731855612131453d,bottom: 0.5441893988257648d,left: 0.05519821932925406d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8227246846619639d,right: 0.9644629343754747d,bottom: 0.4302616717500226d,left: 0.5287357604323581d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.891069409069548d,right: 0.9076431503842706d,bottom: 0.6143692159488443d,left: 0.675490625652012d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5239105216727371d,right: 0.6272978543447627d,bottom: 0.35622358069485716d,left: 0.2860430175286698d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6195179641687162d,right: 0.9218043491747726d,bottom: 0.33675084219481d,left: 0.23104866740041186d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9411631897968382d,right: 0.9017933575553041d,bottom: 0.027815210464919415d,left: 0.5506172765002213d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5113809139884417d,right: 0.5034232520735408d,bottom: 0.2020957453862401d,left: 0.45633493793832136d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8665592182181487d,right: 0.8144962881866677d,bottom: 0.7457370461975146d,left: 0.4947642696244775d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8586576605458808d,right: 0.6623226634838326d,bottom: 0.44479075151743364d,left: 0.4316781636087734d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8421488944895926d,right: 0.4747425671495211d,bottom: 0.41950429337209416d,left: 0.40935408956773567d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23717901850253476d,right: 0.4276331341613191d,bottom: 0.07980385944209412d,left: 0.2614885890409351d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.620455953514756d,right: 0.2537326039411171d,bottom: 0.3730082682100099d,left: 0.042948229497092205d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9944347292788082d,right: 0.9629610539674859d,bottom: 0.11021356321272602d,left: 0.6260401654518659d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8966417468896206d,right: 0.8929668925011867d,bottom: 0.8499925587701805d,left: 0.8074886551403457d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8934534965823399d,right: 0.9445532746683883d,bottom: 0.18263802921702033d,left: 0.22247618492976307d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6687720418929965d,right: 0.9029561304781268d,bottom: 0.002923144152157442d,left: 0.4583396812538949d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2810543518962245d,right: 0.4622858458167072d,bottom: 0.12358571723606149d,left: 0.3947689740100355d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8079100308217715d,right: 0.30420763260664985d,bottom: 0.25929671049881897d,left: 0.18530533158121631d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8934109488926766d,right: 0.8948510108605985d,bottom: 0.6431690499370808d,left: 0.8696101582019642d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8875055244711647d,right: 0.36513978643811196d,bottom: 0.38075943824473135d,left: 0.25850534963730354d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6680617781277433d,right: 0.5621617489096074d,bottom: 0.030756794913062047d,left: 0.2667352822855843d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9992599297962841d,right: 0.5603557142270907d,bottom: 0.4761716170136807d,left: 0.38772525609253294d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8682653099037325d,right: 0.5102936144690698d,bottom: 0.837934119255016d,left: 0.013413760711661893d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42680688764508645d,right: 0.9838137600886493d,bottom: 0.13111299038465174d,left: 0.5746969801922724d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7258930667743619d,right: 0.592561218411271d,bottom: 0.4662968882815546d,left: 0.04708282153749066d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7370020948067402d,right: 0.9533926862030363d,bottom: 0.3794677145001213d,left: 0.06058110561759833d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7452565078265749d,right: 0.5012361789459715d,bottom: 0.07944673185112827d,left: 0.47922048538108675d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9829286640469239d,right: 0.9371729327278525d,bottom: 0.5986421941558606d,left: 0.4159190337927634d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.904137563621923d,right: 0.9724943543427012d,bottom: 0.5910967137840646d,left: 0.9233043329017959d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4710913839073312d,right: 0.2767663145215412d,bottom: 0.37088018375058596d,left: 0.04901817042907475d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30673975691388033d,right: 0.8127606104991545d,bottom: 0.1443727751825843d,left: 0.22259886708706267d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6924127275243314d,right: 0.9943785798411711d,bottom: 0.3154468344935554d,left: 0.1282301442484175d))));//Value

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
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
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
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
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxbox0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxbox0M),
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
FROM public.binary_npgsqlboxbox0m m
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                var importCollection = new List<NpgsqlBoxbox0M>();
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
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0M>();
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
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI), typeof(NpgsqlBoxbox0MI)],
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

