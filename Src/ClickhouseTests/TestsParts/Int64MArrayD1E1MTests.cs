

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IInt64MArrayMArrayD1
    {
    }
    
    internal partial class Int64MArrayMArrayD1 : IInt64MArrayMArrayD1
    {


#region TestData

        private readonly Int64MArrayD1E1M[] _testData = new Int64MArrayD1E1M[]
        {
            new Int64MArrayD1E1M
{
    Id = 4,
    Value = 
new System.Int64[3]
{
8320927370190630202L,
1987142866079353170L,
1651014775905672460L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Int64[3]
{
4505589438893919900L,
5443562761337720947L,
2780853022589400574L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 5,
    Value = 
new System.Int64[3]
{
1909679503122258962L,
679609487185545900L,
2032939511622309728L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Int64[3]
{
5542799864731347046L,
3842810707980426101L,
8204307911512594211L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8844293819070880589L,
7186307917735572322L,
5161731840523191287L,
758995273511020949L,
},
},
            new Int64MArrayD1E1M
{
    Id = 12,
    Value = 
new System.Int64[3]
{
4931259079305549107L,
1034043811350988389L,
1465591604271578247L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Int64[3]
{
2967941543619565261L,
6076395890405280276L,
1351691778323563591L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1464495407283130717L,
9044529671241711575L,
45647324306409632L,
3835889854440282103L,
},
},
            new Int64MArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int64[4]
{
2730191559532334275L,
6866094629816924861L,
9167284311588456167L,
3923711935678721178L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Int64[3]
{
7481323168646159933L,
1468817694398680764L,
4173158576047886887L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8788946062029027765L,
7687396455021367966L,
741701507434346054L,
1281726032688408499L,
},
},
            new Int64MArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int64[3]
{
1215063684881344978L,
6385050860592247997L,
7713235596791853049L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Int64[3]
{
6851476723204963554L,
8515532082372479965L,
5591243440169524092L,
},
    NullableValue = 
new System.Int64[4]
{
2234964555087731517L,
9141474262878065152L,
2769747371356008502L,
6861012002512568500L,
},
},
    NullableValue = 
new System.Int64[4]
{
4336842588389371907L,
6914050659667298444L,
2733175421401309802L,
532787016849255634L,
},
},
            new Int64MArrayD1E1M
{
    Id = 28,
    Value = 
new System.Int64[4]
{
3946982965501599755L,
1645298663013285669L,
9040144317166338179L,
3059796363363958434L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Int64[4]
{
3138535988133993182L,
1592947765620373092L,
4041129380089795391L,
3876166649616053993L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 36,
    Value = 
new System.Int64[3]
{
7470615543071087872L,
1237245861405480834L,
9130421214713536357L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Int64[4]
{
2923856250028510288L,
5189793161734108110L,
5415788514601081403L,
1411298291584677897L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int64[4]
{
1561190693371846962L,
7477947227139631028L,
2415648477433120318L,
9169763836751271812L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Int64[4]
{
3544450104025264810L,
3947211581735034655L,
221610578798882682L,
416675108489814290L,
},
    NullableValue = 
new System.Int64[3]
{
1992084732753707158L,
2376130378339356876L,
8792436836421364382L,
},
},
    NullableValue = 
new System.Int64[3]
{
4103610185370375925L,
2604432478991331647L,
1253688653455847777L,
},
},
            new Int64MArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int64[4]
{
8704597121681996438L,
1666797705420942520L,
6633181138949989309L,
1498831812210409076L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Int64[3]
{
2699970080748802563L,
7409430159890366446L,
7383749234163902989L,
},
    NullableValue = 
new System.Int64[4]
{
1007445645712758026L,
5047579123160909257L,
8291942485437248014L,
4252567801449859906L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int64[3]
{
3630774350734938169L,
4887156492965295547L,
3155299642733576290L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Int64[4]
{
3106541585917032970L,
9135961093332818638L,
1151886914203930953L,
7090338593332344935L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2187627328657754278L,
2067692948896343683L,
2304257770936254911L,
7526462172767604928L,
},
},
            new Int64MArrayD1E1M
{
    Id = 54,
    Value = 
new System.Int64[4]
{
1402643911269195105L,
3575556997484313558L,
3351334188380426277L,
3199225828151297953L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Int64[4]
{
5041291619221944388L,
3390780241390831686L,
604255382347588094L,
7744451092048891658L,
},
    NullableValue = 
new System.Int64[4]
{
952576752806304781L,
8037964318647226663L,
5477167398312353557L,
929921596007990872L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 62,
    Value = 
new System.Int64[4]
{
6299804967040603198L,
9181328395017010845L,
8047871091891950737L,
6475271006194738648L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int64[3]
{
4640091726916885615L,
4542723073532603748L,
2150889094423251170L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int64[4]
{
5501743458494911188L,
2931703948676296537L,
5581171054839631529L,
4315891490715317684L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Int64[3]
{
1401291454384615711L,
3445359148012775012L,
3755961327456086279L,
},
    NullableValue = 
new System.Int64[3]
{
5463752569365063641L,
6716891563929024899L,
4083106015384766046L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 79,
    Value = 
new System.Int64[3]
{
5225533393417859879L,
5245263880983212805L,
3970229174330332924L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Int64[3]
{
5542167188397497872L,
342413342580759692L,
4592550514865863828L,
},
    NullableValue = 
new System.Int64[3]
{
1704526963727128846L,
8219894587669423810L,
8796152075250424570L,
},
},
    NullableValue = 
new System.Int64[3]
{
748155727081534122L,
4192967371085474022L,
2554664869051556613L,
},
},
            new Int64MArrayD1E1M
{
    Id = 84,
    Value = 
new System.Int64[4]
{
730045129199485672L,
5825609614792285518L,
7716140170496569078L,
2636193902654984682L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Int64[3]
{
1029663178019987672L,
5557235372397122799L,
5917688998359690288L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 86,
    Value = 
new System.Int64[3]
{
2005321363882870859L,
7344010058282370770L,
4297666599355115294L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int64[3]
{
1767426551424878287L,
413957651550025285L,
4198940030170350966L,
},
    NullableValue = 
new System.Int64[4]
{
1534689280167864186L,
611515734973364573L,
5127657915295214271L,
5684332252846223199L,
},
},
    NullableValue = 
new System.Int64[3]
{
1970845782495059999L,
8262170214423572766L,
7597097268872076326L,
},
},
            new Int64MArrayD1E1M
{
    Id = 92,
    Value = 
new System.Int64[4]
{
1367102755262786867L,
646922821965164542L,
9064039028155035079L,
8316271654616913207L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Int64[4]
{
3918880256436921296L,
3857323655387626444L,
8664077277631873825L,
5538008791048408154L,
},
    NullableValue = 
new System.Int64[3]
{
6641817707542530770L,
2751547134295080777L,
2617335183934172777L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 96,
    Value = 
new System.Int64[3]
{
5810927212063819575L,
6218795826765151972L,
6974202080501031665L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int64[4]
{
4176383422560395920L,
4197972219624158444L,
16297332066189650L,
2812087710349732506L,
},
    NullableValue = 
new System.Int64[3]
{
2530003697938994753L,
494709574627057108L,
4815611718699625279L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 100,
    Value = 
new System.Int64[4]
{
1243246147470006591L,
7300846390461391294L,
2532170024668948233L,
8187353108984381867L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Int64[4]
{
1301622757642286733L,
7786862375713623072L,
3262176135108561875L,
2425463607232046650L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6524499586247219455L,
6531580272196754515L,
28545431559750597L,
7002813567853209597L,
},
},
            new Int64MArrayD1E1M
{
    Id = 106,
    Value = 
new System.Int64[3]
{
5429897680386554853L,
6101625233563143493L,
7028223123109730703L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Int64[3]
{
1016893462392850905L,
336659156192567734L,
7188272716488612659L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7504682950050223324L,
3277204495111540560L,
962149417239073749L,
1632103243763330571L,
},
},
            new Int64MArrayD1E1M
{
    Id = 110,
    Value = 
new System.Int64[3]
{
5460701216374152420L,
616598892156667999L,
5483624274066450752L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Int64[4]
{
7108335443669737236L,
714065758325975242L,
6253812081640815822L,
7525586476601209242L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 114,
    Value = 
new System.Int64[3]
{
4250904500841458706L,
8579903059055262129L,
4829775553960181122L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Int64[3]
{
6022682076441762682L,
1997314707744162507L,
2500622425281187644L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1472053544987224901L,
4184291013605507598L,
4847110665826170291L,
},
},
            new Int64MArrayD1E1M
{
    Id = 117,
    Value = 
new System.Int64[3]
{
5822550354800618009L,
6284132169116684837L,
3150941707018490920L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Int64[3]
{
4488462244559036456L,
2001593238209149166L,
5498306451618861675L,
},
    NullableValue = 
new System.Int64[3]
{
593462392072300015L,
5800004941959687173L,
8594734930540440292L,
},
},
    NullableValue = 
new System.Int64[3]
{
3320846924124896253L,
3289632041113549652L,
1324240802756035249L,
},
},
            new Int64MArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int64[3]
{
1653115410642050644L,
5438085120333930098L,
679006088913893292L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Int64[4]
{
3532483142712721639L,
487273962281773461L,
355803476324844125L,
5692351122004129769L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int64[3]
{
8928340662475499669L,
2381384908858188349L,
5383436400927629874L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.Int64[4]
{
4234423660259169493L,
1262900775866466808L,
6102609802088563894L,
7968161839572943879L,
},
    NullableValue = 
new System.Int64[3]
{
4264145184937502072L,
5173321380956931397L,
3406561527800565396L,
},
},
    NullableValue = 
new System.Int64[4]
{
6278680641278162685L,
1101254243553086564L,
283567318794063093L,
6371968398342728039L,
},
},
            new Int64MArrayD1E1M
{
    Id = 137,
    Value = 
new System.Int64[4]
{
4780577818650038172L,
1737545829506365286L,
5162822502924941713L,
678039797421784748L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Int64[3]
{
3699622638728919524L,
2235330058902542842L,
4693734506514117953L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 142,
    Value = 
new System.Int64[4]
{
6544800807675632541L,
5285955627796041909L,
8706558957496072761L,
1481262406689407120L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 132,
    Value = 
new System.Int64[4]
{
4866011880952173749L,
1576357236869610811L,
2022031781862211780L,
2469814304863319409L,
},
    NullableValue = 
new System.Int64[4]
{
4242284620875906571L,
6243965944379404612L,
7631441513394462109L,
843312682174637443L,
},
},
    NullableValue = 
new System.Int64[3]
{
9141165106852782514L,
5783191556911961348L,
2196567166698369852L,
},
},
            new Int64MArrayD1E1M
{
    Id = 146,
    Value = 
new System.Int64[4]
{
125204556111222284L,
305053428134484331L,
904119968525524985L,
6139459984405379705L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Int64[4]
{
2610556661266951811L,
3255821835755489519L,
4218027109260468273L,
2650186492569558308L,
},
    NullableValue = 
new System.Int64[4]
{
7807196700578226929L,
9130858625460786379L,
5188968223187517511L,
4716066832919250809L,
},
},
    NullableValue = 
new System.Int64[4]
{
1808228835732994941L,
5237079338919106282L,
6849490457428064081L,
6031463807296078887L,
},
},
            new Int64MArrayD1E1M
{
    Id = 153,
    Value = 
new System.Int64[3]
{
2756422223061846828L,
6203343844890766040L,
4885964930520869739L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 144,
    Value = 
new System.Int64[3]
{
3996417395758109865L,
5978280474094460954L,
2226950572730720382L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
588631156025327161L,
4868487946080522789L,
8503018495857616105L,
1897469019579823541L,
},
},
            new Int64MArrayD1E1M
{
    Id = 162,
    Value = 
new System.Int64[3]
{
5788442883545183214L,
6482584023191557809L,
3589052509417059769L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Int64[4]
{
7058674673809597613L,
4395414445010830124L,
5724084417349256881L,
1958463312017577462L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4298559208981684770L,
9055999511443472706L,
130788607192898715L,
},
},
            new Int64MArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int64[4]
{
7661737202908339469L,
7058693711522977044L,
7418646830147554002L,
8196899638951350752L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Int64[3]
{
6365021710804718845L,
6525816534364798034L,
980896547607575191L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 173,
    Value = 
new System.Int64[3]
{
4046909008848009491L,
3412154413057837968L,
3906154360382077417L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Int64[3]
{
6414528793275924027L,
1839262144537581538L,
3022721333507488381L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 177,
    Value = 
new System.Int64[4]
{
5150557991850516605L,
6759269297136061229L,
7402158045299918787L,
1265310781846638791L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 159,
    Value = 
new System.Int64[4]
{
5686828131218818162L,
1329976896268926602L,
1684136472818447455L,
732171850164089940L,
},
    NullableValue = 
new System.Int64[4]
{
2257266292372894638L,
5037824120204863996L,
2737105077493046032L,
4224862076046334963L,
},
},
    NullableValue = 
new System.Int64[3]
{
4371278103758589586L,
3683923045669041987L,
1085715994171731109L,
},
},
            new Int64MArrayD1E1M
{
    Id = 178,
    Value = 
new System.Int64[4]
{
6250584100909054605L,
634815163451047235L,
2350514707699034968L,
8447741194929239084L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Int64[3]
{
897925986468098017L,
3993073370958602038L,
2031952515239824507L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
484960964079767889L,
4817314158935092634L,
986267106700938901L,
1123000077054338116L,
},
},
            new Int64MArrayD1E1M
{
    Id = 185,
    Value = 
new System.Int64[4]
{
3071454631982282675L,
4898689790588067924L,
5685805852451444846L,
583800603404558180L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.Int64[4]
{
8739857394206415820L,
3128467393966470558L,
6664759873923379045L,
5001043433832239666L,
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int64)}, 
    {mi_id:Int32},
    {mi_value:Array(Int64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IInt64MArrayMArrayD1)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.int64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

