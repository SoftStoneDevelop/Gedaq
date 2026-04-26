

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
    internal partial interface INpgsqlCircleListcircleArray
    {
    }
    
    internal partial class NpgsqlCircleListcircleArray : INpgsqlCircleListcircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray2M[] _testData = new NpgsqlCirclecircleArray2M[]
        {
            new NpgsqlCirclecircleArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3706305349231993d, y: 0.24112389077327945d), radius: 0.6609931155393135d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3872363409734927d, y: 0.50042429799302d), radius: 0.00690203290686453d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3179827619996477d, y: 0.7838576449252173d), radius: 0.8699194420935652d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6069909470268383d, y: 0.6394110169578496d), radius: 0.9126238262338895d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3519421990188025d, y: 0.8069027902705342d), radius: 0.6414767986601643d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45835939386123514d, y: 0.5227104089067838d), radius: 0.08090571265000579d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4872343003667102d, y: 0.8915313897169777d), radius: 0.1977496058178786d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.061364432070875274d, y: 0.6952379903131278d), radius: 0.6904493284409725d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5541760256156932d, y: 0.9729905517960122d), radius: 0.7724934655778577d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45060836251579617d, y: 0.7432311825823746d), radius: 0.9508341084707018d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.311067709024217d, y: 0.8869977857306758d), radius: 0.24783019935095385d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6560787385327502d, y: 0.011542225368611714d), radius: 0.9060789360649366d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.634424837900464d, y: 0.08220160444350377d), radius: 0.6854900267380737d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9813815606747446d, y: 0.4689168913627062d), radius: 0.37101668333029514d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.72036142340803d, y: 0.09356915659795662d), radius: 0.3667585797394983d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8146016541536224d, y: 0.23692217915402225d), radius: 0.054352027606972886d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6807805093816716d, y: 0.6730961733812253d), radius: 0.5774481082566141d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7526526209830525d, y: 0.6797251531703858d), radius: 0.8755638645593936d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20855553204580135d, y: 0.04605254225769084d), radius: 0.4089928344244067d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41079511830049364d, y: 0.7656245336898998d), radius: 0.4541043197640354d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5592106554072799d, y: 0.15756143961198377d), radius: 0.12603241106625684d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17954237928818373d, y: 0.6019915275563965d), radius: 0.9597548605579649d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45419609038850906d, y: 0.06925029283595607d), radius: 0.1582030672713356d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4475175368881654d, y: 0.5874370647574477d), radius: 0.793636360261571d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6125331944248549d, y: 0.10450000520157454d), radius: 0.6280612651033906d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48827906522629416d, y: 0.5779777945084767d), radius: 0.9552871082600175d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17013927914582194d, y: 0.5794408308959262d), radius: 0.9294988885187203d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8265398250636822d, y: 0.3524178382817238d), radius: 0.6923456141559189d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22353440558235138d, y: 0.8687693354383882d), radius: 0.10973144916776656d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07667936308755363d, y: 0.5337012077744195d), radius: 0.677986913180222d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4434636202207757d, y: 0.8633364339563983d), radius: 0.8117995838633121d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3668194503657326d, y: 0.579517933495986d), radius: 0.2126464276314477d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5478086354773624d, y: 0.4763197926604349d), radius: 0.7246168200755525d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6823841100196815d, y: 0.8846384397889598d), radius: 0.6435692162865086d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05785798223424954d, y: 0.8112811651495583d), radius: 0.6394929815630918d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3145405687261701d, y: 0.5598435642442594d), radius: 0.6434675886478646d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7887660048536682d, y: 0.5358329284968048d), radius: 0.8742217924826706d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5371357087530495d, y: 0.5726371398561818d), radius: 0.9230057885353561d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9955370768737655d, y: 0.5818601934029075d), radius: 0.1106583893521984d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9471180121352121d, y: 0.019460918563565577d), radius: 0.7993986705195384d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27182052866505335d, y: 0.9804148622968443d), radius: 0.6520015143359563d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028235101147905728d, y: 0.2593074127267043d), radius: 0.15932628531392834d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2087385887708071d, y: 0.4904974850389211d), radius: 0.8334480956209119d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024278589283582397d, y: 0.4923133339800718d), radius: 0.17253324438113493d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7213704860540846d, y: 0.0800040257886574d), radius: 0.6698229565304374d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2693005795651382d, y: 0.4233649840751851d), radius: 0.8029149476109847d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7096348712483755d, y: 0.7233723464740269d), radius: 0.5462778945072784d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5961865438010764d, y: 0.728161345365785d), radius: 0.7200904358389575d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8662656333070565d, y: 0.8724068757219937d), radius: 0.63241646761337d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6785171803088346d, y: 0.649411549916266d), radius: 0.3712307846637172d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6384816787065029d, y: 0.2398188099563846d), radius: 0.18688119025873529d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3477379065990026d, y: 0.45686970285164086d), radius: 0.445599470261003d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8174534005319783d, y: 0.20701258170188164d), radius: 0.5656108807771991d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9032615553358373d, y: 0.2988803604430912d), radius: 0.5223610830281509d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4761370091023539d, y: 0.10999041089372186d), radius: 0.8383045730714872d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9410140567079895d, y: 0.5326361819346906d), radius: 0.30457187896699334d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04905530035660344d, y: 0.527719166155732d), radius: 0.28314759489229413d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20217187302325168d, y: 0.7432900074014596d), radius: 0.08268552307001298d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3010495253936646d, y: 0.6886316256219942d), radius: 0.578511372225615d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23767047221171522d, y: 0.8777537470540352d), radius: 0.5206317282501107d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7503270989355627d, y: 0.5768383101867058d), radius: 0.0793718279367831d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13697417858979555d, y: 0.0787646699306428d), radius: 0.7337403546464375d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.583691446113404d, y: 0.6358471535448994d), radius: 0.18964729093694632d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9292389650701014d, y: 0.6586261011377902d), radius: 0.9611615046267741d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.53341607484751d, y: 0.171505490894169d), radius: 0.8217919282080595d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49143216490677d, y: 0.7440501061431677d), radius: 0.5263331167575104d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38018945601664333d, y: 0.9393252007506377d), radius: 0.32751883832441075d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7044963002713054d, y: 0.2667637476904199d), radius: 0.4347443978516544d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9941534302527737d, y: 0.9232922213371952d), radius: 0.35014003636797353d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8201454782702688d, y: 0.24309642856651625d), radius: 0.7855356923361995d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5729321869852637d, y: 0.8822149375433536d), radius: 0.9241414011542557d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7946438741096069d, y: 0.9588782387957937d), radius: 0.8267040585576175d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5175234948504587d, y: 0.6628397774299027d), radius: 0.4143338110549212d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15988024369163412d, y: 0.01755918999897821d), radius: 0.10944875797009368d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8029180774047527d, y: 0.18539116591282268d), radius: 0.7984069745433343d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6903796949719265d, y: 0.7706409156624092d), radius: 0.7919539261237641d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8313685417557308d, y: 0.05219679229570917d), radius: 0.16031876787017696d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3675441878483616d, y: 0.20031732164507254d), radius: 0.24406297175739322d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8892984729514853d, y: 0.786297958722905d), radius: 0.11224527051059807d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3291804333876006d, y: 0.3269382947999503d), radius: 0.3346037632229205d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10392906078455444d, y: 0.4969365694217508d), radius: 0.9124866671113815d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7471355921242293d, y: 0.8573455703172388d), radius: 0.1438874277011717d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9544672629930018d, y: 0.5953211696336657d), radius: 0.6029167008797038d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2622304498093726d, y: 0.49984552528418846d), radius: 0.6423040039361697d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9559900699014052d, y: 0.048655749307800145d), radius: 0.9102571364333497d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23185222082765589d, y: 0.4307820101387144d), radius: 0.95484920475104d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.731064495674884d, y: 0.575428529878099d), radius: 0.028834950009649307d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34828465097379524d, y: 0.583987120208377d), radius: 0.8247373896801845d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.865747603621355d, y: 0.1599642783305978d), radius: 0.8632943429025708d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23160241025784156d, y: 0.42571941504057265d), radius: 0.3659998552790289d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7964805940419829d, y: 0.6988420077940432d), radius: 0.6749379854857133d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3278472012098226d, y: 0.09061146853217572d), radius: 0.9822070821225628d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25298855928887765d, y: 0.42879451096436016d), radius: 0.7251752598253126d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8321819274547372d, y: 0.09906784121652579d), radius: 0.5612198609406461d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40422469805537786d, y: 0.14063347786402425d), radius: 0.36214393151539503d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.650727139247479d, y: 0.170253428933836d), radius: 0.8839539130750611d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8532274697154645d, y: 0.4452142831549355d), radius: 0.2624298419071107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.921241782994188d, y: 0.7567752585350569d), radius: 0.2337420264001291d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3314842227413186d, y: 0.8756287273121545d), radius: 0.5937070642955086d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834272667078295d, y: 0.47456934622458913d), radius: 0.6733614539205525d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23256953962689175d, y: 0.2669906051546005d), radius: 0.8295382649537502d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6301773282344775d, y: 0.019486158772248685d), radius: 0.20904212356779273d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5171938886441487d, y: 0.2604182958118013d), radius: 0.21480271436199105d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7052218264185967d, y: 0.5295428333762385d), radius: 0.9594351127775083d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8779653854849427d, y: 0.24775590884393572d), radius: 0.7857912623682495d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9857729962869817d, y: 0.830754497055838d), radius: 0.30578114180932636d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8891471881879407d, y: 0.1959858366001408d), radius: 0.48039836177481166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1990391875448304d, y: 0.3336481818595781d), radius: 0.22441561397444076d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5868387262171597d, y: 0.002113358017834188d), radius: 0.40220932014842203d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10622648935449819d, y: 0.4687655409736454d), radius: 0.7265913436032744d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3725373623373671d, y: 0.669659121750919d), radius: 0.47630582224478246d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4687568808791994d, y: 0.9993359794227245d), radius: 0.47749309756082936d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4945157970905367d, y: 0.3620344395998405d), radius: 0.15892486402719963d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9269870242865275d, y: 0.15361776691639806d), radius: 0.19904714316307615d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5300630769376299d, y: 0.7387807334186126d), radius: 0.33913862132280304d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7634391713560161d, y: 0.9839262408713979d), radius: 0.7863079758691548d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6372529470819959d, y: 0.07756986373978536d), radius: 0.19076193172353972d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3510321834099559d, y: 0.6683933277984063d), radius: 0.05722432314978099d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5507806453946268d, y: 0.8210005476322622d), radius: 0.8052355634682663d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44216884660385625d, y: 0.1873293652738821d), radius: 0.7027970104128352d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4002376621519532d, y: 0.4589793336508401d), radius: 0.5193157814578665d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29769507727389255d, y: 0.29857928357265007d), radius: 0.7443670292507517d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6815856942778924d, y: 0.5318149140847855d), radius: 0.21623441304458946d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4568130334717222d, y: 0.9930256372385442d), radius: 0.38331700659990964d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5089718923656711d, y: 0.9981069871304431d), radius: 0.4598513423384454d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9152401185055691d, y: 0.14806082074038085d), radius: 0.8821633710712685d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8736999566615735d, y: 0.5920046904757204d), radius: 0.2954290911784434d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5297068876219296d, y: 0.12581552167322985d), radius: 0.7342275645724156d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5547735194892649d, y: 0.5681664018211132d), radius: 0.15083678949452928d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7493852448764189d, y: 0.639217407952817d), radius: 0.5038378779069792d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9015482025691756d, y: 0.7914770995063802d), radius: 0.07342940192388503d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.057976853507880066d, y: 0.3059218849554175d), radius: 0.7247519550990813d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42200607417684766d, y: 0.11542658431393782d), radius: 0.025089404801849957d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9052266037374908d, y: 0.9864210161406318d), radius: 0.35622341515316625d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9014620827101487d, y: 0.6139069779313165d), radius: 0.9036559232353552d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5956382179805854d, y: 0.7461045547514278d), radius: 0.9722302525858337d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23760106206650278d, y: 0.9186432466590944d), radius: 0.11613381953040247d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.89567154139657d, y: 0.056994070755092885d), radius: 0.4017739181935108d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.121484470303589d, y: 0.585549653761414d), radius: 0.5173985692791128d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4635149887657035d, y: 0.05899725964796698d), radius: 0.9686823651577419d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8798293115233131d, y: 0.6737029533535994d), radius: 0.5355329311929593d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4056294118412632d, y: 0.07044832000727164d), radius: 0.813642384550708d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37409138090159433d, y: 0.4919594219111235d), radius: 0.9158875046817437d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2797101847241785d, y: 0.9933660608224917d), radius: 0.532846997041998d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8497001049368135d, y: 0.308910986081962d), radius: 0.5486744801696064d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7336380260759772d, y: 0.7031130125214697d), radius: 0.5493317940929925d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9438853347706737d, y: 0.3087906972901443d), radius: 0.2955058527295933d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6061515866542031d, y: 0.6497662873015897d), radius: 0.821548503892325d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7218138209927679d, y: 0.9082212490014546d), radius: 0.7721346510383197d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48960688253296114d, y: 0.7805596431633255d), radius: 0.4155338216172477d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33485654165190404d, y: 0.9285688182698745d), radius: 0.887673777356438d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031156472986067496d, y: 0.233795550926446d), radius: 0.5488541860480403d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.248458771823449d, y: 0.22572506677891302d), radius: 0.13380392418379827d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.63960733704335d, y: 0.17927935102911197d), radius: 0.9316215705218255d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.522607498292085d, y: 0.14754685292862246d), radius: 0.5111795936618598d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4271708378201827d, y: 0.8428377174789028d), radius: 0.9885264058483778d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8983222717623477d, y: 0.22335883875262763d), radius: 0.5249062045139558d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8528182696181218d, y: 0.5473794487959447d), radius: 0.35887149187573475d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03801652412846812d, y: 0.16716848586111577d), radius: 0.5762747483905012d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2649083338484275d, y: 0.04012702971886739d), radius: 0.43109725138605215d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35596038390171036d, y: 0.587165958894344d), radius: 0.9201181694380272d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8761226973914362d, y: 0.2720522843852321d), radius: 0.07878279076318251d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48622180139298643d, y: 0.9546756118563411d), radius: 0.8939301985182111d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40074411782983566d, y: 0.14702408674071243d), radius: 0.6738280094767869d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9334882189631062d, y: 0.6064192489507635d), radius: 0.8765611471627507d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016068966062759427d, y: 0.033553240978486665d), radius: 0.4170931299127415d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36349013437346644d, y: 0.09829793892291638d), radius: 0.22460598747648375d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4870328534310141d, y: 0.077700677601655d), radius: 0.3553343350583299d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29474096045480147d, y: 0.5596729688860476d), radius: 0.8595401397299203d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5796803762422955d, y: 0.5949543974685161d), radius: 0.04862654898726848d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7067261121669597d, y: 0.7074904537647305d), radius: 0.4210913799786675d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8080611763692217d, y: 0.46934403011549164d), radius: 0.250621796062488d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7029796614349582d, y: 0.9593809498399011d), radius: 0.04535697191265731d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23920229434232465d, y: 0.3023452592825112d), radius: 0.7451614103030059d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30486047690962104d, y: 0.10219906811821489d), radius: 0.13577288107860808d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9619930377097223d, y: 0.7497975076591958d), radius: 0.10277257983808963d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05590441185438577d, y: 0.4363629051954342d), radius: 0.47947701523548414d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3783265668678214d, y: 0.3311560812711636d), radius: 0.5037563642100281d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44232956616560914d, y: 0.1946968203670454d), radius: 0.7109582469827793d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.624312621551796d, y: 0.8453928151831475d), radius: 0.2879112162719588d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3093674713220218d, y: 0.4519602596495491d), radius: 0.04667311406843999d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15568448337895024d, y: 0.07469283024537599d), radius: 0.2826250677178018d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8383735056571103d, y: 0.5487299501103837d), radius: 0.6599771284052269d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7033002664916201d, y: 0.7376985607588791d), radius: 0.3141395762971675d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08828552854643335d, y: 0.07182650066419138d), radius: 0.9680415205013094d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24812933155830386d, y: 0.6061212339913506d), radius: 0.8274394917726314d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1162765483612086d, y: 0.9882413928666685d), radius: 0.6814338265929379d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022154711801418814d, y: 0.0936274987214597d), radius: 0.6326229401790282d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2370273032274992d, y: 0.9423108479237275d), radius: 0.29138095690287336d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7927897280279274d, y: 0.7113038401965409d), radius: 0.39604309834924867d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9524223700888629d, y: 0.8623279368495943d), radius: 0.9673101111997731d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7195902520810212d, y: 0.6587308855290203d), radius: 0.285859664951453d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1287289928051225d, y: 0.7144143899104728d), radius: 0.7706388328705035d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30536253375447253d, y: 0.06937619320406219d), radius: 0.3203659365816188d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6777617229112447d, y: 0.412666594374258d), radius: 0.3695878510800963d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.953496518940829d, y: 0.17586710003432937d), radius: 0.8857933741635231d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1172501832151368d, y: 0.10418798809263852d), radius: 0.21137268389742025d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34092597149512605d, y: 0.12986751082791315d), radius: 0.42422069809223184d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15606813856510393d, y: 0.11219816645487846d), radius: 0.682945890005583d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1678724508099544d, y: 0.9007485240301388d), radius: 0.027930469035344685d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5693422950033559d, y: 0.6632705202267328d), radius: 0.9481584450589278d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.501105871662586d, y: 0.3114366892718411d), radius: 0.8351018412667078d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5035292725218699d, y: 0.39227847182523723d), radius: 0.9117160473728754d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20133599072956632d, y: 0.4076689531830744d), radius: 0.010968755935662156d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020595000389569296d, y: 0.3299892184771087d), radius: 0.4312423643972825d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8752892933035136d, y: 0.23678927788831605d), radius: 0.45527199017843156d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5547429239375897d, y: 0.5541445692967788d), radius: 0.3626107997004757d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35310907254662605d, y: 0.9176052047518559d), radius: 0.3062572994402205d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7644694464793731d, y: 0.6134979024468731d), radius: 0.7045550120211216d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43606017191445456d, y: 0.9822023782001899d), radius: 0.589337987524635d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07623243899971233d, y: 0.8864228146366545d), radius: 0.6009452445770924d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12462421045269423d, y: 0.0655802670485377d), radius: 0.4741654645458133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7081417986852061d, y: 0.7516699140929368d), radius: 0.638297038202803d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7830858674298159d, y: 0.9512627506812895d), radius: 0.3469501760972834d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1003209934824395d, y: 0.4426634337427098d), radius: 0.4553482543028856d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8449047816791949d, y: 0.07565022512319608d), radius: 0.04413435353933082d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2750441899794812d, y: 0.7884320626415223d), radius: 0.09755753866877825d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8068761500003255d, y: 0.11786518822055736d), radius: 0.4982645084509528d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8227159806140679d, y: 0.0905881866956969d), radius: 0.4577225299608869d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3723809492223952d, y: 0.9678816840789088d), radius: 0.4264747628473463d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08936882088744147d, y: 0.446687597429282d), radius: 0.12003655204398778d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40906194656203465d, y: 0.9959148238098412d), radius: 0.47910986761754526d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48341446969018764d, y: 0.11678620443234611d), radius: 0.8580329259172566d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5291528415786367d, y: 0.09116460061891596d), radius: 0.629693174073397d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7483863495527595d, y: 0.010872627883082187d), radius: 0.3117040996890048d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4635740847483665d, y: 0.1646364231197267d), radius: 0.2639165985079436d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20434843064526276d, y: 0.828795882145877d), radius: 0.9475756077798312d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9743546612208541d, y: 0.5679394924651243d), radius: 0.6892779090218613d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2285716141831886d, y: 0.3554646414525846d), radius: 0.09813522905098804d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.255915164674437d, y: 0.7017531197996688d), radius: 0.5997757977137872d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.872096878388302d, y: 0.9439243066710796d), radius: 0.2731749976304715d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6309301772955331d, y: 0.19892869650459932d), radius: 0.657697928145731d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0851389710295225d, y: 0.5229950941390491d), radius: 0.7371809433447971d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34466293480290733d, y: 0.4138557144151178d), radius: 0.7167806167193d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6610300328159802d, y: 0.47455934950967416d), radius: 0.5807693091916093d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6617123652454567d, y: 0.6827664717173552d), radius: 0.22804159048277095d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9004058211726936d, y: 0.8189481420844452d), radius: 0.6729830169268525d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.585062825468653d, y: 0.7004744195048451d), radius: 0.5951848963476067d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23398316046038325d, y: 0.7792146732955562d), radius: 0.6192216968621683d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8115961837984239d, y: 0.6564088589390694d), radius: 0.7071476327980055d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004591667702455338d, y: 0.3461937470291071d), radius: 0.3010929147522732d),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                List<NpgsqlCirclecircleArray2M> models = null;

                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray2M> models = null;

                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[30], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 68, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 122, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 13, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[30], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 131, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 42, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 134, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2m m
LEFT JOIN public.binary_npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2M>(15);

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
                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

