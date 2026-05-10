

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
    internal partial interface IUInt64ArrayArrayUInt64
    {
    }
    
    internal partial class UInt64ArrayArrayUInt64 : IUInt64ArrayArrayUInt64
    {


#region TestData

        private readonly UInt64ArrayUInt641M[] _testData = new UInt64ArrayUInt641M[]
        {
            new UInt64ArrayUInt641M
{
    Id = 4,
    Value = 
new System.UInt64[4]
{
2955130716160513778L,
3203027989996418705L,
3106780430201759381L,
7377776807900985800L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 3,
    Value = 
new System.UInt64[4]
{
3342026671606779906L,
4635822738453410060L,
6428988780135050895L,
5147485697925791674L,
},
    NullableValue = 
new System.UInt64[3]
{
6724773593580890520L,
2115388784981828141L,
8307120870964499696L,
},
},
    NullableValue = 
new System.UInt64[3]
{
6836909876047863501L,
7757380532686018959L,
6236866658630608552L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 6,
    Value = 
new System.UInt64[3]
{
9001118922555652549L,
2126498048216461148L,
6400406928590323948L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 8,
    Value = 
new System.UInt64[4]
{
4723555380429558129L,
7528883276083531212L,
6001048635630019982L,
3331311457953783231L,
},
    NullableValue = 
new System.UInt64[3]
{
8559281314515608980L,
2874701135034797643L,
180801398580935535L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 11,
    Value = 
new System.UInt64[3]
{
137181412706097383L,
2688177139516628344L,
8689255099893645473L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 16,
    Value = 
new System.UInt64[4]
{
2396134521084872609L,
485395856275256605L,
2434289642620954917L,
5833081343162797917L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
6757689037163549740L,
5447286202118068294L,
6845642807363168925L,
778179526704020606L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 14,
    Value = 
new System.UInt64[3]
{
5059073048610330662L,
3509758549910383740L,
2821413597955020028L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 22,
    Value = 
new System.UInt64[4]
{
4148664307909960855L,
8656516832361529082L,
6133725784951351950L,
6735276960748543310L,
},
    NullableValue = 
new System.UInt64[4]
{
8828132445870179081L,
7159499845261548971L,
7853878048098081704L,
1833138010618067286L,
},
},
    NullableValue = 
new System.UInt64[4]
{
6481349901103496725L,
881694423524369515L,
8965985065192582685L,
6679245672039427739L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 18,
    Value = 
new System.UInt64[3]
{
6349485010539694441L,
6713265666315780482L,
8152781391410361061L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 27,
    Value = 
new System.UInt64[4]
{
2244623155308992225L,
5927808418460677937L,
5424177198906307032L,
4696548762291204183L,
},
    NullableValue = 
new System.UInt64[3]
{
6124921393517425110L,
1264633891886926036L,
527985505708030231L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4561280210088456979L,
5577659631154813062L,
9097530386976372337L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 26,
    Value = 
new System.UInt64[3]
{
501997585033598477L,
4356323822663476971L,
1772185694701524107L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 28,
    Value = 
new System.UInt64[3]
{
5270480198504399049L,
4567909036040116876L,
6104587323893768524L,
},
    NullableValue = 
new System.UInt64[3]
{
6371322163588662850L,
5637158014038985858L,
8193368742820730814L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 28,
    Value = 
new System.UInt64[3]
{
7963901588951364235L,
8018719323425431986L,
4547848344758743496L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 33,
    Value = 
new System.UInt64[4]
{
1129382715814120351L,
6650720081934264288L,
8564066276924001469L,
4829317872662855624L,
},
    NullableValue = 
new System.UInt64[4]
{
2567203075076813777L,
7775816261403418417L,
6364713721066254557L,
2854179693426722318L,
},
},
    NullableValue = 
new System.UInt64[3]
{
2348065624315876876L,
9190676182874255072L,
8540723915693772856L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 33,
    Value = 
new System.UInt64[3]
{
5526258068090241613L,
3602032417558111361L,
4438934962259427064L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 37,
    Value = 
new System.UInt64[3]
{
8125594115061762327L,
399407087287238068L,
6659550079982698444L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 38,
    Value = 
new System.UInt64[3]
{
3852614248205362552L,
6294067104377016091L,
991332102093025051L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 40,
    Value = 
new System.UInt64[3]
{
2892004818156031575L,
7805417130873853570L,
8512622490968560404L,
},
    NullableValue = 
new System.UInt64[4]
{
7907252747897434932L,
4583205529095025646L,
6791655036511202037L,
1503758738443755320L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 41,
    Value = 
new System.UInt64[3]
{
2302714550665029132L,
7374781210759060342L,
8617961546070741843L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 43,
    Value = 
new System.UInt64[4]
{
5748038405368225060L,
1830043100488027156L,
3510445194039036115L,
3120051765941293290L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 49,
    Value = 
new System.UInt64[3]
{
3185474712537460148L,
923269011782591754L,
6553126196544918857L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 52,
    Value = 
new System.UInt64[4]
{
5453470279664142010L,
6017132879350503525L,
2261764246943310856L,
853478920105159529L,
},
    NullableValue = 
new System.UInt64[4]
{
5141324146505482127L,
8317273958462334492L,
4691333925974282171L,
8580465809264702561L,
},
},
    NullableValue = 
new System.UInt64[4]
{
2659397340729687951L,
8026654028292345154L,
89680922880626331L,
8725063127608358938L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 56,
    Value = 
new System.UInt64[3]
{
3152556116010744715L,
7905409437308899314L,
613168294059613895L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 61,
    Value = 
new System.UInt64[3]
{
3005904745548480926L,
3008754297723628966L,
1754017573555149184L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 64,
    Value = 
new System.UInt64[3]
{
8378373335626364283L,
1725046537988482724L,
9016098585798909748L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 64,
    Value = 
new System.UInt64[4]
{
4882970654817026046L,
6688674824289717736L,
3212831908425844330L,
4341418894653593322L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 69,
    Value = 
new System.UInt64[3]
{
9170994285339374025L,
1031754314179332761L,
4460589064357043868L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 73,
    Value = 
new System.UInt64[3]
{
3938044286952917246L,
8768108595588487019L,
2140149248308167731L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
7001937851963498657L,
4353571244458203139L,
3796561350091052283L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 78,
    Value = 
new System.UInt64[3]
{
7956267690259235193L,
907412666479360740L,
2401438817886873252L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 81,
    Value = 
new System.UInt64[4]
{
274031715730343214L,
5386519197334751974L,
6178467451905046109L,
2038793312233735940L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
7441082733140765599L,
4155662445767378712L,
4313650593416025605L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 84,
    Value = 
new System.UInt64[4]
{
8468416761630277783L,
2863661574623240544L,
5616571769153916522L,
3123539770163828024L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 83,
    Value = 
new System.UInt64[3]
{
8173067533523863984L,
6725917483624325824L,
6497200035326200188L,
},
    NullableValue = 
new System.UInt64[3]
{
5800255352017841448L,
5046680737105364785L,
844230769291529903L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 87,
    Value = 
new System.UInt64[3]
{
2166792638215416641L,
1404316100628038699L,
4130009598804226704L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 88,
    Value = 
new System.UInt64[4]
{
4359445860650165605L,
3760842011069989393L,
5799230033908904263L,
9015287534982816542L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 91,
    Value = 
new System.UInt64[4]
{
2972627946727432738L,
1887698292368593946L,
270530063734001129L,
3282875963766434571L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 92,
    Value = 
new System.UInt64[3]
{
3202551408744909742L,
3573563188468677456L,
6284780305483541508L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
2130769419506331274L,
513903128709631991L,
5818416491962963091L,
5054027769762289911L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 98,
    Value = 
new System.UInt64[4]
{
603141555388494387L,
2469224626602947975L,
5399060900729413479L,
1908339466434138997L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 99,
    Value = 
new System.UInt64[3]
{
365811932520849013L,
9211256273616587096L,
3739010817062535911L,
},
    NullableValue = 
new System.UInt64[4]
{
2758168561782131015L,
3246066943554666836L,
8215999816028963948L,
6602483386948812420L,
},
},
    NullableValue = 
new System.UInt64[4]
{
6336802117720414188L,
2183319977769126961L,
8042587774987436785L,
7183379950901313415L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 99,
    Value = 
new System.UInt64[3]
{
7816655408089698595L,
3537560463898003174L,
4955244396255243063L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 108,
    Value = 
new System.UInt64[4]
{
6315112082189168894L,
3030057176658995859L,
370849814418163789L,
3409498057722142895L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 108,
    Value = 
new System.UInt64[4]
{
2759831640136725992L,
5898213654298257859L,
4598560809577075509L,
5986127002682556247L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 113,
    Value = 
new System.UInt64[3]
{
2796782346639326831L,
6045178910585506426L,
6598147721994165606L,
},
    NullableValue = 
new System.UInt64[4]
{
6970891213031542041L,
242471940839242931L,
290745584644769535L,
7664083367867861310L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 111,
    Value = 
new System.UInt64[3]
{
8829334646305158008L,
418867148143514457L,
4219242075283266888L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 119,
    Value = 
new System.UInt64[4]
{
8459935829400434846L,
555612735140959397L,
2716841588081658535L,
1017745988721392797L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 113,
    Value = 
new System.UInt64[3]
{
782145011337181896L,
542561746448809246L,
1535031015807674303L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 121,
    Value = 
new System.UInt64[4]
{
7658356711729236879L,
1206867597672798849L,
6379051920189212399L,
5308995781041724358L,
},
    NullableValue = 
new System.UInt64[3]
{
964117822161124843L,
6050325131085446568L,
3792824227845607755L,
},
},
    NullableValue = 
new System.UInt64[4]
{
36619807097985574L,
8303856701722379149L,
5406746372695277482L,
754185885511028870L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 115,
    Value = 
new System.UInt64[3]
{
8902720272954817685L,
3900472688688779737L,
2302578256342089074L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 125,
    Value = 
new System.UInt64[3]
{
8452392412632288724L,
7857934906346722831L,
234008997247199668L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 119,
    Value = 
new System.UInt64[4]
{
2503247018152022168L,
6202303981793656558L,
554521372586973339L,
2836508153969014205L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 131,
    Value = 
new System.UInt64[4]
{
5903199859050003330L,
2855880439553629873L,
5675467460658818546L,
1091168401235194691L,
},
    NullableValue = 
new System.UInt64[4]
{
490188747591368588L,
3962820467828275343L,
8540485319441076825L,
8764699068254397244L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 124,
    Value = 
new System.UInt64[4]
{
537712467399833608L,
4106396557515191373L,
1214021806592303458L,
1513559582307474444L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 134,
    Value = 
new System.UInt64[3]
{
5165394259186719861L,
5013613596724436464L,
5243821925312353250L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
7629786439273205330L,
2248447351968228230L,
2274725590547951631L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 125,
    Value = 
new System.UInt64[4]
{
3420505808230562620L,
8993472600878120198L,
8234979975148657246L,
5752767994221875915L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 135,
    Value = 
new System.UInt64[3]
{
2348158513162223784L,
7399914977040071822L,
2834317698020545665L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 132,
    Value = 
new System.UInt64[3]
{
607591521343510708L,
48710262095919898L,
931824889877767070L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 140,
    Value = 
new System.UInt64[3]
{
8266032088058527089L,
556274510436890124L,
3239113586473161759L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
1123174590261793503L,
6491166373745518137L,
445600195781782153L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 140,
    Value = 
new System.UInt64[4]
{
1725668634387166931L,
7554616933911287638L,
8370516868175282310L,
4875139683414789045L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 144,
    Value = 
new System.UInt64[3]
{
5392946264938077858L,
10726771710506179L,
1830791484308461237L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
6580040423131108451L,
6069934727403607628L,
1715802492795845079L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 147,
    Value = 
new System.UInt64[3]
{
3213079698792212927L,
1763250042068309373L,
275747122754139916L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 153,
    Value = 
new System.UInt64[3]
{
8993264171182628521L,
1247900391474246562L,
5749866264245387771L,
},
    NullableValue = 
new System.UInt64[4]
{
8453719396145980073L,
3202956350228654465L,
1060607280397098119L,
8637066867536913356L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 154,
    Value = 
new System.UInt64[3]
{
6581387138978178861L,
4576945093521171134L,
3168055277357010107L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 157,
    Value = 
new System.UInt64[4]
{
65090839404944707L,
6485371372413848699L,
7370606059034409935L,
3454298259780343306L,
},
    NullableValue = 
new System.UInt64[4]
{
7542371370462419600L,
1144527988037922110L,
2816702294548596298L,
8315068060426535757L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 161,
    Value = 
new System.UInt64[3]
{
4303461138054388378L,
548524337428211841L,
6163672324638880583L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 162,
    Value = 
new System.UInt64[4]
{
7937245294827496959L,
597762598358272446L,
3252748140513215600L,
2845457894702967556L,
},
    NullableValue = 
new System.UInt64[3]
{
2143677631083051881L,
806313563817332787L,
8239369717627649062L,
},
},
    NullableValue = 
new System.UInt64[4]
{
3379306242678197138L,
1276021727773404284L,
772830082133765351L,
2839501568462223911L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 167,
    Value = 
new System.UInt64[3]
{
3744284248326901493L,
2135078293651038904L,
3340778912739266311L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 166,
    Value = 
new System.UInt64[4]
{
6638169842505847936L,
925139088927292958L,
4850823710334881142L,
4238310785500278361L,
},
    NullableValue = 
new System.UInt64[4]
{
2417551934690810105L,
7180147291402122950L,
3150806233963472180L,
903263133051074196L,
},
},
    NullableValue = 
new System.UInt64[3]
{
1094120672112162556L,
5057681449938097458L,
1877906342452680426L,
},
},
            new UInt64ArrayUInt641M
{
    Id = 176,
    Value = 
new System.UInt64[4]
{
5039965755489253891L,
2354677805133849702L,
4665915193345336023L,
721917214678480311L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 173,
    Value = 
new System.UInt64[3]
{
6542848381242523712L,
8007906321068784301L,
8653239516523944746L,
},
    NullableValue = 
new System.UInt64[3]
{
3159069795606700732L,
9184913803031249522L,
2417011631691982383L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt641M
{
    Id = 179,
    Value = 
new System.UInt64[4]
{
2019499530021152252L,
2081090327960911826L,
5503248371572856443L,
1603876011063164118L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 176,
    Value = 
new System.UInt64[4]
{
5661159380920821455L,
1627809623351646429L,
568794162773808592L,
7433652041868568935L,
},
    NullableValue = 
new System.UInt64[3]
{
9219027194511330477L,
5089614890115558801L,
6522196874645026791L,
},
},
    NullableValue = 
new System.UInt64[4]
{
5768550388231599506L,
7578275483266963704L,
53119033010874392L,
3007052853902415910L,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64arrayuint641m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt64)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64ArrayArrayUInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
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
                    await ((IUInt64ArrayArrayUInt64)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64ArrayArrayUInt64)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64arrayuint641m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64ArrayUInt641M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64ArrayArrayUInt64)),
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
                    var models = await ((IUInt64ArrayArrayUInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64ArrayUInt641M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64ArrayArrayUInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64ArrayUInt641M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

