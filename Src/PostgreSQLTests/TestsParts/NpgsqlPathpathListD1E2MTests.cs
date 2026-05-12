

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
    internal partial interface INpgsqlPathListpathListD1
    {
    }
    
    internal partial class NpgsqlPathListpathListD1 : INpgsqlPathListpathListD1
    {


#region TestData

        private readonly NpgsqlPathpathListD1E2M[] _testData = new NpgsqlPathpathListD1E2M[]
        {
            new NpgsqlPathpathListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4922758648677307d, y: 0.931834286363516d), new NpgsqlTypes.NpgsqlPoint(x: 0.24337286724695673d, y: 0.40007328911291407d), new NpgsqlTypes.NpgsqlPoint(x: 0.13186484473014792d, y: 0.6343427150678707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.933362309821393d, y: 0.495725599549212d), new NpgsqlTypes.NpgsqlPoint(x: 0.7918241809061689d, y: 0.6691501381392186d), new NpgsqlTypes.NpgsqlPoint(x: 0.398627901010306d, y: 0.5000795913532203d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10338297122278683d, y: 0.5680298589597275d), new NpgsqlTypes.NpgsqlPoint(x: 0.2688901872242936d, y: 0.19782601138873734d), new NpgsqlTypes.NpgsqlPoint(x: 0.15867234839049393d, y: 0.9930705755483995d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.594318753956926d, y: 0.04553397429610295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273620671707341d, y: 0.41658574372300106d), new NpgsqlTypes.NpgsqlPoint(x: 0.19161735613477093d, y: 0.6902688319452659d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20560981294985026d, y: 0.4454699988761732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299986482087254d, y: 0.07380028640135328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417380245750624d, y: 0.4157055859907579d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17475558228914723d, y: 0.5377911566938433d), new NpgsqlTypes.NpgsqlPoint(x: 0.23445403082683136d, y: 0.9564384670148843d), new NpgsqlTypes.NpgsqlPoint(x: 0.004030199457941586d, y: 0.4903246762146518d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7068527418778661d, y: 0.06198896580807045d), new NpgsqlTypes.NpgsqlPoint(x: 0.46479261786493764d, y: 0.9904180107628631d), new NpgsqlTypes.NpgsqlPoint(x: 0.13582595252967988d, y: 0.9335626430521831d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3978306215007441d, y: 0.681187058631243d), new NpgsqlTypes.NpgsqlPoint(x: 0.20036691710278043d, y: 0.9105941942923615d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183119670617399d, y: 0.11837976445280274d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9661216580000335d, y: 0.7033515000976839d), new NpgsqlTypes.NpgsqlPoint(x: 0.5893736724496846d, y: 0.9917744766823632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7072565843440416d, y: 0.5971483641182205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05943506891716566d, y: 0.6155458746223864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5029512092518514d, y: 0.374711919516003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5833647785037666d, y: 0.7956842490982866d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1310495445089941d, y: 0.5831908733914715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795774491616117d, y: 0.7223947637073851d), new NpgsqlTypes.NpgsqlPoint(x: 0.17525671665988063d, y: 0.010624703922608836d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.634678367224162d, y: 0.5370209155457704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7176747872057491d, y: 0.7155550415237718d), new NpgsqlTypes.NpgsqlPoint(x: 0.14073235411998553d, y: 0.5178249082220437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8742055928567952d, y: 0.8524049413419865d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132847395124805d, y: 0.5027117948409862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6655378079749144d, y: 0.5560466494491505d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9958113881250028d, y: 0.4319253684723352d), new NpgsqlTypes.NpgsqlPoint(x: 0.09450639920339698d, y: 0.537877955039569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256682293307141d, y: 0.21147442312896492d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7798353571104907d, y: 0.8863910331836925d), new NpgsqlTypes.NpgsqlPoint(x: 0.5061398162644246d, y: 0.6591584754076506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028596515271562d, y: 0.5528795453163781d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6536147508265303d, y: 0.2666084791141252d), new NpgsqlTypes.NpgsqlPoint(x: 0.21669787750992953d, y: 0.4253903918166795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489034222527765d, y: 0.45220281579750565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43704779679343086d, y: 0.36512494852427146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4081373216488673d, y: 0.353449784932818d), new NpgsqlTypes.NpgsqlPoint(x: 0.052575641626721126d, y: 0.5690489125666139d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12149398639165132d, y: 0.19957206464354038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169448787102534d, y: 0.867913472562221d), new NpgsqlTypes.NpgsqlPoint(x: 0.43411901580942736d, y: 0.9093710328185624d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7274649173646998d, y: 0.8894238444459436d), new NpgsqlTypes.NpgsqlPoint(x: 0.7386863552990873d, y: 0.09352502275346608d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136819277553498d, y: 0.3803248062569511d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8522131640469971d, y: 0.3676499283070753d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324303804653901d, y: 0.43766303693505537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8004736592009055d, y: 0.033532913354588745d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20325841528900868d, y: 0.9421270778588999d), new NpgsqlTypes.NpgsqlPoint(x: 0.3131783013978454d, y: 0.16924255619730955d), new NpgsqlTypes.NpgsqlPoint(x: 0.12843896468413307d, y: 0.09538859540585887d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8478637155405578d, y: 0.06587920169319883d), new NpgsqlTypes.NpgsqlPoint(x: 0.48575482976673223d, y: 0.46748657488427425d), new NpgsqlTypes.NpgsqlPoint(x: 0.909320623807599d, y: 0.3370949526388898d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055026940497791d, y: 0.36411399650022513d), new NpgsqlTypes.NpgsqlPoint(x: 0.675357481162728d, y: 0.46664298771557045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191712232947634d, y: 0.7859255376118885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.964776101480932d, y: 0.21298365499815208d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535500296236075d, y: 0.23534684926428684d), new NpgsqlTypes.NpgsqlPoint(x: 0.3081626977080635d, y: 0.12981227747932733d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6458395061220362d, y: 0.765408386995662d), new NpgsqlTypes.NpgsqlPoint(x: 0.961724562661553d, y: 0.9123437184272686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6837418958330296d, y: 0.3985129390490003d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8915009125483224d, y: 0.026677045171897618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8565012534218328d, y: 0.8581622009405144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5009926147589004d, y: 0.9119149381832131d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25619744469128103d, y: 0.8401057175618033d), new NpgsqlTypes.NpgsqlPoint(x: 0.787777583919393d, y: 0.9388913748380548d), new NpgsqlTypes.NpgsqlPoint(x: 0.22022389617635862d, y: 0.5566431636282687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9765087129730713d, y: 0.051835767914267916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869092476887846d, y: 0.42830643349098607d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353380408683771d, y: 0.9677145292387247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3066576117855875d, y: 0.5887748454224944d), new NpgsqlTypes.NpgsqlPoint(x: 0.012055558156322088d, y: 0.191340972077232d), new NpgsqlTypes.NpgsqlPoint(x: 0.3200252296551176d, y: 0.19653236428398202d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6893673611066785d, y: 0.4067874346655812d), new NpgsqlTypes.NpgsqlPoint(x: 0.928123921735565d, y: 0.14754276236454367d), new NpgsqlTypes.NpgsqlPoint(x: 0.4252792606790976d, y: 0.510289089305704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8747079130508579d, y: 0.38885013827670567d), new NpgsqlTypes.NpgsqlPoint(x: 0.6145319928354337d, y: 0.16351088607841613d), new NpgsqlTypes.NpgsqlPoint(x: 0.650916526066898d, y: 0.8747802541205336d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40571406608448346d, y: 0.4415442562262901d), new NpgsqlTypes.NpgsqlPoint(x: 0.33770573087751765d, y: 0.088198215636488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7187416826818629d, y: 0.019107557845377987d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7832053182712723d, y: 0.8593337595802644d), new NpgsqlTypes.NpgsqlPoint(x: 0.17327018196455568d, y: 0.5002693657206481d), new NpgsqlTypes.NpgsqlPoint(x: 0.47462616619614484d, y: 0.2992122309015981d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39218726118171265d, y: 0.006619010575132922d), new NpgsqlTypes.NpgsqlPoint(x: 0.7812439388688233d, y: 0.47429654675823585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5894608817691808d, y: 0.698593294152457d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4661545143099527d, y: 0.27088250910641865d), new NpgsqlTypes.NpgsqlPoint(x: 0.40947734576083494d, y: 0.2731958763716327d), new NpgsqlTypes.NpgsqlPoint(x: 0.1829361967234342d, y: 0.6137414077127398d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5115642388610071d, y: 0.3058194997907784d), new NpgsqlTypes.NpgsqlPoint(x: 0.008588029374305028d, y: 0.1862650355265203d), new NpgsqlTypes.NpgsqlPoint(x: 0.10744483404373473d, y: 0.3281089933423602d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2603078251899419d, y: 0.35181491155559685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4327285563665868d, y: 0.47341297044034736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243344937523384d, y: 0.05542714913027347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7122779981015581d, y: 0.08181014775542528d), new NpgsqlTypes.NpgsqlPoint(x: 0.3779857081445732d, y: 0.9747182306950861d), new NpgsqlTypes.NpgsqlPoint(x: 0.4452058026331176d, y: 0.12301276914820425d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9168660652257193d, y: 0.7267753261974532d), new NpgsqlTypes.NpgsqlPoint(x: 0.06832642883791318d, y: 0.31992275343762366d), new NpgsqlTypes.NpgsqlPoint(x: 0.0732132744259113d, y: 0.14492812408880684d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7196859230861038d, y: 0.630878386763898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110241296588394d, y: 0.8779764747315871d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062831250257754d, y: 0.42337726372987405d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3853866272042763d, y: 0.04867934158203968d), new NpgsqlTypes.NpgsqlPoint(x: 0.05388736712818454d, y: 0.780112810040723d), new NpgsqlTypes.NpgsqlPoint(x: 0.11802929836109965d, y: 0.7309106133074436d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5387747774954065d, y: 0.443290221700003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7659196397071999d, y: 0.27155064121895256d), new NpgsqlTypes.NpgsqlPoint(x: 0.015229001134913434d, y: 0.9772937942836512d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4801176810725424d, y: 0.559998772477384d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566513403867535d, y: 0.780278373051284d), new NpgsqlTypes.NpgsqlPoint(x: 0.38333433864584177d, y: 0.9794762493519282d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9203591351829534d, y: 0.8023633007660516d), new NpgsqlTypes.NpgsqlPoint(x: 0.34152827280365305d, y: 0.19601964910667724d), new NpgsqlTypes.NpgsqlPoint(x: 0.890033137257458d, y: 0.05611901582306944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9327045530120399d, y: 0.7843314771018491d), new NpgsqlTypes.NpgsqlPoint(x: 0.1988092135466475d, y: 0.7369277431090372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9921591957176712d, y: 0.028257707532117537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6289729359363286d, y: 0.9203104464079218d), new NpgsqlTypes.NpgsqlPoint(x: 0.07509179436984881d, y: 0.29226308623959896d), new NpgsqlTypes.NpgsqlPoint(x: 0.4694334135592255d, y: 0.021432247937258952d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3807682086007387d, y: 0.21765989568556832d), new NpgsqlTypes.NpgsqlPoint(x: 0.1881194299191954d, y: 0.7994475005105776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785576626759318d, y: 0.6135733967312691d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6581506110610041d, y: 0.7151051166558d), new NpgsqlTypes.NpgsqlPoint(x: 0.12480217172011376d, y: 0.2809977739617108d), new NpgsqlTypes.NpgsqlPoint(x: 0.8299338407016127d, y: 0.1527560061734854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6029156398655264d, y: 0.6641226439320432d), new NpgsqlTypes.NpgsqlPoint(x: 0.055733589796424954d, y: 0.7351471143584398d), new NpgsqlTypes.NpgsqlPoint(x: 0.05761995119630692d, y: 0.6154574656953681d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24598152416839536d, y: 0.2925028570839969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5736014478135515d, y: 0.4169926663219703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302319571261642d, y: 0.6849310465931703d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8495040607744094d, y: 0.8311483102252591d), new NpgsqlTypes.NpgsqlPoint(x: 0.6714139366882763d, y: 0.4338133613994184d), new NpgsqlTypes.NpgsqlPoint(x: 0.22946580222670931d, y: 0.9603284370639641d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049791022326706735d, y: 0.5047778949409758d), new NpgsqlTypes.NpgsqlPoint(x: 0.6213611815996652d, y: 0.06775109254346223d), new NpgsqlTypes.NpgsqlPoint(x: 0.2613064790415297d, y: 0.46575403096413137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.818246829165504d, y: 0.6237653844762954d), new NpgsqlTypes.NpgsqlPoint(x: 0.3962589187043909d, y: 0.8989938464473131d), new NpgsqlTypes.NpgsqlPoint(x: 0.35976320758173863d, y: 0.7172907975500954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1604305317596041d, y: 0.14763476470186532d), new NpgsqlTypes.NpgsqlPoint(x: 0.14253249382060995d, y: 0.3147375977211543d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469276211426234d, y: 0.6898883234882625d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8156451959222852d, y: 0.7139960998128203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9043888506001243d, y: 0.163596777256534d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026172307695463d, y: 0.44740638813776934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8473673388139297d, y: 0.17423908495775764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8698530535335116d, y: 0.565858971525814d), new NpgsqlTypes.NpgsqlPoint(x: 0.09008821781562426d, y: 0.9592350793444813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2530985328665384d, y: 0.37166312554341463d), new NpgsqlTypes.NpgsqlPoint(x: 0.1494901186731632d, y: 0.9234215979675993d), new NpgsqlTypes.NpgsqlPoint(x: 0.723403178220217d, y: 0.34773677352944743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8112148918748728d, y: 0.0010534238979948984d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864698313692287d, y: 0.12527405218167242d), new NpgsqlTypes.NpgsqlPoint(x: 0.40237521764284656d, y: 0.6553474014715415d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3665105950166295d, y: 0.8735931130858802d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578398687268223d, y: 0.5475688307640301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8596277886113195d, y: 0.274259009658836d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48096284225673336d, y: 0.2943844694406972d), new NpgsqlTypes.NpgsqlPoint(x: 0.4944998528724863d, y: 0.3032587073806987d), new NpgsqlTypes.NpgsqlPoint(x: 0.4197966934391356d, y: 0.02506055337044566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8093361451312753d, y: 0.5550301792364709d), new NpgsqlTypes.NpgsqlPoint(x: 0.9883035615792606d, y: 0.11303928965610488d), new NpgsqlTypes.NpgsqlPoint(x: 0.781532151019152d, y: 0.0803428653287328d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12736970763271627d, y: 0.744360117567393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5003177323069476d, y: 0.005683922274267061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7173820204800175d, y: 0.03423379763470624d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7816873837062299d, y: 0.3797129807878983d), new NpgsqlTypes.NpgsqlPoint(x: 0.02913349948337518d, y: 0.45295233654028644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7310038926177035d, y: 0.22907999042587024d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.032108236312784144d, y: 0.07968789629027218d), new NpgsqlTypes.NpgsqlPoint(x: 0.18774709069681916d, y: 0.7099674624349596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7164596856216504d, y: 0.4390481533013604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37531395531950085d, y: 0.47274485136981304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9398837247592846d, y: 0.16509059898543366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5067078503253807d, y: 0.9409243794879647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7909928596303221d, y: 0.8919183496814511d), new NpgsqlTypes.NpgsqlPoint(x: 0.4053143662563635d, y: 0.7015271614979777d), new NpgsqlTypes.NpgsqlPoint(x: 0.34279206501562376d, y: 0.9740009807748952d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.694290542447186d, y: 0.04808653104651428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270427244033211d, y: 0.17975517953846887d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361495499346571d, y: 0.914028325925667d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3985040327193181d, y: 0.7560548290236851d), new NpgsqlTypes.NpgsqlPoint(x: 0.7323226079920421d, y: 0.8340769667532698d), new NpgsqlTypes.NpgsqlPoint(x: 0.2894171999335199d, y: 0.3753741206320943d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5187543663251379d, y: 0.4127114756047795d), new NpgsqlTypes.NpgsqlPoint(x: 0.16429180548798816d, y: 0.4846489387213151d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337864815924807d, y: 0.9514733166623505d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32215709287023864d, y: 0.10854324448943764d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165526282220475d, y: 0.21504686917585103d), new NpgsqlTypes.NpgsqlPoint(x: 0.1789298781452009d, y: 0.5356332183200292d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16655733989834398d, y: 0.11199643677508253d), new NpgsqlTypes.NpgsqlPoint(x: 0.656813055261143d, y: 0.6101587897749922d), new NpgsqlTypes.NpgsqlPoint(x: 0.27528391397108654d, y: 0.7034939566218019d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7684127216149049d, y: 0.8495356766069034d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525731963620602d, y: 0.862393218774884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9998523381321818d, y: 0.6240753331480472d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8022841548221022d, y: 0.33029429190195847d), new NpgsqlTypes.NpgsqlPoint(x: 0.17558013410293205d, y: 0.4717462689125367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5961701447303319d, y: 0.12214337091331073d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19654936435975312d, y: 0.7220741762037529d), new NpgsqlTypes.NpgsqlPoint(x: 0.22207332314852735d, y: 0.02399123932823022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8320186337843537d, y: 0.03906300953375563d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5190902374545672d, y: 0.8800162753660682d), new NpgsqlTypes.NpgsqlPoint(x: 0.07305509286395495d, y: 0.629175446198156d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966593471373904d, y: 0.5786314988474908d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6449953249140051d, y: 0.2737343420559861d), new NpgsqlTypes.NpgsqlPoint(x: 0.2667070210331537d, y: 0.9454312589493479d), new NpgsqlTypes.NpgsqlPoint(x: 0.22879088066316866d, y: 0.8919780257704387d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2567025193270662d, y: 0.4860442828616185d), new NpgsqlTypes.NpgsqlPoint(x: 0.26277467757892636d, y: 0.13513200631264866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293931539394832d, y: 0.18765384236756977d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8212153399029782d, y: 0.5183097490285842d), new NpgsqlTypes.NpgsqlPoint(x: 0.5881769507338741d, y: 0.8916262994960049d), new NpgsqlTypes.NpgsqlPoint(x: 0.3703793373839992d, y: 0.44540681835272267d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.034155199683675974d, y: 0.7784205572021018d), new NpgsqlTypes.NpgsqlPoint(x: 0.2512901779169868d, y: 0.24874116199949703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610183980864926d, y: 0.1256836782189964d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41890379331618643d, y: 0.5208366249609165d), new NpgsqlTypes.NpgsqlPoint(x: 0.07120938738694726d, y: 0.1673275632247334d), new NpgsqlTypes.NpgsqlPoint(x: 0.3478412037006777d, y: 0.6647508578440132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8506091642361693d, y: 0.02203242369407299d), new NpgsqlTypes.NpgsqlPoint(x: 0.6012016613919575d, y: 0.6826244834751731d), new NpgsqlTypes.NpgsqlPoint(x: 0.7223520620745998d, y: 0.9409057344459589d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16211990284652822d, y: 0.8840741037215335d), new NpgsqlTypes.NpgsqlPoint(x: 0.584389484127657d, y: 0.8702277842718018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8607738270283491d, y: 0.05840561962584523d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.653485910582661d, y: 0.2879552787364358d), new NpgsqlTypes.NpgsqlPoint(x: 0.36754620375300917d, y: 0.6375706803180221d), new NpgsqlTypes.NpgsqlPoint(x: 0.039819534317542926d, y: 0.472895756277951d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.600868280473684d, y: 0.028072622888411503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9982719517696146d, y: 0.8862156146763903d), new NpgsqlTypes.NpgsqlPoint(x: 0.2858040564742982d, y: 0.5254452981691339d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09822474951563387d, y: 0.14109227968400984d), new NpgsqlTypes.NpgsqlPoint(x: 0.876981766175979d, y: 0.5083392149352062d), new NpgsqlTypes.NpgsqlPoint(x: 0.29237972327435846d, y: 0.3029276413151293d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7578623484520153d, y: 0.43945489236178026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3143386382081208d, y: 0.252532942585998d), new NpgsqlTypes.NpgsqlPoint(x: 0.39256126415811876d, y: 0.029084429252043464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20455502837348072d, y: 0.6128380830775477d), new NpgsqlTypes.NpgsqlPoint(x: 0.6547635706826836d, y: 0.9318239658389177d), new NpgsqlTypes.NpgsqlPoint(x: 0.18294195848790895d, y: 0.6763329962204462d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9170776520667498d, y: 0.27858382997782793d), new NpgsqlTypes.NpgsqlPoint(x: 0.11820788388635639d, y: 0.05082248092062869d), new NpgsqlTypes.NpgsqlPoint(x: 0.537493879192587d, y: 0.07481103493831565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.738198042844691d, y: 0.1090721546376342d), new NpgsqlTypes.NpgsqlPoint(x: 0.16218350306178253d, y: 0.4060411148045331d), new NpgsqlTypes.NpgsqlPoint(x: 0.05091343952028271d, y: 0.18848553612894192d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09082187827316457d, y: 0.8715518261112457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897419969130829d, y: 0.6189473852284407d), new NpgsqlTypes.NpgsqlPoint(x: 0.563322419670861d, y: 0.5258872281479092d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20611897644317023d, y: 0.9607006035462407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006393570488832d, y: 0.30336108933290495d), new NpgsqlTypes.NpgsqlPoint(x: 0.698996678205286d, y: 0.9658520717711351d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49923729559162777d, y: 0.36670270665189786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715976601948298d, y: 0.47158329982140457d), new NpgsqlTypes.NpgsqlPoint(x: 0.4216004663160976d, y: 0.08021512548231835d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8472250119919938d, y: 0.11264140103240161d), new NpgsqlTypes.NpgsqlPoint(x: 0.0026459441057277155d, y: 0.6160335587456816d), new NpgsqlTypes.NpgsqlPoint(x: 0.2921518742444016d, y: 0.1172070170514754d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6143576306420627d, y: 0.34272644488116655d), new NpgsqlTypes.NpgsqlPoint(x: 0.538449700667124d, y: 0.29506216828752163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481601737986464d, y: 0.49574169749374986d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9676289391390839d, y: 0.2242832216560664d), new NpgsqlTypes.NpgsqlPoint(x: 0.1265774536267027d, y: 0.944885219895829d), new NpgsqlTypes.NpgsqlPoint(x: 0.04565104326634828d, y: 0.510238839595347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.081055912341916d, y: 0.13269129517618128d), new NpgsqlTypes.NpgsqlPoint(x: 0.7697793975980178d, y: 0.8008134430620506d), new NpgsqlTypes.NpgsqlPoint(x: 0.13140924823498534d, y: 0.9596432843412093d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49250371712578234d, y: 0.9500596618349576d), new NpgsqlTypes.NpgsqlPoint(x: 0.06995868823692053d, y: 0.04604976244893855d), new NpgsqlTypes.NpgsqlPoint(x: 0.2203915761913452d, y: 0.0816304427831569d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8635118537667555d, y: 0.5029260370325958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6554291422491315d, y: 0.0893819452111212d), new NpgsqlTypes.NpgsqlPoint(x: 0.3411302024565738d, y: 0.9706330967700727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9283313284445036d, y: 0.18785852415726367d), new NpgsqlTypes.NpgsqlPoint(x: 0.37617156839371646d, y: 0.09977190591617902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151465777018855d, y: 0.6372627769814435d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41165918088505526d, y: 0.9463545911566823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505168585591303d, y: 0.6852762333257472d), new NpgsqlTypes.NpgsqlPoint(x: 0.3236775551022002d, y: 0.7779647374691686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21898557158863552d, y: 0.3490766208397811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373683229351476d, y: 0.9172088627194113d), new NpgsqlTypes.NpgsqlPoint(x: 0.07939220258472013d, y: 0.08093390117664523d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49462154735073327d, y: 0.40923720569611566d), new NpgsqlTypes.NpgsqlPoint(x: 0.011202802207553875d, y: 0.9002007542429169d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441684362554456d, y: 0.46875812542894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.553076342811409d, y: 0.4306729578229669d), new NpgsqlTypes.NpgsqlPoint(x: 0.09901550974354068d, y: 0.13358617038401144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6120901999697761d, y: 0.12664163140328044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9882029014971817d, y: 0.9672006988566204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262013332039839d, y: 0.8071992935247794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8108110456116537d, y: 0.07302494881768151d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35671168895648653d, y: 0.49883084858906523d), new NpgsqlTypes.NpgsqlPoint(x: 0.3395486932827839d, y: 0.3443110882546878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9181818524990162d, y: 0.9418791491682652d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5864606813695331d, y: 0.39830177964753644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8241897674248255d, y: 0.7679624967570365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3429397621542737d, y: 0.7170649568311356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5327119460095534d, y: 0.307682247638837d), new NpgsqlTypes.NpgsqlPoint(x: 0.1039777269760972d, y: 0.40683728358175364d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321028758864264d, y: 0.4829725909111172d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28223915113916676d, y: 0.3554961005536017d), new NpgsqlTypes.NpgsqlPoint(x: 0.4597251105543527d, y: 0.984058682836017d), new NpgsqlTypes.NpgsqlPoint(x: 0.1714569276012966d, y: 0.602602337767611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5463918595600072d, y: 0.08775314773933485d), new NpgsqlTypes.NpgsqlPoint(x: 0.42331590402797814d, y: 0.5606895219271253d), new NpgsqlTypes.NpgsqlPoint(x: 0.08264960745177785d, y: 0.01755587599888575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10095314220105522d, y: 0.9524563353773815d), new NpgsqlTypes.NpgsqlPoint(x: 0.7216469998801123d, y: 0.731612181192608d), new NpgsqlTypes.NpgsqlPoint(x: 0.4229785143839725d, y: 0.9029241490892528d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6615702924600777d, y: 0.9105910929054534d), new NpgsqlTypes.NpgsqlPoint(x: 0.9772974569942621d, y: 0.6011765497254008d), new NpgsqlTypes.NpgsqlPoint(x: 0.38626288314031165d, y: 0.5036510150490314d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4062487782515689d, y: 0.42052659408860193d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864968812454527d, y: 0.35379500108600215d), new NpgsqlTypes.NpgsqlPoint(x: 0.2705454818518068d, y: 0.6988831544587913d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6021947433575128d, y: 0.6081203883593757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6892360774169184d, y: 0.1992973947875354d), new NpgsqlTypes.NpgsqlPoint(x: 0.08229388012297323d, y: 0.496405593229734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43587161813757747d, y: 0.06302333258368842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4725104574238117d, y: 0.7021454981320423d), new NpgsqlTypes.NpgsqlPoint(x: 0.44928058521116654d, y: 0.13446740499091459d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31545562989561027d, y: 0.24581330430111537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5497750438505543d, y: 0.571853645147244d), new NpgsqlTypes.NpgsqlPoint(x: 0.23284876125685317d, y: 0.5136990294100735d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004815237300635933d, y: 0.5064028714289337d), new NpgsqlTypes.NpgsqlPoint(x: 0.49656821293428755d, y: 0.758197649592832d), new NpgsqlTypes.NpgsqlPoint(x: 0.3873399447485544d, y: 0.7799352416309131d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7735228698434681d, y: 0.04070039052280583d), new NpgsqlTypes.NpgsqlPoint(x: 2.8010063562677878E-05d, y: 0.1438312843027547d), new NpgsqlTypes.NpgsqlPoint(x: 0.3688124589729178d, y: 0.6598122140455767d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27864891194108665d, y: 0.9408802511139234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6642964436273263d, y: 0.24202988129445735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9880564659302534d, y: 0.4258375038842428d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5798839039137043d, y: 0.28232238377774155d), new NpgsqlTypes.NpgsqlPoint(x: 0.0413055276265345d, y: 0.12058740853892802d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972098363459087d, y: 0.9535681461864851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.706522095870054d, y: 0.3011283076873916d), new NpgsqlTypes.NpgsqlPoint(x: 0.20704883932437224d, y: 0.7162400293893069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8780456028127269d, y: 0.8677712904679632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.693090341035334d, y: 0.9998291493568515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5201484941575836d, y: 0.8279526790629502d), new NpgsqlTypes.NpgsqlPoint(x: 0.4145077245229324d, y: 0.5791882071937661d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21354174269366377d, y: 0.8106960039710115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447581565573833d, y: 0.6284621843928812d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701655324290978d, y: 0.2296121431334619d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5336234825136861d, y: 0.5196890249758938d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397520265494314d, y: 0.8212180562041091d), new NpgsqlTypes.NpgsqlPoint(x: 0.27976275221205615d, y: 0.3463360918937326d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26857958609172083d, y: 0.3678112342327847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304352211589199d, y: 0.8906573232346223d), new NpgsqlTypes.NpgsqlPoint(x: 0.16240928799534626d, y: 0.29903981270676916d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3908505144213471d, y: 0.47996341789409114d), new NpgsqlTypes.NpgsqlPoint(x: 0.06804847218326948d, y: 0.5276234275771138d), new NpgsqlTypes.NpgsqlPoint(x: 0.8290499124978375d, y: 0.12431500337564927d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.893578632389629d, y: 0.783867247445588d), new NpgsqlTypes.NpgsqlPoint(x: 0.17962689065442639d, y: 0.20671710589957992d), new NpgsqlTypes.NpgsqlPoint(x: 0.03698496434970211d, y: 0.9181494346909226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11331481028426371d, y: 0.1997133608332451d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566805922717208d, y: 0.3517738050007002d), new NpgsqlTypes.NpgsqlPoint(x: 0.3803690672068152d, y: 0.7334054771703993d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8096807944954645d, y: 0.2906919995729691d), new NpgsqlTypes.NpgsqlPoint(x: 0.09290732041529448d, y: 0.9581894673173634d), new NpgsqlTypes.NpgsqlPoint(x: 0.10477213092493232d, y: 0.7051085078758085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7453371194755306d, y: 0.2657058304488459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647851972075027d, y: 0.693746134162997d), new NpgsqlTypes.NpgsqlPoint(x: 0.16147180291243513d, y: 0.04392460493041861d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173053544450872d, y: 0.8979078129478959d), new NpgsqlTypes.NpgsqlPoint(x: 0.7880229003436897d, y: 0.8328949788612137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3261425184792526d, y: 0.16011258114083282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6140543800068177d, y: 0.1673712131134375d), new NpgsqlTypes.NpgsqlPoint(x: 0.23790520481038502d, y: 0.4140672197218783d), new NpgsqlTypes.NpgsqlPoint(x: 0.21998191168246983d, y: 0.5070951435191724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021559770544554935d, y: 0.5217842429778581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906027368234276d, y: 0.026680209404026378d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475591454401002d, y: 0.8041430914013703d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3107756895860946d, y: 0.9239699871562261d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118524310766131d, y: 0.7968034670515377d), new NpgsqlTypes.NpgsqlPoint(x: 0.2561835787522182d, y: 0.21877038632065104d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4218898008053762d, y: 0.9394331165282968d), new NpgsqlTypes.NpgsqlPoint(x: 0.10209236241723285d, y: 0.01072139985203524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5681443774523951d, y: 0.10466545191221888d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8442731358232461d, y: 0.09364790492077202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751959652585763d, y: 0.16720942412238005d), new NpgsqlTypes.NpgsqlPoint(x: 0.33625617664710106d, y: 0.46677544252290337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.784992740460516d, y: 0.40659806370783325d), new NpgsqlTypes.NpgsqlPoint(x: 0.29097843239649945d, y: 0.9234508940368863d), new NpgsqlTypes.NpgsqlPoint(x: 0.1320555457471887d, y: 0.032355193735407295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0904019891420782d, y: 0.009011864495954591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277635159941847d, y: 0.3503649511547535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9984038023956209d, y: 0.13485163589349325d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4980151154415532d, y: 0.5374399296563789d), new NpgsqlTypes.NpgsqlPoint(x: 0.034810363326357674d, y: 0.28068185666570056d), new NpgsqlTypes.NpgsqlPoint(x: 0.48631196988871983d, y: 0.7395965552893324d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32947554749919317d, y: 0.5589024161135691d), new NpgsqlTypes.NpgsqlPoint(x: 0.929521815997918d, y: 0.10311211906531659d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568647369802054d, y: 0.1505856183331834d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31540808584693103d, y: 0.24657321609681448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566029605107409d, y: 0.9303942915450658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973549298140089d, y: 0.32487018791859523d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4075754012693019d, y: 0.5380775387472138d), new NpgsqlTypes.NpgsqlPoint(x: 0.03415491439647689d, y: 0.48056783862840713d), new NpgsqlTypes.NpgsqlPoint(x: 0.6154099651456407d, y: 0.2198384677709938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8319950123646616d, y: 0.09229020837728874d), new NpgsqlTypes.NpgsqlPoint(x: 0.3465944856572105d, y: 0.22372686548931398d), new NpgsqlTypes.NpgsqlPoint(x: 0.6020201745943031d, y: 0.42206543719229694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19354933879246294d, y: 0.6727175643089124d), new NpgsqlTypes.NpgsqlPoint(x: 0.06974940310161581d, y: 0.7446944607512728d), new NpgsqlTypes.NpgsqlPoint(x: 0.24412045176190444d, y: 0.7922865605982433d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23580824081896268d, y: 0.717846928036401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796829419842144d, y: 0.1658157295268421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868603121640877d, y: 0.45972626181855947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2829459055154969d, y: 0.6364740930259937d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779584521948337d, y: 0.05817620630835352d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616435437119848d, y: 0.5154449804548011d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4123586046764386d, y: 0.06355323725088258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836941202860733d, y: 0.03240471066171935d), new NpgsqlTypes.NpgsqlPoint(x: 0.389846023208421d, y: 0.6020394286873141d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35783415528602613d, y: 0.3009416953234929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434231180591146d, y: 0.609704340374755d), new NpgsqlTypes.NpgsqlPoint(x: 0.929560738378713d, y: 0.2391458592873842d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.919278877827755d, y: 0.19793037100228184d), new NpgsqlTypes.NpgsqlPoint(x: 0.19470254429852485d, y: 0.3195136984364463d), new NpgsqlTypes.NpgsqlPoint(x: 0.16038330750819774d, y: 0.12959127094792355d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3939605071995207d, y: 0.2708044822138792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6928007130929481d, y: 0.5233128194966483d), new NpgsqlTypes.NpgsqlPoint(x: 0.42596184043924556d, y: 0.510642668923364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9909402495403448d, y: 0.06368834299508785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7058691042014208d, y: 0.309897847224047d), new NpgsqlTypes.NpgsqlPoint(x: 0.22752857800905024d, y: 0.02605207198969295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03172619603138893d, y: 0.9967727184942345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4244050882752335d, y: 0.4141857175270234d), new NpgsqlTypes.NpgsqlPoint(x: 0.7864913311370505d, y: 0.4207113936755206d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23770917944715575d, y: 0.18738942854551877d), new NpgsqlTypes.NpgsqlPoint(x: 0.027420750674790884d, y: 0.8028790678329683d), new NpgsqlTypes.NpgsqlPoint(x: 0.18101888181154435d, y: 0.03010408226513961d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6270056804555018d, y: 0.8939739916373496d), new NpgsqlTypes.NpgsqlPoint(x: 0.500332384500569d, y: 0.5594069566704306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8407032870538522d, y: 0.5005801413194383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17237810863941494d, y: 0.06042327904361011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5326019239432069d, y: 0.14254874081737112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8471450438876096d, y: 0.029168940545613364d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3813927932207587d, y: 0.997612884267895d), new NpgsqlTypes.NpgsqlPoint(x: 0.39811295636658517d, y: 0.3282357025650601d), new NpgsqlTypes.NpgsqlPoint(x: 0.10094810070782123d, y: 0.6127676489271033d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7627357367548452d, y: 0.3333962995194987d), new NpgsqlTypes.NpgsqlPoint(x: 0.560030832506681d, y: 0.784599607951388d), new NpgsqlTypes.NpgsqlPoint(x: 0.8695228586002302d, y: 0.5485824445562806d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30259360046981687d, y: 0.3528853683922354d), new NpgsqlTypes.NpgsqlPoint(x: 0.25946630347532196d, y: 0.7685552092936071d), new NpgsqlTypes.NpgsqlPoint(x: 0.18938812646194159d, y: 0.30891464043264505d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37270327815019544d, y: 0.17285350615570128d), new NpgsqlTypes.NpgsqlPoint(x: 0.31782076483945143d, y: 0.45323950434618654d), new NpgsqlTypes.NpgsqlPoint(x: 0.2579185313794573d, y: 0.1580104159505461d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.382770618962498d, y: 0.31647479613310303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356878751351537d, y: 0.8471226827248206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688884447417981d, y: 0.5737371327509992d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19707154964878082d, y: 0.4184483148254279d), new NpgsqlTypes.NpgsqlPoint(x: 0.1691770633103249d, y: 0.9760874781372034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511298039754911d, y: 0.2041288027068502d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3542103248624626d, y: 0.9726363215882251d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974273885108738d, y: 0.4137377993559149d), new NpgsqlTypes.NpgsqlPoint(x: 0.24338013009450998d, y: 0.12342372290448911d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6584904964961621d, y: 0.9757205925997203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485576053224139d, y: 0.6689378011731184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617216865397466d, y: 0.5055028583317274d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19355461340776015d, y: 0.2504790082917885d), new NpgsqlTypes.NpgsqlPoint(x: 0.038825688282203785d, y: 0.4957004008004343d), new NpgsqlTypes.NpgsqlPoint(x: 0.041233516929880976d, y: 0.8947815676784708d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5414124306469703d, y: 0.21440625492635124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8485045701528274d, y: 0.4225302404647501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5229096185883746d, y: 0.9774483093804466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4450498681600147d, y: 0.7306658601652535d), new NpgsqlTypes.NpgsqlPoint(x: 0.07930818415729146d, y: 0.8586033739034343d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003158264082006d, y: 0.08317265641817473d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41491383146745797d, y: 0.009423312517021998d), new NpgsqlTypes.NpgsqlPoint(x: 0.3827165280102336d, y: 0.9809470345461739d), new NpgsqlTypes.NpgsqlPoint(x: 0.03672307948388409d, y: 0.6916433423009313d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9536853394734841d, y: 0.13104161099723144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5562426772454439d, y: 0.8505798384306301d), new NpgsqlTypes.NpgsqlPoint(x: 0.531533116363613d, y: 0.491926028448739d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14875878296027067d, y: 0.057481937282742424d), new NpgsqlTypes.NpgsqlPoint(x: 0.339244089071008d, y: 0.7568797815509526d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619928887988769d, y: 0.11203146668397257d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2872481653972344d, y: 0.18585541485511325d), new NpgsqlTypes.NpgsqlPoint(x: 0.44305990939449436d, y: 0.3877024677807682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5951268824395303d, y: 0.5123750940724494d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5860798012376612d, y: 0.8069615017602805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982050897448903d, y: 0.2581338735909986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802160474173566d, y: 0.6860319618810776d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0709372691032778d, y: 0.9235437528839789d), new NpgsqlTypes.NpgsqlPoint(x: 0.35052452326161376d, y: 0.5800732561283023d), new NpgsqlTypes.NpgsqlPoint(x: 0.4437917472807945d, y: 0.15930344957044684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6889600322430924d, y: 0.3016038621668915d), new NpgsqlTypes.NpgsqlPoint(x: 0.1382992407368493d, y: 0.1210089450440559d), new NpgsqlTypes.NpgsqlPoint(x: 0.19211760605815953d, y: 0.13270292168003572d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7548228490045312d, y: 0.76584737525219d), new NpgsqlTypes.NpgsqlPoint(x: 0.03465811774981842d, y: 0.7241527685736412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6795802195794627d, y: 0.7412369220231376d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6893893721191079d, y: 0.8794835955205944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9811227703805189d, y: 0.560391823558578d), new NpgsqlTypes.NpgsqlPoint(x: 0.17819799048001117d, y: 0.7323698472310858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6588601713130141d, y: 0.05078240444388604d), new NpgsqlTypes.NpgsqlPoint(x: 0.6007811682396635d, y: 0.23125178294992732d), new NpgsqlTypes.NpgsqlPoint(x: 0.2618853160582223d, y: 0.5743633840227401d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44063456372331444d, y: 0.9119277897381151d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099636719975864d, y: 0.8359040231501571d), new NpgsqlTypes.NpgsqlPoint(x: 0.1905238576037518d, y: 0.6296144015802089d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3659047340835383d, y: 0.01490085819647713d), new NpgsqlTypes.NpgsqlPoint(x: 0.34361761262534085d, y: 0.40710036945411554d), new NpgsqlTypes.NpgsqlPoint(x: 0.674301784151154d, y: 0.3185589202022143d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6538758709290206d, y: 0.42575149798328005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5825680531099051d, y: 0.509400641631617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9467836533611592d, y: 0.522292805182422d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8615665381323305d, y: 0.8147526968901608d), new NpgsqlTypes.NpgsqlPoint(x: 0.39023195843051284d, y: 0.41598947553798504d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010515389409086d, y: 0.3003479992020064d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7397020120710153d, y: 0.07830963079291509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774775767642901d, y: 0.8056476027727909d), new NpgsqlTypes.NpgsqlPoint(x: 0.3433414162151506d, y: 0.9661529182790802d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8661034341543498d, y: 0.6879395109876261d), new NpgsqlTypes.NpgsqlPoint(x: 0.862407563236534d, y: 0.5055583325545194d), new NpgsqlTypes.NpgsqlPoint(x: 0.07507586999826132d, y: 0.2570090142525068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6962452512416722d, y: 0.6091787307283862d), new NpgsqlTypes.NpgsqlPoint(x: 0.92082195380781d, y: 0.7789084457759053d), new NpgsqlTypes.NpgsqlPoint(x: 0.4540732910141483d, y: 0.8335602031538843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111089517122743d, y: 0.08980133872810014d), new NpgsqlTypes.NpgsqlPoint(x: 0.31790670507804564d, y: 0.16568474280883705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624829378408812d, y: 0.2867980837134152d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8611816173846509d, y: 0.3719406265030283d), new NpgsqlTypes.NpgsqlPoint(x: 0.377015712083944d, y: 0.6318562450547467d), new NpgsqlTypes.NpgsqlPoint(x: 0.5208648311627146d, y: 0.3363141277863656d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8626312182570864d, y: 0.99216108380159d), new NpgsqlTypes.NpgsqlPoint(x: 0.08978243761709248d, y: 0.29078388606833094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8227049263253599d, y: 0.06340352298699903d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8426013671474656d, y: 0.8907427977420052d), new NpgsqlTypes.NpgsqlPoint(x: 0.11391155095877714d, y: 0.4682999631246637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7816990938399968d, y: 0.3967983270815718d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7596259874591541d, y: 0.3305316317018363d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457616218594216d, y: 0.022361835538720953d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199271537644035d, y: 0.679552219407809d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28893843415489207d, y: 0.0065773061027019075d), new NpgsqlTypes.NpgsqlPoint(x: 0.02782936449914497d, y: 0.6572539500467748d), new NpgsqlTypes.NpgsqlPoint(x: 0.6885012465131941d, y: 0.6183184897482145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5450302884816709d, y: 0.16304445819417746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9676415311909693d, y: 0.2874062524671107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136160291944164d, y: 0.6333414381988833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7454932888581688d, y: 0.7610297587603235d), new NpgsqlTypes.NpgsqlPoint(x: 0.11774238393058734d, y: 0.7243627935885208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760156682478703d, y: 0.25701777504924717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3740851407354676d, y: 0.536419046149356d), new NpgsqlTypes.NpgsqlPoint(x: 0.11597182083934454d, y: 0.8425933641618572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8711303518096005d, y: 0.5127352086444663d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05900285180763343d, y: 0.08623146546159233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286306529864017d, y: 0.20249411418698937d), new NpgsqlTypes.NpgsqlPoint(x: 0.703413040682351d, y: 0.37649037338635627d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38943395506554146d, y: 0.7296234069342956d), new NpgsqlTypes.NpgsqlPoint(x: 0.4963944002974606d, y: 0.34664702043080675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8851990129518212d, y: 0.43141562538118927d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9461992740364332d, y: 0.5185708381096705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7461466576106675d, y: 0.06877342062364566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157121247116108d, y: 0.5963459227596032d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1781114426672905d, y: 0.8729225305823001d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286727872112843d, y: 0.5935741134423379d), new NpgsqlTypes.NpgsqlPoint(x: 0.4030227842210712d, y: 0.954581002377271d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7871209558195184d, y: 0.14929851037393782d), new NpgsqlTypes.NpgsqlPoint(x: 0.4957768906476212d, y: 0.9735377727665047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849189707094615d, y: 0.8109746502722269d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4971185293139935d, y: 0.7628224697274062d), new NpgsqlTypes.NpgsqlPoint(x: 0.09053199704129d, y: 0.3266059715915324d), new NpgsqlTypes.NpgsqlPoint(x: 0.45477153586513064d, y: 0.9190740417818243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.974909214667977d, y: 0.5300963886375331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998797223288821d, y: 0.5719990908004581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5982868174671129d, y: 0.998139292953937d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7406651922490755d, y: 0.1994571388848323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8847985565798939d, y: 0.8390258937514992d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394141253539924d, y: 0.1888887747160405d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6203354339218363d, y: 0.861528172808335d), new NpgsqlTypes.NpgsqlPoint(x: 0.594759125176325d, y: 0.8239765729696907d), new NpgsqlTypes.NpgsqlPoint(x: 0.043448731536770535d, y: 0.9565465359358254d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025476640504235593d, y: 0.7032431594321605d), new NpgsqlTypes.NpgsqlPoint(x: 0.9818848252635373d, y: 0.9230597555382604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622058754541272d, y: 0.44116533865445606d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30246011456834987d, y: 0.7534146788565814d), new NpgsqlTypes.NpgsqlPoint(x: 0.24920209283740413d, y: 0.5534196766662262d), new NpgsqlTypes.NpgsqlPoint(x: 0.20773554521798643d, y: 0.10637771981471233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7061771367803524d, y: 0.8188251484056751d), new NpgsqlTypes.NpgsqlPoint(x: 0.4154102820116605d, y: 0.3965245898753835d), new NpgsqlTypes.NpgsqlPoint(x: 0.7572909302442627d, y: 0.061682048933662026d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8840837630529829d, y: 0.12417095124631594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3622276145770875d, y: 0.6404676390511148d), new NpgsqlTypes.NpgsqlPoint(x: 0.11868300110441465d, y: 0.969678864682467d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24619121705593172d, y: 0.4815733425806792d), new NpgsqlTypes.NpgsqlPoint(x: 0.3062315482435337d, y: 0.7678365817881873d), new NpgsqlTypes.NpgsqlPoint(x: 0.44104745260559364d, y: 0.6362927299583162d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4967102534137493d, y: 0.5510066834802607d), new NpgsqlTypes.NpgsqlPoint(x: 0.30642657887975666d, y: 0.5196782626389472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147024497149301d, y: 0.882225362199358d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4098251050443338d, y: 0.5360858517898242d), new NpgsqlTypes.NpgsqlPoint(x: 0.3764448676093882d, y: 0.9061861348550205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5210188717145385d, y: 0.1072046272050936d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2772785215477165d, y: 0.6382749596644752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5520790985614319d, y: 0.9683966503908366d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133870710432732d, y: 0.19782446091986705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8748684667913207d, y: 0.6042042892714352d), new NpgsqlTypes.NpgsqlPoint(x: 0.48168629817429287d, y: 0.19694527235531312d), new NpgsqlTypes.NpgsqlPoint(x: 0.33865279346349464d, y: 0.4864600414147535d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5587999476079546d, y: 0.7959260647577092d), new NpgsqlTypes.NpgsqlPoint(x: 0.15429975147289343d, y: 0.4095131468602595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8051829144800421d, y: 0.2870239748155321d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9889467921424174d, y: 0.6144786899077731d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853852342124982d, y: 0.7468305965135984d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157745026655006d, y: 0.006195443633446929d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19208617489146063d, y: 0.6615908725627869d), new NpgsqlTypes.NpgsqlPoint(x: 0.3672218357127317d, y: 0.34573142072636576d), new NpgsqlTypes.NpgsqlPoint(x: 0.829844163151204d, y: 0.5518244558779914d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12916651926621558d, y: 0.81572744256741d), new NpgsqlTypes.NpgsqlPoint(x: 0.34542044423954166d, y: 0.13335073498440675d), new NpgsqlTypes.NpgsqlPoint(x: 0.2291573826513621d, y: 0.4500441182533371d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18738817622976733d, y: 0.8624988904151739d), new NpgsqlTypes.NpgsqlPoint(x: 0.5947337639659825d, y: 0.7326313873338709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439369775921952d, y: 0.6595997986008905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8094737896154676d, y: 0.8137837788603229d), new NpgsqlTypes.NpgsqlPoint(x: 0.4351792643343423d, y: 0.5305011623368999d), new NpgsqlTypes.NpgsqlPoint(x: 0.38911229884434007d, y: 0.7831738959200135d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6351015398853249d, y: 0.31640246990673704d), new NpgsqlTypes.NpgsqlPoint(x: 0.18143282687263396d, y: 0.7370540496040422d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557342664761931d, y: 0.34807867417321803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8547837360905038d, y: 0.4558593243195692d), new NpgsqlTypes.NpgsqlPoint(x: 0.7386953928080845d, y: 0.28039367035392615d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914318543178689d, y: 0.5473495444388918d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611756600590977d, y: 0.20424374920855204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8712222602100814d, y: 0.8349995003247682d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587571607166864d, y: 0.8068102771778004d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33891516969133917d, y: 0.3971645379963177d), new NpgsqlTypes.NpgsqlPoint(x: 0.11889883885645525d, y: 0.48507560980315223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3213985985678499d, y: 0.764607414574656d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.817135569156363d, y: 0.2853110777984913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816536855974259d, y: 0.935766750680564d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290914363200499d, y: 0.864793007545405d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2727440322780529d, y: 0.12641945025551304d), new NpgsqlTypes.NpgsqlPoint(x: 0.4959541317046502d, y: 0.7902936441838764d), new NpgsqlTypes.NpgsqlPoint(x: 0.1110687761519974d, y: 0.4370861851650617d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6762958693622149d, y: 0.6016071879066448d), new NpgsqlTypes.NpgsqlPoint(x: 0.30121128231164473d, y: 0.4286869213339948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6175882907325475d, y: 0.14403895926870003d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40685310182116896d, y: 0.565227017462927d), new NpgsqlTypes.NpgsqlPoint(x: 0.18688195205199787d, y: 0.8414728536321497d), new NpgsqlTypes.NpgsqlPoint(x: 0.43215231086478545d, y: 0.9589276346565719d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6273298199368258d, y: 0.6563756039992032d), new NpgsqlTypes.NpgsqlPoint(x: 0.670682885907659d, y: 0.546330598170484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813282670388242d, y: 0.4448240818313085d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3306927004224145d, y: 0.7679502144761345d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223652977271758d, y: 0.8221339791436058d), new NpgsqlTypes.NpgsqlPoint(x: 0.3665444999375439d, y: 0.08622940047541294d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6998532155450644d, y: 0.3643171864271716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904444983158936d, y: 0.16675947487115095d), new NpgsqlTypes.NpgsqlPoint(x: 0.30154019139291643d, y: 0.6800037265384107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8284246030988912d, y: 0.30041580324881456d), new NpgsqlTypes.NpgsqlPoint(x: 0.28298149332532996d, y: 0.08847688285955035d), new NpgsqlTypes.NpgsqlPoint(x: 0.18477790926523296d, y: 0.7620271622133853d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5506967474412544d, y: 0.08495323757824869d), new NpgsqlTypes.NpgsqlPoint(x: 0.33072110188570136d, y: 0.923134085518529d), new NpgsqlTypes.NpgsqlPoint(x: 0.5561298677567009d, y: 0.05877247176883027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6723428806742776d, y: 0.1652581956898821d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227595455330686d, y: 0.5315698699004779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5631044918361808d, y: 0.41734689632938105d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8435899256078989d, y: 0.5337973269645041d), new NpgsqlTypes.NpgsqlPoint(x: 0.08851570760916827d, y: 0.5056958572412121d), new NpgsqlTypes.NpgsqlPoint(x: 0.1297779701588072d, y: 0.9992832666364081d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3229011842724171d, y: 0.3557389958807905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5328276311631165d, y: 0.6629680137375823d), new NpgsqlTypes.NpgsqlPoint(x: 0.04833424669149167d, y: 0.20953219802592304d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9462104635684342d, y: 0.4844593785059603d), new NpgsqlTypes.NpgsqlPoint(x: 0.38566400427824465d, y: 0.4568583956291754d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676046711784242d, y: 0.22273248003579194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09216317023228593d, y: 0.19124988807549725d), new NpgsqlTypes.NpgsqlPoint(x: 0.3312773883657847d, y: 0.3299037782278821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218347724562763d, y: 0.7107578474187611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2306544713822073d, y: 0.35068880070216246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465792141023643d, y: 0.5048437967587681d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439556937882627d, y: 0.7407780212133318d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7206081667047667d, y: 0.9973983684770712d), new NpgsqlTypes.NpgsqlPoint(x: 0.0844824759611269d, y: 0.40828161897240645d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608118951836423d, y: 0.053948749491499304d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7466731785401722d, y: 0.03961990612398458d), new NpgsqlTypes.NpgsqlPoint(x: 0.44991534221331875d, y: 0.10965681317506504d), new NpgsqlTypes.NpgsqlPoint(x: 0.8602317254030915d, y: 0.9810371552337148d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7154993222744819d, y: 0.41694123960109797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7645623293219702d, y: 0.9982184713682389d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026889607444178d, y: 0.6103425263722418d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8543609486259377d, y: 0.04381295032245203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447713367791697d, y: 0.34137646559232626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464878321468888d, y: 0.7131023647308087d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20834259127875776d, y: 0.9966948424329382d), new NpgsqlTypes.NpgsqlPoint(x: 0.10783241378666075d, y: 0.16525718274138423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5344984273654146d, y: 0.7413730568687154d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46651705128966137d, y: 0.9269178799091319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3152220124441023d, y: 0.9581040504796552d), new NpgsqlTypes.NpgsqlPoint(x: 0.4651606918474269d, y: 0.12337381377445877d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3002411115727228d, y: 0.9449876598802668d), new NpgsqlTypes.NpgsqlPoint(x: 0.6299832259850123d, y: 0.4633375035946862d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250074060221513d, y: 0.11287426757849361d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9881081004436636d, y: 0.6596256537173636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5890727306706861d, y: 0.4190681379000747d), new NpgsqlTypes.NpgsqlPoint(x: 0.2413331730843561d, y: 0.13936345169148012d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009232691403902149d, y: 0.7565754250299325d), new NpgsqlTypes.NpgsqlPoint(x: 0.7647101522980186d, y: 0.7051716749833639d), new NpgsqlTypes.NpgsqlPoint(x: 0.854860209276067d, y: 0.3921336655823954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7428153118394759d, y: 0.1259932568537312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335943219831883d, y: 0.7165323516552854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857933340308758d, y: 0.846516344854448d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8010527447774182d, y: 0.8239279660694276d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105360649734562d, y: 0.8037802151651077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6780252649130648d, y: 0.5820690558279598d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5736804421731675d, y: 0.8713789430574d), new NpgsqlTypes.NpgsqlPoint(x: 0.001988193555734541d, y: 0.856029444900088d), new NpgsqlTypes.NpgsqlPoint(x: 0.7740971410203328d, y: 0.6818648579916996d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4962566914157347d, y: 0.3824097941659488d), new NpgsqlTypes.NpgsqlPoint(x: 0.08784692925640902d, y: 0.27272432862445883d), new NpgsqlTypes.NpgsqlPoint(x: 0.8907697711015968d, y: 0.2503010093611132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3805475267684033d, y: 0.20141552812312258d), new NpgsqlTypes.NpgsqlPoint(x: 0.385529511038037d, y: 0.16213242918325876d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964812294339379d, y: 0.13666071584387396d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.752481923471996d, y: 0.6976520143038464d), new NpgsqlTypes.NpgsqlPoint(x: 0.57148162764963d, y: 0.9620472638857884d), new NpgsqlTypes.NpgsqlPoint(x: 0.4105951661285413d, y: 0.5023828918342403d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.796433299878946d, y: 0.4868817934204548d), new NpgsqlTypes.NpgsqlPoint(x: 0.611322720046311d, y: 0.2909389061930393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6462598585686001d, y: 0.16429388050143845d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4234517117741412d, y: 0.6749012460664366d), new NpgsqlTypes.NpgsqlPoint(x: 0.955427156811833d, y: 0.5797301384983682d), new NpgsqlTypes.NpgsqlPoint(x: 0.05293038691679497d, y: 0.1416480744924542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8250843888602711d, y: 0.12310045243535594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769037851196742d, y: 0.4403225775840214d), new NpgsqlTypes.NpgsqlPoint(x: 0.5751893507885295d, y: 0.9209673560600762d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.569927629776258d, y: 0.1879065342490609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9918734992157552d, y: 0.1198797429565499d), new NpgsqlTypes.NpgsqlPoint(x: 0.6695977467136014d, y: 0.7641128749346684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7590437092092611d, y: 0.7660860341921811d), new NpgsqlTypes.NpgsqlPoint(x: 0.35091455445926134d, y: 0.6075000134698841d), new NpgsqlTypes.NpgsqlPoint(x: 0.5610031910616339d, y: 0.5395871554052979d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44846657771016385d, y: 0.07210659954245047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401662225193374d, y: 0.7723553665293923d), new NpgsqlTypes.NpgsqlPoint(x: 0.1823058733789633d, y: 0.36981653932327785d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27774869378195577d, y: 0.4006097585107835d), new NpgsqlTypes.NpgsqlPoint(x: 0.48388732329870454d, y: 0.8443569969178049d), new NpgsqlTypes.NpgsqlPoint(x: 0.18804142111722288d, y: 0.9482948376421243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29581871453883735d, y: 0.40841457093327194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056020150789163d, y: 0.6258163929347264d), new NpgsqlTypes.NpgsqlPoint(x: 0.954605692139503d, y: 0.9823652198391052d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8201852575510765d, y: 0.4581044109198664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888752432227637d, y: 0.9085026041175893d), new NpgsqlTypes.NpgsqlPoint(x: 0.4608689045451728d, y: 0.00022964781383971733d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6107974198324385d, y: 0.45807081361170277d), new NpgsqlTypes.NpgsqlPoint(x: 0.466358607784656d, y: 0.25967546632835936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573461825469406d, y: 0.4163868509933448d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9150719358574296d, y: 0.7457710838699634d), new NpgsqlTypes.NpgsqlPoint(x: 0.7156969594963499d, y: 0.5840346420895155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6300051573791822d, y: 0.28671894977460755d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.490918658023643d, y: 0.6756408979755795d), new NpgsqlTypes.NpgsqlPoint(x: 0.39794892399096604d, y: 0.655230825863603d), new NpgsqlTypes.NpgsqlPoint(x: 0.05360882209620943d, y: 0.034815328825621994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9392490966056654d, y: 0.83371218509216d), new NpgsqlTypes.NpgsqlPoint(x: 0.36947284396565894d, y: 0.47944863450825403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8987664932086973d, y: 0.40690679694790466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9067490419847379d, y: 0.30140425700912243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6817313569947d, y: 0.02710292367204048d), new NpgsqlTypes.NpgsqlPoint(x: 0.3444834571337978d, y: 0.46404617470210663d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                List<NpgsqlPathpathListD1E2M> models = null;

                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathListD1E2M> models = null;

                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 151;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 104, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 88, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 76, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 11, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 157, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatch(connection, 26, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models = await ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models =  ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
FROM public.binary_npgsqlpathpathlistd1e2m m
LEFT JOIN public.binary_npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathListpathListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI), typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                await ((INpgsqlPathListpathListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                ((INpgsqlPathListpathListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

