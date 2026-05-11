

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
    internal partial interface INpgsqlPointListpointListD1
    {
    }
    
    internal partial class NpgsqlPointListpointListD1 : INpgsqlPointListpointListD1
    {


#region TestData

        private readonly NpgsqlPointpointListD1E2M[] _testData = new NpgsqlPointpointListD1E2M[]
        {
            new NpgsqlPointpointListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9986693608813721d, y: 0.017264142855334397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9899848437159567d, y: 0.3830897489813091d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0824297635106539d, y: 0.9871118057797303d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.287343005707256d, y: 0.5650113998920738d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6723883820547873d, y: 0.8987182750450309d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08103588366597059d, y: 0.21776329672807793d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04572725497046726d, y: 0.15507177414486295d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1250863800994103d, y: 0.5079831253169526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5527345191467768d, y: 0.09423212006292547d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3621573433821126d, y: 0.6416097875183481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09920668021808032d, y: 0.20697147896254453d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2598540163963673d, y: 0.19175155637617614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06792063424283645d, y: 0.8768169074808789d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18613668540038408d, y: 0.8664487441487169d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7996660177178901d, y: 0.9144289601725248d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3300377260816053d, y: 0.986746671000166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39998269421892374d, y: 0.5037405563707072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5477822181410971d, y: 0.8257685695299625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7986858789384069d, y: 0.7146480043473971d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6757706944292974d, y: 0.3815491757520607d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4727878929307022d, y: 0.6105229408375675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38045692397883446d, y: 0.7637853574867881d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.026226718693933893d, y: 0.21400661529622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.020867439547808675d, y: 0.843951313145552d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9952811411399874d, y: 0.7971094214856673d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9192658119520422d, y: 0.7247775541084186d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6276090887544442d, y: 0.42062069378852773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32490606128332544d, y: 0.40614710237111873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09516179749819043d, y: 0.9374020245423232d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12958079719114723d, y: 0.7378790207789672d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6907467603633782d, y: 0.8840845636302174d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14843234728113408d, y: 0.18590082161741894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9851669346725604d, y: 0.9004392269849357d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7980181662297992d, y: 0.4780748755851938d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5486885852624445d, y: 0.8739531322475608d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49552581277773544d, y: 0.222214510961393d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18816020038111114d, y: 0.847001932957514d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8806859624234586d, y: 0.9028532548047485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33702287146333676d, y: 0.7628025592990001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8952753345095779d, y: 0.22674883528307355d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7218832741075027d, y: 0.2310462229167609d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7141885923834814d, y: 0.034053666328822674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04489642000050409d, y: 0.0831242460400734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8922460538376289d, y: 0.3932370864689454d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.773683048387636d, y: 0.7376898497920874d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44951774224235397d, y: 0.26922185873343596d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7677407127754026d, y: 0.4483762598082699d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1756860736570498d, y: 0.5620211465078836d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7289857044035472d, y: 0.08591567008639933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33112873215992233d, y: 0.7556163586916765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3437986095461656d, y: 0.24163240406529163d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5324925224918262d, y: 0.7459450554558948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7011003917545323d, y: 0.9121209473598345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15603665554403912d, y: 0.6913909976861741d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9636607866332829d, y: 0.5108487476237576d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18538172405533704d, y: 0.3855376458282572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3624037716647286d, y: 0.1982391152889067d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4511409536569395d, y: 0.6578254089280494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13203590508013197d, y: 0.29252189335774004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9944519830784497d, y: 0.3506990024317106d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8254093213427421d, y: 0.005746244458016525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.97874463589691d, y: 0.8208230076706624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8415155555962969d, y: 0.04178137139693616d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11509523463505411d, y: 0.25495886978791626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31649192264150217d, y: 0.19954764245293866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5383706517979058d, y: 0.5401628332388038d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10938842872387011d, y: 0.3074328047927354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7204795128352964d, y: 0.5613503978031579d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5110791640836048d, y: 0.9956854568069088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10113438292473464d, y: 0.4610299667295691d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23908170104801885d, y: 0.19455801575346854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7819144317268109d, y: 0.3582509065266388d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5919686877983487d, y: 0.6808184004973293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12890870834523915d, y: 0.2259493279543634d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2889782266244302d, y: 0.6293049224455255d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6080855929998844d, y: 0.5625066768872452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35287812049536027d, y: 0.07139933376560159d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7352282783555063d, y: 0.7387390143962088d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32918126446913143d, y: 0.027150312847033287d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9277849798266402d, y: 0.626457313625395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.010303965856649833d, y: 0.4416419840646679d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19960802387472099d, y: 0.28160076569381576d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7105924414580634d, y: 0.6773430304934953d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8482874747777737d, y: 0.009389369960713934d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16848821801035851d, y: 0.7517299027422415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018775279773232678d, y: 0.38871701386475876d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1320359265886305d, y: 0.43535214461833605d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46276596656778746d, y: 0.5169260766222172d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8333742091801639d, y: 0.5329253529946714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5410845006145806d, y: 0.026787783886061067d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4203134137189609d, y: 0.8622003603984971d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10048624313748655d, y: 0.3364875218379756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02195076292344844d, y: 0.8334883973383712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04553586955538125d, y: 0.25466619845842386d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.930932343414466d, y: 0.4011964525470031d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8994189369570325d, y: 0.6131680861296336d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8530244024670074d, y: 0.21353415612537996d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5892135775001123d, y: 0.4329323112173309d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6016043234545579d, y: 0.7155160714522173d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6391793828735812d, y: 0.5136667082391788d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6909810779969604d, y: 0.25879945247261404d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682248294844178d, y: 0.22453704371680905d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0171842364127055d, y: 0.30618661938107383d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8540066301391992d, y: 0.9391500349138712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8726722337587068d, y: 0.2603666590115563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3379606775640891d, y: 0.17249383529726714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20366083238753496d, y: 0.565410615683265d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.628330602535189d, y: 0.788006155127316d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06902301875018668d, y: 0.4174503104447522d),

new NpgsqlTypes.NpgsqlPoint(x: 0.906354408961001d, y: 0.3717989245199823d),

new NpgsqlTypes.NpgsqlPoint(x: 0.045659180638033425d, y: 0.5619711679950972d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9518094533403099d, y: 0.43311757550114205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6403354151562956d, y: 0.7846453438796136d),

new NpgsqlTypes.NpgsqlPoint(x: 0.040112103175031444d, y: 0.8686858040609123d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05131025526577837d, y: 0.729116169583887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.749758945988973d, y: 0.04541621671688756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6500229113586008d, y: 0.92652443589902d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5873735075181927d, y: 0.1326803223947678d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9370995924448113d, y: 0.5081294485237743d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8730574287964764d, y: 0.8157276616017497d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8924989281403729d, y: 0.5834619756712192d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26440661164962365d, y: 0.5848399552933109d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2160972843131015d, y: 0.8853904319513773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6735944536045539d, y: 0.94373642691922d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9197570963058662d, y: 0.8843905521767885d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6659862428698409d, y: 0.7649365247239467d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1918299652346075d, y: 0.8855940268252358d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6777468314830872d, y: 0.6412038570437735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9769082049114355d, y: 0.8088366388652296d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4876170022799764d, y: 0.2067874433489073d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4032760050588805d, y: 0.4675597684692441d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5415483160634427d, y: 0.7724344309270957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.947873274862626d, y: 0.26950485420295944d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7910826834381915d, y: 0.775267160320755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04384623848518121d, y: 0.5415175295565666d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41589737244409153d, y: 0.38131679710984767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3465168684923644d, y: 0.6092845555389741d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5528560781458063d, y: 0.04918304686561803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3193156177511758d, y: 0.28358245699466234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9931194117234746d, y: 0.7487056556042568d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.267622482616411d, y: 0.6641751148027987d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3696195410994153d, y: 0.08505979810102304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9390327622593899d, y: 0.3678523784789465d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7610496364939215d, y: 0.2333851614680399d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2437865390484607d, y: 0.7826866634243251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4977719719724685d, y: 0.17782135676479105d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9449788897642748d, y: 0.5944398099849247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8507122104614184d, y: 0.07358583298852373d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9839400139567387d, y: 0.5990313929695059d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.502888418921459d, y: 0.4838958049070885d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4699138485092129d, y: 0.380745118294891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0544104440354688d, y: 0.9915688303523357d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27469130043434375d, y: 0.6301905239353421d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03927426467672279d, y: 0.749173785081035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7188249622884278d, y: 0.14522188133054825d),

new NpgsqlTypes.NpgsqlPoint(x: 0.051391435029561006d, y: 0.11180222083863656d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35983775332492407d, y: 0.6329850552366478d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11185228494615784d, y: 0.033156276923148376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5395891695876196d, y: 0.7329261672374993d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2724568547926596d, y: 0.32787869706058537d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7667858647716836d, y: 0.822350607745714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5906887649653007d, y: 0.9016019123253081d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14842476432330365d, y: 0.5705900534173645d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5238881359277408d, y: 0.434655654729182d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7731249450354007d, y: 0.024646829211507626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9408453281318516d, y: 0.5854315513317464d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07426641053725846d, y: 0.1112141370322215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13948336320765453d, y: 0.6171595592182473d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13570345428276587d, y: 0.559869554398971d),

new NpgsqlTypes.NpgsqlPoint(x: 0.639177102158806d, y: 0.38799465901080354d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9688717997894177d, y: 0.512208014810305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18990450733274122d, y: 0.613889851612745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3659817449598174d, y: 0.17722265613771637d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6342614158448414d, y: 0.7703741973159758d),

new NpgsqlTypes.NpgsqlPoint(x: 0.025204285010920313d, y: 0.4565954578681283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.743905837729467d, y: 0.23354497712146094d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17012003846155876d, y: 0.10941562709036512d),

new NpgsqlTypes.NpgsqlPoint(x: 0.007825782630769273d, y: 0.07912337451917695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26968555219704804d, y: 0.7157771050190165d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08319093455729165d, y: 0.2583991160034701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8444407853765468d, y: 0.5477988756447701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2486377654346703d, y: 0.35608626789928166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7301331229123001d, y: 0.4902877537318945d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8098152238095692d, y: 0.5317316782474153d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2983581541499587d, y: 0.2978564601888417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8161283710269795d, y: 0.8477037606702985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9196906051118795d, y: 0.1583278601193263d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7150140721328417d, y: 0.11283330819778237d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42657703625695054d, y: 0.028760043687017012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3993085882649944d, y: 0.8735001092656115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27065088649846414d, y: 0.711415548985144d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26922829757987476d, y: 0.6976196950047916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26978593915303895d, y: 0.563662538007944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7161130392751347d, y: 0.20777771718734694d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36568960651677906d, y: 0.5510499359509364d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10182911667585548d, y: 0.7116815006562172d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09607654851321767d, y: 0.5001206533815613d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5457947120687824d, y: 0.7780048735127834d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6745500398087922d, y: 0.46626267904959107d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09040817690218916d, y: 0.4507533192252756d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8299226800567934d, y: 0.8512489235602927d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6047164428820105d, y: 0.519210896675477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14576424342624228d, y: 0.012728294492809433d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44133432675175643d, y: 0.24766353239551242d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6973746628479931d, y: 0.6350676485024923d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18137863926592557d, y: 0.7095862734152801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9563425365630919d, y: 0.7144524673474737d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7099036431500405d, y: 0.8867092242659095d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21262855872634168d, y: 0.4668494246239755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29365987436409047d, y: 0.7030731521889171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5490441354513652d, y: 0.6489121695114147d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3330456589224462d, y: 0.8186114539837719d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22643702530590026d, y: 0.699262640013726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7670592961447691d, y: 0.8468362368651208d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3885674669157452d, y: 0.16913140358579848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8217860902105054d, y: 0.290877822340471d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7179012824614938d, y: 0.11681363210829843d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4931341130469896d, y: 0.004820231748188353d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41457132774332295d, y: 0.5744458078034873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9556777748443028d, y: 0.9816591647776772d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46765795258754883d, y: 0.886747518069315d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15472540599765716d, y: 0.9030698707865152d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6988380425970492d, y: 0.14468563305526294d),

new NpgsqlTypes.NpgsqlPoint(x: 0.036573498968058504d, y: 0.3766706600544075d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19580943281175667d, y: 0.6665588090201938d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1545040333937563d, y: 0.7831053897127217d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7347437690368406d, y: 0.6354875864283916d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171623563860976d, y: 0.10434847831334271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9285744020908341d, y: 0.06146519783024851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5797338249119085d, y: 0.20549990314619138d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2960851510641733d, y: 0.9020152097480238d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3244955612934236d, y: 0.9464891234300874d),

new NpgsqlTypes.NpgsqlPoint(x: 0.647140125746341d, y: 0.3691709197540888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7772989998491799d, y: 0.1946524001215041d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07120086829416739d, y: 0.11559934712589215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.964521691705014d, y: 0.14812837390651634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5551017009483774d, y: 0.7061628077516542d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13248410358069884d, y: 0.629043963563007d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2787906310729308d, y: 0.9001411389153003d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39490347367886425d, y: 0.7145510390910055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123136275565726d, y: 0.8662279572745732d),

new NpgsqlTypes.NpgsqlPoint(x: 0.299262824825959d, y: 0.5302920229477405d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22700309612287428d, y: 0.749379514968216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12319328235806892d, y: 0.6499361683814104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5177425236994709d, y: 0.3841202472215486d),

new NpgsqlTypes.NpgsqlPoint(x: 0.715902353160571d, y: 0.31839897402010187d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24667047120708174d, y: 0.6627329020293182d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6301518670279066d, y: 0.8800242227154511d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6567238471824492d, y: 0.32094140852505515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24462969222921593d, y: 0.6095786446470673d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9184262632180146d, y: 0.04025503997237123d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5265005646520364d, y: 0.9083727014604152d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7780541536063483d, y: 0.11962913259848629d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07426243179929659d, y: 0.9313299273356276d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14590401765075578d, y: 0.7877077793807391d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31247632801553327d, y: 0.7485369846582448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05609751442086519d, y: 0.9932435727759853d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04467725155212643d, y: 0.8132925422587789d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6544736601339353d, y: 0.3490019606561243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12369167990093821d, y: 0.5725443554931611d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06518111016979256d, y: 0.026314163320914186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7252463533653627d, y: 0.4187087760106768d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42727836904960625d, y: 0.3330622861900884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16793719730549406d, y: 0.06529205083245149d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14628131450036574d, y: 0.9810561588214181d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1013126947505637d, y: 0.955790017454395d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29123840627133124d, y: 0.46020489034738943d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7694201388710856d, y: 0.9423686698293523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45576740775829827d, y: 0.7937505588906675d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7706571014774358d, y: 0.004347762980107639d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2668901732764424d, y: 0.7162855731325356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.011428473622094315d, y: 0.5828648669686529d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42029928680266404d, y: 0.15003445858548137d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6672562915060049d, y: 0.5793183780842892d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4735739706527007d, y: 0.9990493843312862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7607839942851177d, y: 0.9535075044086058d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)), 
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
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                List<NpgsqlPointpointListD1E2M> models = null;

                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointListD1E2M> models = null;

                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 86, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 67, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 117, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 138, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 153, query1, 83, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 153, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 69, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatch(connection, 117, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models =  ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[16], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[34], false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointListD1E2M),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
FROM public.binary_npgsqlpointpointlistd1e2m m
LEFT JOIN public.binary_npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models =  ((INpgsqlPointListpointListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI), typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                await ((INpgsqlPointListpointListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                ((INpgsqlPointListpointListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

