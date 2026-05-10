

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
    internal partial interface IUInt64ArrayUInt64Array
    {
    }
    
    internal partial class UInt64ArrayUInt64Array : IUInt64ArrayUInt64Array
    {


#region TestData

        private readonly UInt64UInt64Array1M[] _testData = new UInt64UInt64Array1M[]
        {
            new UInt64UInt64Array1M
{
    Id = 1,
    Value = 
new System.UInt64[4]
{
5657505858304090056L,
8204789929347945863L,
6636540774631682523L,
5198044814964353534L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 7,
    Value = 
new System.UInt64[3]
{
1249685288041798862L,
7146766112131559755L,
8614562278807090103L,
},
    NullableValue = 
new System.UInt64[3]
{
1270424696837847982L,
4272895079941122936L,
4433797706157423656L,
},
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 2,
    Value = 
new System.UInt64[3]
{
7314133413305999415L,
1643317454167256613L,
5066157092262963278L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 12,
    Value = 
new System.UInt64[3]
{
6637356655822356102L,
2253275556900384126L,
8006939475234524322L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
3336389685458647986L,
6009360649899078299L,
2923716344525596650L,
391173871885288937L,
},
},
            new UInt64UInt64Array1M
{
    Id = 4,
    Value = 
new System.UInt64[3]
{
7741016740910033259L,
3106194263856665424L,
5873175758026767340L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 16,
    Value = 
new System.UInt64[4]
{
8536565772517916687L,
3573535244457236158L,
5361736536640749224L,
6554073692861565752L,
},
    NullableValue = 
new System.UInt64[4]
{
2672278490350791332L,
4606512722913008660L,
2759065667649759357L,
1629267804614457110L,
},
},
    NullableValue = 
new System.UInt64[3]
{
8024000525627030941L,
7572077419454833678L,
8201702667791042817L,
},
},
            new UInt64UInt64Array1M
{
    Id = 9,
    Value = 
new System.UInt64[4]
{
5428613348966153741L,
8571011560243594841L,
7909871268734818529L,
9090783942705396008L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 19,
    Value = 
new System.UInt64[3]
{
7065767686441463470L,
567471404767075173L,
8025468102762913559L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
7586399173766393303L,
1998984289788056061L,
7078366606302437469L,
1126114504942607640L,
},
},
            new UInt64UInt64Array1M
{
    Id = 16,
    Value = 
new System.UInt64[4]
{
4799802694225429701L,
5215520990430491120L,
2086030264975100219L,
2120275779665846125L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 28,
    Value = 
new System.UInt64[3]
{
3302220911821947117L,
1854798966696900082L,
1015627602423112281L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
6967970726119498130L,
1835150126721316694L,
5131916288573256740L,
},
},
            new UInt64UInt64Array1M
{
    Id = 25,
    Value = 
new System.UInt64[3]
{
6785835338430594076L,
2694014909411531574L,
4581546781705069832L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 37,
    Value = 
new System.UInt64[4]
{
8948858737356022463L,
2153999982541063143L,
3330642660771283888L,
4634859218289807708L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
6287460676363658579L,
1585497304466851064L,
4365709578487563899L,
5772459012723621190L,
},
},
            new UInt64UInt64Array1M
{
    Id = 33,
    Value = 
new System.UInt64[3]
{
4323677416993685127L,
6354663160364038217L,
2063475126544740709L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 45,
    Value = 
new System.UInt64[3]
{
7776052818822493247L,
4706771523817321682L,
5492342560105357469L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
5567114046856638436L,
1238059891173422305L,
3424746610917337325L,
2442520900247690535L,
},
},
            new UInt64UInt64Array1M
{
    Id = 42,
    Value = 
new System.UInt64[3]
{
278207003775452182L,
2011651860498748691L,
2341589754325262994L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 52,
    Value = 
new System.UInt64[4]
{
206252692485818130L,
1477215518074077568L,
390674918991267249L,
6111173571022808056L,
},
    NullableValue = 
new System.UInt64[3]
{
4150052436304740415L,
5609659493486628868L,
4039250340743937794L,
},
},
    NullableValue = 
new System.UInt64[4]
{
1819237796226409476L,
2154854690189546136L,
3828626514584580977L,
9183887134256156271L,
},
},
            new UInt64UInt64Array1M
{
    Id = 50,
    Value = 
new System.UInt64[3]
{
9169588318115874547L,
4897370848885071856L,
5895676537486069724L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 57,
    Value = 
new System.UInt64[3]
{
969948762654157431L,
6667087250659884981L,
4613080896144139889L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 59,
    Value = 
new System.UInt64[3]
{
5119096382714235549L,
3465388498090104791L,
18354843595912835L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 65,
    Value = 
new System.UInt64[3]
{
2785396164113909581L,
2033190380108040606L,
4374793070073182601L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
5943878173308845171L,
5963017611990642269L,
2235571353159190726L,
},
},
            new UInt64UInt64Array1M
{
    Id = 64,
    Value = 
new System.UInt64[3]
{
5779829721549295379L,
3255187103936882611L,
7354355339629935049L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 70,
    Value = 
new System.UInt64[4]
{
1669846275417848477L,
1600709911492479337L,
7861790231136673199L,
8376600033839389113L,
},
    NullableValue = 
new System.UInt64[3]
{
4073021507197232397L,
3487852385423554624L,
2482570579074545995L,
},
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 70,
    Value = 
new System.UInt64[4]
{
7583052916193255323L,
72331004791115435L,
5293066087765880505L,
4464480695638274475L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 79,
    Value = 
new System.UInt64[4]
{
7369025514730780812L,
1155400961733560595L,
3239080481438142201L,
8945361017723216153L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3003811511593626626L,
6772090391291768958L,
6642838879341343052L,
},
},
            new UInt64UInt64Array1M
{
    Id = 78,
    Value = 
new System.UInt64[4]
{
8553154262657460432L,
4865840070272702633L,
6172711909984932417L,
2106601009135848997L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 84,
    Value = 
new System.UInt64[3]
{
5272295558706235128L,
4635531986191549371L,
7232219715226878945L,
},
    NullableValue = 
new System.UInt64[3]
{
3055144290508110626L,
499315023918683983L,
4977222780012955916L,
},
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 86,
    Value = 
new System.UInt64[3]
{
474019569272831549L,
1195803239082523094L,
240098067555626463L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 92,
    Value = 
new System.UInt64[3]
{
5250615668150129893L,
1784524552210212050L,
3007998008663120288L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
7996069165387140584L,
811598526790665606L,
3613748036238962149L,
},
},
            new UInt64UInt64Array1M
{
    Id = 87,
    Value = 
new System.UInt64[3]
{
6417125170719577400L,
3967746833534800117L,
3983845246133038609L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 97,
    Value = 
new System.UInt64[3]
{
2146620017127174798L,
7117824260491378133L,
746784296132321204L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 94,
    Value = 
new System.UInt64[3]
{
508112603895661108L,
7190398201812380548L,
2607328501526549319L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 103,
    Value = 
new System.UInt64[3]
{
2824960024079607026L,
6462588354603712689L,
7865931823160887893L,
},
    NullableValue = 
new System.UInt64[3]
{
1585604026287463160L,
5140879454428954582L,
2940170764682448397L,
},
},
    NullableValue = 
new System.UInt64[4]
{
8864855700651717317L,
1281317678302915085L,
6833237799832496683L,
3191364079962437219L,
},
},
            new UInt64UInt64Array1M
{
    Id = 97,
    Value = 
new System.UInt64[3]
{
5527240595030602093L,
7234550310206602449L,
1254948675509970659L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 104,
    Value = 
new System.UInt64[3]
{
8124890916692918771L,
4389551182997033140L,
3174175572157465139L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 99,
    Value = 
new System.UInt64[4]
{
2399902935385732621L,
4306672289601742279L,
53019027843199068L,
926680436667923996L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 111,
    Value = 
new System.UInt64[3]
{
2762144454691346141L,
2986216350086277971L,
6380908666589292072L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 100,
    Value = 
new System.UInt64[3]
{
5006196345037182298L,
2610871920297369682L,
2818114680171727676L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 115,
    Value = 
new System.UInt64[3]
{
5029349789064338451L,
2461940166575479574L,
7357364799016988849L,
},
    NullableValue = 
new System.UInt64[4]
{
5869836598656485067L,
2269851081559942576L,
8580183278743026844L,
1175917587280890331L,
},
},
    NullableValue = 
new System.UInt64[3]
{
8374222524674583682L,
3115931446487399582L,
1516496205031573721L,
},
},
            new UInt64UInt64Array1M
{
    Id = 101,
    Value = 
new System.UInt64[3]
{
1659747767572091520L,
495529380118155562L,
1934979341005564195L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 123,
    Value = 
new System.UInt64[4]
{
8785546043069586288L,
3985302197814234021L,
5301951052141140829L,
5751141990889239484L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 109,
    Value = 
new System.UInt64[3]
{
5622918068181751662L,
3921139743623159240L,
4821847562453787122L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 125,
    Value = 
new System.UInt64[4]
{
3721055820207878999L,
3494219241902354044L,
4321058480069150624L,
7202334657864618177L,
},
    NullableValue = 
new System.UInt64[3]
{
449346304653279688L,
3509503556423032836L,
8986210497111235676L,
},
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 112,
    Value = 
new System.UInt64[4]
{
7067464397989639289L,
932612075980657741L,
7681647927244759601L,
1700562682358489459L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 132,
    Value = 
new System.UInt64[3]
{
762208440463238353L,
4676934506464028396L,
7576794976811045012L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 120,
    Value = 
new System.UInt64[3]
{
7253643578585856912L,
1981812718635378533L,
7750843427770505073L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 138,
    Value = 
new System.UInt64[3]
{
2235426545067745482L,
6440455839576974299L,
6691083090410660962L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 121,
    Value = 
new System.UInt64[4]
{
2261036071343767931L,
8153208987171358335L,
6759175902509665539L,
587799973513815652L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 141,
    Value = 
new System.UInt64[4]
{
3847498883188932621L,
1807249428728672065L,
2716446020567336916L,
7650794718655508529L,
},
    NullableValue = 
new System.UInt64[4]
{
1651711744625032959L,
2209588350839886487L,
2022455827267734032L,
946012318656467933L,
},
},
    NullableValue = 
new System.UInt64[4]
{
1266157096163113319L,
1309747789007457923L,
1622111061430192550L,
6392334940586085413L,
},
},
            new UInt64UInt64Array1M
{
    Id = 127,
    Value = 
new System.UInt64[4]
{
2512186808975220115L,
6137805472015332670L,
7199836908840635368L,
6728626350609090030L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 142,
    Value = 
new System.UInt64[3]
{
3303976079538430931L,
6058821148634114334L,
1187756576378307394L,
},
    NullableValue = 
new System.UInt64[4]
{
8047807381621653656L,
6323574908736116575L,
1381490695700589052L,
5628450475115354222L,
},
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 130,
    Value = 
new System.UInt64[3]
{
6709157134824828786L,
7769834132103489615L,
1949993984761602283L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 148,
    Value = 
new System.UInt64[3]
{
5920918199335825281L,
8779911455414454939L,
5081001903299323038L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 133,
    Value = 
new System.UInt64[4]
{
3509129901811478663L,
8781488422155678581L,
2838892610660986722L,
3232906304348743474L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 153,
    Value = 
new System.UInt64[4]
{
7067617961305211529L,
236123828922068517L,
5619088189675885032L,
34309198252229891L,
},
    NullableValue = 
new System.UInt64[4]
{
7896407195174326287L,
7035233052689274738L,
3207731231725444291L,
5765403716775272124L,
},
},
    NullableValue = 
new System.UInt64[3]
{
289486976434417969L,
80950749209424313L,
4422413127140553866L,
},
},
            new UInt64UInt64Array1M
{
    Id = 142,
    Value = 
new System.UInt64[4]
{
6470108935018938097L,
511291893695609464L,
4652291346658291997L,
5752997413247259944L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 157,
    Value = 
new System.UInt64[3]
{
7855774047986196378L,
2085504441429293484L,
8726295248236866710L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
1247425429106593381L,
7681170763842661022L,
6782053201299036726L,
},
},
            new UInt64UInt64Array1M
{
    Id = 148,
    Value = 
new System.UInt64[3]
{
1622715763692646843L,
8084105797448133452L,
4850832482816815437L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 165,
    Value = 
new System.UInt64[3]
{
1882865328915282226L,
6351731551011397456L,
5071308347355169436L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
2915296876233171913L,
535931087292783853L,
3767510595947265285L,
},
},
            new UInt64UInt64Array1M
{
    Id = 156,
    Value = 
new System.UInt64[4]
{
3097656495040391994L,
2438463288140336391L,
5467998448402642369L,
5612272789056415933L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 166,
    Value = 
new System.UInt64[4]
{
6177226797912326181L,
5061484673249125138L,
6611953085371490424L,
4984233921331015135L,
},
    NullableValue = 
new System.UInt64[3]
{
5761822627871303218L,
519683336492573913L,
3827863419455623146L,
},
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 157,
    Value = 
new System.UInt64[3]
{
4538975858761178908L,
5983513866324308153L,
2262247977210702744L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 167,
    Value = 
new System.UInt64[3]
{
6692529151563304897L,
697700991571875541L,
8094883831034272724L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3118139783224755604L,
5526076118982003240L,
6923649631520014733L,
},
},
            new UInt64UInt64Array1M
{
    Id = 166,
    Value = 
new System.UInt64[4]
{
8977484433020129534L,
8340537432806161495L,
7887498722833465191L,
5999829564546681402L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 173,
    Value = 
new System.UInt64[3]
{
7157495836729516069L,
8625633694592941542L,
8817053290857299661L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
6763276121817743411L,
3607865810248237085L,
3260053892714496695L,
3962458585698312744L,
},
},
            new UInt64UInt64Array1M
{
    Id = 175,
    Value = 
new System.UInt64[4]
{
6763317209203566119L,
1351048118810015468L,
8465830220458338531L,
7103190373050435209L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 174,
    Value = 
new System.UInt64[3]
{
7822501019979588206L,
4519980409937063055L,
3752883726175494463L,
},
    NullableValue = 
new System.UInt64[3]
{
7785271118617475529L,
2120721718829005896L,
6847377486454739307L,
},
},
    NullableValue = null,
},
            new UInt64UInt64Array1M
{
    Id = 183,
    Value = 
new System.UInt64[3]
{
3313446903784557109L,
4697707413751370956L,
5769804351516091317L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 177,
    Value = 
new System.UInt64[4]
{
2704565362024261813L,
7517071438518959619L,
2010542356792780819L,
1049319320269091751L,
},
    NullableValue = 
new System.UInt64[4]
{
9194647984107311845L,
4148225250247157711L,
8932039002091671419L,
4094281184568995869L,
},
},
    NullableValue = 
new System.UInt64[4]
{
9134913009774673217L,
8507893588979867553L,
157454049343487073L,
1938881979199096181L,
},
},
            new UInt64UInt64Array1M
{
    Id = 190,
    Value = 
new System.UInt64[4]
{
7392272135239978915L,
7614812485143544658L,
4938850301446169903L,
8529313698239865046L,
},
    ModelInner = new UInt64UInt64Array1MI
{
    Id = 179,
    Value = 
new System.UInt64[4]
{
7791085472873664294L,
439302233746929376L,
9149822344894200433L,
5452006925179876731L,
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
INSERT INTO gedaqtests.uint64uint64array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt64[]}, 
    {mi_id:Int32},
    {mi_value:UInt64[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64ArrayUInt64Array)),
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
                    await ((IUInt64ArrayUInt64Array)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64ArrayUInt64Array)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64uint64array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64UInt64Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64ArrayUInt64Array)),
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
                    var models = await ((IUInt64ArrayUInt64Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64UInt64Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64ArrayUInt64Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64UInt64Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

