

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
    internal partial interface IInt64MArrayMArrayD2
    {
    }
    
    internal partial class Int64MArrayMArrayD2 : IInt64MArrayMArrayD2
    {


#region TestData

        private readonly Int64MArrayD2E1M[] _testData = new Int64MArrayD2E1M[]
        {
            new Int64MArrayD2E1M
{
    Id = 6,
    Value = 
new System.Int64[,] { { 1645473072872658814L, 7522884422615265577L, }, { 8566472611511344033L, 6489655348487673429L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Int64[,] { { 4123406201734291066L, 6571364436662786793L, }, { 5618934566589818990L, 1961390688464191522L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 11,
    Value = 
new System.Int64[,] { { 1103343516854970841L, 2028744776379319457L, }, { 8570358747303906628L, 7904142342264904541L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Int64[,] { { 3745411374291036067L, 948931882000754635L, }, { 4854198726063335456L, 2640390352147288215L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 13,
    Value = 
new System.Int64[,] { { 6597709482224340261L, 706250835414127455L, }, { 2272299613991739506L, 8529194521990789259L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Int64[,] { { 8850634472478254296L, 8168808559230292946L, }, { 3966262556680935358L, 6713881315770943494L, }, },
    NullableValue = 
new System.Int64[,] { { 1774070017944663513L, 520485916026128409L, }, { 532619814884456877L, 973852670495250485L, }, },
},
    NullableValue = 
new System.Int64[,] { { 3587540661141929929L, 5087441463750659440L, }, { 2092076095497074497L, 4334585202551919388L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int64[,] { { 8951745967901475544L, 957781228861603996L, }, { 8053864245103265862L, 854046783132999716L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Int64[,] { { 2034099916624627638L, 8153187893009057849L, }, { 6235713077930381269L, 288438719682826377L, }, },
    NullableValue = 
new System.Int64[,] { { 4215705580683544386L, 4972614758859619421L, }, { 5533197190212640735L, 5039869008026498965L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 23,
    Value = 
new System.Int64[,] { { 8438423738122735489L, 7123669843615622559L, }, { 4402053045509739438L, 8165425020574374260L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int64[,] { { 3766647396632384576L, 5067546139494321576L, }, { 5117982318674292533L, 6071415977550437730L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 5137116408051349970L, 8155798352671246038L, }, { 370078255002346482L, 4615910424549003312L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 31,
    Value = 
new System.Int64[,] { { 3862690380088431989L, 295606839539482740L, }, { 2424702671543190557L, 5915580284913383161L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Int64[,] { { 4584835477428345043L, 1772223806192145116L, }, { 4315737179449494882L, 527046280407047803L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2232888037596247493L, 7265574410401746976L, }, { 4508236740822875221L, 5434750063252367688L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 33,
    Value = 
new System.Int64[,] { { 2485256672998534461L, 8155717886777550201L, }, { 8497726679807462672L, 5994275559474510140L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Int64[,] { { 2625899854224976926L, 8982695422486215575L, }, { 6776358175102691394L, 8580520705456790274L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 34,
    Value = 
new System.Int64[,] { { 3117169887653646577L, 3279184747407909093L, }, { 86892539799802474L, 6028743065538642281L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Int64[,] { { 660016692197171679L, 2862338963788619597L, }, { 6815495401240335868L, 1828676896127630763L, }, },
    NullableValue = 
new System.Int64[,] { { 4418539646618590800L, 7487837247831594368L, }, { 8585856649984467237L, 6757472533147853559L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2632331909835324416L, 2172689459662698182L, }, { 7432276193560737235L, 2922282535335486117L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int64[,] { { 8027002021087996673L, 3776420998896899110L, }, { 2119749920680317968L, 5389882627838105345L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int64[,] { { 1722691017331220610L, 6961575246732601230L, }, { 6778391116252412617L, 917963237022887624L, }, },
    NullableValue = 
new System.Int64[,] { { 1044064518205960761L, 6338347086969469814L, }, { 1347030316292881740L, 6791328257272057773L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 42,
    Value = 
new System.Int64[,] { { 3913542470831817380L, 1987158897024469714L, }, { 1737691090909127665L, 1889658381164364512L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Int64[,] { { 6253981512634444196L, 7701891649899797032L, }, { 4719763681783762236L, 7433821002918803132L, }, },
    NullableValue = 
new System.Int64[,] { { 531603419501301790L, 8730259781720755926L, }, { 7886527790742811752L, 4158385106562275628L, }, },
},
    NullableValue = 
new System.Int64[,] { { 8432710432216755359L, 4517081443615832871L, }, { 2893909033142747071L, 8661309060888145008L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int64[,] { { 2957373875481446511L, 5106596796354075847L, }, { 6841622081865974953L, 7670990583962295335L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int64[,] { { 2285741573576143375L, 8140368734041792209L, }, { 1888251202823080982L, 7309055575233649218L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 50,
    Value = 
new System.Int64[,] { { 963225019277860732L, 1346649858494005700L, }, { 2057689425840073753L, 7818262159246011627L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Int64[,] { { 2022547266720942367L, 9079984246695406941L, }, { 7026711038457213728L, 7318874974681382783L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4770823430055666512L, 3894445224265256646L, }, { 1901854750819074250L, 2472503777849301655L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int64[,] { { 749599099806016111L, 4895549960763872289L, }, { 3075808500353144354L, 2481605931615256144L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Int64[,] { { 3439186299473329409L, 2265365200587327068L, }, { 1800787277603294534L, 4462634146294527895L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6970081230199901115L, 638378810536418385L, }, { 5929506874192065601L, 7533569832055019197L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 54,
    Value = 
new System.Int64[,] { { 64977870049776791L, 4308453111136184L, }, { 3149967092165113471L, 4516860300099059835L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Int64[,] { { 2774770864884299098L, 5503928429160454765L, }, { 3509983014981747791L, 2430804678217866775L, }, },
    NullableValue = 
new System.Int64[,] { { 6201572135550052763L, 69162792923538206L, }, { 970751728965687186L, 7726468498726314983L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6949678489378745512L, 8551807072090996716L, }, { 4516400281932834054L, 5579839006939642444L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 59,
    Value = 
new System.Int64[,] { { 8069211044536489836L, 2783714460063511749L, }, { 4282952563078913952L, 7441023178228996901L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Int64[,] { { 4817702611912753871L, 6148548937061038380L, }, { 3172804235706361526L, 3659605701813336304L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 61,
    Value = 
new System.Int64[,] { { 8358375442882846200L, 7303254408503247636L, }, { 1871364452311327282L, 5685923385963268530L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Int64[,] { { 3178685943649425324L, 4347322581983702537L, }, { 8676430647779372267L, 8663917622457757078L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 63,
    Value = 
new System.Int64[,] { { 615256877430139874L, 8414389511859995244L, }, { 8577717411932552839L, 3859082606815185912L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 97,
    Value = 
new System.Int64[,] { { 6474592141262949021L, 2293163784307002492L, }, { 5288925540716993569L, 2669097040517337650L, }, },
    NullableValue = 
new System.Int64[,] { { 7634907825844905044L, 7409185517867078301L, }, { 365439978131094470L, 2718859078284327014L, }, },
},
    NullableValue = 
new System.Int64[,] { { 3750618546107030582L, 7985244058643704213L, }, { 2476124601812447801L, 2393210882718673628L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 69,
    Value = 
new System.Int64[,] { { 7846176270652805715L, 7064671770866515524L, }, { 8207762452864919464L, 7907581411059326686L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Int64[,] { { 1418474445358964970L, 6946524517571873637L, }, { 8843285911177123212L, 554692448542223872L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 1675257804152749449L, 4861102927839880234L, }, { 967030745624682911L, 2595585906461523191L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int64[,] { { 3866334833102544587L, 4445463997118903310L, }, { 1344392681459756119L, 7319363810746609341L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Int64[,] { { 5130620670234338851L, 8529981508990025032L, }, { 1017342206877409431L, 2267444026636097115L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 83,
    Value = 
new System.Int64[,] { { 7703182986668966490L, 1246612934940616092L, }, { 8050532571853288505L, 8055021568596051595L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Int64[,] { { 6420000295043957001L, 3454444057667614711L, }, { 3054681991330569713L, 1962749996393527399L, }, },
    NullableValue = 
new System.Int64[,] { { 4625803336857410177L, 1100736904955639946L, }, { 5749696494137534006L, 2134048111247380365L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 84,
    Value = 
new System.Int64[,] { { 3179754412949518773L, 3139053574777568449L, }, { 4422075440204511932L, 4653825211798160314L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.Int64[,] { { 1092197097028696764L, 5735921948222685170L, }, { 4539313493499806567L, 6618194152763376106L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6894041445628520546L, 1141963009037048999L, }, { 8562841646249827445L, 590252100294497641L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 92,
    Value = 
new System.Int64[,] { { 3437883641498249207L, 5125203536025536402L, }, { 2053247026683048980L, 4884130817005006128L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Int64[,] { { 1942655432261806209L, 4558085980103495933L, }, { 1353315614494615597L, 5001736531249662636L, }, },
    NullableValue = 
new System.Int64[,] { { 6367815431056710064L, 999079464068092020L, }, { 428156445138978680L, 5426596461564591469L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 97,
    Value = 
new System.Int64[,] { { 1418368536150379575L, 976194822217501136L, }, { 7294810986454412264L, 7252473832051044656L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 127,
    Value = 
new System.Int64[,] { { 8807842704950644265L, 1666848225653514271L, }, { 747413974229199328L, 4587625073728996707L, }, },
    NullableValue = 
new System.Int64[,] { { 7668283112470091267L, 1554111590279849635L, }, { 1584314416025109429L, 188908107955542000L, }, },
},
    NullableValue = 
new System.Int64[,] { { 1296320216715250609L, 3341516424370670170L, }, { 6550416710332779767L, 4787705518892505346L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 105,
    Value = 
new System.Int64[,] { { 5925664646163086334L, 3271894862350944104L, }, { 8793654299925590741L, 4696573463083709426L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Int64[,] { { 3912570590985774156L, 714478169849305375L, }, { 2314692625749806956L, 5296224750806809225L, }, },
    NullableValue = 
new System.Int64[,] { { 1022519944730525051L, 3586287561750397572L, }, { 3387800515921786488L, 731923555967272775L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 108,
    Value = 
new System.Int64[,] { { 185377184586936828L, 5584342740411538225L, }, { 6512400322595687260L, 2942541000724315855L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Int64[,] { { 5502538431816403936L, 1550930746757586529L, }, { 4120477875036553756L, 1813096307367011297L, }, },
    NullableValue = 
new System.Int64[,] { { 8430437333997021956L, 4614708330215822268L, }, { 9022371980339220975L, 645578423630702241L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 111,
    Value = 
new System.Int64[,] { { 5032768686937443906L, 2417269712276064100L, }, { 4486235998743384391L, 813945352276800726L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Int64[,] { { 6000633252923276143L, 8557974339605535977L, }, { 9113125238026496408L, 2035822231592047404L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 7721462286757806247L, 8180208267806759288L, }, { 866101755588822570L, 7597120628531838149L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 114,
    Value = 
new System.Int64[,] { { 6754754453915252161L, 3864014308172412654L, }, { 5982127134919098414L, 9123923782000926085L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Int64[,] { { 6660407947618416704L, 1985907260101906587L, }, { 1852969002267436483L, 743613175607951231L, }, },
    NullableValue = 
new System.Int64[,] { { 7083941239567861989L, 6345391485461025224L, }, { 7903448283910104488L, 8546785061118703304L, }, },
},
    NullableValue = 
new System.Int64[,] { { 5693827546822693968L, 2019818002227093723L, }, { 6565688333039850465L, 9109231958576704442L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 117,
    Value = 
new System.Int64[,] { { 9138807615490763477L, 583687480368894798L, }, { 5805073500150770870L, 6760676126159577540L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 150,
    Value = 
new System.Int64[,] { { 6383055203568997625L, 3952557362325047524L, }, { 5759994892082521340L, 7796540240565305829L, }, },
    NullableValue = 
new System.Int64[,] { { 5551826916414328994L, 5303803810819775876L, }, { 1990230723424039360L, 1214222875257388284L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 124,
    Value = 
new System.Int64[,] { { 6603010942278262749L, 8074305528275405929L, }, { 5330784637062405649L, 8537208681421399872L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 154,
    Value = 
new System.Int64[,] { { 341329046581618572L, 1052161800878949941L, }, { 2247112893224952977L, 775257606091677958L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 132,
    Value = 
new System.Int64[,] { { 1718113966347504875L, 3439601108057098738L, }, { 2788031001089343326L, 6439540514886310933L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Int64[,] { { 1219479698044197132L, 1229834180580299912L, }, { 8288627863703400576L, 9093876852690191696L, }, },
    NullableValue = 
new System.Int64[,] { { 735210104254160760L, 565223428042877836L, }, { 8454203190025738616L, 3395738027989771886L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 137,
    Value = 
new System.Int64[,] { { 6754666260153063787L, 356597900759210471L, }, { 8779298680608123105L, 4247709954046732133L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Int64[,] { { 8609009757689097217L, 4482275471027913134L, }, { 1086711551342088823L, 2878386129949114955L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 7133856271297448491L, 6074549335739769643L, }, { 3322852772924198427L, 5534484608366731672L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 144,
    Value = 
new System.Int64[,] { { 1674466665771391535L, 3737677540326192797L, }, { 1773932148067609642L, 2788075236703809791L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Int64[,] { { 4919845492105262417L, 4668312264907339247L, }, { 45925673918064005L, 2067641531584288566L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int64[,] { { 3714857897927809479L, 6542169209413352009L, }, { 7642040218239243535L, 6279985637194865133L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Int64[,] { { 1774623715826231264L, 8269436525983792905L, }, { 8648938831309478501L, 8129175037863255941L, }, },
    NullableValue = 
new System.Int64[,] { { 7406581217118632008L, 4746489431781204561L, }, { 2451876664010112343L, 3320216749241914423L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 148,
    Value = 
new System.Int64[,] { { 7007526570384040393L, 6557400062799901603L, }, { 5464139467528211864L, 9056557111833205441L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 172,
    Value = 
new System.Int64[,] { { 4853697858566211698L, 2769262110009129624L, }, { 3037297227748038565L, 9161986819722163289L, }, },
    NullableValue = 
new System.Int64[,] { { 1041349674086873662L, 2682741442999601743L, }, { 1910919578673470296L, 1317357969163277783L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 153,
    Value = 
new System.Int64[,] { { 5051186543987609323L, 9216089379313426274L, }, { 4339326804661946274L, 5624193750438210227L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Int64[,] { { 8585141987403067618L, 3587850388022062061L, }, { 7772270304798902225L, 4739678548401899486L, }, },
    NullableValue = 
new System.Int64[,] { { 5955144958063914781L, 5396040231180728151L, }, { 7747320856595004063L, 2297057419232799687L, }, },
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
INSERT INTO gedaqtests.int64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
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
                    await ((IInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IInt64MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.int64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD2)),
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
                    var models = await ((IInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

