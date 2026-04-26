

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
    internal partial interface INpgsqlPolygonListpolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonArray : INpgsqlPolygonListpolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray2M[] _testData = new NpgsqlPolygonpolygonArray2M[]
        {
            new NpgsqlPolygonpolygonArray2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1570783484438799d, y: 0.06707069064172944d), new NpgsqlTypes.NpgsqlPoint(x: 0.024458935110281188d, y: 0.6753677828597008d), new NpgsqlTypes.NpgsqlPoint(x: 0.05727057664814461d, y: 0.5797809459918206d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1662712089698507d, y: 0.26449500884338184d), new NpgsqlTypes.NpgsqlPoint(x: 0.059311559753382315d, y: 0.3365905212405952d), new NpgsqlTypes.NpgsqlPoint(x: 0.5258006344058079d, y: 0.5763509296148422d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6559265149042285d, y: 0.46788312748153305d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903096467816535d, y: 0.7945751463835445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245653768595095d, y: 0.8001855971519165d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6260466697407003d, y: 0.3662193676960369d), new NpgsqlTypes.NpgsqlPoint(x: 0.4918674671335511d, y: 0.42387682802873483d), new NpgsqlTypes.NpgsqlPoint(x: 0.18911511947588322d, y: 0.8413295302743085d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01666617283118299d, y: 0.717591277945719d), new NpgsqlTypes.NpgsqlPoint(x: 0.8621993915114359d, y: 0.10279328460607051d), new NpgsqlTypes.NpgsqlPoint(x: 0.19582352366624312d, y: 0.9107610976361445d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5229818915705767d, y: 0.3636755911698756d), new NpgsqlTypes.NpgsqlPoint(x: 0.8439142131395481d, y: 0.8460589492155378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7910900418972407d, y: 0.86425817153362d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8559735656692354d, y: 0.5167871982420672d), new NpgsqlTypes.NpgsqlPoint(x: 0.882712609209138d, y: 0.40993235169331865d), new NpgsqlTypes.NpgsqlPoint(x: 0.2479021925203002d, y: 0.9169967462823468d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17434897404903782d, y: 0.22093654579753608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5359284240072d, y: 0.7862772432051558d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251576259932214d, y: 0.16858633348123986d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5932968902700584d, y: 0.8443082213362306d), new NpgsqlTypes.NpgsqlPoint(x: 0.520934171693774d, y: 0.9276069864386178d), new NpgsqlTypes.NpgsqlPoint(x: 0.4748119932227123d, y: 0.16708556927431173d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22427866329107649d, y: 0.7854062880165208d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592494420718107d, y: 0.34651724956219887d), new NpgsqlTypes.NpgsqlPoint(x: 0.23211035492325582d, y: 0.2174492468349989d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05529891639739182d, y: 0.7157850239770756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9965435737110565d, y: 0.94599013991953d), new NpgsqlTypes.NpgsqlPoint(x: 0.6931675119151418d, y: 0.11556037501144556d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9836234933468869d, y: 0.21802655690213446d), new NpgsqlTypes.NpgsqlPoint(x: 0.4599399045630391d, y: 0.43569194875418715d), new NpgsqlTypes.NpgsqlPoint(x: 0.28511868900625614d, y: 0.752863813919743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5249924368998597d, y: 0.5262073297264476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055085356575339d, y: 0.9747405603255952d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853998801122222d, y: 0.7413297760450203d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9466409816407836d, y: 0.818287019931608d), new NpgsqlTypes.NpgsqlPoint(x: 0.8641479629425919d, y: 0.29550719283489646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3614720522348155d, y: 0.001116899516154124d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8469667515155036d, y: 0.4190695204195255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205866859564859d, y: 0.2397091996162719d), new NpgsqlTypes.NpgsqlPoint(x: 0.16173725589073795d, y: 0.878963110825536d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7934139353813975d, y: 0.9192451094898528d), new NpgsqlTypes.NpgsqlPoint(x: 0.320620443789715d, y: 0.7285619284073975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5523637102913469d, y: 0.7609069847390626d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.712293183592144d, y: 0.863930752128018d), new NpgsqlTypes.NpgsqlPoint(x: 0.18128705858491367d, y: 0.1667553938089028d), new NpgsqlTypes.NpgsqlPoint(x: 0.07014433035565004d, y: 0.3477301991904148d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1952287434102311d, y: 0.41332297011511754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9357031249274781d, y: 0.6333990970934835d), new NpgsqlTypes.NpgsqlPoint(x: 0.419896220292589d, y: 0.899383714252793d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9599611134007225d, y: 0.34655328886173364d), new NpgsqlTypes.NpgsqlPoint(x: 0.985687652150538d, y: 0.1142322581669225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7963900469085442d, y: 0.537497193671894d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32965933634785183d, y: 0.7404161612992326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9587025394332364d, y: 0.11616567950281842d), new NpgsqlTypes.NpgsqlPoint(x: 0.07037566390001082d, y: 0.8879222650746484d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7107089175044136d, y: 0.8360179630086664d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084841071607642d, y: 0.4191176047152335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9511985738802373d, y: 0.881819884047745d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3234862936198124d, y: 0.4705543104254428d), new NpgsqlTypes.NpgsqlPoint(x: 0.06789939564710623d, y: 0.038812067161113406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185030831809415d, y: 0.35424097454315984d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37789559154641983d, y: 0.7932602999650465d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526451058296812d, y: 0.06327045899860917d), new NpgsqlTypes.NpgsqlPoint(x: 0.7836120557140529d, y: 0.7574185174251591d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5350726839987473d, y: 0.7739217785262075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4134389606920653d, y: 0.8429580877274937d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616781793310294d, y: 0.8209541116090552d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05070249104212743d, y: 0.17464560822789343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9044795868101934d, y: 0.04929357433079562d), new NpgsqlTypes.NpgsqlPoint(x: 0.7845726378768114d, y: 0.9134075634748146d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8295445880807032d, y: 0.5132444894767517d), new NpgsqlTypes.NpgsqlPoint(x: 0.76679758808358d, y: 0.5505276967753395d), new NpgsqlTypes.NpgsqlPoint(x: 0.17212022919173975d, y: 0.20449545190970064d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5828255200538415d, y: 0.7416353016987965d), new NpgsqlTypes.NpgsqlPoint(x: 0.10018840595819167d, y: 0.21563755866057732d), new NpgsqlTypes.NpgsqlPoint(x: 0.046874551143693766d, y: 0.5311620338762951d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8888894686294254d, y: 0.1617334804643653d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164265042853961d, y: 0.8034519649498126d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564607024508123d, y: 0.8187761165302224d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6413237248427521d, y: 0.9836412835387701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8719274573335921d, y: 0.5622379152217383d), new NpgsqlTypes.NpgsqlPoint(x: 0.26662971794412216d, y: 0.00402409721510566d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41199787930993625d, y: 0.30298483549100985d), new NpgsqlTypes.NpgsqlPoint(x: 0.1071058519619904d, y: 0.24052667844223707d), new NpgsqlTypes.NpgsqlPoint(x: 0.23774336581328515d, y: 0.31867132396523723d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5699724202453123d, y: 0.7107803004662983d), new NpgsqlTypes.NpgsqlPoint(x: 0.24159177252834985d, y: 0.25380364066117234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6965062027647808d, y: 0.29177877799559293d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18397797767252133d, y: 0.9312435564502691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392575767873853d, y: 0.9788523610882274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8148470141138017d, y: 0.8443627381239893d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9028136929138115d, y: 0.053534381617245885d), new NpgsqlTypes.NpgsqlPoint(x: 0.02378996693932478d, y: 0.6541331942806698d), new NpgsqlTypes.NpgsqlPoint(x: 0.275154982844811d, y: 0.7176156856701319d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8512496371288679d, y: 0.2449841975194481d), new NpgsqlTypes.NpgsqlPoint(x: 0.3378449101988613d, y: 0.9678193240581489d), new NpgsqlTypes.NpgsqlPoint(x: 0.6122615446226605d, y: 0.6804834913329565d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.295446339124088d, y: 0.39729231016061484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531252766504017d, y: 0.32013257011321494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114552163952302d, y: 0.2348186120292841d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08062992371075928d, y: 0.2431010387590301d), new NpgsqlTypes.NpgsqlPoint(x: 0.4083673368447701d, y: 0.7062104248095691d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875719272080905d, y: 0.1906798691318765d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9386548735832414d, y: 0.18251598606769714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722151927887751d, y: 0.6660302835894276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7083351974556391d, y: 0.5017693767317623d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024878120609126753d, y: 0.24400184671435576d), new NpgsqlTypes.NpgsqlPoint(x: 0.02940834408328452d, y: 0.4142585131454609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6759723896537544d, y: 0.3730997622344653d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4663057724247367d, y: 0.8636905332136857d), new NpgsqlTypes.NpgsqlPoint(x: 0.34100546782094976d, y: 0.20363257827827141d), new NpgsqlTypes.NpgsqlPoint(x: 0.22967280179141303d, y: 0.82400665871068d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4817745876063273d, y: 0.3960164102778777d), new NpgsqlTypes.NpgsqlPoint(x: 0.48125055895299595d, y: 0.7298133732171144d), new NpgsqlTypes.NpgsqlPoint(x: 0.4721454487203238d, y: 0.11701444260230365d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9440966676903304d, y: 0.6168703791550578d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833603121598996d, y: 0.7297098676083286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106481767471764d, y: 0.5188908605564828d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07852050062470872d, y: 0.4086963280471414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752156021614426d, y: 0.0645881510483608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868246461791603d, y: 0.7760455589477858d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.983034853987798d, y: 0.32549568906155024d), new NpgsqlTypes.NpgsqlPoint(x: 0.36080252436975846d, y: 0.12568365031617224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4451609427585129d, y: 0.4093496361329979d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2672661588009254d, y: 0.280995510398375d), new NpgsqlTypes.NpgsqlPoint(x: 0.974742704294013d, y: 0.24961407760037513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5200192377315696d, y: 0.08516593939654082d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43411885101515957d, y: 0.6402244554444646d), new NpgsqlTypes.NpgsqlPoint(x: 0.08782700002136401d, y: 0.1611758788427342d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944457431033919d, y: 0.12386796187668703d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9520264708116455d, y: 0.953474034451712d), new NpgsqlTypes.NpgsqlPoint(x: 0.2574197419128237d, y: 0.1483234306837452d), new NpgsqlTypes.NpgsqlPoint(x: 0.24111356489544544d, y: 0.11928230164408471d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6212137587169947d, y: 0.8045560248702082d), new NpgsqlTypes.NpgsqlPoint(x: 0.0006065817933929019d, y: 0.6383778697525337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063523517657763d, y: 0.0882777566843449d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3968596063533242d, y: 0.30742950378666434d), new NpgsqlTypes.NpgsqlPoint(x: 0.6071592815871677d, y: 0.10910991892587618d), new NpgsqlTypes.NpgsqlPoint(x: 0.574450510165538d, y: 0.6466570057093372d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13571980539960493d, y: 0.10037038018781952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382315471585046d, y: 0.932021894318541d), new NpgsqlTypes.NpgsqlPoint(x: 0.25221161608165954d, y: 0.14555363321825343d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7106549022890357d, y: 0.978483405869705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5406781868540013d, y: 0.6531013731722769d), new NpgsqlTypes.NpgsqlPoint(x: 0.284279201494268d, y: 0.006559918572635048d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3121989128057838d, y: 0.06364573002946339d), new NpgsqlTypes.NpgsqlPoint(x: 0.11811923283190406d, y: 0.27022599627094324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384462602144207d, y: 0.5378001810345963d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7756859910273345d, y: 0.17288756523991844d), new NpgsqlTypes.NpgsqlPoint(x: 0.715871788057362d, y: 0.48523621503800607d), new NpgsqlTypes.NpgsqlPoint(x: 0.06781607924879918d, y: 0.7116748461420388d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9642631502883362d, y: 0.9278455188467737d), new NpgsqlTypes.NpgsqlPoint(x: 0.32886261587987253d, y: 0.20561382936215888d), new NpgsqlTypes.NpgsqlPoint(x: 0.607202329649777d, y: 0.14806148081057258d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8384739518897004d, y: 0.19206326448650812d), new NpgsqlTypes.NpgsqlPoint(x: 0.4069339883226708d, y: 0.724319994300972d), new NpgsqlTypes.NpgsqlPoint(x: 0.7488084813303413d, y: 0.6950699492398497d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03860078991266369d, y: 0.423090875274151d), new NpgsqlTypes.NpgsqlPoint(x: 0.35873444733979054d, y: 0.3330642323733767d), new NpgsqlTypes.NpgsqlPoint(x: 0.549036320760081d, y: 0.05629724610600062d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.371733031996623d, y: 0.4582361583584631d), new NpgsqlTypes.NpgsqlPoint(x: 0.624946824548431d, y: 0.30507999538128616d), new NpgsqlTypes.NpgsqlPoint(x: 0.7265816287685027d, y: 0.760455913890447d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3576248047699433d, y: 0.2605983804781513d), new NpgsqlTypes.NpgsqlPoint(x: 0.14387724245287992d, y: 0.3206189732691166d), new NpgsqlTypes.NpgsqlPoint(x: 0.3567391864773185d, y: 0.4587580241155803d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46891149393731013d, y: 0.8782341141946012d), new NpgsqlTypes.NpgsqlPoint(x: 0.7532419916781498d, y: 0.028483737339055515d), new NpgsqlTypes.NpgsqlPoint(x: 0.525572655340544d, y: 0.7944790451474404d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25373317979490195d, y: 0.3487002656811108d), new NpgsqlTypes.NpgsqlPoint(x: 0.699818596846367d, y: 0.8810991163124954d), new NpgsqlTypes.NpgsqlPoint(x: 0.4035670763545812d, y: 0.7042235117544191d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07196378853346619d, y: 0.5379925622470828d), new NpgsqlTypes.NpgsqlPoint(x: 0.0044347492869606375d, y: 0.9692716575573662d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800194805603767d, y: 0.2111263652484089d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.597366203538863d, y: 0.3452991475060849d), new NpgsqlTypes.NpgsqlPoint(x: 0.556271602943692d, y: 0.12185784001311406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9751325448436285d, y: 0.4965602910019652d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30316490692047726d, y: 0.4173473642971465d), new NpgsqlTypes.NpgsqlPoint(x: 0.20142453778179215d, y: 0.4094341106225594d), new NpgsqlTypes.NpgsqlPoint(x: 0.37428573293396483d, y: 0.39475945132508117d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4492768065250541d, y: 0.8086543684581955d), new NpgsqlTypes.NpgsqlPoint(x: 0.4405498776845864d, y: 0.1161679357532186d), new NpgsqlTypes.NpgsqlPoint(x: 0.47853440756106935d, y: 0.7364796717896985d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1724694574424438d, y: 0.10691011127900951d), new NpgsqlTypes.NpgsqlPoint(x: 0.5595115729903983d, y: 0.15995882619459778d), new NpgsqlTypes.NpgsqlPoint(x: 0.43922622486341667d, y: 0.5311748031774124d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6288725053712387d, y: 0.49879053361000814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242228415661876d, y: 0.8202483073785176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8291605026897702d, y: 0.24244850074945312d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4036552462846257d, y: 0.7383718580131257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8040644639926714d, y: 0.6937762891431525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537235520517454d, y: 0.2001235629954442d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8277826615875712d, y: 0.8700382655683775d), new NpgsqlTypes.NpgsqlPoint(x: 0.09129166045206316d, y: 0.6729798499865391d), new NpgsqlTypes.NpgsqlPoint(x: 0.11201053329726796d, y: 0.18314292450253322d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5304569327998233d, y: 0.2618507077596418d), new NpgsqlTypes.NpgsqlPoint(x: 0.9771826840911368d, y: 0.5102469200799674d), new NpgsqlTypes.NpgsqlPoint(x: 0.16390684851695136d, y: 0.49246059227529293d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05622376589028599d, y: 0.585383409453866d), new NpgsqlTypes.NpgsqlPoint(x: 0.43123901459301983d, y: 0.6969484272585501d), new NpgsqlTypes.NpgsqlPoint(x: 0.47178126541915155d, y: 0.8720711447132743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.726241720950155d, y: 0.2792660003119898d), new NpgsqlTypes.NpgsqlPoint(x: 0.4536149685816009d, y: 0.7290209457690965d), new NpgsqlTypes.NpgsqlPoint(x: 0.46653255491571544d, y: 0.4957033800761673d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24189489830058541d, y: 0.41998719435086407d), new NpgsqlTypes.NpgsqlPoint(x: 0.36014049811785087d, y: 0.4664096141434583d), new NpgsqlTypes.NpgsqlPoint(x: 0.2645529659507625d, y: 0.8255870235682224d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5224535083629798d, y: 0.702196189723766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507155223200242d, y: 0.7963132940720965d), new NpgsqlTypes.NpgsqlPoint(x: 0.380136068505052d, y: 0.9996609286888545d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2482047400830959d, y: 0.8647448768807051d), new NpgsqlTypes.NpgsqlPoint(x: 0.01091164118496335d, y: 0.989632213584181d), new NpgsqlTypes.NpgsqlPoint(x: 0.8882130872185171d, y: 0.18882903334633838d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4875059227284514d, y: 0.5108619592686409d), new NpgsqlTypes.NpgsqlPoint(x: 0.3931510213428039d, y: 0.12906922947898236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3542138592137396d, y: 0.02644559510906419d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10807940108169745d, y: 0.11955618445702543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641871874426332d, y: 0.9577783179992226d), new NpgsqlTypes.NpgsqlPoint(x: 0.554213634609558d, y: 0.5395240423924993d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5544518326402423d, y: 0.6360456321989663d), new NpgsqlTypes.NpgsqlPoint(x: 0.28499474415618564d, y: 0.38431226676989716d), new NpgsqlTypes.NpgsqlPoint(x: 0.781277498787134d, y: 0.05068943399928294d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06377583174053614d, y: 0.22249169954417558d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098394254915048d, y: 0.8072851749981356d), new NpgsqlTypes.NpgsqlPoint(x: 0.4364530975745392d, y: 0.4079713559865492d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8788800238332687d, y: 0.8055237398349214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7058302889124737d, y: 0.2710616428703998d), new NpgsqlTypes.NpgsqlPoint(x: 0.2463443278389117d, y: 0.30580535220907057d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1470270456886863d, y: 0.5813326188531274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277205876147138d, y: 0.45368701511061915d), new NpgsqlTypes.NpgsqlPoint(x: 0.2771043071783572d, y: 0.08862629476448691d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8826185354847013d, y: 0.3683943300679565d), new NpgsqlTypes.NpgsqlPoint(x: 0.023377088220145614d, y: 0.8811140448307629d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381337456128684d, y: 0.1474984026089997d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5587463868532351d, y: 0.9932759698499792d), new NpgsqlTypes.NpgsqlPoint(x: 0.1060853661404122d, y: 0.6658981071363315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7216135763395172d, y: 0.26981838907973144d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0652817940864533d, y: 0.06718371557839042d), new NpgsqlTypes.NpgsqlPoint(x: 0.043559912265999534d, y: 0.3836928704813872d), new NpgsqlTypes.NpgsqlPoint(x: 0.09085230581071624d, y: 0.48261382357821614d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7037431318134233d, y: 0.7552301553854188d), new NpgsqlTypes.NpgsqlPoint(x: 0.7963699869028289d, y: 0.23309702848909708d), new NpgsqlTypes.NpgsqlPoint(x: 0.18811371810184352d, y: 0.7932234850329771d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3722656204408765d, y: 0.791445949504958d), new NpgsqlTypes.NpgsqlPoint(x: 0.8210352089748936d, y: 0.7413412793070638d), new NpgsqlTypes.NpgsqlPoint(x: 0.017403516740687297d, y: 0.5014249599554659d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5287268630891991d, y: 0.07830170063409747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8031691519312583d, y: 0.89128078032867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3937804823891279d, y: 0.05277524333678574d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6988171369623153d, y: 0.47414950628875696d), new NpgsqlTypes.NpgsqlPoint(x: 0.24342173838017123d, y: 0.7007727003068258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457963084510074d, y: 0.28567849470226003d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5557218495315223d, y: 0.9550286249517786d), new NpgsqlTypes.NpgsqlPoint(x: 0.29185217066243907d, y: 0.6750859780216084d), new NpgsqlTypes.NpgsqlPoint(x: 0.3282252685896627d, y: 0.5356322823428917d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3611108967218276d, y: 0.3041244856705295d), new NpgsqlTypes.NpgsqlPoint(x: 0.21380026696612398d, y: 0.3734296587582293d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632312341443406d, y: 0.4523745157081468d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3884028307192098d, y: 0.47843305449769447d), new NpgsqlTypes.NpgsqlPoint(x: 0.49867841175351535d, y: 0.5017609050903933d), new NpgsqlTypes.NpgsqlPoint(x: 0.2890176618743978d, y: 0.18443847843942585d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7723471296639705d, y: 0.6138486832853821d), new NpgsqlTypes.NpgsqlPoint(x: 0.09171567542323478d, y: 0.2776807140075249d), new NpgsqlTypes.NpgsqlPoint(x: 0.25078608146386683d, y: 0.2405602280644692d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6595546944435998d, y: 0.6669590803259128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646088534094988d, y: 0.19684492583714275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998782867939597d, y: 0.32579637954060925d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11581116559317128d, y: 0.1059185367534039d), new NpgsqlTypes.NpgsqlPoint(x: 0.18148368426186656d, y: 0.03162028980648057d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962300727083527d, y: 0.32383247425182626d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6528768613153814d, y: 0.9872433795435457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6498721333038621d, y: 0.3123129573873846d), new NpgsqlTypes.NpgsqlPoint(x: 0.09134076153539117d, y: 0.13697525195843607d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20364049213197732d, y: 0.5690092920239046d), new NpgsqlTypes.NpgsqlPoint(x: 0.1180132139099479d, y: 0.917646007521876d), new NpgsqlTypes.NpgsqlPoint(x: 0.0632564754429964d, y: 0.8932961857840761d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33103908639053226d, y: 0.7625064805323949d), new NpgsqlTypes.NpgsqlPoint(x: 0.830936508514003d, y: 0.012577416679206754d), new NpgsqlTypes.NpgsqlPoint(x: 0.878299037148524d, y: 0.09865212956791203d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7017037113201182d, y: 0.4690791395482714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464703394981386d, y: 0.8553674044149001d), new NpgsqlTypes.NpgsqlPoint(x: 0.8891461427097376d, y: 0.3574769658664386d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5996874733764622d, y: 0.021619652100239528d), new NpgsqlTypes.NpgsqlPoint(x: 0.279309269852244d, y: 0.962046287612884d), new NpgsqlTypes.NpgsqlPoint(x: 0.5685304455832697d, y: 0.6322089657145188d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6696550865549806d, y: 0.743633991977095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2696763473077898d, y: 0.018004525403364058d), new NpgsqlTypes.NpgsqlPoint(x: 0.029525910018966428d, y: 0.04997923946775895d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6389785869799139d, y: 0.6994872245553369d), new NpgsqlTypes.NpgsqlPoint(x: 0.04182414477727525d, y: 0.006513835249017275d), new NpgsqlTypes.NpgsqlPoint(x: 0.12401453529670181d, y: 0.7185714262368068d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4954055455524703d, y: 0.7868083841916079d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947824435196234d, y: 0.8755833843100288d), new NpgsqlTypes.NpgsqlPoint(x: 0.1659756643298661d, y: 0.20608189422973966d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45056052698258153d, y: 0.40378632630786615d), new NpgsqlTypes.NpgsqlPoint(x: 0.023438612503582923d, y: 0.8378842146030577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464821282661152d, y: 0.9929318534467704d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36750141205532283d, y: 0.5672047360318306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4541571441894453d, y: 0.7808895643834128d), new NpgsqlTypes.NpgsqlPoint(x: 0.009546778246139476d, y: 0.11923430645023281d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10450967948589474d, y: 0.8091968705555264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6605752550857564d, y: 0.06854741178213097d), new NpgsqlTypes.NpgsqlPoint(x: 0.18634166407222896d, y: 0.3400019089015094d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1777611455805359d, y: 0.9773883149688521d), new NpgsqlTypes.NpgsqlPoint(x: 0.09166888718705868d, y: 0.9306723872092258d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986097617269648d, y: 0.1186893379559556d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9290923635153643d, y: 0.4171686077615856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278843507058834d, y: 0.7417300187480338d), new NpgsqlTypes.NpgsqlPoint(x: 0.34128229281747846d, y: 0.38570237445273536d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8449021741405293d, y: 0.6750586352090555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4958991881593142d, y: 0.32079505633274064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9356861634062645d, y: 0.7314527514298912d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2567836271630588d, y: 0.12268307270974221d), new NpgsqlTypes.NpgsqlPoint(x: 0.3619639399394716d, y: 0.4070178205274896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570816878274631d, y: 0.9301650932556382d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8255245166873414d, y: 0.44282776026179604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7267733579884809d, y: 0.3825644090116982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010746310389233d, y: 0.49114595886389734d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30793566913380344d, y: 0.40136199372331904d), new NpgsqlTypes.NpgsqlPoint(x: 0.02554002724134019d, y: 0.4903425707071184d), new NpgsqlTypes.NpgsqlPoint(x: 0.051459504680518964d, y: 0.05651515761379955d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11943851295869035d, y: 0.4330118470120553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5770679818563298d, y: 0.9908481230374102d), new NpgsqlTypes.NpgsqlPoint(x: 0.793079949623876d, y: 0.6403672689025253d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08517507171590055d, y: 0.459937899919718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6230225251677164d, y: 0.8979088947374892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853469280453115d, y: 0.9952098767485082d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2246075561558014d, y: 0.8409659215673955d), new NpgsqlTypes.NpgsqlPoint(x: 0.33095451858626823d, y: 0.9201491781603863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816186876185519d, y: 0.447454255546071d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44162280550199695d, y: 0.36447587638524814d), new NpgsqlTypes.NpgsqlPoint(x: 0.5128804304214405d, y: 0.6139841600933194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131799112995568d, y: 0.9457865120130707d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7517910571805122d, y: 0.9683694356221761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739643934489564d, y: 0.9135211323041309d), new NpgsqlTypes.NpgsqlPoint(x: 0.7740438837574195d, y: 0.6734358915670728d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8047879308250565d, y: 0.4652391690975135d), new NpgsqlTypes.NpgsqlPoint(x: 0.649711055521462d, y: 0.27297163351288645d), new NpgsqlTypes.NpgsqlPoint(x: 0.7884824800267657d, y: 0.8232796110659067d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7975362341267769d, y: 0.23454714153799283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596820034889364d, y: 0.043704443827660255d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152018187220366d, y: 0.02929389313612707d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2544779914585793d, y: 0.49857403811908074d), new NpgsqlTypes.NpgsqlPoint(x: 0.006066772457879899d, y: 0.18155328679029803d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712350719090466d, y: 0.04404790517961932d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28485968362119396d, y: 0.49048211634432193d), new NpgsqlTypes.NpgsqlPoint(x: 0.12625913799616417d, y: 0.1916289778302196d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562547037494056d, y: 0.22782298520448918d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3718166588173373d, y: 0.29299640183198883d), new NpgsqlTypes.NpgsqlPoint(x: 0.31273970122428985d, y: 0.30804767574535463d), new NpgsqlTypes.NpgsqlPoint(x: 0.24282648149551322d, y: 0.47997498687476825d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48315423173342864d, y: 0.8007389217707612d), new NpgsqlTypes.NpgsqlPoint(x: 0.3613190982176454d, y: 0.34018573909719474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9881080596746866d, y: 0.19442092008497336d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33209913783047385d, y: 0.7257374888608619d), new NpgsqlTypes.NpgsqlPoint(x: 0.46494037868514504d, y: 0.6768012608055841d), new NpgsqlTypes.NpgsqlPoint(x: 0.03308736496080833d, y: 0.06804387480970464d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5964602929994172d, y: 0.4218969105099215d), new NpgsqlTypes.NpgsqlPoint(x: 0.31309093037918023d, y: 0.4210106834465306d), new NpgsqlTypes.NpgsqlPoint(x: 0.30638038828947556d, y: 0.05295216454882967d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40698700045291725d, y: 0.42040193245566126d), new NpgsqlTypes.NpgsqlPoint(x: 0.4471861077993049d, y: 0.10200813406846754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2532579197211131d, y: 0.7052703651180121d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41534699359705485d, y: 0.7467404534945482d), new NpgsqlTypes.NpgsqlPoint(x: 0.03335809643180121d, y: 0.20904912256247155d), new NpgsqlTypes.NpgsqlPoint(x: 0.4851422212842429d, y: 0.45269344139431733d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9183024484487992d, y: 0.3037227851510953d), new NpgsqlTypes.NpgsqlPoint(x: 0.7228975758540788d, y: 0.3712321692679549d), new NpgsqlTypes.NpgsqlPoint(x: 0.32438076249667946d, y: 0.4596531448940593d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8851805933230701d, y: 0.29819160932497013d), new NpgsqlTypes.NpgsqlPoint(x: 0.41550449375982057d, y: 0.8347230401082072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9167457136188298d, y: 0.7397458632348455d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.843069497712036d, y: 0.9250229233268465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7214664050443704d, y: 0.33868984182283446d), new NpgsqlTypes.NpgsqlPoint(x: 0.539353707707338d, y: 0.532130237098936d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8563804063673373d, y: 0.43937305360415513d), new NpgsqlTypes.NpgsqlPoint(x: 0.06950360429120184d, y: 0.7748287440637183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390286752818428d, y: 0.4909462646582854d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38311175121797636d, y: 0.14462412469250674d), new NpgsqlTypes.NpgsqlPoint(x: 0.4238981534472952d, y: 0.4898232170362259d), new NpgsqlTypes.NpgsqlPoint(x: 0.014923030488792843d, y: 0.4626091351138578d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.036177472221591844d, y: 0.5909008354261001d), new NpgsqlTypes.NpgsqlPoint(x: 0.45291870884990726d, y: 0.44564826750632913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9497003387320513d, y: 0.4108623738668955d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01437993433919238d, y: 0.1804806938553647d), new NpgsqlTypes.NpgsqlPoint(x: 0.0014685166713539477d, y: 0.029548779667932457d), new NpgsqlTypes.NpgsqlPoint(x: 0.41877323693284363d, y: 0.22532814610490304d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8717230008895879d, y: 0.9759898988667831d), new NpgsqlTypes.NpgsqlPoint(x: 0.5580270424909411d, y: 0.5246236414603471d), new NpgsqlTypes.NpgsqlPoint(x: 0.47236109251928493d, y: 0.881716044294862d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2473642726202031d, y: 0.9348691080255837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725615940615311d, y: 0.8675714258480264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9019511580383984d, y: 0.5568756812706706d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.689665660071992d, y: 0.2731726598248406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218675770655285d, y: 0.27672972627663217d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299386425183012d, y: 0.3591939006160666d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06722327753381019d, y: 0.20750354161905948d), new NpgsqlTypes.NpgsqlPoint(x: 0.7948244082852182d, y: 0.5137376085942137d), new NpgsqlTypes.NpgsqlPoint(x: 0.07894158786418703d, y: 0.8343764659591859d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7295629897128991d, y: 0.8569260324333002d), new NpgsqlTypes.NpgsqlPoint(x: 0.6773986091008126d, y: 0.5652803847080307d), new NpgsqlTypes.NpgsqlPoint(x: 0.014628677187203065d, y: 0.5735547786742933d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2307360467466546d, y: 0.9513510247465808d), new NpgsqlTypes.NpgsqlPoint(x: 0.21543673562681254d, y: 0.7777787485141648d), new NpgsqlTypes.NpgsqlPoint(x: 0.24197176992296587d, y: 0.3892899269879385d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37511892426361726d, y: 0.08509528470151106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6331404573414283d, y: 0.47156570638473116d), new NpgsqlTypes.NpgsqlPoint(x: 0.2085113204859187d, y: 0.405168692651789d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9928914184448586d, y: 0.8973065505745423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7607550588504531d, y: 0.053433845640264876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731454752525886d, y: 0.5199272675021859d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6923957745938905d, y: 0.37521181403346504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374719658617685d, y: 0.07206846349092577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4658132275265936d, y: 0.08056186166810209d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5021558941622567d, y: 0.05401826692225675d), new NpgsqlTypes.NpgsqlPoint(x: 0.36801756537899133d, y: 0.6723194314261871d), new NpgsqlTypes.NpgsqlPoint(x: 0.6314074706254288d, y: 0.2928783916861468d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7445700635854204d, y: 0.15248203130886806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746738982349914d, y: 0.3988522961350932d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449903945604109d, y: 0.1600964921788297d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22192703177399786d, y: 0.5162515867799132d), new NpgsqlTypes.NpgsqlPoint(x: 0.34434015989067124d, y: 0.22123267773010824d), new NpgsqlTypes.NpgsqlPoint(x: 0.10275151544412842d, y: 0.23571125751505795d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28230317262439164d, y: 0.1904922116675899d), new NpgsqlTypes.NpgsqlPoint(x: 0.3552031263495554d, y: 0.6931578105614078d), new NpgsqlTypes.NpgsqlPoint(x: 0.04220509840259934d, y: 0.6543392023034655d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6612522237740298d, y: 0.29297096775973364d), new NpgsqlTypes.NpgsqlPoint(x: 0.12684175552962285d, y: 0.6817368797033622d), new NpgsqlTypes.NpgsqlPoint(x: 0.021068939848086332d, y: 0.11943632254590697d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8757750939267412d, y: 0.4608723214218594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517731474207857d, y: 0.7884892513873023d), new NpgsqlTypes.NpgsqlPoint(x: 0.985267095461189d, y: 0.3465077694333254d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00378784624253814d, y: 0.45197012873690956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9909490607217861d, y: 0.828349715463579d), new NpgsqlTypes.NpgsqlPoint(x: 0.6801683583386323d, y: 0.29242479559537193d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12880444524628176d, y: 0.8732899659123453d), new NpgsqlTypes.NpgsqlPoint(x: 0.3205240129858259d, y: 0.8726891794967181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6721744631592899d, y: 0.5352020114646073d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7016600143531168d, y: 0.3694386407184208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6844556972402173d, y: 0.3559067671382036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936758558306747d, y: 0.38127402959446843d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4333002696853955d, y: 0.23192042110955013d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739848263169295d, y: 0.5459913556321644d), new NpgsqlTypes.NpgsqlPoint(x: 0.30314064823189946d, y: 0.5941480835540855d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.566495305379186d, y: 0.6656212784048533d), new NpgsqlTypes.NpgsqlPoint(x: 0.12862310096210572d, y: 0.1913841364266997d), new NpgsqlTypes.NpgsqlPoint(x: 0.020596035483150255d, y: 0.6434121955731749d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2958102947584391d, y: 0.013976205395234254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255962581458063d, y: 0.8071806337960895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3593752114944607d, y: 0.82963884702451d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.026895311477614148d, y: 0.8215638489722521d), new NpgsqlTypes.NpgsqlPoint(x: 0.24558997206587074d, y: 0.8219206759794175d), new NpgsqlTypes.NpgsqlPoint(x: 0.11576883095194412d, y: 0.33329877498773175d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.227411687260208d, y: 0.46405201333005264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942162436159512d, y: 0.5811990118412682d), new NpgsqlTypes.NpgsqlPoint(x: 0.845487461950941d, y: 0.5270527028114941d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11955458706984734d, y: 0.5005736017765733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442578289232993d, y: 0.15582966424171107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271894710378631d, y: 0.8102849829249067d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.478509724329082d, y: 0.4125065178467435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651380041272882d, y: 0.11841467739110001d), new NpgsqlTypes.NpgsqlPoint(x: 0.806483521773335d, y: 0.17492217334616d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7254891066046649d, y: 0.24779247999754306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3743071171193746d, y: 0.5171191667623527d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624429561174201d, y: 0.8979708485787551d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5952572396851238d, y: 0.4280398948833013d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426046056246934d, y: 0.16324506363363367d), new NpgsqlTypes.NpgsqlPoint(x: 0.734544218204267d, y: 0.25376934404156426d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3683860321706287d, y: 0.3799574482843179d), new NpgsqlTypes.NpgsqlPoint(x: 0.003988665749576792d, y: 0.5878374471682287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3894812041804525d, y: 0.3311812622492002d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42182365743693595d, y: 0.2800357370298715d), new NpgsqlTypes.NpgsqlPoint(x: 0.19522964755777927d, y: 0.21694597752447764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7715173071083744d, y: 0.09287558362912551d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8476947506990721d, y: 0.7118804297148258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561248071445324d, y: 0.8292371505484888d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114280793937769d, y: 0.03597164139032594d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5043030626957539d, y: 0.49497413621994735d), new NpgsqlTypes.NpgsqlPoint(x: 0.33300954142568306d, y: 0.5909387604439922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5239804127372432d, y: 0.6698196437328695d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13932814880316013d, y: 0.9078096162118797d), new NpgsqlTypes.NpgsqlPoint(x: 0.5436959446101525d, y: 0.2690791893223893d), new NpgsqlTypes.NpgsqlPoint(x: 0.4427039251287451d, y: 0.008411125105641681d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2753612137412401d, y: 0.176744279781751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7714690592093694d, y: 0.7199570234318692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301864630307729d, y: 0.4439360541041507d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6502737395098008d, y: 0.6137090573519522d), new NpgsqlTypes.NpgsqlPoint(x: 0.4366945666486315d, y: 0.39568083072240356d), new NpgsqlTypes.NpgsqlPoint(x: 0.7607441419325455d, y: 0.020765481840988476d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6067554549496809d, y: 0.5448398656147748d), new NpgsqlTypes.NpgsqlPoint(x: 0.46246061136052363d, y: 0.38520871842485127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554029257870565d, y: 0.575115099205814d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2954187653627771d, y: 0.6007324185246001d), new NpgsqlTypes.NpgsqlPoint(x: 0.061428214385795266d, y: 0.7408627764654421d), new NpgsqlTypes.NpgsqlPoint(x: 0.15894254318913537d, y: 0.6183654555431014d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7969165071785442d, y: 0.9770983599451893d), new NpgsqlTypes.NpgsqlPoint(x: 0.1358983597261053d, y: 0.09154205939953464d), new NpgsqlTypes.NpgsqlPoint(x: 0.8280423361261667d, y: 0.7561009823849876d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9906826591781407d, y: 0.479853924983227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077972970048702d, y: 0.039383708430659414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4470113998344515d, y: 0.38347409561124823d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8089726915335015d, y: 0.796570671107941d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825208703454602d, y: 0.16254693114016716d), new NpgsqlTypes.NpgsqlPoint(x: 0.22062565444012672d, y: 0.7637161867374591d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9309365399841895d, y: 0.516456393795389d), new NpgsqlTypes.NpgsqlPoint(x: 0.14825579092121466d, y: 0.8317768615942371d), new NpgsqlTypes.NpgsqlPoint(x: 0.32964904632954617d, y: 0.8483605957881096d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7708143492927835d, y: 0.9919739143642663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5819203393744755d, y: 0.9824633910616721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6340535142378041d, y: 0.3354750452837356d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6103801153039646d, y: 0.16534050999917826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8410268800962716d, y: 0.17535468520725817d), new NpgsqlTypes.NpgsqlPoint(x: 0.07505813022775842d, y: 0.631725748511741d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8591900024692387d, y: 0.7660166691666463d), new NpgsqlTypes.NpgsqlPoint(x: 0.731582099781839d, y: 0.13029357762349392d), new NpgsqlTypes.NpgsqlPoint(x: 0.023522944376022092d, y: 0.650499779218757d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5166109438698908d, y: 0.1641379373006855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5244317654755443d, y: 0.3721542588483877d), new NpgsqlTypes.NpgsqlPoint(x: 0.1918662894749149d, y: 0.10437760435297427d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7911531252000868d, y: 0.13628541969755648d), new NpgsqlTypes.NpgsqlPoint(x: 0.625657612739057d, y: 0.26735580812147575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889633122546917d, y: 0.24330142062217375d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8746149087783277d, y: 0.3860145588687063d), new NpgsqlTypes.NpgsqlPoint(x: 0.24282205133598922d, y: 0.5082410101307098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8165630691720012d, y: 0.6194545319872116d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6470302699844875d, y: 0.629034504945106d), new NpgsqlTypes.NpgsqlPoint(x: 0.17259167667127784d, y: 0.6025682010385643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5718575483649689d, y: 0.6203607758272742d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03637828413849398d, y: 0.9415285895301796d), new NpgsqlTypes.NpgsqlPoint(x: 0.18828519121595233d, y: 0.8178191974005375d), new NpgsqlTypes.NpgsqlPoint(x: 0.003498784840014757d, y: 0.5638552603812261d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2527417866985634d, y: 0.3335858418134351d), new NpgsqlTypes.NpgsqlPoint(x: 0.04985421218511521d, y: 0.052984348486754373d), new NpgsqlTypes.NpgsqlPoint(x: 0.34881367066256697d, y: 0.9421271716353603d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2992491642344307d, y: 0.2772445521034549d), new NpgsqlTypes.NpgsqlPoint(x: 0.4039369230213945d, y: 0.0946612045297216d), new NpgsqlTypes.NpgsqlPoint(x: 0.4386952091169719d, y: 0.8304352113434035d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10183780112394625d, y: 0.26259935418878333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373420911402945d, y: 0.5882543261966298d), new NpgsqlTypes.NpgsqlPoint(x: 0.9066793658019209d, y: 0.7743064038760411d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07649865828931157d, y: 0.05603344037016733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7423276636149565d, y: 0.26910303695814664d), new NpgsqlTypes.NpgsqlPoint(x: 0.2868791447366752d, y: 0.6159911197643019d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05785338688283537d, y: 0.022788764275456952d), new NpgsqlTypes.NpgsqlPoint(x: 0.578336178078344d, y: 0.9942558728072508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8634309960538629d, y: 0.5951542300618916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4265210571699527d, y: 0.24172087724813018d), new NpgsqlTypes.NpgsqlPoint(x: 0.032579444423645576d, y: 0.3050430052317006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388716239349769d, y: 0.660150173901781d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5475219706308599d, y: 0.37353552354660835d), new NpgsqlTypes.NpgsqlPoint(x: 0.24941575461342058d, y: 0.00679031610847225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076743778051665d, y: 0.4548768447042718d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5908990948756015d, y: 0.819702875579739d), new NpgsqlTypes.NpgsqlPoint(x: 0.23792937211849963d, y: 0.8574711803723623d), new NpgsqlTypes.NpgsqlPoint(x: 0.34649924544911714d, y: 0.8654929375002454d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22909873006832282d, y: 0.6857460061170364d), new NpgsqlTypes.NpgsqlPoint(x: 0.4400907378684594d, y: 0.5122725744746112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7800136201385133d, y: 0.5855982914019422d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9225623246148461d, y: 0.26820182540077d), new NpgsqlTypes.NpgsqlPoint(x: 0.43233022538939225d, y: 0.6973127905931062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973196464518763d, y: 0.4619032984531676d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41717169632904794d, y: 0.28091621174556847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441102150630238d, y: 0.6405649332470518d), new NpgsqlTypes.NpgsqlPoint(x: 0.03441071824947772d, y: 0.12843118701961953d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2557392951801377d, y: 0.1305780813531804d), new NpgsqlTypes.NpgsqlPoint(x: 0.20735380712352403d, y: 0.22665207559236877d), new NpgsqlTypes.NpgsqlPoint(x: 0.13854502757117926d, y: 0.5830336398518121d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.909477911967741d, y: 0.7521344774211165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5789235677216582d, y: 0.8604168563967333d), new NpgsqlTypes.NpgsqlPoint(x: 0.10553325610142916d, y: 0.8223669656321043d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8800943118581399d, y: 0.13594351175667996d), new NpgsqlTypes.NpgsqlPoint(x: 0.29094396568645975d, y: 0.1670148996083386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231682599511076d, y: 0.731391368946439d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0029173718010674365d, y: 0.8408942087167391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867567526209121d, y: 0.3251234013088894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678137531959669d, y: 0.9856507257829179d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17145200338600597d, y: 0.7681003067887614d), new NpgsqlTypes.NpgsqlPoint(x: 0.3280726304397642d, y: 0.14550943727558396d), new NpgsqlTypes.NpgsqlPoint(x: 0.3810568635329574d, y: 0.03317630239000269d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.597879134527731d, y: 0.7317985954103209d), new NpgsqlTypes.NpgsqlPoint(x: 0.33609120544650084d, y: 0.01286407949371493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1330558391250315d, y: 0.6849533051413186d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6601977985848098d, y: 0.3677412766988464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550976339406162d, y: 0.9108934206377832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123464433319951d, y: 0.4160889978009499d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10428658079802178d, y: 0.006282658975102384d), new NpgsqlTypes.NpgsqlPoint(x: 0.16811695452129938d, y: 0.44695053843180266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9057863981806804d, y: 0.19840348109051587d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0988689374996441d, y: 0.47105106309552114d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427119008564223d, y: 0.3925801789908687d), new NpgsqlTypes.NpgsqlPoint(x: 0.850713152221245d, y: 0.7536234638420827d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6895899100473312d, y: 0.46216669891728357d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315845176532575d, y: 0.9434019997930572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412640818452787d, y: 0.8741498742108568d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9338855194537896d, y: 0.7068559428549674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3871107402468721d, y: 0.9693408742346169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889665716270447d, y: 0.7668503135605811d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32176786253847534d, y: 0.017393980171814483d), new NpgsqlTypes.NpgsqlPoint(x: 0.5704349449016194d, y: 0.2805440099383969d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298961391906846d, y: 0.06166058721004519d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7232762027639854d, y: 0.14466555031520434d), new NpgsqlTypes.NpgsqlPoint(x: 0.6629551942779838d, y: 0.9487674026526427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988162053629555d, y: 0.7659836428275502d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3743766759546382d, y: 0.47539821621708545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874045082785816d, y: 0.6149465036434045d), new NpgsqlTypes.NpgsqlPoint(x: 0.17849269820089408d, y: 0.5036513299526235d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6814459001641997d, y: 0.9832981368002599d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394627470473733d, y: 0.6452838741469253d), new NpgsqlTypes.NpgsqlPoint(x: 0.53890058598634d, y: 0.3974813723513154d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8357665680831953d, y: 0.9626301724225655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118937298237551d, y: 0.920999412314495d), new NpgsqlTypes.NpgsqlPoint(x: 0.5015943934628971d, y: 0.10882905379195129d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005480423148278124d, y: 0.7873532913497465d), new NpgsqlTypes.NpgsqlPoint(x: 0.3454900456464719d, y: 0.19616033705864766d), new NpgsqlTypes.NpgsqlPoint(x: 0.724416023217792d, y: 0.05786086645098509d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052653212256121074d, y: 0.9819233294218306d), new NpgsqlTypes.NpgsqlPoint(x: 0.361438340531676d, y: 0.6393998574759436d), new NpgsqlTypes.NpgsqlPoint(x: 0.648126845903682d, y: 0.8025528441609203d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9720321155539623d, y: 0.8456850181174312d), new NpgsqlTypes.NpgsqlPoint(x: 0.7189845894732986d, y: 0.28443329718505284d), new NpgsqlTypes.NpgsqlPoint(x: 0.1250573165183272d, y: 0.8763421160719247d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26707082229893464d, y: 0.17394060315677118d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708883465246625d, y: 0.9592988475804901d), new NpgsqlTypes.NpgsqlPoint(x: 0.3573450656337086d, y: 0.41284836805649516d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2868149320199327d, y: 0.5666769454622304d), new NpgsqlTypes.NpgsqlPoint(x: 0.38944650116167334d, y: 7.257793968040716E-07d), new NpgsqlTypes.NpgsqlPoint(x: 0.3957361128989544d, y: 0.632911653985492d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.652487131439912d, y: 0.6158978284557275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6879851169870101d, y: 0.6397713376111599d), new NpgsqlTypes.NpgsqlPoint(x: 0.927626319364441d, y: 0.19940769975866024d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6579276036929411d, y: 0.4188988307621564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808621577900804d, y: 0.6830342069699724d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096677584277026d, y: 0.0926532567331736d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3715134486022049d, y: 0.11977669482638886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7541890582675919d, y: 0.44187369372413443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9380385930862838d, y: 0.7772916863994048d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7231311153974344d, y: 0.5578106128213812d), new NpgsqlTypes.NpgsqlPoint(x: 0.2933136965113218d, y: 0.5458778876133129d), new NpgsqlTypes.NpgsqlPoint(x: 0.013380741905880789d, y: 0.6175970045408348d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1412672442538223d, y: 0.3326299093884074d), new NpgsqlTypes.NpgsqlPoint(x: 0.27742033493435303d, y: 0.7112207647747122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8986565078263339d, y: 0.6410164787148434d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6413643302150016d, y: 0.1391259256128018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5632333227302119d, y: 0.2306125599925063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7884773374631772d, y: 0.30114250373084395d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36670567564309386d, y: 0.9722504229142981d), new NpgsqlTypes.NpgsqlPoint(x: 0.6174481212690831d, y: 0.8067181395357323d), new NpgsqlTypes.NpgsqlPoint(x: 0.05356259441436506d, y: 0.8646061217021405d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8665994614250658d, y: 0.3926483916537642d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784469118198136d, y: 0.04286138794958172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6709066686881613d, y: 0.6887081144574326d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3172417377469656d, y: 0.2520288364938088d), new NpgsqlTypes.NpgsqlPoint(x: 0.02479680089827263d, y: 0.1529650375629643d), new NpgsqlTypes.NpgsqlPoint(x: 0.14371379808899365d, y: 0.5775426081650731d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12690759040991684d, y: 0.5170321222039315d), new NpgsqlTypes.NpgsqlPoint(x: 0.028344380834322003d, y: 0.26685696021734095d), new NpgsqlTypes.NpgsqlPoint(x: 0.4458156668210811d, y: 0.7651753313379559d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8165970343122714d, y: 0.6488394636527789d), new NpgsqlTypes.NpgsqlPoint(x: 0.34432862120590335d, y: 0.4015752714533356d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579026135965832d, y: 0.38449671481077263d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5825309522308695d, y: 0.8053590708774208d), new NpgsqlTypes.NpgsqlPoint(x: 0.4124466299289632d, y: 0.5035781085757242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6834687292880555d, y: 0.30235334022831095d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05968747529275453d, y: 0.7732438104623679d), new NpgsqlTypes.NpgsqlPoint(x: 0.34130011347501676d, y: 0.8652157421619401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782561545273148d, y: 0.6974291929813943d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6157809625905655d, y: 0.4332929456136192d), new NpgsqlTypes.NpgsqlPoint(x: 0.33940337906668727d, y: 0.05383395776856592d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296644143700442d, y: 0.19608425651845218d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7974541269021855d, y: 0.7133829656087246d), new NpgsqlTypes.NpgsqlPoint(x: 0.4266488798603081d, y: 0.8884877694059758d), new NpgsqlTypes.NpgsqlPoint(x: 0.09024092100306014d, y: 0.2241031185394594d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7900997872843336d, y: 0.6601159758953675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4533249276033441d, y: 0.13680624972916267d), new NpgsqlTypes.NpgsqlPoint(x: 0.025631960478575855d, y: 0.5347671160848458d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33681633225162433d, y: 0.18494064742127214d), new NpgsqlTypes.NpgsqlPoint(x: 0.1421529976348257d, y: 0.8397005779912633d), new NpgsqlTypes.NpgsqlPoint(x: 0.04387203886267699d, y: 0.061433284028248325d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10455358215534438d, y: 0.22735352814188858d), new NpgsqlTypes.NpgsqlPoint(x: 0.13989497458935085d, y: 0.6262957933307431d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930301021951267d, y: 0.417208283981237d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11896078251800868d, y: 0.7442639041541449d), new NpgsqlTypes.NpgsqlPoint(x: 0.10406190639966162d, y: 0.6575973792422728d), new NpgsqlTypes.NpgsqlPoint(x: 0.189361582353487d, y: 0.8076607061339416d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43915201058754294d, y: 0.5192891562150855d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530296178552957d, y: 0.17491240205253034d), new NpgsqlTypes.NpgsqlPoint(x: 0.16148401374985788d, y: 0.40279674381037434d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1470855928986874d, y: 0.31748837862987334d), new NpgsqlTypes.NpgsqlPoint(x: 0.4552817531577339d, y: 0.6419532423424873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9354134951602042d, y: 0.04826035275830487d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7557136393775493d, y: 0.6712684849452834d), new NpgsqlTypes.NpgsqlPoint(x: 0.547572374098727d, y: 0.9113196605817003d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673142805881224d, y: 0.3927740929024388d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.431510944776882d, y: 0.3015818122655731d), new NpgsqlTypes.NpgsqlPoint(x: 0.7239844802121941d, y: 0.2170702452456461d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156515427722455d, y: 0.16098161112703246d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8400766310369722d, y: 0.4005563246737144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5416584195426093d, y: 0.9273654417683833d), new NpgsqlTypes.NpgsqlPoint(x: 0.7219266972743926d, y: 0.4524473508090827d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7674152623376026d, y: 0.3897075956169632d), new NpgsqlTypes.NpgsqlPoint(x: 0.0015832261541272041d, y: 0.2552168992127063d), new NpgsqlTypes.NpgsqlPoint(x: 0.07739970298820942d, y: 0.004013142041514817d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.458525136836506d, y: 0.1464933526841582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289315212877179d, y: 0.5580284217413342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136056458249604d, y: 0.9257747332335222d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5275832571343573d, y: 0.38837825009532934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430506281192065d, y: 0.2652170945247536d), new NpgsqlTypes.NpgsqlPoint(x: 0.05877411624358586d, y: 0.9391094543718768d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.885877553482266d, y: 0.4813273228676924d), new NpgsqlTypes.NpgsqlPoint(x: 0.03082769378507466d, y: 0.5709061649147549d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183134158181548d, y: 0.5039802433336092d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9163271898925689d, y: 0.23532357728064368d), new NpgsqlTypes.NpgsqlPoint(x: 0.22834247275010633d, y: 0.6709503303099873d), new NpgsqlTypes.NpgsqlPoint(x: 0.48200473138328537d, y: 0.8839678097459931d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9885858411466102d, y: 0.5727864641896024d), new NpgsqlTypes.NpgsqlPoint(x: 0.9407426540526914d, y: 0.718810160770445d), new NpgsqlTypes.NpgsqlPoint(x: 0.03414768798221568d, y: 0.97452613506677d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20436382049850554d, y: 0.4518519779950063d), new NpgsqlTypes.NpgsqlPoint(x: 0.4528227249677622d, y: 0.430758966278576d), new NpgsqlTypes.NpgsqlPoint(x: 0.12089627656970114d, y: 0.3740070748718952d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04513782159508928d, y: 0.16543285298651322d), new NpgsqlTypes.NpgsqlPoint(x: 0.43610355997688d, y: 0.5322482771798728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562508431180396d, y: 0.1580388685489078d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6061390322932231d, y: 0.37269006179013153d), new NpgsqlTypes.NpgsqlPoint(x: 0.03185767226235736d, y: 0.9925182359380842d), new NpgsqlTypes.NpgsqlPoint(x: 0.7252171499861657d, y: 0.3724284034831399d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017961001642884278d, y: 0.13768581193372909d), new NpgsqlTypes.NpgsqlPoint(x: 0.4390123411774648d, y: 0.2743090741128381d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920040045390613d, y: 0.21597596915897088d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8547154186463329d, y: 0.5493700211898846d), new NpgsqlTypes.NpgsqlPoint(x: 0.539075459279148d, y: 0.6747836817515107d), new NpgsqlTypes.NpgsqlPoint(x: 0.47485232941584765d, y: 0.49146543280792354d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7030576899018112d, y: 0.3157608164415927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8312783212821198d, y: 0.40458127808605127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5599840554509629d, y: 0.8704318330498316d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45478928710752065d, y: 0.6831691818460984d), new NpgsqlTypes.NpgsqlPoint(x: 0.2514312037071559d, y: 0.4355450797377093d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979238778967789d, y: 0.22798340834269804d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19103930439636185d, y: 0.17703700618040452d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295431843524282d, y: 0.06344638404854219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463171604904336d, y: 0.07053487849271145d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8926913570835369d, y: 0.9992382563950094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564900615402978d, y: 0.32929682625684487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846469664663619d, y: 0.6888359757775837d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)), 
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
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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

                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPolygonListpolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[29], false);
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

                var models =  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[1], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[2], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[3], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 47, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 87, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[29], false);
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
                var models =  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatch(connection, 29, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlPolygonListpolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

