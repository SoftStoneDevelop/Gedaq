

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
    internal partial interface INpgsqlBoxListboxListD1
    {
    }
    
    internal partial class NpgsqlBoxListboxListD1 : INpgsqlBoxListboxListD1
    {


#region TestData

        private readonly NpgsqlBoxboxListD1E2M[] _testData = new NpgsqlBoxboxListD1E2M[]
        {
            new NpgsqlBoxboxListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8812137819866993d,right: 0.8282200197849758d,bottom: 0.7011685925038716d,left: 0.06780479508318715d),

new NpgsqlTypes.NpgsqlBox(top: 0.6118932681109716d,right: 0.9494712672963813d,bottom: 0.22817711434887578d,left: 0.3382425319601726d),

new NpgsqlTypes.NpgsqlBox(top: 0.4744668838872128d,right: 0.734370145643881d,bottom: 0.16025297888232337d,left: 0.18320979206464338d),

new NpgsqlTypes.NpgsqlBox(top: 0.46583416350355444d,right: 0.8298510401347149d,bottom: 0.24239645013168165d,left: 0.7499835159841916d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6309608756294064d,right: 0.9901605193585973d,bottom: 0.34389305739978815d,left: 0.32079854288260234d),

new NpgsqlTypes.NpgsqlBox(top: 0.8363113761919027d,right: 0.7792207799926169d,bottom: 0.021541297257759884d,left: 0.7138370140321815d),

new NpgsqlTypes.NpgsqlBox(top: 0.30406759104037595d,right: 0.29853258632852453d,bottom: 0.03312761891615512d,left: 0.03980183061373421d),

new NpgsqlTypes.NpgsqlBox(top: 0.7534858518842842d,right: 0.9300595503218959d,bottom: 0.051665472984337546d,left: 0.9088166244518171d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.29725853953847237d,right: 0.148830787420974d,bottom: 0.25487582353115656d,left: 0.10305529744477082d),

new NpgsqlTypes.NpgsqlBox(top: 0.3778099671462152d,right: 0.9125382804223089d,bottom: 0.03364131739984133d,left: 0.0038237266656543367d),

new NpgsqlTypes.NpgsqlBox(top: 0.10894049279679752d,right: 0.9576581100838463d,bottom: 0.10774483137724d,left: 0.5662754739199495d),

new NpgsqlTypes.NpgsqlBox(top: 0.7626332428148828d,right: 0.8890991093047715d,bottom: 0.23224395394930164d,left: 0.2502822425071306d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9351893762916259d,right: 0.875665935198331d,bottom: 0.8213016222810979d,left: 0.18620214351003428d),

new NpgsqlTypes.NpgsqlBox(top: 0.4778194439999912d,right: 0.05420793495094267d,bottom: 0.18461238955721349d,left: 0.021523181448897644d),

new NpgsqlTypes.NpgsqlBox(top: 0.2681731191877639d,right: 0.40788216158331025d,bottom: 0.1862422580693852d,left: 0.3497579202235668d),

new NpgsqlTypes.NpgsqlBox(top: 0.17963712342387572d,right: 0.6571241442113823d,bottom: 0.05261423694767564d,left: 0.1774769344007775d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5925385584759739d,right: 0.9743539313328792d,bottom: 0.29360320145458974d,left: 0.11385748991170741d),

new NpgsqlTypes.NpgsqlBox(top: 0.7609014685165318d,right: 0.8435913741279045d,bottom: 0.36034742625251603d,left: 0.5773862937632205d),

new NpgsqlTypes.NpgsqlBox(top: 0.8570067363672798d,right: 0.42690419499781096d,bottom: 0.7145743284767463d,left: 0.13708894669829008d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5445757839213287d,right: 0.7757625380658626d,bottom: 0.029585573581187186d,left: 0.5676155263542744d),

new NpgsqlTypes.NpgsqlBox(top: 0.3631429937102728d,right: 0.6707002454355944d,bottom: 0.2422331763035096d,left: 0.02053535058763345d),

new NpgsqlTypes.NpgsqlBox(top: 0.528433731407847d,right: 0.6288414998942768d,bottom: 0.41643012487305475d,left: 0.4011987321593583d),

new NpgsqlTypes.NpgsqlBox(top: 0.9774812863766091d,right: 0.9648025459152837d,bottom: 0.31076480847402077d,left: 0.09850282885779627d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8186410032158795d,right: 0.9242268731726043d,bottom: 0.2670541435754338d,left: 0.12271367135104805d),

new NpgsqlTypes.NpgsqlBox(top: 0.5347171995330806d,right: 0.6019447928111095d,bottom: 0.04197147978262994d,left: 0.5468238855041624d),

new NpgsqlTypes.NpgsqlBox(top: 0.9639582288109618d,right: 0.4214326246695804d,bottom: 0.30529865463524075d,left: 0.25944179407545864d),

new NpgsqlTypes.NpgsqlBox(top: 0.7494735534887021d,right: 0.9340889394533255d,bottom: 0.6338192932449914d,left: 0.04516715539088878d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.846656034114462d,right: 0.9645459755530403d,bottom: 0.27689928178159906d,left: 0.10459452822136794d),

new NpgsqlTypes.NpgsqlBox(top: 0.6646900876182974d,right: 0.5062775796328555d,bottom: 0.36966919128321385d,left: 0.36603672811982624d),

new NpgsqlTypes.NpgsqlBox(top: 0.22505086344130598d,right: 0.3684229251084349d,bottom: 0.1792447817930264d,left: 0.1544776362729663d),

new NpgsqlTypes.NpgsqlBox(top: 0.794108929040081d,right: 0.4241744717290111d,bottom: 0.7115294238143934d,left: 0.11792911734907263d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2330382441817508d,right: 0.9794101838801281d,bottom: 0.09297830681034802d,left: 0.3542847626902932d),

new NpgsqlTypes.NpgsqlBox(top: 0.46961544557318813d,right: 0.8913491963643042d,bottom: 0.25907867687570774d,left: 0.7384936110964558d),

new NpgsqlTypes.NpgsqlBox(top: 0.36736840521439396d,right: 0.8662194437251031d,bottom: 0.20148984913637236d,left: 0.06932362099296807d),

new NpgsqlTypes.NpgsqlBox(top: 0.5893468706546768d,right: 0.6988720520140801d,bottom: 0.07659137984213371d,left: 0.3904421581522849d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9907350047223352d,right: 0.9187470936867577d,bottom: 0.4548150820457748d,left: 0.45904054209574496d),

new NpgsqlTypes.NpgsqlBox(top: 0.8554311331988158d,right: 0.7226868738509299d,bottom: 0.3195876774950748d,left: 0.5415253498734655d),

new NpgsqlTypes.NpgsqlBox(top: 0.938227699492999d,right: 0.8293052599175239d,bottom: 0.9296265405970575d,left: 0.41196077623508653d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9277411416892234d,right: 0.6499410542966568d,bottom: 0.07311276279221235d,left: 0.351028291344069d),

new NpgsqlTypes.NpgsqlBox(top: 0.9744380279809962d,right: 0.9045816082053012d,bottom: 0.306453970681565d,left: 0.6308333122223453d),

new NpgsqlTypes.NpgsqlBox(top: 0.9847610747802714d,right: 0.6203729918088222d,bottom: 0.5932533062110928d,left: 0.34077269424981316d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6576220674931074d,right: 0.8880836048243766d,bottom: 0.46784614132238445d,left: 0.8513440909848489d),

new NpgsqlTypes.NpgsqlBox(top: 0.5084651859213264d,right: 0.5532474060230936d,bottom: 0.4038698844849202d,left: 0.5360874761240028d),

new NpgsqlTypes.NpgsqlBox(top: 0.32866983908499947d,right: 0.6315582005594751d,bottom: 0.22688766036645058d,left: 0.5513453749782707d),

new NpgsqlTypes.NpgsqlBox(top: 0.9197414027481323d,right: 0.49308375470885324d,bottom: 0.9011743840888249d,left: 0.16712254730089338d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9742520970957282d,right: 0.7801448229088578d,bottom: 0.3753090772878527d,left: 0.5817066420461914d),

new NpgsqlTypes.NpgsqlBox(top: 0.535135260607356d,right: 0.41382594073668844d,bottom: 0.49033987165313586d,left: 0.4024251304958907d),

new NpgsqlTypes.NpgsqlBox(top: 0.9146024070532855d,right: 0.8454624688986785d,bottom: 0.607747953332814d,left: 0.25952593920113187d),

new NpgsqlTypes.NpgsqlBox(top: 0.17095691505109178d,right: 0.7841066584379346d,bottom: 0.07588849980199708d,left: 0.38607997429326646d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.11028754799564233d,right: 0.8983384170445716d,bottom: 0.04142369606394569d,left: 0.5017311895453167d),

new NpgsqlTypes.NpgsqlBox(top: 0.9876565048448015d,right: 0.7980904372408237d,bottom: 0.13557151744361595d,left: 0.5744006026948362d),

new NpgsqlTypes.NpgsqlBox(top: 0.7229704333528851d,right: 0.6966794648039986d,bottom: 0.17075579694893073d,left: 0.5225436147025899d),

new NpgsqlTypes.NpgsqlBox(top: 0.7745306235207318d,right: 0.7356947163244855d,bottom: 0.3112072132510887d,left: 0.29427955357718294d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.39917182415834984d,right: 0.5526893207047935d,bottom: 0.059650325113496105d,left: 0.24460189533224053d),

new NpgsqlTypes.NpgsqlBox(top: 0.7032622996391862d,right: 0.7763899286341795d,bottom: 0.29929613237022357d,left: 0.5394025102358904d),

new NpgsqlTypes.NpgsqlBox(top: 0.982080446208296d,right: 0.4788606470339104d,bottom: 0.05199376638373643d,left: 0.41497637346628025d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5023984887227331d,right: 0.6953766879314326d,bottom: 0.23329607682588893d,left: 0.36908671307604135d),

new NpgsqlTypes.NpgsqlBox(top: 0.8566620776836776d,right: 0.7428955798325496d,bottom: 0.14756655215297843d,left: 0.2163530309349232d),

new NpgsqlTypes.NpgsqlBox(top: 0.879701395266824d,right: 0.9948353840535565d,bottom: 0.0840341842127047d,left: 0.6880603073255304d),

new NpgsqlTypes.NpgsqlBox(top: 0.6506418259436615d,right: 0.5064857074138095d,bottom: 0.4571330711320878d,left: 0.28255041242378387d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2681943773602735d,right: 0.7056601573955185d,bottom: 0.0617234125975189d,left: 0.5342589723296145d),

new NpgsqlTypes.NpgsqlBox(top: 0.7870547567236316d,right: 0.7804929260153807d,bottom: 0.4858733141788938d,left: 0.5210019931477149d),

new NpgsqlTypes.NpgsqlBox(top: 0.9616614880580074d,right: 0.9974152435505022d,bottom: 0.026284174679722216d,left: 0.508058052309844d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.550860301980707d,right: 0.8413163624843475d,bottom: 0.26831613350913763d,left: 0.05909277887954878d),

new NpgsqlTypes.NpgsqlBox(top: 0.8057939932414364d,right: 0.05539468832463401d,bottom: 0.07055967952769227d,left: 0.0010214807951539617d),

new NpgsqlTypes.NpgsqlBox(top: 0.8037297895039439d,right: 0.9680292488421666d,bottom: 0.0029038813473323266d,left: 0.2804432955229361d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8260427813142459d,right: 0.9470818784888086d,bottom: 0.151697023632827d,left: 0.5654755471334333d),

new NpgsqlTypes.NpgsqlBox(top: 0.36485286319353494d,right: 0.861234093878198d,bottom: 0.13982284600157457d,left: 0.8282038253115522d),

new NpgsqlTypes.NpgsqlBox(top: 0.9993975916903417d,right: 0.8787881750421949d,bottom: 0.5934872328173136d,left: 0.7658661286084493d),

new NpgsqlTypes.NpgsqlBox(top: 0.8573390606715752d,right: 0.8146193963798938d,bottom: 0.479538094100447d,left: 0.6034708802649708d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4779203637846866d,right: 0.4099414268802444d,bottom: 0.34447100000618003d,left: 0.2660955537541876d),

new NpgsqlTypes.NpgsqlBox(top: 0.40548356518369244d,right: 0.2368363241398399d,bottom: 0.20262371165721804d,left: 0.22025690565754052d),

new NpgsqlTypes.NpgsqlBox(top: 0.9532462488331318d,right: 0.8065019985286808d,bottom: 0.5550303497924948d,left: 0.043273366623569176d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4629350202007778d,right: 0.9105525945711535d,bottom: 0.10834116261469573d,left: 0.46151736248254416d),

new NpgsqlTypes.NpgsqlBox(top: 0.948052295649904d,right: 0.7279814069079827d,bottom: 0.25501091300784273d,left: 0.012485062460322993d),

new NpgsqlTypes.NpgsqlBox(top: 0.7399271550144185d,right: 0.9579923741215495d,bottom: 0.4162808925378624d,left: 0.5194102894313357d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5848051671738311d,right: 0.8007860224186725d,bottom: 0.29715800709906404d,left: 0.14968368800382081d),

new NpgsqlTypes.NpgsqlBox(top: 0.5029411006000432d,right: 0.26165700198178243d,bottom: 0.15146364588817907d,left: 0.03479507899941536d),

new NpgsqlTypes.NpgsqlBox(top: 0.49328848936278746d,right: 0.948169575410715d,bottom: 0.11763057221547368d,left: 0.04619324953919035d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8800465548393259d,right: 0.8882196081285166d,bottom: 0.2826964767056199d,left: 0.08365136980527244d),

new NpgsqlTypes.NpgsqlBox(top: 0.9356442244350922d,right: 0.6158729005954631d,bottom: 0.25232804855988866d,left: 0.05265823862567842d),

new NpgsqlTypes.NpgsqlBox(top: 0.19055925461510848d,right: 0.7712472812885428d,bottom: 0.18560163344870506d,left: 0.04264389858868223d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8714983758050057d,right: 0.8819220390626309d,bottom: 0.6636433658308035d,left: 0.11238030383998687d),

new NpgsqlTypes.NpgsqlBox(top: 0.5561059844199613d,right: 0.6001524920345079d,bottom: 0.35447826656412107d,left: 0.056791050625984996d),

new NpgsqlTypes.NpgsqlBox(top: 0.4049161362153112d,right: 0.3281411502247349d,bottom: 0.016563736628159242d,left: 0.2896990079917955d),

new NpgsqlTypes.NpgsqlBox(top: 0.4796947003210814d,right: 0.5284605433141709d,bottom: 0.29900185466211937d,left: 0.06861184749524796d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.992137309779165d,right: 0.5894831684596578d,bottom: 0.9211961240513934d,left: 0.13003930591220825d),

new NpgsqlTypes.NpgsqlBox(top: 0.474027796803028d,right: 0.8474318218879247d,bottom: 0.25726263099565594d,left: 0.6087581503554712d),

new NpgsqlTypes.NpgsqlBox(top: 0.959765287697855d,right: 0.7192254332714995d,bottom: 0.5007095663968462d,left: 0.4422705495695731d),

new NpgsqlTypes.NpgsqlBox(top: 0.1886513910153882d,right: 0.0705084450458181d,bottom: 0.049239568261972066d,left: 0.001432731640657381d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.975126690385605d,right: 0.3733699767902712d,bottom: 0.8994469448089977d,left: 0.14261886245278366d),

new NpgsqlTypes.NpgsqlBox(top: 0.5703431806504448d,right: 0.7923342048054702d,bottom: 0.3007361415740506d,left: 0.6400804752678947d),

new NpgsqlTypes.NpgsqlBox(top: 0.4814956880582907d,right: 0.4450524625989961d,bottom: 0.3662995941589883d,left: 0.07262532989612824d),

new NpgsqlTypes.NpgsqlBox(top: 0.6177268473529663d,right: 0.9383845771455316d,bottom: 0.0983308354744249d,left: 0.8687166525951734d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.29773796594465884d,right: 0.29392928601151114d,bottom: 0.12033637978424316d,left: 0.028518882507974852d),

new NpgsqlTypes.NpgsqlBox(top: 0.29738378310082747d,right: 0.5574063132674744d,bottom: 0.19509152820039233d,left: 0.12115884680679412d),

new NpgsqlTypes.NpgsqlBox(top: 0.43233260942592877d,right: 0.7375114698798397d,bottom: 0.39504096163813907d,left: 0.442711748474785d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7418230890333392d,right: 0.9561727381244445d,bottom: 0.3333745297252072d,left: 0.21205496489246134d),

new NpgsqlTypes.NpgsqlBox(top: 0.8000013846662694d,right: 0.9957942470952676d,bottom: 0.5496940370842662d,left: 0.1271636695327667d),

new NpgsqlTypes.NpgsqlBox(top: 0.9108275241829252d,right: 0.5332702546998885d,bottom: 0.1127320286049126d,left: 0.01468039499324636d),

new NpgsqlTypes.NpgsqlBox(top: 0.906922749888779d,right: 0.5524901485019892d,bottom: 0.3593654085527186d,left: 0.1257159833399648d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9136773839549869d,right: 0.7266407399816199d,bottom: 0.3734052529311387d,left: 0.3528288703010235d),

new NpgsqlTypes.NpgsqlBox(top: 0.46711771651466516d,right: 0.6648537638483646d,bottom: 0.03882760559917264d,left: 0.1386096648371733d),

new NpgsqlTypes.NpgsqlBox(top: 0.30242651665550613d,right: 0.9209071887067115d,bottom: 0.00629915047839158d,left: 0.12560769216966838d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8342248454561852d,right: 0.8852767449861872d,bottom: 0.02950903422161466d,left: 0.8822135878614099d),

new NpgsqlTypes.NpgsqlBox(top: 0.904291784943666d,right: 0.9167846585029665d,bottom: 0.4910443028783311d,left: 0.7125590734576468d),

new NpgsqlTypes.NpgsqlBox(top: 0.8170878672988698d,right: 0.6976618131753907d,bottom: 0.05907029327682056d,left: 0.24732139310749068d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7867603428614192d,right: 0.9663406872915631d,bottom: 0.07707540340597008d,left: 0.6817568428907154d),

new NpgsqlTypes.NpgsqlBox(top: 0.7093083251249385d,right: 0.8264574491221808d,bottom: 0.47419579914798804d,left: 0.427494789901839d),

new NpgsqlTypes.NpgsqlBox(top: 0.829377401348034d,right: 0.9224288923120584d,bottom: 0.3422679174204737d,left: 0.258984868504763d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8153757371046949d,right: 0.8496086100294739d,bottom: 0.6839522653019595d,left: 0.6464788845955841d),

new NpgsqlTypes.NpgsqlBox(top: 0.2053472661361353d,right: 0.5615255955288841d,bottom: 0.16547342666053588d,left: 0.4309767437394181d),

new NpgsqlTypes.NpgsqlBox(top: 0.9544775803336693d,right: 0.61127026436578d,bottom: 0.37680878251499395d,left: 0.5066058190524096d),

new NpgsqlTypes.NpgsqlBox(top: 0.3488268323541741d,right: 0.43107546659787355d,bottom: 0.1576647716802646d,left: 0.1914713216095858d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9688000931539914d,right: 0.526076374269974d,bottom: 0.6644748198851468d,left: 0.47645729551950977d),

new NpgsqlTypes.NpgsqlBox(top: 0.3494388155172935d,right: 0.9514391462434634d,bottom: 0.19790999075820825d,left: 0.31967454498379955d),

new NpgsqlTypes.NpgsqlBox(top: 0.42183200202212934d,right: 0.8931741539342912d,bottom: 0.4148015510127344d,left: 0.6592534784764129d),

new NpgsqlTypes.NpgsqlBox(top: 0.7924298393322413d,right: 0.647070887292904d,bottom: 0.4583391128377471d,left: 0.5071570751697808d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3674981048596837d,right: 0.5387047440679907d,bottom: 0.1891646384770106d,left: 0.18784125513960914d),

new NpgsqlTypes.NpgsqlBox(top: 0.5794292436919551d,right: 0.8768858876642068d,bottom: 0.18705734196936397d,left: 0.2730241921126201d),

new NpgsqlTypes.NpgsqlBox(top: 0.264851497329881d,right: 0.8492281141936174d,bottom: 0.07550198875762826d,left: 0.3972723093042796d),

new NpgsqlTypes.NpgsqlBox(top: 0.933932919089047d,right: 0.5352542559886442d,bottom: 0.33414220877476286d,left: 0.0016446453401074423d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9230843098421521d,right: 0.46186081626719866d,bottom: 0.8876498969552308d,left: 0.3383959128697236d),

new NpgsqlTypes.NpgsqlBox(top: 0.6852256318399051d,right: 0.8500495971328806d,bottom: 0.6638859871529476d,left: 0.8253341801236651d),

new NpgsqlTypes.NpgsqlBox(top: 0.7922381823701788d,right: 0.5106874159244097d,bottom: 0.24958166031364826d,left: 0.26102450933896904d),

new NpgsqlTypes.NpgsqlBox(top: 0.8583461934752593d,right: 0.8865650926841566d,bottom: 0.21542766141928638d,left: 0.6085494692333412d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7970243927892866d,right: 0.7944082434965903d,bottom: 0.08540363814649576d,left: 0.5211151479509465d),

new NpgsqlTypes.NpgsqlBox(top: 0.9123990687092147d,right: 0.6468418549556436d,bottom: 0.049585732577166475d,left: 0.05043983768665017d),

new NpgsqlTypes.NpgsqlBox(top: 0.6415419107575334d,right: 0.6866757550731851d,bottom: 0.0154893944167801d,left: 0.6089750800088768d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6542378742921178d,right: 0.6981595477457546d,bottom: 0.44881392788717156d,left: 0.10716431657865089d),

new NpgsqlTypes.NpgsqlBox(top: 0.8331375263543719d,right: 0.41244361945096975d,bottom: 0.4129926027734505d,left: 0.04070891996459536d),

new NpgsqlTypes.NpgsqlBox(top: 0.5113814348474611d,right: 0.9387499690588829d,bottom: 0.10450980546504463d,left: 0.7320433844228903d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6499867362099419d,right: 0.7605832138246911d,bottom: 0.32193737205655515d,left: 0.08111786371107521d),

new NpgsqlTypes.NpgsqlBox(top: 0.28843023353207475d,right: 0.9118877869821421d,bottom: 0.1702348075260931d,left: 0.17183040089289114d),

new NpgsqlTypes.NpgsqlBox(top: 0.9782724125851724d,right: 0.7936474234543663d,bottom: 0.9649520296331063d,left: 0.15779737969229446d),

new NpgsqlTypes.NpgsqlBox(top: 0.8629995452036551d,right: 0.6652056556424046d,bottom: 0.7208776774274276d,left: 0.09144898735701223d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1719174154110309d,right: 0.6650986875298034d,bottom: 0.13774075962934607d,left: 0.5378141654035146d),

new NpgsqlTypes.NpgsqlBox(top: 0.2017710625823459d,right: 0.9194732328996632d,bottom: 0.01094039300687144d,left: 0.16418416380787337d),

new NpgsqlTypes.NpgsqlBox(top: 0.6131535611415558d,right: 0.8159412950869108d,bottom: 0.04029521725160057d,left: 0.2592096192513782d),

new NpgsqlTypes.NpgsqlBox(top: 0.7933227564364613d,right: 0.9317509950309075d,bottom: 0.407262322727049d,left: 0.13848065520874842d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.705214225654384d,right: 0.6440086428095414d,bottom: 0.3214823709365474d,left: 0.29817370397958887d),

new NpgsqlTypes.NpgsqlBox(top: 0.40318764352044334d,right: 0.7219098934009245d,bottom: 0.0612536030492854d,left: 0.18039145371298448d),

new NpgsqlTypes.NpgsqlBox(top: 0.8430051420010317d,right: 0.47153603520553833d,bottom: 0.06516395451155022d,left: 0.11398666291091408d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.577647807252139d,right: 0.9240552632606349d,bottom: 0.0894757515789677d,left: 0.2853133541348737d),

new NpgsqlTypes.NpgsqlBox(top: 0.8451978601800829d,right: 0.8329376902448827d,bottom: 0.8420065949508138d,left: 0.1767984347312519d),

new NpgsqlTypes.NpgsqlBox(top: 0.853130106210348d,right: 0.43694907900218605d,bottom: 0.6175985643452091d,left: 0.1364120787240436d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9269334807756865d,right: 0.9123760770435727d,bottom: 0.23307938431906805d,left: 0.7336686733679096d),

new NpgsqlTypes.NpgsqlBox(top: 0.15008128455727554d,right: 0.6058809003348874d,bottom: 0.1034318373561478d,left: 0.4872022995123798d),

new NpgsqlTypes.NpgsqlBox(top: 0.9422651159168417d,right: 0.8460713027024017d,bottom: 0.8145715467702418d,left: 0.20159310688880605d),

new NpgsqlTypes.NpgsqlBox(top: 0.771880708086386d,right: 0.38343283048846133d,bottom: 0.2537825890471782d,left: 0.03753167274130198d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49416115329308974d,right: 0.7769433974018716d,bottom: 0.04518016340177067d,left: 0.22122908925672835d),

new NpgsqlTypes.NpgsqlBox(top: 0.38792393948584303d,right: 0.9411872246314325d,bottom: 0.011414418200098475d,left: 0.8377218593005348d),

new NpgsqlTypes.NpgsqlBox(top: 0.8879079118411579d,right: 0.7535041051702052d,bottom: 0.7628158144344209d,left: 0.034664276695051455d),

new NpgsqlTypes.NpgsqlBox(top: 0.8472434952251365d,right: 0.9968170011072911d,bottom: 0.43866957894024783d,left: 0.804322734292603d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4948825036307457d,right: 0.5829642474326445d,bottom: 0.2785996237910827d,left: 0.4234061968923938d),

new NpgsqlTypes.NpgsqlBox(top: 0.5463715816038403d,right: 0.7876707896902279d,bottom: 0.021990914062753553d,left: 0.0884525781936999d),

new NpgsqlTypes.NpgsqlBox(top: 0.9118939206850758d,right: 0.3728954409599283d,bottom: 0.18650100645598588d,left: 0.3000543344570037d),

new NpgsqlTypes.NpgsqlBox(top: 0.8825691945866799d,right: 0.9449295798059981d,bottom: 0.5371601550504705d,left: 0.0026652982962734884d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4920861920988987d,right: 0.6855501434856229d,bottom: 0.15465670892692351d,left: 0.07932488978028596d),

new NpgsqlTypes.NpgsqlBox(top: 0.7055738747095737d,right: 0.30629334749058257d,bottom: 0.14224720826841308d,left: 0.15033684707903971d),

new NpgsqlTypes.NpgsqlBox(top: 0.7984072153783031d,right: 0.8679335571083241d,bottom: 0.031680879427180564d,left: 0.17995810958258074d),

new NpgsqlTypes.NpgsqlBox(top: 0.6832051412620271d,right: 0.672111030052237d,bottom: 0.3639484021215311d,left: 0.49376803591443985d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.653540630126708d,right: 0.10817967683843699d,bottom: 0.4046223814516634d,left: 0.01719572317521889d),

new NpgsqlTypes.NpgsqlBox(top: 0.7703775298670339d,right: 0.44259082718666043d,bottom: 0.7545454534829198d,left: 0.06147092393403908d),

new NpgsqlTypes.NpgsqlBox(top: 0.35154477970326614d,right: 0.12012164680080606d,bottom: 0.12650391802549843d,left: 0.07047705944076776d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6131608874846027d,right: 0.8319914651284919d,bottom: 0.21121063885655278d,left: 0.23276821842731743d),

new NpgsqlTypes.NpgsqlBox(top: 0.5490005092910627d,right: 0.7055285088154728d,bottom: 0.4341205611447724d,left: 0.4711720065238265d),

new NpgsqlTypes.NpgsqlBox(top: 0.8517765961395705d,right: 0.9036497133464009d,bottom: 0.42874932111609787d,left: 0.88395011995688d),

new NpgsqlTypes.NpgsqlBox(top: 0.46113565528921585d,right: 0.3918675585675774d,bottom: 0.11499980789466002d,left: 0.07674319300579346d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43786712041280595d,right: 0.971935730544766d,bottom: 0.12912351003646683d,left: 0.6642045045989482d),

new NpgsqlTypes.NpgsqlBox(top: 0.7980427370200919d,right: 0.43305990358569635d,bottom: 0.5823067229296717d,left: 0.30403770335624236d),

new NpgsqlTypes.NpgsqlBox(top: 0.6688388250894799d,right: 0.7824930000889182d,bottom: 0.3778591949664438d,left: 0.013446657951093455d),

new NpgsqlTypes.NpgsqlBox(top: 0.8301684088045032d,right: 0.8182470919513154d,bottom: 0.7614984620621137d,left: 0.277187484533424d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7201978519630345d,right: 0.9544933626568668d,bottom: 0.41102463940942424d,left: 0.06142532123610278d),

new NpgsqlTypes.NpgsqlBox(top: 0.5270396991264584d,right: 0.5061697656880448d,bottom: 0.29727752287858744d,left: 0.08895570971166344d),

new NpgsqlTypes.NpgsqlBox(top: 0.2412686888823813d,right: 0.9953117332356733d,bottom: 0.025214850198752803d,left: 0.18799035081008963d),

new NpgsqlTypes.NpgsqlBox(top: 0.9376584107811656d,right: 0.8536139889061767d,bottom: 0.02085752185520484d,left: 0.32975388363760716d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9475152510525984d,right: 0.7218769982792844d,bottom: 0.7078235513468282d,left: 0.13278662381765494d),

new NpgsqlTypes.NpgsqlBox(top: 0.8507291717790901d,right: 0.9905758678648677d,bottom: 0.6828870876118931d,left: 0.8364129065872753d),

new NpgsqlTypes.NpgsqlBox(top: 0.7205941982446604d,right: 0.5895189927599956d,bottom: 0.26615562691002026d,left: 0.23559179468903046d),

new NpgsqlTypes.NpgsqlBox(top: 0.1799075860398035d,right: 0.8173899383320301d,bottom: 0.10600640847954101d,left: 0.12446571963786679d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2271794414399222d,right: 0.6562735177924957d,bottom: 0.09548692273991544d,left: 0.5984312394303665d),

new NpgsqlTypes.NpgsqlBox(top: 0.7130388222564129d,right: 0.775935155434811d,bottom: 0.13840082428576395d,left: 0.49534244087037815d),

new NpgsqlTypes.NpgsqlBox(top: 0.6314704774574402d,right: 0.54791353155518d,bottom: 0.42555642165311247d,left: 0.5298521057318969d),

new NpgsqlTypes.NpgsqlBox(top: 0.9635331317986666d,right: 0.49157116240748955d,bottom: 0.71395229541234d,left: 0.4099525859460905d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9356946326982619d,right: 0.7760337147728831d,bottom: 0.2076314527883717d,left: 0.5946262324050493d),

new NpgsqlTypes.NpgsqlBox(top: 0.9652758952347023d,right: 0.49942337240908175d,bottom: 0.9031146275797174d,left: 0.3851952718267798d),

new NpgsqlTypes.NpgsqlBox(top: 0.8961075584380005d,right: 0.5016738142112971d,bottom: 0.05286429233385781d,left: 0.09715652123913732d),

new NpgsqlTypes.NpgsqlBox(top: 0.4831776961962041d,right: 0.44386655474252223d,bottom: 0.31063484225898685d,left: 0.4108739916045201d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9982573259429293d,right: 0.18415217617158242d,bottom: 0.3989211621521829d,left: 0.0919183981102325d),

new NpgsqlTypes.NpgsqlBox(top: 0.9190368590724693d,right: 0.47389580171021795d,bottom: 0.8039766295864778d,left: 0.47014002208042593d),

new NpgsqlTypes.NpgsqlBox(top: 0.7809352619150856d,right: 0.8026907154792856d,bottom: 0.0738188315145798d,left: 0.32595786387660475d),

new NpgsqlTypes.NpgsqlBox(top: 0.9094942982491048d,right: 0.8563406269214732d,bottom: 0.37381406980495413d,left: 0.44320782354959154d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7385040737800439d,right: 0.8628752363337348d,bottom: 0.4841874663536595d,left: 0.8490614684457569d),

new NpgsqlTypes.NpgsqlBox(top: 0.7858902986715861d,right: 0.70137719772608d,bottom: 0.19687858032805827d,left: 0.61863480428962d),

new NpgsqlTypes.NpgsqlBox(top: 0.7863577350606028d,right: 0.10016547577104229d,bottom: 0.3108694593601915d,left: 0.05345206638719946d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5876071613860117d,right: 0.5161259635074722d,bottom: 0.10797299857494524d,left: 0.3189110345189621d),

new NpgsqlTypes.NpgsqlBox(top: 0.4668450367393412d,right: 0.5379799895762833d,bottom: 0.005415877705518213d,left: 0.48964291257470427d),

new NpgsqlTypes.NpgsqlBox(top: 0.8417730148111581d,right: 0.8741973859149637d,bottom: 0.32071617443636735d,left: 0.3050242211822959d),

new NpgsqlTypes.NpgsqlBox(top: 0.39697927586900006d,right: 0.7907261724729543d,bottom: 0.2790248475904833d,left: 0.5478029384396849d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8132442077286278d,right: 0.8680397885318615d,bottom: 0.38804005383683005d,left: 0.3593897170807505d),

new NpgsqlTypes.NpgsqlBox(top: 0.7189767638719478d,right: 0.305090561682422d,bottom: 0.2582877451084197d,left: 0.011638017906648424d),

new NpgsqlTypes.NpgsqlBox(top: 0.6258300086727089d,right: 0.9808016760302992d,bottom: 0.14433725495656213d,left: 0.31334885648518607d),

new NpgsqlTypes.NpgsqlBox(top: 0.7994106954774265d,right: 0.9488088101078807d,bottom: 0.13927594265540688d,left: 0.040753751516232506d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7640648825090526d,right: 0.9753312166685212d,bottom: 0.2474151932768085d,left: 0.5023266416007338d),

new NpgsqlTypes.NpgsqlBox(top: 0.380806250007655d,right: 0.8476762506549891d,bottom: 0.0005685969996276352d,left: 0.6017410898550983d),

new NpgsqlTypes.NpgsqlBox(top: 0.7984381575653022d,right: 0.43412077394969617d,bottom: 0.41205548180302043d,left: 0.11390416676071125d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.853161157743692d,right: 0.612623526479737d,bottom: 0.5956384433857995d,left: 0.5162874418063798d),

new NpgsqlTypes.NpgsqlBox(top: 0.8987814981476855d,right: 0.8950673426651912d,bottom: 0.48868597266786673d,left: 0.009706335307208769d),

new NpgsqlTypes.NpgsqlBox(top: 0.4243928329487424d,right: 0.9857190939503867d,bottom: 0.24222130882121595d,left: 0.1942568453904142d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7114996768806747d,right: 0.7077012302702428d,bottom: 0.5792894789579016d,left: 0.4210011210126008d),

new NpgsqlTypes.NpgsqlBox(top: 0.8025783080301254d,right: 0.6446282029419873d,bottom: 0.44465509305895057d,left: 0.03891799713224631d),

new NpgsqlTypes.NpgsqlBox(top: 0.36953320772839227d,right: 0.32717021030221094d,bottom: 0.09835945000238233d,left: 0.3220124007991195d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7611565423548945d,right: 0.14274173994530837d,bottom: 0.3289352224197042d,left: 0.1302518784110378d),

new NpgsqlTypes.NpgsqlBox(top: 0.7240255505873007d,right: 0.2644402822732277d,bottom: 0.6748383317909981d,left: 0.2338325980083762d),

new NpgsqlTypes.NpgsqlBox(top: 0.9408666674600278d,right: 0.6910811987536332d,bottom: 0.6789730409009729d,left: 0.3558070326161251d),

new NpgsqlTypes.NpgsqlBox(top: 0.6301331042825472d,right: 0.7751513931428271d,bottom: 0.22390470678485297d,left: 0.008995732514549437d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.11615953721430672d,right: 0.2536948064654725d,bottom: 0.09474964183258616d,left: 0.028298437292825995d),

new NpgsqlTypes.NpgsqlBox(top: 0.8450911727130404d,right: 0.997629961814696d,bottom: 0.7441712278454643d,left: 0.9904786511938128d),

new NpgsqlTypes.NpgsqlBox(top: 0.6996975247297871d,right: 0.807882141974482d,bottom: 0.5458935576840999d,left: 0.714358736529615d),

new NpgsqlTypes.NpgsqlBox(top: 0.9608673032522754d,right: 0.7304443895420785d,bottom: 0.6730648744148273d,left: 0.4614328146440704d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.20578906640418293d,right: 0.6997223605220365d,bottom: 0.06451059925715574d,left: 0.26326575574058664d),

new NpgsqlTypes.NpgsqlBox(top: 0.5602065222897262d,right: 0.13902388499495388d,bottom: 0.5358501842443597d,left: 0.051005521099973916d),

new NpgsqlTypes.NpgsqlBox(top: 0.9169443217709626d,right: 0.4955610080513807d,bottom: 0.38380202449355993d,left: 0.07878144593684178d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6400074682776599d,right: 0.984796000080199d,bottom: 0.11982326289505552d,left: 0.3742539256635785d),

new NpgsqlTypes.NpgsqlBox(top: 0.6490196947198711d,right: 0.12893917875295335d,bottom: 0.639387145985945d,left: 0.0028293739078143476d),

new NpgsqlTypes.NpgsqlBox(top: 0.9001362100262569d,right: 0.6536560073708635d,bottom: 0.4206701419530927d,left: 0.04975679194079197d),

new NpgsqlTypes.NpgsqlBox(top: 0.8562243868853228d,right: 0.9792783855370847d,bottom: 0.4875538536081083d,left: 0.3598926735272733d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8040310104826223d,right: 0.7429283904932189d,bottom: 0.24826375197822215d,left: 0.33412183536610485d),

new NpgsqlTypes.NpgsqlBox(top: 0.9883610274488759d,right: 0.6672028531000856d,bottom: 0.49011742878562925d,left: 0.43901780137480695d),

new NpgsqlTypes.NpgsqlBox(top: 0.4270608617771229d,right: 0.6208079424650701d,bottom: 0.1361399184936114d,left: 0.5402204405942809d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9484073058821526d,right: 0.9919843048215995d,bottom: 0.6785995792141755d,left: 0.850534793244734d),

new NpgsqlTypes.NpgsqlBox(top: 0.9498128066318743d,right: 0.09311875372013123d,bottom: 0.8944287656848834d,left: 0.04085422891797952d),

new NpgsqlTypes.NpgsqlBox(top: 0.7062308207978486d,right: 0.5406874307705614d,bottom: 0.0792973865998654d,left: 0.43497256645363636d),

new NpgsqlTypes.NpgsqlBox(top: 0.8008266499503522d,right: 0.2546272536724341d,bottom: 0.015523849251295796d,left: 0.12177953413744591d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2634990423450586d,right: 0.47372054808382924d,bottom: 0.1974269003597875d,left: 0.2538732965232655d),

new NpgsqlTypes.NpgsqlBox(top: 0.6080959824869879d,right: 0.5644626268409745d,bottom: 0.5156498568624642d,left: 0.3240883675880212d),

new NpgsqlTypes.NpgsqlBox(top: 0.7664986451746476d,right: 0.8693740955665531d,bottom: 0.7436501073272178d,left: 0.2730587735429124d),

new NpgsqlTypes.NpgsqlBox(top: 0.9031763972724757d,right: 0.9318135287322663d,bottom: 0.44575575236637943d,left: 0.8114999191736657d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.765416894471839d,right: 0.47868842883882756d,bottom: 0.6391236828759438d,left: 0.3596097787221114d),

new NpgsqlTypes.NpgsqlBox(top: 0.6128212332969506d,right: 0.6996235227243287d,bottom: 0.22622424683507414d,left: 0.6587785402605959d),

new NpgsqlTypes.NpgsqlBox(top: 0.7971893913426743d,right: 0.8315108432486115d,bottom: 0.6537044412042328d,left: 0.18576609289676327d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.36400823875740707d,right: 0.9540978575849387d,bottom: 0.004836976915634783d,left: 0.38326578965862046d),

new NpgsqlTypes.NpgsqlBox(top: 0.8635187985971696d,right: 0.7926938669567379d,bottom: 0.4865316742379038d,left: 0.05984609692876519d),

new NpgsqlTypes.NpgsqlBox(top: 0.621654259022262d,right: 0.9309327180450476d,bottom: 0.6100616121173745d,left: 0.4834600823184123d),

new NpgsqlTypes.NpgsqlBox(top: 0.6639297082655108d,right: 0.5998823370561055d,bottom: 0.3744052125037487d,left: 0.1556789751770392d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9756022564201807d,right: 0.37891899473274226d,bottom: 0.5535164892686412d,left: 0.025856398451931883d),

new NpgsqlTypes.NpgsqlBox(top: 0.6982967963471093d,right: 0.7064409474753355d,bottom: 0.14729993160166632d,left: 0.01620150277404009d),

new NpgsqlTypes.NpgsqlBox(top: 0.4322362393550495d,right: 0.7678432764152714d,bottom: 0.15859847680903283d,left: 0.6042837602058776d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.10628932817010117d,right: 0.4121937486195133d,bottom: 0.03150208293065282d,left: 0.3002794511613158d),

new NpgsqlTypes.NpgsqlBox(top: 0.6559614132692924d,right: 0.6329495889102564d,bottom: 0.4028969268772633d,left: 0.22940825383105246d),

new NpgsqlTypes.NpgsqlBox(top: 0.8368052518656031d,right: 0.6579436818260768d,bottom: 0.4214919517082064d,left: 0.6234365969844116d),

new NpgsqlTypes.NpgsqlBox(top: 0.6561019564176944d,right: 0.8420919865392581d,bottom: 0.36050708332774495d,left: 0.5135512158539957d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8735770069944576d,right: 0.20857714578738362d,bottom: 0.31718456266008077d,left: 0.025032507501764112d),

new NpgsqlTypes.NpgsqlBox(top: 0.6709366892625638d,right: 0.5642759942661228d,bottom: 0.023402929839549613d,left: 0.3720077332344145d),

new NpgsqlTypes.NpgsqlBox(top: 0.7596382883536655d,right: 0.9568861560239855d,bottom: 0.6390325202761055d,left: 0.6463095847670477d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8633968555245708d,right: 0.7239229785728184d,bottom: 0.5386556628412865d,left: 0.2470787258131486d),

new NpgsqlTypes.NpgsqlBox(top: 0.9520066305318675d,right: 0.537797936110621d,bottom: 0.20527966004638143d,left: 0.2947122520552673d),

new NpgsqlTypes.NpgsqlBox(top: 0.9097128770435096d,right: 0.9884219483466331d,bottom: 0.26542138660093206d,left: 0.7756694036184069d),

new NpgsqlTypes.NpgsqlBox(top: 0.8135652352332274d,right: 0.5809972589446619d,bottom: 0.6592405540252699d,left: 0.08596673862756643d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3213807815392832d,right: 0.17929969557444814d,bottom: 0.19510132120245305d,left: 0.10593285662520546d),

new NpgsqlTypes.NpgsqlBox(top: 0.9871371939879297d,right: 0.5442194855822566d,bottom: 0.38490313111045327d,left: 0.263412292510001d),

new NpgsqlTypes.NpgsqlBox(top: 0.5146565035989698d,right: 0.8163834983056095d,bottom: 0.09544162847718163d,left: 0.004137637356802615d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43545068013021826d,right: 0.4870191979002143d,bottom: 0.07331880021272719d,left: 0.06329880209834504d),

new NpgsqlTypes.NpgsqlBox(top: 0.8229191340821503d,right: 0.3457940947729148d,bottom: 0.1627678061998309d,left: 0.2934264339764239d),

new NpgsqlTypes.NpgsqlBox(top: 0.8605474879746059d,right: 0.44446845400712964d,bottom: 0.5838237131730543d,left: 0.2802932318974919d),

new NpgsqlTypes.NpgsqlBox(top: 0.9082635937082263d,right: 0.6697068736751497d,bottom: 0.3114938115669955d,left: 0.3235916306548231d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9525087991237318d,right: 0.8246689140197615d,bottom: 0.4034810914402299d,left: 0.8056343185337036d),

new NpgsqlTypes.NpgsqlBox(top: 0.2845958052330253d,right: 0.5428254373187349d,bottom: 0.22864065026069724d,left: 0.17087577781759344d),

new NpgsqlTypes.NpgsqlBox(top: 0.5677844380876523d,right: 0.7821788226657777d,bottom: 0.4238066363851294d,left: 0.5268727003511187d),

new NpgsqlTypes.NpgsqlBox(top: 0.9698549881028423d,right: 0.45096418827901896d,bottom: 0.6149150681103892d,left: 0.23126819544888988d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9220986331490129d,right: 0.657099944165243d,bottom: 0.6846680427941064d,left: 0.2602636396743788d),

new NpgsqlTypes.NpgsqlBox(top: 0.8738818450091537d,right: 0.9237079715668636d,bottom: 0.28016413152321107d,left: 0.6219655614505479d),

new NpgsqlTypes.NpgsqlBox(top: 0.5973179566085847d,right: 0.6359872770658476d,bottom: 0.2892246508775793d,left: 0.14623598195864151d),

new NpgsqlTypes.NpgsqlBox(top: 0.6569557705017024d,right: 0.8554177162828107d,bottom: 0.0625639182146489d,left: 0.5127318116656182d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxlistd1e2mi_id", 
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
                List<NpgsqlBoxboxListD1E2M> models = null;

                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxListD1E2M> models = null;

                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 127;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr2.Value = 47;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 148, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 12, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 141, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 134, query1, 150, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 26, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 152, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatch(connection, 61, 85))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models = await ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[18], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[19], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[20], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[21], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[22], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[23], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[24], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[25], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[26], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[27], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
FROM public.binary_npgsqlboxboxlistd1e2m m
LEFT JOIN public.binary_npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxListboxListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI), typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxListD1E2MI>();
                var models2 = new List<NpgsqlBoxboxListD1E2MI>();
                await ((INpgsqlBoxListboxListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MI>();
                var models2 = new List<NpgsqlBoxboxListD1E2MI>();
                ((INpgsqlBoxListboxListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

