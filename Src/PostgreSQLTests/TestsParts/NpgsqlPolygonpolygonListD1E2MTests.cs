

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
    internal partial interface INpgsqlPolygonListpolygonListD1
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonListD1 : INpgsqlPolygonListpolygonListD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonListD1E2M[] _testData = new NpgsqlPolygonpolygonListD1E2M[]
        {
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6957622801376935d, y: 0.9085672084970033d), new NpgsqlTypes.NpgsqlPoint(x: 0.45622129217526586d, y: 0.33214398437676784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8292850689086328d, y: 0.4395862559299233d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8494491523212149d, y: 0.35593808809186234d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843641713182651d, y: 0.05294319044756368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464627595876703d, y: 0.9181610628782906d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5935437645039857d, y: 0.5755311854038859d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352566167322208d, y: 0.17602660725614672d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298935476048875d, y: 0.6211827477246293d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5963631754126723d, y: 0.8460430538504742d), new NpgsqlTypes.NpgsqlPoint(x: 0.9397049544990177d, y: 0.31021864244319064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274535157630772d, y: 0.2663647709358562d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7729653886876753d, y: 0.43224650123449193d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011683645610584d, y: 0.17218768885152158d), new NpgsqlTypes.NpgsqlPoint(x: 0.04122487467467384d, y: 0.7563479587082012d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5568635037645109d, y: 0.3941027311654589d), new NpgsqlTypes.NpgsqlPoint(x: 0.5778605407192158d, y: 0.10855907156424771d), new NpgsqlTypes.NpgsqlPoint(x: 0.7690726125350628d, y: 0.42512559211009626d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09232087547455436d, y: 0.07977183658281461d), new NpgsqlTypes.NpgsqlPoint(x: 0.44231837192161283d, y: 0.5500432016469136d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475481386078241d, y: 0.437302671493371d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8047945842128154d, y: 0.061549066822434106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8033944361110185d, y: 0.2753395837854251d), new NpgsqlTypes.NpgsqlPoint(x: 0.2104633012786865d, y: 0.2542105619870778d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8250134842109474d, y: 0.5550297983502781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781776059354257d, y: 0.09229366365072145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3813311363092433d, y: 0.6012473778737194d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1947792515820127d, y: 0.8378150564619652d), new NpgsqlTypes.NpgsqlPoint(x: 0.06105182908276241d, y: 0.09395110784082095d), new NpgsqlTypes.NpgsqlPoint(x: 0.7334224686680184d, y: 0.9620551744536875d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9380958836334059d, y: 0.9235825323479823d), new NpgsqlTypes.NpgsqlPoint(x: 0.85295113142117d, y: 0.6438546463433356d), new NpgsqlTypes.NpgsqlPoint(x: 0.20771771191738087d, y: 0.333603600382268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5937558587100936d, y: 0.6584275605161537d), new NpgsqlTypes.NpgsqlPoint(x: 0.059944842624680694d, y: 0.22631459266024245d), new NpgsqlTypes.NpgsqlPoint(x: 0.3061439877360589d, y: 0.45093829724168477d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.777123738347458d, y: 0.7581616396475608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9421439286676243d, y: 0.6113552926261706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7603472364124818d, y: 0.6240004786258703d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.579247520796382d, y: 0.8725615558628911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6953791270228183d, y: 0.7873901185929434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9037829831365973d, y: 0.8293608305267443d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4596743165388363d, y: 0.45357603526339496d), new NpgsqlTypes.NpgsqlPoint(x: 0.3833034272428407d, y: 0.7902219220147173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9915009637670591d, y: 0.9525858736387396d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5157348696094606d, y: 0.07029423427205228d), new NpgsqlTypes.NpgsqlPoint(x: 0.2586009815564134d, y: 0.2543446033257054d), new NpgsqlTypes.NpgsqlPoint(x: 0.37170337473205717d, y: 0.72812904854311d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.539787261136068d, y: 0.34095428155437013d), new NpgsqlTypes.NpgsqlPoint(x: 0.2687426785145043d, y: 0.5307956102733881d), new NpgsqlTypes.NpgsqlPoint(x: 0.3708726136870807d, y: 0.6161490403677767d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5607137511934949d, y: 0.6845167635701328d), new NpgsqlTypes.NpgsqlPoint(x: 0.2177952338498833d, y: 0.5861611564141639d), new NpgsqlTypes.NpgsqlPoint(x: 0.21596401323053538d, y: 0.7740542694051799d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8294728634053673d, y: 0.8652155866041323d), new NpgsqlTypes.NpgsqlPoint(x: 0.010345686048416458d, y: 0.6748845944231611d), new NpgsqlTypes.NpgsqlPoint(x: 0.45123507150680975d, y: 0.06796170640616161d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8439452458283784d, y: 0.8314056063017831d), new NpgsqlTypes.NpgsqlPoint(x: 0.36909738309377105d, y: 0.18235277286050633d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341832547853596d, y: 0.3423004885921699d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48213824721926546d, y: 0.7154871457845761d), new NpgsqlTypes.NpgsqlPoint(x: 0.13923063936027436d, y: 0.8027004865002262d), new NpgsqlTypes.NpgsqlPoint(x: 0.16746608259249485d, y: 0.39564984564127215d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9344406449068094d, y: 0.8386195968624357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403354744390418d, y: 0.8288744233151127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5630149566608119d, y: 0.6322622721970539d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.933936434684046d, y: 0.794691180853757d), new NpgsqlTypes.NpgsqlPoint(x: 0.4396873534213568d, y: 0.2506375588813311d), new NpgsqlTypes.NpgsqlPoint(x: 0.298988345959707d, y: 0.871954271345468d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1327630736559433d, y: 0.10024500835388439d), new NpgsqlTypes.NpgsqlPoint(x: 0.24292644984730372d, y: 0.594982053689992d), new NpgsqlTypes.NpgsqlPoint(x: 0.06817319106311959d, y: 0.35775731490970974d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1762848230020858d, y: 0.46807130945477293d), new NpgsqlTypes.NpgsqlPoint(x: 0.16748708943337198d, y: 0.49079086052396437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5770236157227769d, y: 0.3911854445404531d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7396405469271421d, y: 0.40885223238794777d), new NpgsqlTypes.NpgsqlPoint(x: 0.82548125708694d, y: 0.3605419890627243d), new NpgsqlTypes.NpgsqlPoint(x: 0.16262207654198546d, y: 0.08592544835320626d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5026766968880562d, y: 0.6843772607628904d), new NpgsqlTypes.NpgsqlPoint(x: 0.21084919549350056d, y: 0.7161547320172789d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758090460102032d, y: 0.18016820204733364d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022068887876132703d, y: 0.25954825513054136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5525427522835835d, y: 0.04367954743423175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3683734018768835d, y: 0.17946948244889105d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13465175517587735d, y: 0.3431485059383417d), new NpgsqlTypes.NpgsqlPoint(x: 0.12462820648820583d, y: 0.5646465963291228d), new NpgsqlTypes.NpgsqlPoint(x: 0.31816528756037055d, y: 0.1638039221194557d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3181557969545249d, y: 0.27346342604249896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7693983109623191d, y: 0.6192832998082122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108101088822756d, y: 0.10806529752950489d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4904835921081644d, y: 0.6299306885782118d), new NpgsqlTypes.NpgsqlPoint(x: 0.0416000833471285d, y: 0.1484760274727347d), new NpgsqlTypes.NpgsqlPoint(x: 0.88428249840641d, y: 0.41069205268030573d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18314710031188586d, y: 0.2431947664279802d), new NpgsqlTypes.NpgsqlPoint(x: 0.41198049731098974d, y: 0.6692270396808522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3873004094633785d, y: 0.5511845975369012d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06062088545373423d, y: 0.6812647442437875d), new NpgsqlTypes.NpgsqlPoint(x: 0.49947754610031103d, y: 0.19399066060456882d), new NpgsqlTypes.NpgsqlPoint(x: 0.2415318595701419d, y: 0.13217882612658993d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9963280891684823d, y: 0.7619224299340185d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813236754138408d, y: 0.09860666029762499d), new NpgsqlTypes.NpgsqlPoint(x: 0.261790756468543d, y: 0.29468151742189175d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42430147380220273d, y: 0.7974251373312634d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559957107468146d, y: 0.7946102297152943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5188367080970591d, y: 0.7077744997799498d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7177883040865422d, y: 0.9716252768930891d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146927066020674d, y: 0.8373232327612041d), new NpgsqlTypes.NpgsqlPoint(x: 0.44359086524499913d, y: 0.7737415657812167d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9838755939359299d, y: 0.6053889584425434d), new NpgsqlTypes.NpgsqlPoint(x: 0.19894980606426538d, y: 0.5079173661598677d), new NpgsqlTypes.NpgsqlPoint(x: 0.582730575408954d, y: 0.07277206130405922d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24528846302904328d, y: 0.82674619277683d), new NpgsqlTypes.NpgsqlPoint(x: 0.06902654123951235d, y: 0.29998420142449567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307193883220989d, y: 0.07232084827662943d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5990317966500268d, y: 0.6984576280193694d), new NpgsqlTypes.NpgsqlPoint(x: 0.4662753335382298d, y: 0.5494623181770473d), new NpgsqlTypes.NpgsqlPoint(x: 0.07684096676974617d, y: 0.261756658953607d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5527154426584269d, y: 0.8203349520507965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164230467521358d, y: 0.7704280388230986d), new NpgsqlTypes.NpgsqlPoint(x: 0.37488153549974335d, y: 0.17625454395427298d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8762499892633774d, y: 0.2667817424570055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216322945899451d, y: 0.46624952726534163d), new NpgsqlTypes.NpgsqlPoint(x: 0.04466157173373675d, y: 0.4819297648205364d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3707199444355379d, y: 0.4626607787664603d), new NpgsqlTypes.NpgsqlPoint(x: 0.499947867710978d, y: 0.8398365462624384d), new NpgsqlTypes.NpgsqlPoint(x: 0.19825460346298662d, y: 0.30989687554518697d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4924487064175179d, y: 0.2704745768179936d), new NpgsqlTypes.NpgsqlPoint(x: 0.03453173088939254d, y: 0.3785037869374326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7480033721622046d, y: 0.23109458411292239d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8238794428557571d, y: 0.6428918242816285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136659622330928d, y: 0.40743267053549204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396738648076578d, y: 0.7573109590222292d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7846941253336766d, y: 0.4839497087505885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9756693494386728d, y: 0.6634400024631175d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899330986671372d, y: 0.6398690781817503d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7151656783620026d, y: 0.05699821405631911d), new NpgsqlTypes.NpgsqlPoint(x: 0.4000224094462743d, y: 0.0027434208669772087d), new NpgsqlTypes.NpgsqlPoint(x: 0.4658383163959048d, y: 0.1814237693321108d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6647283844147766d, y: 0.9723833055889173d), new NpgsqlTypes.NpgsqlPoint(x: 0.07994744078381988d, y: 0.09993595081928741d), new NpgsqlTypes.NpgsqlPoint(x: 0.007402425081987629d, y: 0.8994089114819988d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5305727123580951d, y: 0.19161718974670883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351227706730063d, y: 0.8249507244144815d), new NpgsqlTypes.NpgsqlPoint(x: 0.34537416016152434d, y: 0.9153647812553629d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8076315063459808d, y: 0.662471609794974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341226195229915d, y: 0.27423831537533605d), new NpgsqlTypes.NpgsqlPoint(x: 0.12429076006886919d, y: 0.5490666686516982d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37799634291374795d, y: 0.12499567573280779d), new NpgsqlTypes.NpgsqlPoint(x: 0.9333595154431641d, y: 0.7398320261607751d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572366311381265d, y: 0.17629659865444114d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5751271633094223d, y: 0.08302588482078832d), new NpgsqlTypes.NpgsqlPoint(x: 0.09523939418606464d, y: 0.3933255153820209d), new NpgsqlTypes.NpgsqlPoint(x: 0.026970100566160893d, y: 0.4532455930622501d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07018404243205167d, y: 0.5652870222808172d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872189950378561d, y: 0.5192332884466992d), new NpgsqlTypes.NpgsqlPoint(x: 0.3668517712181629d, y: 0.9113428079871195d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.863621745324704d, y: 0.27793372961978824d), new NpgsqlTypes.NpgsqlPoint(x: 0.552776367216648d, y: 0.9971489351353945d), new NpgsqlTypes.NpgsqlPoint(x: 0.918696747072937d, y: 0.7869848347296919d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8568028137352341d, y: 0.3115551484226716d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616377152078244d, y: 0.4488713517989066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734176540186205d, y: 0.7213424610785608d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24360378023122675d, y: 0.35098635905654685d), new NpgsqlTypes.NpgsqlPoint(x: 0.13743088447400253d, y: 0.5319607757248325d), new NpgsqlTypes.NpgsqlPoint(x: 0.41983373793195455d, y: 0.46265291763039884d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5165968025966782d, y: 0.5661325268527698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838279294395597d, y: 0.15413591216458178d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553890374945108d, y: 0.01100244624206892d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2718631759564246d, y: 0.24948203883943776d), new NpgsqlTypes.NpgsqlPoint(x: 0.855049178599553d, y: 0.3237298201219405d), new NpgsqlTypes.NpgsqlPoint(x: 0.7487043259320568d, y: 0.4239537113765911d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3111323379474136d, y: 0.8433228324212072d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373026357740395d, y: 0.5843191745593203d), new NpgsqlTypes.NpgsqlPoint(x: 0.6046063696289319d, y: 0.9708930987891998d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2719782658928581d, y: 0.9083034968259119d), new NpgsqlTypes.NpgsqlPoint(x: 0.46299433212170693d, y: 0.3269385697815601d), new NpgsqlTypes.NpgsqlPoint(x: 0.06956248145559196d, y: 0.14526897488656387d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7610987832894374d, y: 0.9196479491991535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922141890666954d, y: 0.09702411430911084d), new NpgsqlTypes.NpgsqlPoint(x: 0.41415560901176296d, y: 0.40988553153863294d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25553918404730036d, y: 0.12092684632942696d), new NpgsqlTypes.NpgsqlPoint(x: 0.20445960420675302d, y: 0.5009239578779422d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927322218320051d, y: 0.9314206201807406d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10400647705301214d, y: 0.17035513216024634d), new NpgsqlTypes.NpgsqlPoint(x: 0.017381647441599424d, y: 0.7684536362150424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7115793487254538d, y: 0.9013266769260321d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.930181373417922d, y: 0.12931727403000182d), new NpgsqlTypes.NpgsqlPoint(x: 0.17209479272037886d, y: 0.7534163894097533d), new NpgsqlTypes.NpgsqlPoint(x: 0.019490282725226127d, y: 0.8921459851826159d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37752233359124376d, y: 0.2441543639263719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569869921210697d, y: 0.015230783991683539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7789923775137902d, y: 0.9892966149081015d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8221162924381006d, y: 0.7494560739280491d), new NpgsqlTypes.NpgsqlPoint(x: 0.3005614778635908d, y: 0.22616640777655206d), new NpgsqlTypes.NpgsqlPoint(x: 0.2664868625733757d, y: 0.34678450909473624d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8571495098104109d, y: 0.007859722690628845d), new NpgsqlTypes.NpgsqlPoint(x: 0.612352239545889d, y: 0.3889450213722705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7797384339692287d, y: 0.5806417800442769d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27367576269064575d, y: 0.28705586849742926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7405632671024938d, y: 0.2961821705478134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5269123477340232d, y: 0.5832567234282692d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7011883240561015d, y: 0.38383662288837506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5904646316544336d, y: 0.586929685123551d), new NpgsqlTypes.NpgsqlPoint(x: 0.9089536221786432d, y: 0.7389181081570528d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2509825167221714d, y: 0.2718736758133763d), new NpgsqlTypes.NpgsqlPoint(x: 0.4686717199362326d, y: 0.3237637788468296d), new NpgsqlTypes.NpgsqlPoint(x: 0.45334705905397354d, y: 0.046522529334621754d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.029877903064538747d, y: 0.20711541374438835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962293942833967d, y: 0.46604474125871387d), new NpgsqlTypes.NpgsqlPoint(x: 0.586324077729159d, y: 0.4196481069653325d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3671866295213261d, y: 0.9947833876494784d), new NpgsqlTypes.NpgsqlPoint(x: 0.049307086044795945d, y: 0.9205517867459039d), new NpgsqlTypes.NpgsqlPoint(x: 0.11203693814835103d, y: 0.5169944722287638d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7856109743715923d, y: 0.7394881405419623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273662438628486d, y: 0.01456742386156984d), new NpgsqlTypes.NpgsqlPoint(x: 0.31504441830277075d, y: 0.14832533949238325d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5751909606507228d, y: 0.7784672386740609d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521316739595283d, y: 0.5859966984473126d), new NpgsqlTypes.NpgsqlPoint(x: 0.818696937523156d, y: 0.36631161404110935d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7301462128692543d, y: 0.44879577061179177d), new NpgsqlTypes.NpgsqlPoint(x: 0.28846876358801454d, y: 0.48032917587324664d), new NpgsqlTypes.NpgsqlPoint(x: 0.10045824062407727d, y: 0.908218495130006d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6039889869088162d, y: 0.2377475054167928d), new NpgsqlTypes.NpgsqlPoint(x: 0.4782888314693653d, y: 0.8042087628408467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8384867845236291d, y: 0.9169264087204729d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.810182401444282d, y: 0.37899709839825024d), new NpgsqlTypes.NpgsqlPoint(x: 0.3637600255708705d, y: 0.0884410998212567d), new NpgsqlTypes.NpgsqlPoint(x: 0.3989853716427687d, y: 0.5321345421383078d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8235163384577489d, y: 0.02419138677903654d), new NpgsqlTypes.NpgsqlPoint(x: 0.36812770403412154d, y: 0.5165238519722954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829341035172932d, y: 0.2409190296835827d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39665088088637024d, y: 0.7479342278682034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6784832164026006d, y: 0.8400470258901998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980041541733117d, y: 0.9527835337411573d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.032259229073308915d, y: 0.46260048796166164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068214127505388d, y: 0.752502948624813d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123161294654563d, y: 0.6072613505998947d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5868207903687852d, y: 0.32744731189271925d), new NpgsqlTypes.NpgsqlPoint(x: 0.03460382216520197d, y: 0.7298771798547387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5893308386453091d, y: 0.727447810920497d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2531770165660556d, y: 0.9969147049222581d), new NpgsqlTypes.NpgsqlPoint(x: 0.1721264612727671d, y: 0.6964322211881914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077296466364059d, y: 0.449203895116155d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7689155767779106d, y: 0.43902038570483315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9044092051638775d, y: 0.3245062994825978d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214030045883414d, y: 0.46276840359146243d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6459869527900178d, y: 0.12877919185358155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013466277172101d, y: 0.5102940934435984d), new NpgsqlTypes.NpgsqlPoint(x: 0.7636471329141808d, y: 0.11510634150353749d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39895290894145663d, y: 0.5348949127436731d), new NpgsqlTypes.NpgsqlPoint(x: 0.37542732373812293d, y: 0.5020200371270744d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404129315043357d, y: 0.9698108176671351d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40206980397349323d, y: 0.4583070917543136d), new NpgsqlTypes.NpgsqlPoint(x: 0.40527631384218976d, y: 0.4293776319663787d), new NpgsqlTypes.NpgsqlPoint(x: 0.825149417663858d, y: 0.518306509318649d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8030174798900532d, y: 0.410435466831216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8365845941380504d, y: 0.0775887161379023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199771471617745d, y: 0.9811433171459853d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9014732253460026d, y: 0.42393829295142793d), new NpgsqlTypes.NpgsqlPoint(x: 0.24870448836594672d, y: 0.6136379217417093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924247409830117d, y: 0.5983997535333048d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4903493953249837d, y: 0.8709677839078885d), new NpgsqlTypes.NpgsqlPoint(x: 0.12126433680273874d, y: 0.7916642763193504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3798678313405548d, y: 0.07883938813840552d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.353325183598877d, y: 0.3740266597001374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638053829729902d, y: 0.29287650357257655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5072852632206659d, y: 0.006136722038054598d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22868417135600771d, y: 0.5562535163227115d), new NpgsqlTypes.NpgsqlPoint(x: 0.17662698365886487d, y: 0.5874049543143867d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019342590979503d, y: 0.49440976712954665d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7753029669252998d, y: 0.7244356662693262d), new NpgsqlTypes.NpgsqlPoint(x: 0.21932455876652823d, y: 0.9233509362816803d), new NpgsqlTypes.NpgsqlPoint(x: 0.24415370431359773d, y: 0.7894578383478945d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46681304135013657d, y: 0.5478909045840473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326978221987503d, y: 0.26624660882681983d), new NpgsqlTypes.NpgsqlPoint(x: 0.13548569401785748d, y: 0.5916497268595365d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6627637421778455d, y: 0.7016411327116385d), new NpgsqlTypes.NpgsqlPoint(x: 0.512462274003539d, y: 0.6081091028469104d), new NpgsqlTypes.NpgsqlPoint(x: 0.11797179068187635d, y: 0.09689934735370342d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6170904030436667d, y: 0.19903306233578455d), new NpgsqlTypes.NpgsqlPoint(x: 0.805752033960008d, y: 0.9650314964942615d), new NpgsqlTypes.NpgsqlPoint(x: 0.10319536444112787d, y: 0.9541223291582107d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40453027708975187d, y: 0.9471935894876441d), new NpgsqlTypes.NpgsqlPoint(x: 0.758050230489546d, y: 0.9025776894715436d), new NpgsqlTypes.NpgsqlPoint(x: 0.08275503381798777d, y: 0.03280807942584396d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9942995884530976d, y: 0.8180578266204513d), new NpgsqlTypes.NpgsqlPoint(x: 0.05310672807225858d, y: 0.8090386946386002d), new NpgsqlTypes.NpgsqlPoint(x: 0.11553823853709677d, y: 0.6505818594809368d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.387480288487691d, y: 0.41013215222634725d), new NpgsqlTypes.NpgsqlPoint(x: 0.1743442138765d, y: 0.09013198177728876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8170065403737296d, y: 0.08585315548792727d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.454890790221155d, y: 0.11012523040131661d), new NpgsqlTypes.NpgsqlPoint(x: 0.6312658492127394d, y: 0.4527109157069368d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994056541306171d, y: 0.8817096173927833d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2905038049096672d, y: 0.7105290712392829d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166568711101812d, y: 0.9222682853806983d), new NpgsqlTypes.NpgsqlPoint(x: 0.22035551550737797d, y: 0.8027641799138306d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4425045610840115d, y: 0.4586520731090996d), new NpgsqlTypes.NpgsqlPoint(x: 0.3586094528630257d, y: 0.08776241208985036d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520092132499837d, y: 0.6535842384410846d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36357914009330217d, y: 0.42813558447122024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5692009035357222d, y: 0.5127060868071893d), new NpgsqlTypes.NpgsqlPoint(x: 0.48074914058706997d, y: 0.7131449731962467d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5967720873662505d, y: 0.409039839944632d), new NpgsqlTypes.NpgsqlPoint(x: 0.5364922454930259d, y: 0.663748622868683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652724175889147d, y: 0.8334998575008379d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2670909775660032d, y: 0.0008431243014146439d), new NpgsqlTypes.NpgsqlPoint(x: 0.281342749987078d, y: 0.5532278419495543d), new NpgsqlTypes.NpgsqlPoint(x: 0.21947925403827295d, y: 0.8040939845576898d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2471761908363458d, y: 0.8341661712514493d), new NpgsqlTypes.NpgsqlPoint(x: 0.44899877632001584d, y: 0.16754169207619996d), new NpgsqlTypes.NpgsqlPoint(x: 0.09426638179840408d, y: 0.7979754181878957d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08476544124786978d, y: 0.061254356561102785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7380385482167637d, y: 0.3820226885874167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7689543758016365d, y: 0.6851723042946846d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9567559424345764d, y: 0.12319878549104868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7285787127392542d, y: 0.4184466855206779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535126049475317d, y: 0.13740176083370725d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9314301671301286d, y: 0.008057142378349647d), new NpgsqlTypes.NpgsqlPoint(x: 0.721773981634313d, y: 0.19370975183300398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5685840800013333d, y: 0.6807480744244077d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.922017685223686d, y: 0.7736058806646661d), new NpgsqlTypes.NpgsqlPoint(x: 0.1921547531374116d, y: 0.779323254386368d), new NpgsqlTypes.NpgsqlPoint(x: 0.10061147923680491d, y: 0.8611191330213865d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.837453732606608d, y: 0.5806891635141165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568982900186937d, y: 0.8277521310375552d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317277348759024d, y: 0.9510645796335145d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15039642336248116d, y: 0.764522379057504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6831742673647343d, y: 0.5890428191242386d), new NpgsqlTypes.NpgsqlPoint(x: 0.641872561404886d, y: 0.6928945367618294d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9706722623229761d, y: 0.2882786886083457d), new NpgsqlTypes.NpgsqlPoint(x: 0.4912969774514644d, y: 0.742692191496367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5305220808859994d, y: 0.8288439698387066d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01318693408229421d, y: 0.28478769414203287d), new NpgsqlTypes.NpgsqlPoint(x: 0.030325731912337894d, y: 0.5464188473287477d), new NpgsqlTypes.NpgsqlPoint(x: 0.06206331698229939d, y: 0.11158504731396501d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.700481775263075d, y: 0.8829787272009196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5555671572041588d, y: 0.8929046815728038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7119649462040644d, y: 0.2432543700247487d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2504139833060549d, y: 0.4545401518647848d), new NpgsqlTypes.NpgsqlPoint(x: 0.7146559988626638d, y: 0.6451438010482291d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319795188515202d, y: 0.5458761026241168d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5895136431159047d, y: 0.4004937454438048d), new NpgsqlTypes.NpgsqlPoint(x: 0.17899655651810087d, y: 0.7520017611845694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580935411067277d, y: 0.8986020291674485d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15054835307270198d, y: 0.5785539735129215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942375491381952d, y: 0.5892462650895381d), new NpgsqlTypes.NpgsqlPoint(x: 0.1250853271012241d, y: 0.1767088167982963d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14499665219412705d, y: 0.23511210168954422d), new NpgsqlTypes.NpgsqlPoint(x: 0.8375331194732217d, y: 0.8801934042968411d), new NpgsqlTypes.NpgsqlPoint(x: 0.7286039236656221d, y: 0.2653639957996967d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.921074663153967d, y: 0.05557288573381369d), new NpgsqlTypes.NpgsqlPoint(x: 0.8749937847006048d, y: 0.20526147532722938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527881353179658d, y: 0.9401423925503467d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44815723893128123d, y: 0.3084311984650323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8135241102099603d, y: 0.5856555165415248d), new NpgsqlTypes.NpgsqlPoint(x: 0.13987664159536617d, y: 0.9815639748526598d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07378350689230495d, y: 0.6710341806100437d), new NpgsqlTypes.NpgsqlPoint(x: 0.29670633193508d, y: 0.6054097200177042d), new NpgsqlTypes.NpgsqlPoint(x: 0.8931320760437118d, y: 0.8334717595051307d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6158837707657502d, y: 0.45923451658370973d), new NpgsqlTypes.NpgsqlPoint(x: 0.03234873464364463d, y: 0.6556408883984544d), new NpgsqlTypes.NpgsqlPoint(x: 0.2327205564091661d, y: 0.03443394341036188d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6049548679100266d, y: 0.15387408820021187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189207508855813d, y: 0.696530462422963d), new NpgsqlTypes.NpgsqlPoint(x: 0.30218415055536374d, y: 0.1991132471544148d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0162454501847884d, y: 0.4015622537547392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971251493574944d, y: 0.04030993969383356d), new NpgsqlTypes.NpgsqlPoint(x: 0.41165039309969687d, y: 0.8614535979712122d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9295706948395976d, y: 0.7496068196114971d), new NpgsqlTypes.NpgsqlPoint(x: 0.4208380868917534d, y: 0.5073764806885223d), new NpgsqlTypes.NpgsqlPoint(x: 0.030036119774401016d, y: 0.6790428970735725d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31909175870399586d, y: 0.7758503632638806d), new NpgsqlTypes.NpgsqlPoint(x: 0.345737645106726d, y: 0.5692058719924697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242980499786545d, y: 0.21422581396597073d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11200713003308305d, y: 0.4567175781505345d), new NpgsqlTypes.NpgsqlPoint(x: 0.2343792089015072d, y: 0.48408123583887697d), new NpgsqlTypes.NpgsqlPoint(x: 0.5229286988992914d, y: 0.2996734050770301d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43732101558451186d, y: 0.1624424685426581d), new NpgsqlTypes.NpgsqlPoint(x: 0.932701102834881d, y: 0.9338853965144449d), new NpgsqlTypes.NpgsqlPoint(x: 0.83220358350061d, y: 0.03143155298815259d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43229942088248696d, y: 0.8147220443629671d), new NpgsqlTypes.NpgsqlPoint(x: 0.027023340842025845d, y: 0.2443468724853498d), new NpgsqlTypes.NpgsqlPoint(x: 0.27525101460755064d, y: 0.2512353473596375d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26354709842434976d, y: 0.023188049935457977d), new NpgsqlTypes.NpgsqlPoint(x: 0.3410735857382279d, y: 0.21292905070091273d), new NpgsqlTypes.NpgsqlPoint(x: 0.3411285222529308d, y: 0.1434290102449236d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16513882301203742d, y: 0.7477119516659662d), new NpgsqlTypes.NpgsqlPoint(x: 0.029681742137027456d, y: 0.2519459876602844d), new NpgsqlTypes.NpgsqlPoint(x: 0.4721043314838891d, y: 0.23492215925197535d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15076089249628533d, y: 0.9152768410497791d), new NpgsqlTypes.NpgsqlPoint(x: 0.393406639790999d, y: 0.15616659599548377d), new NpgsqlTypes.NpgsqlPoint(x: 0.05471123213175899d, y: 0.34525365758721416d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9185878820911965d, y: 0.020161352203291516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1258322693550158d, y: 0.7681623536920225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172082743099081d, y: 0.6489412042750881d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9538940337762599d, y: 0.5842078551847748d), new NpgsqlTypes.NpgsqlPoint(x: 0.14969825895374256d, y: 0.21672825724120492d), new NpgsqlTypes.NpgsqlPoint(x: 0.21439627195901856d, y: 0.4535034024763278d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33422709509891246d, y: 0.8221783459272748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320897019687748d, y: 0.4075412704423286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6313287859627628d, y: 0.3681973309394272d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07826955056992868d, y: 0.8893240129432712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5582920798039748d, y: 0.5898832817016744d), new NpgsqlTypes.NpgsqlPoint(x: 0.10077699561085285d, y: 0.25689502465060565d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7756205472226283d, y: 0.40828874842002927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633111625427904d, y: 0.27360929419918834d), new NpgsqlTypes.NpgsqlPoint(x: 0.8973908052646025d, y: 0.8183116971180486d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2360593345896208d, y: 0.4190794964582071d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747184259084698d, y: 0.09663420574963244d), new NpgsqlTypes.NpgsqlPoint(x: 0.6450542566718666d, y: 0.19724048445170528d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9460495645235287d, y: 0.013939097365125774d), new NpgsqlTypes.NpgsqlPoint(x: 0.7603595270767413d, y: 0.9498518262065296d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605612801732794d, y: 0.8579530089342962d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9933379407361741d, y: 0.39063268187772593d), new NpgsqlTypes.NpgsqlPoint(x: 0.908151734377588d, y: 0.6063254582593929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499143945652492d, y: 0.034851286088068534d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8846806212871221d, y: 0.9004462396711159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262918745823281d, y: 0.22955897267525827d), new NpgsqlTypes.NpgsqlPoint(x: 0.12223342747682364d, y: 0.8916121703222143d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8317992594181228d, y: 0.8832660544705854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676476296738459d, y: 0.05162018079338315d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601022771222226d, y: 0.5951574749898412d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43005004380093104d, y: 0.5701682590919795d), new NpgsqlTypes.NpgsqlPoint(x: 0.2741775594190553d, y: 0.08728369035717998d), new NpgsqlTypes.NpgsqlPoint(x: 0.20681066120145009d, y: 0.43229606688861844d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48595615976074613d, y: 0.7979752627065404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9463006110008728d, y: 0.30686807501086255d), new NpgsqlTypes.NpgsqlPoint(x: 0.07488900318580072d, y: 0.9719924560621899d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7836653039432857d, y: 0.4170155340689293d), new NpgsqlTypes.NpgsqlPoint(x: 0.0747316766607019d, y: 0.16408139496293006d), new NpgsqlTypes.NpgsqlPoint(x: 0.12549795942085862d, y: 0.6215664846843538d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.404800672901661d, y: 0.8859908661698759d), new NpgsqlTypes.NpgsqlPoint(x: 0.8183599197359401d, y: 0.7814069463226768d), new NpgsqlTypes.NpgsqlPoint(x: 0.0861111052380541d, y: 0.990656849493287d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3481799088378862d, y: 0.1855907257561351d), new NpgsqlTypes.NpgsqlPoint(x: 0.7464264478088898d, y: 0.9992549462364316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592530094439668d, y: 0.5574793061594351d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45947605758088506d, y: 0.7224705188362615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788205904111208d, y: 0.6892630280668689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2905955383642008d, y: 0.49535375275010474d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8741135578135456d, y: 0.9117461404735939d), new NpgsqlTypes.NpgsqlPoint(x: 0.588665845082962d, y: 0.4450374037596616d), new NpgsqlTypes.NpgsqlPoint(x: 0.1754099897119621d, y: 0.0018270139803444607d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.563494540279766d, y: 0.1499486633198317d), new NpgsqlTypes.NpgsqlPoint(x: 0.64854141193425d, y: 0.29136915754148085d), new NpgsqlTypes.NpgsqlPoint(x: 0.318123810165436d, y: 0.15580346626039454d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7033031456292276d, y: 0.8511752365822828d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110648205885842d, y: 0.05755536965382735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8845367732328575d, y: 0.4958732662786496d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9399830231066835d, y: 0.6396687953660667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5863626932177878d, y: 0.931842297939199d), new NpgsqlTypes.NpgsqlPoint(x: 0.42382751865831125d, y: 0.15045611753498d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6019645957056922d, y: 0.1915334772318733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167798614058348d, y: 0.5248863481250993d), new NpgsqlTypes.NpgsqlPoint(x: 0.07691150994559015d, y: 0.754763879780296d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8370553101051819d, y: 0.03317208910327507d), new NpgsqlTypes.NpgsqlPoint(x: 0.740958451871823d, y: 0.2997368342854434d), new NpgsqlTypes.NpgsqlPoint(x: 0.17310652894395362d, y: 0.38276802519433384d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9255523072895222d, y: 0.42131043535012336d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677389574275837d, y: 0.6791428477133409d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325403022811492d, y: 0.5155040579142797d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6671926398767047d, y: 0.9217388873424202d), new NpgsqlTypes.NpgsqlPoint(x: 0.12381150350548875d, y: 0.8293129345017412d), new NpgsqlTypes.NpgsqlPoint(x: 0.2923579351305784d, y: 0.7185199531127897d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23842511258314503d, y: 0.3719417624256117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559264884577935d, y: 0.7795964914039236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078583556215224d, y: 0.19167483740091373d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.590017880995648d, y: 0.26611463022392223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084616878861131d, y: 0.6206384316491427d), new NpgsqlTypes.NpgsqlPoint(x: 0.707432069032048d, y: 0.47374090326786267d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5306899715214076d, y: 0.27613759947843697d), new NpgsqlTypes.NpgsqlPoint(x: 0.1418086191753667d, y: 0.9297713625515921d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417350635800287d, y: 0.21017282339858456d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6244323420071987d, y: 0.6020877227650022d), new NpgsqlTypes.NpgsqlPoint(x: 0.41169179101405373d, y: 0.23264044876142664d), new NpgsqlTypes.NpgsqlPoint(x: 0.5673042204392393d, y: 0.32762817087750506d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6182782054340293d, y: 0.10311856171519618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570359561282525d, y: 0.920782098466917d), new NpgsqlTypes.NpgsqlPoint(x: 0.09393607852265651d, y: 0.4952366480312599d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6656276280164579d, y: 0.30995238515545065d), new NpgsqlTypes.NpgsqlPoint(x: 0.44292734900112807d, y: 0.0012317794317866504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361126004207588d, y: 0.14085230949872085d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6660140835127618d, y: 0.916126852911312d), new NpgsqlTypes.NpgsqlPoint(x: 0.10031730814028483d, y: 0.9538240221246336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572912058276547d, y: 0.5955252026185244d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2747860574928048d, y: 0.5335128681918093d), new NpgsqlTypes.NpgsqlPoint(x: 0.3123487523006713d, y: 0.8576046161353289d), new NpgsqlTypes.NpgsqlPoint(x: 0.3836228083273432d, y: 0.8090250283896407d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10055305010945337d, y: 0.6309239064738597d), new NpgsqlTypes.NpgsqlPoint(x: 0.06800280433335593d, y: 0.3144943585588751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013985724232709d, y: 0.3433200482262815d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5171109315703937d, y: 0.278295903994925d), new NpgsqlTypes.NpgsqlPoint(x: 0.2518129535868896d, y: 0.493360748716723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554267694439316d, y: 0.7957511942105557d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7134157812347358d, y: 0.6635490086891489d), new NpgsqlTypes.NpgsqlPoint(x: 0.583822169812123d, y: 0.12363836740682521d), new NpgsqlTypes.NpgsqlPoint(x: 0.027706675230416478d, y: 0.19783455950349715d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14770227789294976d, y: 0.1206511334388477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9829165201252358d, y: 0.15532915229427202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7323403765071765d, y: 0.906619622677491d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45557942333584245d, y: 0.049321191566013556d), new NpgsqlTypes.NpgsqlPoint(x: 0.5801796125950746d, y: 0.7288407314567549d), new NpgsqlTypes.NpgsqlPoint(x: 0.689819030073473d, y: 0.8077784215899175d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008052500821392972d, y: 0.014442590177138892d), new NpgsqlTypes.NpgsqlPoint(x: 0.2793757382472758d, y: 0.8377686345969034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895964156721688d, y: 0.45454852200898277d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2751019678889708d, y: 0.07767580731818147d), new NpgsqlTypes.NpgsqlPoint(x: 0.2971938474189946d, y: 0.8055175204765813d), new NpgsqlTypes.NpgsqlPoint(x: 0.04119439255997648d, y: 0.3756215392546932d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25017603449914827d, y: 0.16466894598883175d), new NpgsqlTypes.NpgsqlPoint(x: 0.26099731505838175d, y: 0.7714119933200223d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627270258637402d, y: 0.6667893816760466d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8517579493612893d, y: 0.5963589055952035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831132631920241d, y: 0.1081688825682996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972014621880184d, y: 0.7919922786285578d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19914423462792963d, y: 0.24970391119774837d), new NpgsqlTypes.NpgsqlPoint(x: 0.4461274071959841d, y: 0.3512516527880746d), new NpgsqlTypes.NpgsqlPoint(x: 0.23285580302986175d, y: 0.8337679830980382d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28353261959520226d, y: 0.12657203349802326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6617569347155823d, y: 0.9790655128837497d), new NpgsqlTypes.NpgsqlPoint(x: 0.23155537264296744d, y: 0.6102994039158599d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39352825265358093d, y: 0.4721794662984885d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758282942882723d, y: 0.05078887200451643d), new NpgsqlTypes.NpgsqlPoint(x: 0.13890451822177485d, y: 0.5769077305690024d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3254922393980164d, y: 0.8073612926799751d), new NpgsqlTypes.NpgsqlPoint(x: 0.44691592830754334d, y: 0.002955766768258372d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333187145051124d, y: 0.8176266417665494d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5892448461786544d, y: 0.584086591672585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8081618601613355d, y: 0.44706753790934417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3719163679957729d, y: 0.3184742758863678d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3403129248873563d, y: 0.3345796386648191d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547309835975703d, y: 0.9633321642746941d), new NpgsqlTypes.NpgsqlPoint(x: 0.030387990108053264d, y: 0.829042287803046d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9607735559524859d, y: 0.4214294915448388d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115588003519023d, y: 0.6185867895314806d), new NpgsqlTypes.NpgsqlPoint(x: 0.38977563227429657d, y: 0.650533558104607d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28698361703981123d, y: 0.8965427067286748d), new NpgsqlTypes.NpgsqlPoint(x: 0.008827851414778931d, y: 0.9826818485186688d), new NpgsqlTypes.NpgsqlPoint(x: 0.19937667037310836d, y: 0.9829871469626378d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6794605239615134d, y: 0.3190591672221993d), new NpgsqlTypes.NpgsqlPoint(x: 0.26462292798305764d, y: 0.9403977941141658d), new NpgsqlTypes.NpgsqlPoint(x: 0.3453256113077835d, y: 0.41266655201889746d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008334297781307232d, y: 0.5985665231533203d), new NpgsqlTypes.NpgsqlPoint(x: 0.26053226191641776d, y: 0.7107518425573839d), new NpgsqlTypes.NpgsqlPoint(x: 0.7367874222172471d, y: 0.09115631432998106d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8881187308241756d, y: 0.3872282836868691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6407888595822833d, y: 0.8587357800899056d), new NpgsqlTypes.NpgsqlPoint(x: 0.12157742186993203d, y: 0.4808189866567091d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6386742168335565d, y: 0.027228772329569995d), new NpgsqlTypes.NpgsqlPoint(x: 0.05762254946173084d, y: 0.05020170188559614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5064573662431078d, y: 0.35037909334029915d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.760062398067295d, y: 0.8339928468947193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215263737120213d, y: 0.6751260869786474d), new NpgsqlTypes.NpgsqlPoint(x: 0.12873678569870384d, y: 0.10583310447150429d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22631773606195515d, y: 0.7476197747762223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1769859008197182d, y: 0.7176411058479597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996656399140374d, y: 0.8995739122489367d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6874297809684004d, y: 0.6732027128805641d), new NpgsqlTypes.NpgsqlPoint(x: 0.1556052607130396d, y: 0.3718613862807184d), new NpgsqlTypes.NpgsqlPoint(x: 0.8851076997351948d, y: 0.15691025055620034d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9113741713199004d, y: 0.35021712965003127d), new NpgsqlTypes.NpgsqlPoint(x: 0.8770501393979042d, y: 0.1632376548568074d), new NpgsqlTypes.NpgsqlPoint(x: 0.1483438065571051d, y: 0.8422076740374188d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20467469516059322d, y: 0.7163761347410065d), new NpgsqlTypes.NpgsqlPoint(x: 0.16355231252980562d, y: 0.12132828427431419d), new NpgsqlTypes.NpgsqlPoint(x: 0.9201500302775054d, y: 0.22980345877810882d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4832339812337414d, y: 0.8404776976060273d), new NpgsqlTypes.NpgsqlPoint(x: 0.6501658436870483d, y: 0.45343727581114657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008366185424797d, y: 0.6487790597382121d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8352706718588309d, y: 0.0847622826308011d), new NpgsqlTypes.NpgsqlPoint(x: 0.058673024185613376d, y: 0.14788751449890092d), new NpgsqlTypes.NpgsqlPoint(x: 0.15711923174429143d, y: 0.14365736603058776d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5515644191286273d, y: 0.27015534361280835d), new NpgsqlTypes.NpgsqlPoint(x: 0.14079964530468103d, y: 0.18616503947676655d), new NpgsqlTypes.NpgsqlPoint(x: 0.24359845552488335d, y: 0.6545692896971884d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3420739740334964d, y: 0.09250539992689066d), new NpgsqlTypes.NpgsqlPoint(x: 0.3774299803054648d, y: 0.23773367447785132d), new NpgsqlTypes.NpgsqlPoint(x: 0.667406717792945d, y: 0.6107858840638762d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3094589267938147d, y: 0.26190451845444784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347855490687074d, y: 0.14259037923055884d), new NpgsqlTypes.NpgsqlPoint(x: 0.21934392489869303d, y: 0.176704022695636d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5874403317756274d, y: 0.09329551937536174d), new NpgsqlTypes.NpgsqlPoint(x: 0.05376484948591698d, y: 0.45880621922942233d), new NpgsqlTypes.NpgsqlPoint(x: 0.16516680665851335d, y: 0.1809462013619504d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22125040567731746d, y: 0.4610361604199458d), new NpgsqlTypes.NpgsqlPoint(x: 0.34562072943530364d, y: 0.704331978993629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249803941245773d, y: 0.20412380795633522d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47481737092180254d, y: 0.5065150156195037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855792619440285d, y: 0.6061604176748581d), new NpgsqlTypes.NpgsqlPoint(x: 0.1063305055217687d, y: 0.19867097551590784d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2587243182725638d, y: 0.517043882635765d), new NpgsqlTypes.NpgsqlPoint(x: 0.3750982443685431d, y: 0.17194079277071006d), new NpgsqlTypes.NpgsqlPoint(x: 0.4419388920373335d, y: 0.9094838672232437d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.606401026674996d, y: 0.8460212395510647d), new NpgsqlTypes.NpgsqlPoint(x: 0.43648149652528057d, y: 0.9128275846554764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873604336388323d, y: 0.16945354552024405d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3759106409998326d, y: 0.4885176863271937d), new NpgsqlTypes.NpgsqlPoint(x: 0.06236216932705341d, y: 0.6133524152945793d), new NpgsqlTypes.NpgsqlPoint(x: 0.3852884174689538d, y: 0.16121113676096277d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7103268565830766d, y: 0.1505338086917889d), new NpgsqlTypes.NpgsqlPoint(x: 0.856270021422467d, y: 0.725953540218198d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668668422527454d, y: 0.0683713972448804d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.313795822532263d, y: 0.9359077774912096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9478384049558997d, y: 0.9412389680695765d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520669023804591d, y: 0.2974070300951419d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7930275144225456d, y: 0.24280433614386487d), new NpgsqlTypes.NpgsqlPoint(x: 0.8441464899580614d, y: 0.630483730426712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5802482448582887d, y: 0.43107670316096547d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18725093973616258d, y: 0.49305654347339645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8365245898706061d, y: 0.12896205652025816d), new NpgsqlTypes.NpgsqlPoint(x: 0.4845854223297045d, y: 0.6542399022311426d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38523115108002104d, y: 0.5784445449575145d), new NpgsqlTypes.NpgsqlPoint(x: 0.622953389943483d, y: 0.3210753661583877d), new NpgsqlTypes.NpgsqlPoint(x: 0.09758577049136186d, y: 0.6076817439536644d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9945781194337134d, y: 0.831423168426116d), new NpgsqlTypes.NpgsqlPoint(x: 0.13233746123754675d, y: 0.6208331060988843d), new NpgsqlTypes.NpgsqlPoint(x: 0.43700037807958747d, y: 0.4674124582888284d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6973820418216332d, y: 0.8618547495083506d), new NpgsqlTypes.NpgsqlPoint(x: 0.40657293328637045d, y: 0.04747038635403622d), new NpgsqlTypes.NpgsqlPoint(x: 0.48463187691050014d, y: 0.4425340996072936d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17733558844816577d, y: 0.2639362316138001d), new NpgsqlTypes.NpgsqlPoint(x: 0.39194836064192773d, y: 0.3515037887445642d), new NpgsqlTypes.NpgsqlPoint(x: 0.7046727873501013d, y: 0.27075818608068936d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16945712741109775d, y: 0.5269031539637231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768245929472865d, y: 0.6286160696728716d), new NpgsqlTypes.NpgsqlPoint(x: 0.3853926552970447d, y: 0.06024529854827643d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34683150356353143d, y: 0.2265943452667053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5561199463323658d, y: 0.527842633785358d), new NpgsqlTypes.NpgsqlPoint(x: 0.38524713585792847d, y: 0.15696045704323025d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4836090092626557d, y: 0.24441606744575517d), new NpgsqlTypes.NpgsqlPoint(x: 0.48305414595294904d, y: 0.2887307407976317d), new NpgsqlTypes.NpgsqlPoint(x: 0.1322057435967543d, y: 0.4715162373165118d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3253042730050334d, y: 0.4637837411210909d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396262339970629d, y: 0.4699037687695634d), new NpgsqlTypes.NpgsqlPoint(x: 0.1531341863863105d, y: 0.9142186985213928d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0020072723546937787d, y: 0.36083291180429067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6096225636361354d, y: 0.8449498546871155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8445711815248385d, y: 0.8643054420210072d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6606084287925302d, y: 0.6705301334152673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6276622312220017d, y: 0.7007670332231638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7184927566056025d, y: 0.2512535919741653d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906107466910502d, y: 0.8331728499183361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471250892326021d, y: 0.4625012391820995d), new NpgsqlTypes.NpgsqlPoint(x: 0.11002359555173513d, y: 0.442196287831058d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35236243940394485d, y: 0.5595170008115237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5736461373373533d, y: 0.6463347481377759d), new NpgsqlTypes.NpgsqlPoint(x: 0.49266836175256834d, y: 0.3707829111584775d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30729970458164924d, y: 0.41838518690285686d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554616478027297d, y: 0.9279600050741993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352316796848856d, y: 0.5823912928486772d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2138329130733685d, y: 0.8512284369970377d), new NpgsqlTypes.NpgsqlPoint(x: 0.18938775008407338d, y: 0.03893376398405002d), new NpgsqlTypes.NpgsqlPoint(x: 0.8115303018444581d, y: 0.5557011138548922d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6243960476478999d, y: 0.9679843968237823d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386039940876696d, y: 0.5153645983184062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428546114192641d, y: 0.42902862343126924d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5370519543184282d, y: 0.9720684868208054d), new NpgsqlTypes.NpgsqlPoint(x: 0.2342995179694808d, y: 0.8257630931548033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5263363285888689d, y: 0.5626421106495233d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7954812591361295d, y: 0.5804479222213604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101776154231175d, y: 0.005226219306206481d), new NpgsqlTypes.NpgsqlPoint(x: 0.1493582070799616d, y: 0.981393777703406d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6239543580003468d, y: 0.19934457033223085d), new NpgsqlTypes.NpgsqlPoint(x: 0.2992807318768298d, y: 0.44541095460660596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5481071974635884d, y: 0.5681991452981546d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8118592936001288d, y: 0.24132758603470505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298659665727669d, y: 0.8843502354965734d), new NpgsqlTypes.NpgsqlPoint(x: 0.21130809858677257d, y: 0.8069773679051515d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39944595839152497d, y: 0.9083394695849792d), new NpgsqlTypes.NpgsqlPoint(x: 0.3409840813275259d, y: 0.5909524816780528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4370334782383203d, y: 0.5266604560825944d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47674361899277806d, y: 0.029418693775832283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803264844839638d, y: 0.854256722730035d), new NpgsqlTypes.NpgsqlPoint(x: 0.40840052860859477d, y: 0.07135710462863742d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2112472184648042d, y: 0.26973428074660266d), new NpgsqlTypes.NpgsqlPoint(x: 0.2876310703367294d, y: 0.0047772968095872725d), new NpgsqlTypes.NpgsqlPoint(x: 0.3137078396053109d, y: 0.033190917797109476d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.896409904130314d, y: 0.509546856351624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613098069537549d, y: 0.3385352888791304d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357891006131485d, y: 0.28399376470869353d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9340491907207974d, y: 0.6120780383543235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6363130214102376d, y: 0.9934537071672406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021381537077669d, y: 0.057355855446472925d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6465570303323784d, y: 0.6123694337515364d), new NpgsqlTypes.NpgsqlPoint(x: 0.028278043419749377d, y: 0.17840022975377046d), new NpgsqlTypes.NpgsqlPoint(x: 0.3211439428046283d, y: 0.07621213367599455d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37710354613026253d, y: 0.7292113421572426d), new NpgsqlTypes.NpgsqlPoint(x: 0.18007117393577798d, y: 0.9930854803371212d), new NpgsqlTypes.NpgsqlPoint(x: 0.35354888018304165d, y: 0.6750121563150205d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2584051009481607d, y: 0.7163558082717468d), new NpgsqlTypes.NpgsqlPoint(x: 0.788311819171432d, y: 0.00845302708256701d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126009924585353d, y: 0.9854211254672786d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36714282129355214d, y: 0.6736667816983566d), new NpgsqlTypes.NpgsqlPoint(x: 0.951977048671406d, y: 0.05728341392151759d), new NpgsqlTypes.NpgsqlPoint(x: 0.22786635842722625d, y: 0.7910758130175953d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48405703449417437d, y: 0.42437314365466194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4066675253939729d, y: 0.7771646445083394d), new NpgsqlTypes.NpgsqlPoint(x: 0.45148302086376324d, y: 0.4517614118363822d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9449806954299167d, y: 0.8230282460466503d), new NpgsqlTypes.NpgsqlPoint(x: 0.22017348054195995d, y: 0.30631839894208035d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989794986909966d, y: 0.601442026718992d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9619149056821357d, y: 0.870311673343134d), new NpgsqlTypes.NpgsqlPoint(x: 0.014635595592015438d, y: 0.31548348930053494d), new NpgsqlTypes.NpgsqlPoint(x: 0.41471549046294864d, y: 0.4678472136444265d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19965811664721422d, y: 0.3404334822367495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3847109866547911d, y: 0.43443578365545255d), new NpgsqlTypes.NpgsqlPoint(x: 0.0539087553881743d, y: 0.8342113444093616d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5147179625188856d, y: 0.7309983281896989d), new NpgsqlTypes.NpgsqlPoint(x: 0.24344159656936815d, y: 0.7512253203081748d), new NpgsqlTypes.NpgsqlPoint(x: 0.4374282485463902d, y: 0.7960868616131268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9539498316312603d, y: 0.9697583875621824d), new NpgsqlTypes.NpgsqlPoint(x: 0.4533362829748724d, y: 0.09051010412351623d), new NpgsqlTypes.NpgsqlPoint(x: 0.149489488094666d, y: 0.7476327658900478d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8969800649189347d, y: 0.08767763925913608d), new NpgsqlTypes.NpgsqlPoint(x: 0.4643007872868855d, y: 0.2759855180121854d), new NpgsqlTypes.NpgsqlPoint(x: 0.028741521406369985d, y: 0.5843262685176147d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004727738940307535d, y: 0.1470532589685809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6362612810890935d, y: 0.4668087573620068d), new NpgsqlTypes.NpgsqlPoint(x: 0.35111445929880947d, y: 0.22336352611742405d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6739694476437473d, y: 0.0072610184010226675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4320110532143361d, y: 0.19313118417110853d), new NpgsqlTypes.NpgsqlPoint(x: 0.15681598023768983d, y: 0.9365608872926793d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9466362795100954d, y: 0.08641203352023208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768595088062882d, y: 0.1154137239730928d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571808687453558d, y: 0.8852312920145277d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017139125065078642d, y: 0.5570732303604935d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799604559139667d, y: 0.30380304053314533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578090506217505d, y: 0.24299681045664678d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7974288596667096d, y: 0.3080481791653291d), new NpgsqlTypes.NpgsqlPoint(x: 0.005969821501702999d, y: 0.46008303713916043d), new NpgsqlTypes.NpgsqlPoint(x: 0.07415026418602699d, y: 0.7526669214840256d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8698730667279062d, y: 0.7677519563577794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5704467505310362d, y: 0.3838797770746647d), new NpgsqlTypes.NpgsqlPoint(x: 0.21173007055308046d, y: 0.8594130758262843d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8012604893571161d, y: 0.3614588385682739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350430257967739d, y: 0.08034760146436948d), new NpgsqlTypes.NpgsqlPoint(x: 0.8958391792518194d, y: 0.9956299280922027d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7633266784782248d, y: 0.9784433411257552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143072452704663d, y: 0.4186119614333955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719963155575246d, y: 0.23283694550794465d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5067031957196959d, y: 0.9932458203435095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8750240180317963d, y: 0.11488457453876244d), new NpgsqlTypes.NpgsqlPoint(x: 0.12542900857037642d, y: 0.7617002557554833d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3265173286967854d, y: 0.6147976820518662d), new NpgsqlTypes.NpgsqlPoint(x: 0.04138398643867813d, y: 0.5091439092162222d), new NpgsqlTypes.NpgsqlPoint(x: 0.20396981075729825d, y: 0.9880325694297333d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7011986126639455d, y: 0.4183302884878355d), new NpgsqlTypes.NpgsqlPoint(x: 0.10365289899814578d, y: 0.22704545164389234d), new NpgsqlTypes.NpgsqlPoint(x: 0.20165376630339416d, y: 0.8714437967372677d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03826499959133878d, y: 0.3911058841499264d), new NpgsqlTypes.NpgsqlPoint(x: 0.13962513856054048d, y: 0.4748017792839607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739171207249966d, y: 0.859399675097776d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03372183509801807d, y: 0.22386383702629742d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172309239537077d, y: 0.42524898676166656d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253271026204822d, y: 0.8728417377815414d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.695286713217736d, y: 0.993433348699806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162997834277535d, y: 0.6124130738063129d), new NpgsqlTypes.NpgsqlPoint(x: 0.05113967343629122d, y: 0.933869906061715d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8172600172977583d, y: 0.18254264588157454d), new NpgsqlTypes.NpgsqlPoint(x: 0.23349076769500754d, y: 0.6794628172804862d), new NpgsqlTypes.NpgsqlPoint(x: 0.08149606850819091d, y: 0.15149002981597537d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.693754875169204d, y: 0.5173842688307272d), new NpgsqlTypes.NpgsqlPoint(x: 0.894197723848211d, y: 0.8814129732719264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9890745053604558d, y: 0.24159685384679286d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45525358192683585d, y: 0.6314467777599768d), new NpgsqlTypes.NpgsqlPoint(x: 0.4437506568012911d, y: 0.22628140246296347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742234266264765d, y: 0.7628630450224211d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45565421323702004d, y: 0.7508786608987822d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852528371556894d, y: 0.44932256774485746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467076693570285d, y: 0.9452147687680407d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8348312742594778d, y: 0.024536777691332112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021843834146724d, y: 0.026560754211860993d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800192983653228d, y: 0.47829812965453045d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.369174268699607d, y: 0.08748110844443491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9900809021661955d, y: 0.12482173582895528d), new NpgsqlTypes.NpgsqlPoint(x: 0.08569496062595683d, y: 0.30607898094418107d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6426143661698341d, y: 0.1863830673475929d), new NpgsqlTypes.NpgsqlPoint(x: 0.27228603029973053d, y: 0.7026065724113122d), new NpgsqlTypes.NpgsqlPoint(x: 0.7350298975286661d, y: 0.7833884424869849d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7479520839104812d, y: 0.2728573494455435d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406817013340336d, y: 0.16856757363671415d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205342492125744d, y: 0.18582540393669422d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4982198102666362d, y: 0.13831413292173023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6819911095556244d, y: 0.5402275969235112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7735694049664372d, y: 0.2288028652589953d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7770629642000677d, y: 0.023508742023390372d), new NpgsqlTypes.NpgsqlPoint(x: 0.8832959239783384d, y: 0.6622333722527729d), new NpgsqlTypes.NpgsqlPoint(x: 0.3788780822500353d, y: 0.6437892266583402d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7512724621184497d, y: 0.6027947884618662d), new NpgsqlTypes.NpgsqlPoint(x: 0.49097462253205315d, y: 0.47805437076329094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4998757316927398d, y: 0.753923423501332d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13791756563547464d, y: 0.7898037211272824d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659771856736883d, y: 0.6241695856512073d), new NpgsqlTypes.NpgsqlPoint(x: 0.36955189192011173d, y: 0.0114533380355758d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4262897777130872d, y: 0.9483884495748083d), new NpgsqlTypes.NpgsqlPoint(x: 0.12803605293727593d, y: 0.41666590317632335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5792628122530799d, y: 0.29529224712231883d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8558621958675522d, y: 0.7768864951789024d), new NpgsqlTypes.NpgsqlPoint(x: 0.38766574120939623d, y: 0.6752346826870497d), new NpgsqlTypes.NpgsqlPoint(x: 0.3097788434985217d, y: 0.5423692034678184d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0604777696570965d, y: 0.47184917559966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232038631241273d, y: 0.035000362486903636d), new NpgsqlTypes.NpgsqlPoint(x: 0.22653724473935533d, y: 0.7653749499822157d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02966650331709908d, y: 0.7980876825321862d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450842915864321d, y: 0.921192538813839d), new NpgsqlTypes.NpgsqlPoint(x: 0.42771936376410413d, y: 0.8191381334045187d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7223447457217207d, y: 0.9622069903907892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8249781321793392d, y: 0.6751456384167879d), new NpgsqlTypes.NpgsqlPoint(x: 0.28342230937416235d, y: 0.5145438251423372d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12710920961660843d, y: 0.5172316106950787d), new NpgsqlTypes.NpgsqlPoint(x: 0.6589141433703182d, y: 0.18197792744021402d), new NpgsqlTypes.NpgsqlPoint(x: 0.07990359607588882d, y: 0.39298282508144344d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2947031035035448d, y: 0.738929450332724d), new NpgsqlTypes.NpgsqlPoint(x: 0.08897301348946907d, y: 0.9541007987858425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2760652863566039d, y: 0.49182521178435135d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5113773071515344d, y: 0.5446977546368907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7479046203899323d, y: 0.13128519203333955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152195775712215d, y: 0.878544022904814d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06022780798701566d, y: 0.6584571920063075d), new NpgsqlTypes.NpgsqlPoint(x: 0.2015110521699861d, y: 0.1532362573378393d), new NpgsqlTypes.NpgsqlPoint(x: 0.36364099074141354d, y: 0.13146536836564549d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonlistd1e2mi_id", 
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
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 124, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 66, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 149, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 117, query1, 175, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 32, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 168, query1, 156, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 45, query1, 149, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 75, 149))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatch(connection, 61, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[19], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[20], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[21], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[22], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[23], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[24], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[25], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[26], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[27], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[28], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[29], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[19], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[20], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[21], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[22], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[23], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[24], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[25], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[26], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[27], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[28], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[29], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI), typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

