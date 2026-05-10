

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9447657446005393d, y: 0.721900503815809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5643293470572015d, y: 0.8501109343950158d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0750568299306904d, y: 0.9108120120400942d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3274262583231651d, y: 0.9760966141375196d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9432862152405355d, y: 0.32216263224820485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9883553268335923d, y: 0.7842805262429887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.732865294067577d, y: 0.73085144969178d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7845788424582765d, y: 0.8701329178691327d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1928949944418723d, y: 0.10178704128627913d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8098531457272191d, y: 0.9471125130121366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37054901831400866d, y: 0.549507104870691d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5197595044616885d, y: 0.7279223267377152d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5512440503321065d, y: 0.5853906818795938d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9431474175750986d, y: 0.23020883101975642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06537646030927857d, y: 0.5640303228580625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9563648458450328d, y: 0.019089060059125806d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8137225099232731d, y: 0.713089356671249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5215355950056894d, y: 0.19788142014312615d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16606649665618234d, y: 0.5650115237665576d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37114520464380696d, y: 0.4996916145371535d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8693271024308543d, y: 0.5713032779715143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32067835841403947d, y: 0.3087866550724083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7267342749692972d, y: 0.2664094985553448d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3721415680116519d, y: 0.24459724684847794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6478731618049939d, y: 0.15054869043535657d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2720925122762863d, y: 0.5284967099265612d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36736679557890717d, y: 0.4961320150469921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9582234549141918d, y: 0.9944924478932268d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5893618871941542d, y: 0.7412923539646936d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2964088706502189d, y: 0.060476824705487986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30010916927848563d, y: 0.33659903492244014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8569831327136187d, y: 0.5099324893292488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3906828634258146d, y: 0.3874046342302372d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9074390283429434d, y: 0.1200022253327675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20591032158285405d, y: 0.34284898500903904d),

new NpgsqlTypes.NpgsqlPoint(x: 0.304183431180864d, y: 0.07687917940635747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26945071985628977d, y: 0.36161200885450895d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.298254058241061d, y: 0.3688622757322584d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9477525265592769d, y: 0.8014405992003799d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4908232984648436d, y: 0.17049430149051736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6496022975258902d, y: 0.7259350697202706d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.719763693323633d, y: 0.06582470873040414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2809706156436985d, y: 0.2971512581092517d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0590359035656185d, y: 0.3459116329600742d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5859584902408566d, y: 0.8955329695243713d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21124935757947794d, y: 0.5664083964920129d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9908382346228918d, y: 0.8986268657637824d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5682264864945387d, y: 0.8644664960966623d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6474576195051219d, y: 0.5321980493254369d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6498943382976405d, y: 0.060241295014587304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9852781820047831d, y: 0.07629747698975609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08373566484193784d, y: 0.4168644818195273d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8071375692966571d, y: 0.9588014668365609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09988434198141749d, y: 0.4719169060757874d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21397711935976071d, y: 0.8745616251288677d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.944588239617277d, y: 0.699796051445611d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8358596231648706d, y: 0.9916698108742216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.009801004396090662d, y: 0.05015702165551694d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6058115857209199d, y: 0.8320937592778639d),

new NpgsqlTypes.NpgsqlPoint(x: 0.957703974785828d, y: 0.7592812614359289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07307390750850296d, y: 0.6702471351765132d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.709828838557319d, y: 0.8082958633310635d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28638273642663026d, y: 0.8760113882100947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9468681775895559d, y: 0.28130903508590976d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24406095860850407d, y: 0.8844515334140269d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5613483930082162d, y: 0.5591984404053378d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02278000405158853d, y: 0.5113977223758025d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0970883296673074d, y: 0.3489373835433305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4727991302081972d, y: 0.8645432079550285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26870161146626304d, y: 0.5800755705968675d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05269398586574403d, y: 0.7791635519623327d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6444478447727017d, y: 0.291606201228819d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5667512368765786d, y: 0.32675464598152326d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42891928317572514d, y: 0.8050468709546653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6998287358618697d, y: 0.6836653966919398d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9697835423323542d, y: 0.6496240818689805d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04969955431393602d, y: 0.5185564595740567d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4820329136519821d, y: 0.6900904636408965d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9685149664519325d, y: 0.3768696402639723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3155892288472948d, y: 0.8341667875811366d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44903420576726616d, y: 0.7463336982884821d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5350864186901715d, y: 0.1473954822496989d),

new NpgsqlTypes.NpgsqlPoint(x: 0.68609422038566d, y: 0.8056451486621055d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5518823381386025d, y: 0.8190990662856404d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2982999424305337d, y: 0.5781876501090695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8105486338706785d, y: 0.4448747467509411d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9548831437727529d, y: 0.3951975620377757d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.409792102853768d, y: 0.8134439554493585d),

new NpgsqlTypes.NpgsqlPoint(x: 0.017606700838196487d, y: 0.2019764092802181d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19055381098816015d, y: 0.9272089976936441d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9300475783834165d, y: 0.5532276996153604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3730495219922796d, y: 0.9535419212770343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45125877363700606d, y: 0.8971729220413421d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8919048471831849d, y: 0.37094479599689634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9195130384570116d, y: 0.06776284177590686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7844442290007d, y: 0.5500394701075852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09441253751404988d, y: 0.40818044174993795d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9462231303583278d, y: 0.5559726342212861d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7067595780866901d, y: 0.05944158176680736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6068246997038017d, y: 0.15567932031879128d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6331306638221099d, y: 0.6246982383002441d),

new NpgsqlTypes.NpgsqlPoint(x: 0.199291899947883d, y: 0.7798171374594606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.564355596169973d, y: 0.9284236608715932d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6412697934385057d, y: 0.1636008729888545d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7167773156155813d, y: 0.6187179072297466d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4226548029139998d, y: 0.9923042496377243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1439198512610783d, y: 0.4170306775246929d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29160176209252575d, y: 0.23259424655459615d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9533972366871538d, y: 0.5804766253153694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5138167874083793d, y: 0.26684560532349133d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5882385729337992d, y: 0.18072513500210408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4976167540578217d, y: 0.9137588202839217d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20644509888723028d, y: 0.8479208758979381d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7333502269157952d, y: 0.3818482077289188d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07366445918768172d, y: 0.6696445013037213d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5304115940040915d, y: 0.26839093241758194d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10259506181563816d, y: 0.440308251910306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27233304718214724d, y: 0.5727571443137099d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9769276105388849d, y: 0.7331097515180999d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0991197936823639d, y: 0.23451903870287272d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1955492670707082d, y: 0.7670526499729013d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10115417974676777d, y: 0.4971685283666679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2536884823760285d, y: 0.10890709165787049d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8902748527412984d, y: 0.621302000880884d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02549406106894614d, y: 0.8805385874435392d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9188098368107973d, y: 0.9807674613189302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5371857598157807d, y: 0.510542960174785d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.359952792647377d, y: 0.9195492981843383d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8514190929808358d, y: 0.3729281614546388d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4519543220940425d, y: 0.336129057138863d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8993663105519638d, y: 0.8041723702643588d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8175868003258541d, y: 0.8379009540559028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5927598997344802d, y: 0.9281438391942012d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7349377923173807d, y: 0.5229879604318524d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15662828328917644d, y: 0.24743843466137605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3530975895133245d, y: 0.827623954627532d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25185327687759196d, y: 0.03447742275337218d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1289552744958251d, y: 0.9744154337747203d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8346555044597674d, y: 0.9975236987442996d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7571476829309093d, y: 0.10048540961951358d),

new NpgsqlTypes.NpgsqlPoint(x: 0.398282727308356d, y: 0.6790350636636614d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3457048423094532d, y: 0.10566871038060544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13863623166122852d, y: 0.4314696297279055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4750616952020442d, y: 0.2834154892459678d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10132684982914886d, y: 0.05548970076856874d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45696734154020935d, y: 0.8199584875795879d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2591838123745347d, y: 0.7934551183587627d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7376872928215847d, y: 0.17098033188616013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23517586215420527d, y: 0.29601306382765447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.016733001503209444d, y: 0.7812987522148921d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.523293402464739d, y: 0.5357090214385937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9833974843354928d, y: 0.6785116868142252d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09292015598826031d, y: 0.713766977760526d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13944626476613065d, y: 0.7629533052404524d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14288026072908588d, y: 0.35201989770694075d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13478968752234044d, y: 0.6868026885740234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9461609088785798d, y: 0.9610670949795678d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5820809594059309d, y: 0.5732571934506664d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12232513301843673d, y: 0.0170093786164206d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09314262879523494d, y: 0.37049605349137005d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8172580326923335d, y: 0.2135109688083615d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42227052286722055d, y: 0.054616266358853305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8209145455651627d, y: 0.7108939852176408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517009079150568d, y: 0.04929557454628963d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3512549266026457d, y: 0.6476570680810045d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5759466252591123d, y: 0.5868595059110746d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9677109205085384d, y: 0.24074540923346488d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20878049454181247d, y: 0.6598832847607399d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5182605857442388d, y: 0.4000871831986774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7116483565134234d, y: 0.47328043039075374d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5289018597070543d, y: 0.36320401176836425d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26710152487149397d, y: 0.42924832863299733d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5463976736992644d, y: 0.8157427905355653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8590424879301564d, y: 0.05008333736402204d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35772868741076314d, y: 0.9113422422135564d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2936020541396118d, y: 0.9900665631281595d),

new NpgsqlTypes.NpgsqlPoint(x: 0.875343774174416d, y: 0.9169682771436735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49557760483843993d, y: 0.6752230344616243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3668136658877985d, y: 0.7125840580840819d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8219110140166471d, y: 0.44848954428243815d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6435547661168923d, y: 0.8503033397253802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.025149911326591057d, y: 0.21770176464741686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05605586978791177d, y: 0.8322857365595596d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7182081712861607d, y: 0.6604925549454411d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26063996871072204d, y: 0.12728673209500518d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18121472048697596d, y: 0.7436256082237586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48431600900146754d, y: 0.5570029826972165d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32639118303630754d, y: 0.5857497635409705d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6186029620777376d, y: 0.7653320649589352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43032193244060957d, y: 0.2965332642576025d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2548650553386105d, y: 0.6853117121196866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15921870484233547d, y: 0.67530493661301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5774009973505946d, y: 0.8140273194193385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46943591878160496d, y: 0.6185605137121073d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17081546835861272d, y: 0.9843533098797279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4416779990390791d, y: 0.48860066538349256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2833421144730811d, y: 0.7095115264408918d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07557245691060788d, y: 0.6218478435810969d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0602960629753565d, y: 0.946908875156643d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038499137148977236d, y: 0.44060883055169353d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2953779033434899d, y: 0.6450889895081666d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8473886311044968d, y: 0.9695070955113384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12443853585915743d, y: 0.5171517687095886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7087281075079376d, y: 0.019623601662114742d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.999893706246596d, y: 0.005750400849308335d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14830804536456998d, y: 0.7788356980994154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5748548913925259d, y: 0.0733527849377037d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7532130783119355d, y: 0.3577678834097562d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7478932235195992d, y: 0.8817697372608787d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30254819470699335d, y: 0.3806395366212767d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8569267070129436d, y: 0.21819758378058263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5930756938727835d, y: 0.6057364062013867d),

new NpgsqlTypes.NpgsqlPoint(x: 0.746195834318304d, y: 0.88735614355525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5661537740334985d, y: 0.03510093576593343d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.00027697234184331787d, y: 0.8737311202705097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3958346607420894d, y: 0.41044477206179364d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34151158576183316d, y: 0.4805197288711768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1744984869604871d, y: 0.713069536975413d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2523145876654437d, y: 0.053831284468696894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8775595262387188d, y: 0.9524795055286225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8759033852999079d, y: 0.08449663318709377d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4380232383662256d, y: 0.332067451084339d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05316724770563952d, y: 0.7869256663048149d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7332078663523953d, y: 0.9451294326509392d),

new NpgsqlTypes.NpgsqlPoint(x: 0.494885818992703d, y: 0.2476878620087084d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12490341234541835d, y: 0.7491159240623739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406565963930382d, y: 0.0004392509694909341d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6668318395455918d, y: 0.8473127540633998d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5612606470446809d, y: 0.3055176038333909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11307792184899679d, y: 0.6203966312921866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6591193172710703d, y: 0.636102778081852d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2924153338809842d, y: 0.1829232064844386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8361011920030432d, y: 0.1849034494981393d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8291660364905314d, y: 0.011064067320254334d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30266304758644214d, y: 0.030697945699098117d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8953794089530819d, y: 0.27165923044460283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28646342084441034d, y: 0.24883726250059635d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7546626172007799d, y: 0.05377876737768705d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6371956121115293d, y: 0.04653914135070725d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10617553065653929d, y: 0.2195380522365531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9777485143313127d, y: 0.3909371803267734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6647343264413602d, y: 0.7016381017081004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8410021216323408d, y: 0.2763119265750459d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13589121841499074d, y: 0.19274767113455038d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9799660698206634d, y: 0.10525446724238863d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8878496791083478d, y: 0.04360917820853727d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3277789122732806d, y: 0.6893655789893653d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6390304674678501d, y: 0.7517160120586729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17209076173214255d, y: 0.0037698365515460575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5039609546829427d, y: 0.7543959530463411d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4134062365793608d, y: 0.172330261017282d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05540639525042379d, y: 0.30614861459340104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7349372427735839d, y: 0.1930546383394951d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13625782664400465d, y: 0.25979976710288744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9473595497865807d, y: 0.4209839699044332d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43729239655056784d, y: 0.7477281258520483d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04919661596638225d, y: 0.9927554489007945d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5069293305843275d, y: 0.6538805192928633d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.003367876095938249d, y: 0.5479954031617488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2848573731488373d, y: 0.6789548420018079d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8228459567210699d, y: 0.014983552989010218d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5849272621200526d, y: 0.8012091044889414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06379075742714635d, y: 0.20058319446810646d),

new NpgsqlTypes.NpgsqlPoint(x: 0.061566378478692285d, y: 0.1135640818610748d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18089616323951296d, y: 0.8215760568650126d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4962672067358076d, y: 0.9198803651008279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1427045329689992d, y: 0.19067039741798775d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 146, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 135, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 117, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 20, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 164, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 81, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 10, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[25],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[26],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

