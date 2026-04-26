

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7281128888602276d, b: 0.19545968198989083d, c: 0.1377920680909398d),

new NpgsqlTypes.NpgsqlLine(a: 0.9097042732065035d, b: 0.19740861814358024d, c: 0.29150136296056894d),

new NpgsqlTypes.NpgsqlLine(a: 0.9898588425209122d, b: 0.11002112003118969d, c: 0.6576924152670627d),

new NpgsqlTypes.NpgsqlLine(a: 0.7285237127346795d, b: 0.5897297211748881d, c: 0.5505931780390663d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8313186017017111d, b: 0.8389398363259366d, c: 0.41852988384003564d),

new NpgsqlTypes.NpgsqlLine(a: 0.05290222403624911d, b: 0.03267711155671271d, c: 0.8217915662103371d),

new NpgsqlTypes.NpgsqlLine(a: 0.9568171546943662d, b: 0.821577194847359d, c: 0.5585630775285351d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8265323525931757d, b: 0.5558258138884289d, c: 0.4452125484136724d),

new NpgsqlTypes.NpgsqlLine(a: 0.14537372311233654d, b: 0.942003597025595d, c: 0.8639886434436024d),

new NpgsqlTypes.NpgsqlLine(a: 0.9739773993534946d, b: 0.4303577267640448d, c: 0.9189308448147867d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2155195886770812d, b: 0.43209442712981305d, c: 0.7833786411694466d),

new NpgsqlTypes.NpgsqlLine(a: 0.4371158789978494d, b: 0.4745173531968403d, c: 0.6767362701938681d),

new NpgsqlTypes.NpgsqlLine(a: 0.344231458056809d, b: 0.9776116418812312d, c: 0.8773788433726734d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6689539134986745d, b: 0.47363373313315515d, c: 0.24199860949307028d),

new NpgsqlTypes.NpgsqlLine(a: 0.2163061537105362d, b: 0.566819751496114d, c: 0.6209424717725062d),

new NpgsqlTypes.NpgsqlLine(a: 0.2815810710291172d, b: 0.2285086115976135d, c: 0.05272019288121388d),

new NpgsqlTypes.NpgsqlLine(a: 0.5924891664104386d, b: 0.378782085374031d, c: 0.0827176804837414d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5750037582142791d, b: 0.7350843056893602d, c: 0.08660608676574955d),

new NpgsqlTypes.NpgsqlLine(a: 0.14523080476226446d, b: 0.6796200234986957d, c: 0.11249663153610023d),

new NpgsqlTypes.NpgsqlLine(a: 0.8210386185892379d, b: 0.5579432563540668d, c: 0.06969147295769385d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1728324654669393d, b: 0.10706739117390918d, c: 0.619013254583009d),

new NpgsqlTypes.NpgsqlLine(a: 0.0246996452648387d, b: 0.8225015717789821d, c: 0.9781985598148779d),

new NpgsqlTypes.NpgsqlLine(a: 0.7012332118122809d, b: 0.35972679815597663d, c: 0.6812252743373435d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2550791518393476d, b: 0.5692469340435516d, c: 0.6777211999661432d),

new NpgsqlTypes.NpgsqlLine(a: 0.5470126817990583d, b: 0.37519093408167725d, c: 0.9358107113710766d),

new NpgsqlTypes.NpgsqlLine(a: 0.497496234726422d, b: 0.8193965895935557d, c: 0.2072786577904414d),

new NpgsqlTypes.NpgsqlLine(a: 0.3860866033127862d, b: 0.3142208634731348d, c: 0.6039754525743941d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9009643278569633d, b: 0.17044614156712667d, c: 0.18047298088710695d),

new NpgsqlTypes.NpgsqlLine(a: 0.2462555172026314d, b: 0.8081657665544625d, c: 0.6355786283275479d),

new NpgsqlTypes.NpgsqlLine(a: 0.465993689526514d, b: 0.5237822206477892d, c: 0.5151585357589735d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2716699964389607d, b: 0.5448279836037669d, c: 0.745148549763606d),

new NpgsqlTypes.NpgsqlLine(a: 0.43627621560843666d, b: 0.5085151865368185d, c: 0.8890348444036585d),

new NpgsqlTypes.NpgsqlLine(a: 0.2606217800563202d, b: 0.9126635548737811d, c: 0.4710103626100923d),

new NpgsqlTypes.NpgsqlLine(a: 0.6041585941174554d, b: 0.3924138034712412d, c: 0.747877210924516d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21391150548291182d, b: 0.41372530056833023d, c: 0.49192852173268853d),

new NpgsqlTypes.NpgsqlLine(a: 0.7570879197202541d, b: 0.29476251929399044d, c: 0.11964139881654678d),

new NpgsqlTypes.NpgsqlLine(a: 0.9254056841892531d, b: 0.07747089422593434d, c: 0.2988404078187272d),

new NpgsqlTypes.NpgsqlLine(a: 0.8750229536662963d, b: 0.9871575272959606d, c: 0.8035379276332816d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13881824814089483d, b: 0.6427888929216722d, c: 0.8932706342365799d),

new NpgsqlTypes.NpgsqlLine(a: 0.26679313542968497d, b: 0.25195298571644587d, c: 0.599095354106062d),

new NpgsqlTypes.NpgsqlLine(a: 0.785016710425044d, b: 0.29306712343943897d, c: 0.057708506717440655d),

new NpgsqlTypes.NpgsqlLine(a: 0.6694474896084178d, b: 0.21641328075995359d, c: 0.007750570747050101d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6003811418762105d, b: 0.7313621287189865d, c: 0.8347332149464503d),

new NpgsqlTypes.NpgsqlLine(a: 0.6581784781417968d, b: 0.04881707818025338d, c: 0.46686770396399957d),

new NpgsqlTypes.NpgsqlLine(a: 0.22498845225171926d, b: 0.1514599510999316d, c: 0.3521086006277696d),

new NpgsqlTypes.NpgsqlLine(a: 0.6661385791457352d, b: 0.6926223497631543d, c: 0.8882957511905192d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6627835888072406d, b: 0.052597872622167086d, c: 0.3224581459134984d),

new NpgsqlTypes.NpgsqlLine(a: 0.2532617282980879d, b: 0.024136479596776894d, c: 0.13232349462299176d),

new NpgsqlTypes.NpgsqlLine(a: 0.44279546781684365d, b: 0.8799156219224937d, c: 0.47008392780781194d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1934121019669599d, b: 0.27204583249143444d, c: 0.18496959306046656d),

new NpgsqlTypes.NpgsqlLine(a: 0.1031276148595971d, b: 0.7645470029883696d, c: 0.5026268799106488d),

new NpgsqlTypes.NpgsqlLine(a: 0.8473689749958866d, b: 0.16860296386058982d, c: 0.8947864197238936d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3773101196191636d, b: 0.20826844757999852d, c: 0.4833518484076318d),

new NpgsqlTypes.NpgsqlLine(a: 0.782052575197499d, b: 0.9195818415874257d, c: 0.8885274444433824d),

new NpgsqlTypes.NpgsqlLine(a: 0.18774933534196414d, b: 0.19776504847277598d, c: 0.2550528389128528d),

new NpgsqlTypes.NpgsqlLine(a: 0.25634499803122845d, b: 0.9662147500707394d, c: 0.03856802609849441d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8793936993035094d, b: 0.9074087036200735d, c: 0.47198748792287826d),

new NpgsqlTypes.NpgsqlLine(a: 0.8063322897693502d, b: 0.7583088714235539d, c: 0.9781531837481623d),

new NpgsqlTypes.NpgsqlLine(a: 0.49554718934346786d, b: 0.49508805446261517d, c: 0.8776354949465666d),

new NpgsqlTypes.NpgsqlLine(a: 0.18284916025235098d, b: 0.7780337447653308d, c: 0.6971386128358992d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4596057625219474d, b: 0.8171153051041338d, c: 0.8726553886005735d),

new NpgsqlTypes.NpgsqlLine(a: 0.0027714543208777753d, b: 0.6008592619812487d, c: 0.1714734893583164d),

new NpgsqlTypes.NpgsqlLine(a: 0.7356306393378458d, b: 0.23825393894953262d, c: 0.37109421915217944d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.519892848783595d, b: 0.8454308570024024d, c: 0.38851558872390757d),

new NpgsqlTypes.NpgsqlLine(a: 0.12410782326833492d, b: 0.5303900815766445d, c: 0.8533127885973011d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264218787993529d, b: 0.8789723301863633d, c: 0.16177499274548957d),

new NpgsqlTypes.NpgsqlLine(a: 0.938771762034808d, b: 0.5200432643634949d, c: 0.38765276617845457d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9174993841961941d, b: 0.3001618008161899d, c: 0.9445177368222641d),

new NpgsqlTypes.NpgsqlLine(a: 0.7462035872413872d, b: 0.9455624500798635d, c: 0.9920861713136558d),

new NpgsqlTypes.NpgsqlLine(a: 0.6579229317515441d, b: 0.9890349572244559d, c: 0.9913872864485282d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27416310251699294d, b: 0.9819916386144792d, c: 0.7008225728701662d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662615379891273d, b: 0.7916027810786632d, c: 0.16389423759897215d),

new NpgsqlTypes.NpgsqlLine(a: 0.304601857736599d, b: 0.34498877502915104d, c: 0.24081795226940295d),

new NpgsqlTypes.NpgsqlLine(a: 0.9648130851862766d, b: 0.748721545515756d, c: 0.48263422696034997d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.026730132967148545d, b: 0.1567751746031517d, c: 0.514563416871542d),

new NpgsqlTypes.NpgsqlLine(a: 0.5487925067009638d, b: 0.1132543475111002d, c: 0.8471614211698306d),

new NpgsqlTypes.NpgsqlLine(a: 0.5250249278262256d, b: 0.798768923731395d, c: 0.11871100751282304d),

new NpgsqlTypes.NpgsqlLine(a: 0.5905755729824737d, b: 0.2515178945072013d, c: 0.2475630948623323d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6169067682606777d, b: 0.008787957340322339d, c: 0.16268443515242803d),

new NpgsqlTypes.NpgsqlLine(a: 0.6997728028910573d, b: 0.9753115461326791d, c: 0.8822400143440401d),

new NpgsqlTypes.NpgsqlLine(a: 0.43948239518234467d, b: 0.9205473018213551d, c: 0.7339079154757017d),

new NpgsqlTypes.NpgsqlLine(a: 0.9445858483301166d, b: 0.6671304110638644d, c: 0.930376239886638d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6434771053956038d, b: 0.30351658078412824d, c: 0.9818907812617534d),

new NpgsqlTypes.NpgsqlLine(a: 0.2659265558311277d, b: 0.6982516760298709d, c: 0.9693405776703755d),

new NpgsqlTypes.NpgsqlLine(a: 0.5238138353075998d, b: 0.0405509358743712d, c: 0.8673377826098209d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10260454070539493d, b: 0.004850551192473573d, c: 0.8017601995218367d),

new NpgsqlTypes.NpgsqlLine(a: 0.7036340201952901d, b: 0.8924139793318268d, c: 0.07186913368759473d),

new NpgsqlTypes.NpgsqlLine(a: 0.09853481453103852d, b: 0.2744755238111971d, c: 0.2475442208300488d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1364719782806424d, b: 0.9560326607661562d, c: 0.18344947483171437d),

new NpgsqlTypes.NpgsqlLine(a: 0.690507161267582d, b: 0.36159843768296973d, c: 0.28966686957443066d),

new NpgsqlTypes.NpgsqlLine(a: 0.18232250912047243d, b: 0.9946955576868991d, c: 0.4467274934047808d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3401045780967541d, b: 0.28544969316503654d, c: 0.09195894309589991d),

new NpgsqlTypes.NpgsqlLine(a: 0.3008058556412252d, b: 0.3289703513962371d, c: 0.987322321475095d),

new NpgsqlTypes.NpgsqlLine(a: 0.4486210129618359d, b: 0.8067328345156242d, c: 0.05502442288285325d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7621406260559493d, b: 0.24952393536519468d, c: 0.8724258782611417d),

new NpgsqlTypes.NpgsqlLine(a: 0.6874717732077733d, b: 0.052649200820987674d, c: 0.322595253358707d),

new NpgsqlTypes.NpgsqlLine(a: 0.7773535861234007d, b: 0.020333079042773594d, c: 0.554847398277105d),

new NpgsqlTypes.NpgsqlLine(a: 0.7745329671508017d, b: 0.08131162289794291d, c: 0.40884669248095606d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7061498694834519d, b: 0.46622181715942623d, c: 0.003629502387655137d),

new NpgsqlTypes.NpgsqlLine(a: 0.8975676212713048d, b: 0.7475882057065886d, c: 0.37866019177902d),

new NpgsqlTypes.NpgsqlLine(a: 0.2922058175853407d, b: 0.9312997056810985d, c: 0.21861643367481054d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6852374892252231d, b: 0.5258078969893144d, c: 0.02799863587409057d),

new NpgsqlTypes.NpgsqlLine(a: 0.1910539311604803d, b: 0.9516868430570482d, c: 0.2834942375877393d),

new NpgsqlTypes.NpgsqlLine(a: 0.12335317653506328d, b: 0.48083961067874514d, c: 0.05836392765914811d),

new NpgsqlTypes.NpgsqlLine(a: 0.9265621471034773d, b: 0.7377572268148952d, c: 0.7257416336508895d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24641663974503203d, b: 0.5317064721328821d, c: 0.9330293395304056d),

new NpgsqlTypes.NpgsqlLine(a: 0.7307779609611591d, b: 0.7711635764121552d, c: 0.9110996891485129d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467418042890337d, b: 0.8863803388979574d, c: 0.5480922222897651d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44252299773028914d, b: 0.6053810111751168d, c: 0.4729658520468456d),

new NpgsqlTypes.NpgsqlLine(a: 0.9961305154820018d, b: 0.10505624307633621d, c: 0.043955506229126584d),

new NpgsqlTypes.NpgsqlLine(a: 0.9025022370717287d, b: 0.7014579192615301d, c: 0.6291999926907739d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4224480628351992d, b: 0.02160877027947883d, c: 0.09131590999562589d),

new NpgsqlTypes.NpgsqlLine(a: 0.01915510274303389d, b: 0.557885087339578d, c: 0.5615927405416313d),

new NpgsqlTypes.NpgsqlLine(a: 0.16334747673142336d, b: 0.4983942683333741d, c: 0.40036617758164883d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40047236473114944d, b: 0.843607555797528d, c: 0.5050841277490045d),

new NpgsqlTypes.NpgsqlLine(a: 0.6372963087412165d, b: 0.9063177481509596d, c: 0.6468974958116501d),

new NpgsqlTypes.NpgsqlLine(a: 0.9909665753462595d, b: 0.1374653636460872d, c: 0.860939149536208d),

new NpgsqlTypes.NpgsqlLine(a: 0.48953470699337986d, b: 0.1629979595928479d, c: 0.5027676885013952d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2823208136904213d, b: 0.7309030577425197d, c: 0.6354761364398172d),

new NpgsqlTypes.NpgsqlLine(a: 0.2273036727428459d, b: 0.7699294589899721d, c: 0.9559971222211977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8042066973325633d, b: 0.5971614763025417d, c: 0.14590302160145652d),

new NpgsqlTypes.NpgsqlLine(a: 0.7166934955631387d, b: 0.8413257915842833d, c: 0.3403245258635106d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5401663806008711d, b: 0.721938552479202d, c: 0.4573740315048239d),

new NpgsqlTypes.NpgsqlLine(a: 0.5066530570861713d, b: 0.2818350968291212d, c: 0.9685670860097743d),

new NpgsqlTypes.NpgsqlLine(a: 0.2327532498269369d, b: 0.9816166375712194d, c: 0.5212751185381884d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9809828576221316d, b: 0.8471842126490157d, c: 0.8946235024091088d),

new NpgsqlTypes.NpgsqlLine(a: 0.18683650682935427d, b: 0.18224512638543555d, c: 0.7242361745885528d),

new NpgsqlTypes.NpgsqlLine(a: 0.06692988510796405d, b: 0.1651137404759262d, c: 0.5966856509259612d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24804387124491578d, b: 0.23907787932679558d, c: 0.9114481263913808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8898720206519368d, b: 0.23789924191970213d, c: 0.20886595753131376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9553149913652534d, b: 0.39485853680638705d, c: 0.17380276112380366d),

new NpgsqlTypes.NpgsqlLine(a: 0.9508928637768256d, b: 0.38743155848424593d, c: 0.6925457317451899d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06075406844392317d, b: 0.4756801024458799d, c: 0.9820774805176782d),

new NpgsqlTypes.NpgsqlLine(a: 0.9865686750635283d, b: 0.27550345822581146d, c: 0.056145475632468855d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795962549484194d, b: 0.1378691959876126d, c: 0.44013355047610525d),

new NpgsqlTypes.NpgsqlLine(a: 0.777223766404983d, b: 0.6327467744916105d, c: 0.02105329721080562d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8167883519997757d, b: 0.6948852264706402d, c: 0.6925474290077556d),

new NpgsqlTypes.NpgsqlLine(a: 0.8088339216351877d, b: 0.04959566433985663d, c: 0.9579878720714539d),

new NpgsqlTypes.NpgsqlLine(a: 0.12780986664809735d, b: 0.29546285745281287d, c: 0.04573423199499227d),

new NpgsqlTypes.NpgsqlLine(a: 0.19620083318165427d, b: 0.9800434796763987d, c: 0.5000472515068639d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5149497567253413d, b: 0.1853160914739319d, c: 0.8258892573401324d),

new NpgsqlTypes.NpgsqlLine(a: 0.3565195064185799d, b: 0.14480512977173676d, c: 0.8130353871189234d),

new NpgsqlTypes.NpgsqlLine(a: 0.9547211204056317d, b: 0.5537522612033179d, c: 0.0025808897390446894d),

new NpgsqlTypes.NpgsqlLine(a: 0.7575009775973119d, b: 0.25373660826660294d, c: 0.10708362192936582d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.043304161181452194d, b: 0.7527025421945824d, c: 0.6494519774452225d),

new NpgsqlTypes.NpgsqlLine(a: 0.1424760349971228d, b: 0.2972172556520416d, c: 0.5693447182250072d),

new NpgsqlTypes.NpgsqlLine(a: 0.5175072599185164d, b: 0.007319106084691995d, c: 0.1007901668321679d),

new NpgsqlTypes.NpgsqlLine(a: 0.6497863984595442d, b: 0.07011250738599428d, c: 0.42959500678922025d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9259675842932223d, b: 0.16102918665069732d, c: 0.6907694209588654d),

new NpgsqlTypes.NpgsqlLine(a: 0.0016760354899555407d, b: 0.13168319028418518d, c: 0.7083127123100061d),

new NpgsqlTypes.NpgsqlLine(a: 0.05549191481085891d, b: 0.6161603916248845d, c: 0.22498461925474422d),

new NpgsqlTypes.NpgsqlLine(a: 0.5310727489858308d, b: 0.45995140762280806d, c: 0.8195724194537546d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22275143708586576d, b: 0.4511654730518938d, c: 0.2019492693449375d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311269320985997d, b: 0.49154215132605383d, c: 0.2782067636465114d),

new NpgsqlTypes.NpgsqlLine(a: 0.6569429194602586d, b: 0.37763244703829735d, c: 0.07949184927034614d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9820890446311146d, b: 0.8632057809721162d, c: 0.6632869151655125d),

new NpgsqlTypes.NpgsqlLine(a: 0.38196869605624195d, b: 0.8056650606887266d, c: 0.7976099809531094d),

new NpgsqlTypes.NpgsqlLine(a: 0.7553663321939572d, b: 0.4426967787981603d, c: 0.945697247399757d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7912783310338273d, b: 0.26206358041623423d, c: 0.09089985259843181d),

new NpgsqlTypes.NpgsqlLine(a: 0.16458571111616294d, b: 0.43101452351734293d, c: 0.920032518061933d),

new NpgsqlTypes.NpgsqlLine(a: 0.5896960065843445d, b: 0.71796538910374d, c: 0.6850519746051831d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5579772916895162d, b: 0.693315770162815d, c: 0.5596661070506685d),

new NpgsqlTypes.NpgsqlLine(a: 0.5681145976326653d, b: 0.14105902960110706d, c: 0.9798977373554957d),

new NpgsqlTypes.NpgsqlLine(a: 0.887284087772409d, b: 0.7514727076580328d, c: 0.565634086173771d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3956908067667493d, b: 0.20170062614985607d, c: 0.5553010245159741d),

new NpgsqlTypes.NpgsqlLine(a: 0.06252171105627102d, b: 0.1484812387306007d, c: 0.5332915407713558d),

new NpgsqlTypes.NpgsqlLine(a: 0.028018365106108445d, b: 0.043326699853349804d, c: 0.08045103808432885d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03728507704579276d, b: 0.6271488417379643d, c: 0.30071167864681114d),

new NpgsqlTypes.NpgsqlLine(a: 0.2252924867324151d, b: 0.35751239269311774d, c: 0.8366225064907918d),

new NpgsqlTypes.NpgsqlLine(a: 0.9673406894327609d, b: 0.2552506454645628d, c: 0.9338175737605874d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14441301202300383d, b: 0.566596082522992d, c: 0.7643486467834608d),

new NpgsqlTypes.NpgsqlLine(a: 0.8592374315345361d, b: 0.3509394943726827d, c: 0.7659788669397594d),

new NpgsqlTypes.NpgsqlLine(a: 0.9440059513829495d, b: 0.2788545693205857d, c: 0.4050309722265315d),

new NpgsqlTypes.NpgsqlLine(a: 0.07165537382867171d, b: 0.053940219443567194d, c: 0.09177667890836794d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9148373054310289d, b: 0.8718809756209934d, c: 0.7125476129246553d),

new NpgsqlTypes.NpgsqlLine(a: 0.36161286253081837d, b: 0.39967640604096033d, c: 0.005897151339928297d),

new NpgsqlTypes.NpgsqlLine(a: 0.1504440397090009d, b: 0.49688216313592415d, c: 0.7113183041773661d),

new NpgsqlTypes.NpgsqlLine(a: 0.4214482171789842d, b: 0.8554442144574418d, c: 0.5999306051397836d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19353362947791275d, b: 0.3975140078012611d, c: 0.0964187348818677d),

new NpgsqlTypes.NpgsqlLine(a: 0.661870100237565d, b: 0.05909829202430106d, c: 0.25733344382420387d),

new NpgsqlTypes.NpgsqlLine(a: 0.15963927634026043d, b: 0.8132148503863276d, c: 0.7848365264378103d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8890007006634524d, b: 0.5610456470471256d, c: 0.4141849140195162d),

new NpgsqlTypes.NpgsqlLine(a: 0.49164040840625234d, b: 0.2628861881822995d, c: 0.008963614720832291d),

new NpgsqlTypes.NpgsqlLine(a: 0.2675977032754461d, b: 0.12095786033267397d, c: 0.7435619735450576d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4153705830986909d, b: 0.3018066289181225d, c: 0.6885083595665537d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516891413800469d, b: 0.6378744432582539d, c: 0.40732717936461393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5774980217839171d, b: 0.04369392287288576d, c: 0.40747378249719324d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20971940812224532d, b: 0.5064575759641414d, c: 0.6889757242585144d),

new NpgsqlTypes.NpgsqlLine(a: 0.23689892156829717d, b: 0.9888779329341056d, c: 0.9467007858297208d),

new NpgsqlTypes.NpgsqlLine(a: 0.8651249364152753d, b: 0.44564193054510315d, c: 0.9146597938794743d),

new NpgsqlTypes.NpgsqlLine(a: 0.7076012145722977d, b: 0.7992242862154358d, c: 0.9365247567405242d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25356701828998784d, b: 0.08995735308160513d, c: 0.7732426272397638d),

new NpgsqlTypes.NpgsqlLine(a: 0.04222436426414955d, b: 0.517073265561399d, c: 0.7339460471723567d),

new NpgsqlTypes.NpgsqlLine(a: 0.933639516233885d, b: 0.18891234871713836d, c: 0.2917087053910008d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14150630332274328d, b: 0.37305069700615767d, c: 0.8736053320674944d),

new NpgsqlTypes.NpgsqlLine(a: 0.10379350798940001d, b: 0.4529138599913304d, c: 0.9755092396384767d),

new NpgsqlTypes.NpgsqlLine(a: 0.9939763563677675d, b: 0.4440936103992845d, c: 0.6003254213706799d),

new NpgsqlTypes.NpgsqlLine(a: 0.43274020251777556d, b: 0.10612139863171599d, c: 0.6888679792282445d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12161953675425619d, b: 0.16457223168220259d, c: 0.6797388853025407d),

new NpgsqlTypes.NpgsqlLine(a: 0.2380245286211441d, b: 0.18957023541690132d, c: 0.22457675963864854d),

new NpgsqlTypes.NpgsqlLine(a: 0.44047040484175726d, b: 0.8984458294731121d, c: 0.24063798786829904d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06442502007007989d, b: 0.42406739336914545d, c: 0.5661379239347972d),

new NpgsqlTypes.NpgsqlLine(a: 0.5970392659106492d, b: 0.5070220005480437d, c: 0.9929788381040058d),

new NpgsqlTypes.NpgsqlLine(a: 0.6683354508499083d, b: 0.2277888594618548d, c: 0.3662099329969427d),

new NpgsqlTypes.NpgsqlLine(a: 0.9835702857593711d, b: 0.9229307382525527d, c: 0.692650171510546d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8754460482694434d, b: 0.8688913369396141d, c: 0.5165365722726573d),

new NpgsqlTypes.NpgsqlLine(a: 0.6325765208926288d, b: 0.7444049018997673d, c: 0.7404869074238646d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798158263722936d, b: 0.2405990848187889d, c: 0.48505472196102706d),

new NpgsqlTypes.NpgsqlLine(a: 0.17007718380321424d, b: 0.6962531052242192d, c: 0.2553995096327826d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8035502647277759d, b: 0.14446533185250554d, c: 0.10374763827732048d),

new NpgsqlTypes.NpgsqlLine(a: 0.5789976912471653d, b: 0.38194913839647027d, c: 0.6732810057877944d),

new NpgsqlTypes.NpgsqlLine(a: 0.772785866400598d, b: 0.8237898832544432d, c: 0.47497351730099435d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8957996978113631d, b: 0.8593483148856563d, c: 0.44799280907333916d),

new NpgsqlTypes.NpgsqlLine(a: 0.0934168680141293d, b: 0.8693766477139839d, c: 0.5074660663817648d),

new NpgsqlTypes.NpgsqlLine(a: 0.8227299845994954d, b: 0.03134811881143429d, c: 0.769236689405829d),

new NpgsqlTypes.NpgsqlLine(a: 0.8753408135311016d, b: 0.3252447490194219d, c: 0.7148634955706183d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7820326096794799d, b: 0.3694746667853499d, c: 0.8242686297917967d),

new NpgsqlTypes.NpgsqlLine(a: 0.9623022836158697d, b: 0.29962573116314606d, c: 0.30539078950878806d),

new NpgsqlTypes.NpgsqlLine(a: 0.2528476143273035d, b: 0.6495710839238958d, c: 0.5189099200801716d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6016088882382908d, b: 0.5054389316919391d, c: 0.36073470974878585d),

new NpgsqlTypes.NpgsqlLine(a: 0.874239764791243d, b: 0.3363463207639201d, c: 0.7431604905009044d),

new NpgsqlTypes.NpgsqlLine(a: 0.3297136716503587d, b: 0.788384823632883d, c: 0.3730919454516085d),

new NpgsqlTypes.NpgsqlLine(a: 0.4459937276907856d, b: 0.5813044401653392d, c: 0.5964707562050031d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5627346107733434d, b: 0.23421714966133078d, c: 0.8800972383365067d),

new NpgsqlTypes.NpgsqlLine(a: 0.5771032380467718d, b: 0.3859312535208025d, c: 0.11819113046092944d),

new NpgsqlTypes.NpgsqlLine(a: 0.6332141902343525d, b: 0.442276535914655d, c: 0.37763895649099855d),

new NpgsqlTypes.NpgsqlLine(a: 0.8583447864660861d, b: 0.5019402408704524d, c: 0.686633318271611d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2546685580995538d, b: 0.3534701838606017d, c: 0.8753478096556224d),

new NpgsqlTypes.NpgsqlLine(a: 0.5464152425483809d, b: 0.8702542204778393d, c: 0.7063296427110365d),

new NpgsqlTypes.NpgsqlLine(a: 0.28792944548108135d, b: 0.6937334806112633d, c: 0.19654413074304433d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05631731447020383d, b: 0.8299335109366555d, c: 0.2578406446118233d),

new NpgsqlTypes.NpgsqlLine(a: 0.4283020092189227d, b: 0.697117726530161d, c: 0.2593099149924132d),

new NpgsqlTypes.NpgsqlLine(a: 0.7182755551091582d, b: 0.5396214377239398d, c: 0.37019904989369934d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.021735306600072946d, b: 0.5113909058497216d, c: 0.12009372149174469d),

new NpgsqlTypes.NpgsqlLine(a: 0.0445701392246417d, b: 0.07295645987361743d, c: 0.7000850618310618d),

new NpgsqlTypes.NpgsqlLine(a: 0.6648617201281657d, b: 0.07331542422993464d, c: 0.9799518584265333d),

new NpgsqlTypes.NpgsqlLine(a: 0.568063449661779d, b: 0.4026240673490964d, c: 0.9279025587074682d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3160520748128659d, b: 0.038743897365741464d, c: 0.8020141963047889d),

new NpgsqlTypes.NpgsqlLine(a: 0.06118659945893068d, b: 0.7833438035621701d, c: 0.20693282151899217d),

new NpgsqlTypes.NpgsqlLine(a: 0.06837085291277845d, b: 0.8825856267088045d, c: 0.8771930262160482d),

new NpgsqlTypes.NpgsqlLine(a: 0.11956525241146332d, b: 0.5235674983793807d, c: 0.06298543845178217d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42686221254057843d, b: 0.7662393901151289d, c: 0.9100072308454512d),

new NpgsqlTypes.NpgsqlLine(a: 0.6150251670739554d, b: 0.46999182240921444d, c: 0.473455819737467d),

new NpgsqlTypes.NpgsqlLine(a: 0.8576221869474923d, b: 0.4741531303843749d, c: 0.6967906597558816d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5915409514687058d, b: 0.7759974963404511d, c: 0.2590389869985522d),

new NpgsqlTypes.NpgsqlLine(a: 0.6314125656374575d, b: 0.32418203451094674d, c: 0.683507360540177d),

new NpgsqlTypes.NpgsqlLine(a: 0.48797043931299255d, b: 0.007925994045972051d, c: 0.3494869504469037d),

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

                var models = await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
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

                var models =  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatchAsync(connection, 31, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
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
                var models =  ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatch(connection, 26, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 137);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2M>(15);

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
                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

