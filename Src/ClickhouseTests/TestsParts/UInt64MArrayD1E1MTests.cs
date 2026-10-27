

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
    internal partial interface IUInt64MArrayMArrayD1
    {
    }
    
    internal partial class UInt64MArrayMArrayD1 : IUInt64MArrayMArrayD1
    {


#region TestData

        private readonly UInt64MArrayD1E1M[] _testData = new UInt64MArrayD1E1M[]
        {
            new UInt64MArrayD1E1M
{
    Id = 1,
    Value = 
new System.UInt64[4]
{
7870144851733451042L,
6450673880352726177L,
527717969312823679L,
6226316178848610447L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.UInt64[4]
{
6250501521726705093L,
1100917084836892022L,
5112016192905597588L,
196482454781385122L,
},
    NullableValue = 
new System.UInt64[3]
{
2251015031600317872L,
5674274180006222176L,
3762609684014676582L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 8,
    Value = 
new System.UInt64[4]
{
4561442483170892770L,
3080372394344125140L,
5618594786748262648L,
5038567330209720873L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.UInt64[4]
{
2061991489792245697L,
2035739294585643979L,
7447266106015285252L,
5279585224778717257L,
},
    NullableValue = 
new System.UInt64[3]
{
4392738137029400345L,
390339119985452379L,
3908547910142618874L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 13,
    Value = 
new System.UInt64[3]
{
8097308581898920725L,
577296602276753277L,
1811231074979440900L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.UInt64[3]
{
289230181862456124L,
7500131557820517164L,
5814146154001656634L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 14,
    Value = 
new System.UInt64[3]
{
6249399287723309658L,
8209138636683946371L,
133454376027164130L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.UInt64[3]
{
1286703183929531260L,
6236939097979984238L,
5226592969316667792L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
1024057692934312856L,
4540361972837962910L,
5415325046191072484L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 20,
    Value = 
new System.UInt64[4]
{
4151264785165123696L,
5443874042447856589L,
5961165868325913881L,
6894293113942296090L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.UInt64[4]
{
5433838805570017611L,
8397315348176608850L,
7547100705860768406L,
2907444105385407481L,
},
    NullableValue = 
new System.UInt64[3]
{
2716237283954088253L,
2849763274981765672L,
7911890140072593297L,
},
},
    NullableValue = 
new System.UInt64[4]
{
8155545134968502087L,
7840814360934288433L,
5151513089337211268L,
6189284221619258529L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 24,
    Value = 
new System.UInt64[4]
{
4428020234246406200L,
2855275890351624203L,
2211935552670520681L,
3384394578714539162L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.UInt64[4]
{
8326093553902471800L,
5557709438717429014L,
1240094673720093845L,
2876757159015273264L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
6523107256190769214L,
2186854722524706299L,
7504085446741202233L,
1585391531869991294L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 25,
    Value = 
new System.UInt64[3]
{
1115153802709603286L,
938854881131683139L,
4044172344351311365L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 43,
    Value = 
new System.UInt64[4]
{
3527050520379974569L,
8094003235428894830L,
4647174570479289903L,
5959489372100925978L,
},
    NullableValue = 
new System.UInt64[3]
{
4801443762208656061L,
7724682925134928026L,
62358006336490495L,
},
},
    NullableValue = 
new System.UInt64[3]
{
7355819184837912731L,
3909574837840889910L,
2879378060219666635L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 30,
    Value = 
new System.UInt64[3]
{
1554350624202390843L,
8723968082913128691L,
2343728279327872145L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.UInt64[4]
{
2001768515640982556L,
6292070952373465165L,
5204238063566319649L,
3381587616586039643L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
8203765486990186994L,
2708163306123360720L,
3729721096387632773L,
7770733559551355396L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 36,
    Value = 
new System.UInt64[3]
{
3854312352355180307L,
7679270987612484889L,
6100153411732178272L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.UInt64[4]
{
1646176351388465017L,
2479891423055219803L,
6027418821391618803L,
2115820786738474354L,
},
    NullableValue = 
new System.UInt64[4]
{
4295320699799395742L,
7522077874563619964L,
4544447775762039023L,
727640157883907707L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 41,
    Value = 
new System.UInt64[4]
{
6189037322028822531L,
730024963351903317L,
1068459437557401017L,
757881507132825208L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt64[4]
{
1502456291554849901L,
5933914763219128771L,
4803077316395294656L,
5180970132531112171L,
},
    NullableValue = 
new System.UInt64[3]
{
6660056457514646930L,
2683860819373892880L,
6230777437321295535L,
},
},
    NullableValue = 
new System.UInt64[3]
{
6092932842726501252L,
7831793443422634220L,
9120741501558497476L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 43,
    Value = 
new System.UInt64[3]
{
3601063599753738665L,
4731989309579820714L,
7100289556231396526L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 56,
    Value = 
new System.UInt64[3]
{
4824311252633026212L,
3716523056828276737L,
160848202521498088L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 50,
    Value = 
new System.UInt64[3]
{
5188333172865102925L,
1693306693533700608L,
6776465886535119478L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 59,
    Value = 
new System.UInt64[3]
{
7953428789422510891L,
8831130796177745987L,
3896153402758070416L,
},
    NullableValue = 
new System.UInt64[4]
{
2688799393588602922L,
357456097740850561L,
7536654268590933997L,
7521203776239272142L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 54,
    Value = 
new System.UInt64[3]
{
4497151102673640389L,
6699561605537823183L,
4658528367318094917L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.UInt64[4]
{
6146974515327551765L,
7052527478333056723L,
1082639731370403586L,
5077440483077009385L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
9221732285897471996L,
419579772462479041L,
283932438464742716L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 57,
    Value = 
new System.UInt64[4]
{
1392912811107807224L,
3578079729486094691L,
6563967525414695684L,
6776557939653319587L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 72,
    Value = 
new System.UInt64[3]
{
7086608293113668800L,
8580155860473322771L,
5240030183071502533L,
},
    NullableValue = 
new System.UInt64[4]
{
3563168976527118365L,
64896420331192720L,
3629401804129310769L,
5682602127855936704L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4596215076583330700L,
2841124141145914016L,
3697568528305842398L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 58,
    Value = 
new System.UInt64[3]
{
3244621890225710180L,
8571621323182270564L,
4526886035920370101L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.UInt64[3]
{
3228535856008220489L,
4016826591101451680L,
265964508740148612L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
8969979373193985275L,
2573717496596490617L,
8676959419742865497L,
4511864819152803689L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 65,
    Value = 
new System.UInt64[4]
{
2686033602183144810L,
4398149956228698754L,
8554994039601162812L,
6889424564943660582L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.UInt64[4]
{
4308763482261334067L,
3667424141722737948L,
4414431052056860827L,
6684710548404061693L,
},
    NullableValue = 
new System.UInt64[3]
{
2260967318594349516L,
6935679973596502181L,
600538312455859157L,
},
},
    NullableValue = 
new System.UInt64[4]
{
2713701827765661147L,
250225093664229260L,
8958009074699513381L,
5963258468768012080L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 73,
    Value = 
new System.UInt64[4]
{
4362530801676679068L,
6359770202301571399L,
1951979398675798834L,
3694906389758853188L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.UInt64[4]
{
8388465804254306519L,
6155886357859704767L,
8061132441070635096L,
5633763857918839489L,
},
    NullableValue = 
new System.UInt64[3]
{
5732475730997467408L,
6328810869782555915L,
3898258352139456102L,
},
},
    NullableValue = 
new System.UInt64[4]
{
4414665500871756222L,
4471470217456658153L,
8733098373354971215L,
7775353357008964943L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 78,
    Value = 
new System.UInt64[3]
{
2389066966245525804L,
7083949499615056673L,
5037126962640860539L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.UInt64[3]
{
2518901560974939346L,
2236041441709932777L,
495955165175323670L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
8766733852844971814L,
7364061959119941379L,
937982470814931407L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 81,
    Value = 
new System.UInt64[4]
{
4877876394865549543L,
7993593098912950476L,
237209076910985702L,
6308364023668270683L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.UInt64[4]
{
7461196492948880227L,
6775789620390278577L,
6459696134656263198L,
6245009240638925798L,
},
    NullableValue = 
new System.UInt64[3]
{
442376260005348146L,
14817614734763738L,
3488977733805781570L,
},
},
    NullableValue = 
new System.UInt64[4]
{
1979467456249542261L,
4047414922618374129L,
4070905178404435198L,
7272734062313675052L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 83,
    Value = 
new System.UInt64[3]
{
7391447160400809159L,
7615289469927883510L,
4135453707373439969L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 94,
    Value = 
new System.UInt64[3]
{
919184951384769612L,
8363481345990025174L,
6205404923695738959L,
},
    NullableValue = 
new System.UInt64[4]
{
8845033845314269361L,
8781549911594171152L,
1005045695256775273L,
8740687431633969510L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 88,
    Value = 
new System.UInt64[3]
{
8446946848399913444L,
9029756302866312278L,
1503300886895892252L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 97,
    Value = 
new System.UInt64[3]
{
8685234655410087393L,
5149891617459533488L,
3770527360399234786L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
587036690158168734L,
3260839273589784107L,
3222996852562953833L,
7126494025523215179L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 91,
    Value = 
new System.UInt64[3]
{
5375537826129862521L,
8767999097646447534L,
5656425102403505433L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.UInt64[3]
{
4385887741838511522L,
8752198124012334050L,
2260692996834542342L,
},
    NullableValue = 
new System.UInt64[3]
{
8319552899155880233L,
8088745374509633568L,
6837755111322409405L,
},
},
    NullableValue = 
new System.UInt64[4]
{
7531475300085265184L,
6423116120505135906L,
7279110973599113628L,
4295971372764645317L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 93,
    Value = 
new System.UInt64[3]
{
16817924911718570L,
5313740322238206L,
8530637100229440395L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.UInt64[4]
{
8753717794398513738L,
1734553379024582931L,
4868145326633021336L,
6656387811637188711L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 97,
    Value = 
new System.UInt64[3]
{
702474877246320057L,
3680339978668604976L,
2648955572658369836L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.UInt64[4]
{
5692881174396693133L,
5267792171243439735L,
3648935202619256306L,
394954392073782021L,
},
    NullableValue = 
new System.UInt64[3]
{
5702943288758896620L,
8638542922547409397L,
2196096458524585670L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 105,
    Value = 
new System.UInt64[3]
{
4304140937865034642L,
7495577208536886311L,
5472291012966499067L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.UInt64[4]
{
2708394867264381765L,
710594319987802872L,
1193702804027622055L,
5275297990598930430L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 113,
    Value = 
new System.UInt64[4]
{
4960283003160479518L,
4439423386335236203L,
5530171713784513233L,
8552507017644095931L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.UInt64[4]
{
4208501844198662993L,
6434505409152872355L,
7930539097450276410L,
4004540125214529575L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 120,
    Value = 
new System.UInt64[4]
{
2222254419675762940L,
7423156936596254353L,
2360559615449820051L,
2323757994590328619L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.UInt64[4]
{
9218529293708936535L,
3845542278261952166L,
1586552479961507279L,
4241340626553806594L,
},
    NullableValue = 
new System.UInt64[4]
{
2619011770547671739L,
4546578638160029001L,
4185345079317853690L,
112813428012725737L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 123,
    Value = 
new System.UInt64[3]
{
751399035959271914L,
1186589178253722557L,
4738613576197018220L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 137,
    Value = 
new System.UInt64[4]
{
4402846629502951183L,
2515571370049876143L,
8697154907952553884L,
6343700351701182726L,
},
    NullableValue = 
new System.UInt64[3]
{
4183363126981494318L,
7946508199338189074L,
3991503479426694041L,
},
},
    NullableValue = 
new System.UInt64[4]
{
7013069269586555442L,
8777879704269158856L,
2550938237377108898L,
8249095031703358861L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 128,
    Value = 
new System.UInt64[4]
{
8701158661790898118L,
2432308774901656769L,
364748774791913375L,
4575487959553818623L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 146,
    Value = 
new System.UInt64[4]
{
3579542033112507949L,
3014913508807091668L,
7192601942031278454L,
1759344608071250674L,
},
    NullableValue = 
new System.UInt64[3]
{
8360282050157055322L,
1927633302190916218L,
8922059418168425093L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 132,
    Value = 
new System.UInt64[4]
{
6378237533502894258L,
878198558941187021L,
1016597586964640807L,
933111956417665618L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.UInt64[3]
{
949917195127810527L,
7937439384451110427L,
6921371914847678124L,
},
    NullableValue = 
new System.UInt64[4]
{
2033262179968334176L,
7381164724889475596L,
2864737450050289880L,
1248262323283764660L,
},
},
    NullableValue = 
new System.UInt64[4]
{
5160225290524403943L,
511512952254547356L,
8907900513981400843L,
6419818767130339102L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 137,
    Value = 
new System.UInt64[3]
{
990261337382339201L,
7738485698800046812L,
2479179904591908638L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 152,
    Value = 
new System.UInt64[3]
{
1020456424426350024L,
981997472004360277L,
2261148506795826742L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
6486695506024487068L,
637463135921500682L,
7521068821760113220L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 140,
    Value = 
new System.UInt64[3]
{
8424869562032318474L,
4409912045711675914L,
6411500595934693565L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 160,
    Value = 
new System.UInt64[4]
{
7982320443098965121L,
9078525881913030522L,
8217153471558072458L,
3457966099219254086L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 149,
    Value = 
new System.UInt64[4]
{
7937469127012757113L,
5928009831416039370L,
7285899571034907268L,
8195920461274134741L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.UInt64[3]
{
6725364969265392361L,
1424966052957179109L,
5751454678756339315L,
},
    NullableValue = 
new System.UInt64[3]
{
1780713340547491765L,
8032270776947203554L,
9079208247291495951L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4963468509975902831L,
5719338155294380856L,
2207162367729088019L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 158,
    Value = 
new System.UInt64[4]
{
6426420433320623788L,
906251061691982023L,
7116352136722674634L,
4301265503092840282L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 175,
    Value = 
new System.UInt64[3]
{
7241399777728715398L,
7252120274841210414L,
1811270092817867915L,
},
    NullableValue = 
new System.UInt64[3]
{
1396098065702970166L,
3331283984125293766L,
2875441934437039134L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 163,
    Value = 
new System.UInt64[3]
{
1813853392914006984L,
7014093029745677714L,
1976323671788516596L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 182,
    Value = 
new System.UInt64[3]
{
3212903405396267138L,
588747089999468820L,
2646962330936904093L,
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
INSERT INTO gedaqtests.uint64marrayd1e1m(
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
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
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
                    await ((IUInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
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
                    var models = await ((IUInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

