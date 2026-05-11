

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
    internal partial interface INpgsqlLineMArraylineMMArrayD2
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD2 : INpgsqlLineMArraylineMMArrayD2
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD2E1M[] _testData = new NpgsqlLinelineMMArrayD2E1M[]
        {
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6474254801249447d, b: 0.16337916854220813d, c: 0.513826605879715d),
new NpgsqlTypes.NpgsqlLine(a: 0.4006451105066584d, b: 0.42512778641487414d, c: 0.0875299404137776d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5348499480877503d, b: 0.009071365082379379d, c: 0.4784067456466339d),
new NpgsqlTypes.NpgsqlLine(a: 0.9701483776878701d, b: 0.6861785077408304d, c: 0.9483512237369567d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.1469335250436682d, b: 0.7833716892541531d, c: 0.24278987429828358d),
new NpgsqlTypes.NpgsqlLine(a: 0.95867583307795d, b: 0.2929374449318336d, c: 0.7611658784545938d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.4440271631945514d, b: 0.2695412728071246d, c: 0.8176529959869844d),
new NpgsqlTypes.NpgsqlLine(a: 0.010467863428057389d, b: 0.3048595420112934d, c: 0.1312321744444257d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.44962747472401543d, b: 0.014918051582093916d, c: 0.8889061088928131d),
new NpgsqlTypes.NpgsqlLine(a: 0.4562168349662933d, b: 0.21296338525674885d, c: 0.9304392579628606d), } },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6950883771228129d, b: 0.7930275547164325d, c: 0.48939235684523075d),
new NpgsqlTypes.NpgsqlLine(a: 0.865408744228719d, b: 0.5052733394277003d, c: 0.6708783562105848d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6788379268790691d, b: 0.6306684944346935d, c: 0.05372958584049525d),
new NpgsqlTypes.NpgsqlLine(a: 0.20610755470567066d, b: 0.48586997194357595d, c: 0.012714552053853079d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5332748114330823d, b: 0.6134658229086942d, c: 0.6472973402713502d),
new NpgsqlTypes.NpgsqlLine(a: 0.737114070339105d, b: 0.929800213534686d, c: 0.8316227970003115d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7730841079919745d, b: 0.605249473762822d, c: 0.8207338796278598d),
new NpgsqlTypes.NpgsqlLine(a: 0.128867699914046d, b: 0.2662748698247629d, c: 0.8938816889654383d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.055781728777214545d, b: 0.06569519358393727d, c: 0.19120456999717583d),
new NpgsqlTypes.NpgsqlLine(a: 0.30890709698534113d, b: 0.6777182536313187d, c: 0.11108216551819872d), } },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.023591062486019276d, b: 0.08318358081464816d, c: 0.3350198920293628d),
new NpgsqlTypes.NpgsqlLine(a: 0.23887000026109695d, b: 0.4784461192043793d, c: 0.8712312863506083d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.3238516669846313d, b: 0.767591335731818d, c: 0.9937445374185143d),
new NpgsqlTypes.NpgsqlLine(a: 0.519200980904512d, b: 0.6487461200828225d, c: 0.3509759003728572d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.18779166154593563d, b: 0.23792706685459097d, c: 0.08000514715446083d),
new NpgsqlTypes.NpgsqlLine(a: 0.014430359176006546d, b: 0.28455901610703405d, c: 0.4602039235630999d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7457405582121537d, b: 0.03708193549800831d, c: 0.7296634530853872d),
new NpgsqlTypes.NpgsqlLine(a: 0.05043275182120366d, b: 0.0422777778327863d, c: 0.6197030561598464d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.43486311251424814d, b: 0.9904223457734693d, c: 0.7455413362176349d),
new NpgsqlTypes.NpgsqlLine(a: 0.28698470400138987d, b: 0.6343936127621937d, c: 0.6972302733755164d), } },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.2847976226375437d, b: 0.8934889594890535d, c: 0.6875109187713722d),
new NpgsqlTypes.NpgsqlLine(a: 0.9354065014211201d, b: 0.753907313712356d, c: 0.28024389874843525d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5936746333705624d, b: 0.5630304651608167d, c: 0.07710267078028032d),
new NpgsqlTypes.NpgsqlLine(a: 0.41810683602262533d, b: 0.24475511304268427d, c: 0.5017148612269229d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5344021019948347d, b: 0.790233255554908d, c: 0.003097331274574122d),
new NpgsqlTypes.NpgsqlLine(a: 0.02835174390628803d, b: 0.026276560382794356d, c: 0.666458697795109d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7291423916807557d, b: 0.4710292878817993d, c: 0.032805886645847715d),
new NpgsqlTypes.NpgsqlLine(a: 0.8853881043363199d, b: 0.07985347198714998d, c: 0.06369691905024522d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.546269016919044d, b: 0.8465336604738029d, c: 0.7880612823936459d),
new NpgsqlTypes.NpgsqlLine(a: 0.31124754767624785d, b: 0.9362053085485984d, c: 0.3117431632658114d), } },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.822447227155739d, b: 0.411913031946995d, c: 0.5526820921865365d),
new NpgsqlTypes.NpgsqlLine(a: 0.5736402956888642d, b: 0.921976764456304d, c: 0.44831427663731704d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.837794806484738d, b: 0.00764050026975216d, c: 0.4138830288858628d),
new NpgsqlTypes.NpgsqlLine(a: 0.32509678176176626d, b: 0.1414231375099172d, c: 0.29691533531300796d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.2969632090910672d, b: 0.3152561207325091d, c: 0.21158862684508106d),
new NpgsqlTypes.NpgsqlLine(a: 0.3539646289084264d, b: 0.07053658011960007d, c: 0.7610544443978184d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.06785788373759372d, b: 0.08881510230552936d, c: 0.7065482111443153d),
new NpgsqlTypes.NpgsqlLine(a: 0.8425451234108245d, b: 0.9173386930975344d, c: 0.609602287693712d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.19353238851593435d, b: 0.3682865128525358d, c: 0.11649105221834821d),
new NpgsqlTypes.NpgsqlLine(a: 0.18373896173358617d, b: 0.6374681355139855d, c: 0.26412832980636824d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.19610349594523935d, b: 0.7637873566562086d, c: 0.6432032918692158d),
new NpgsqlTypes.NpgsqlLine(a: 0.235542033515441d, b: 0.6879515995446686d, c: 0.2129794590840769d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.516046976529576d, b: 0.7421106937838933d, c: 0.27855614626921765d),
new NpgsqlTypes.NpgsqlLine(a: 0.5892503643882337d, b: 0.43354946233899805d, c: 0.48817465045525854d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6298811234805948d, b: 0.40231421634337294d, c: 0.8149587154541909d),
new NpgsqlTypes.NpgsqlLine(a: 0.8336675690188865d, b: 0.7172237949815287d, c: 0.49596057062832877d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6092147670945599d, b: 0.7822089701727503d, c: 0.7379741977112079d),
new NpgsqlTypes.NpgsqlLine(a: 0.8601463923574664d, b: 0.2013377449626974d, c: 0.3171224800177934d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.13650496700756354d, b: 0.7753616277906695d, c: 0.3084109958190574d),
new NpgsqlTypes.NpgsqlLine(a: 0.8103196573284026d, b: 0.06740825271871809d, c: 0.18334974889683253d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6672462035868674d, b: 0.57467273930328d, c: 0.07700550133317419d),
new NpgsqlTypes.NpgsqlLine(a: 0.4232495058852377d, b: 0.8681771403548246d, c: 0.7011019833815169d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.894817681665849d, b: 0.9799512592405618d, c: 0.14267304284864757d),
new NpgsqlTypes.NpgsqlLine(a: 0.3994266960377171d, b: 0.1455988921395085d, c: 0.05509819130886329d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.3530957463526354d, b: 0.743235636428753d, c: 0.5833922739802468d),
new NpgsqlTypes.NpgsqlLine(a: 0.13451081428192946d, b: 0.9022899654889783d, c: 0.041553535269420405d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7050784724105978d, b: 0.2921148723577831d, c: 0.8963728730403443d),
new NpgsqlTypes.NpgsqlLine(a: 0.29664531326742605d, b: 0.4570400975472072d, c: 0.865741101131491d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6635093209739727d, b: 0.7987209101732055d, c: 0.433517919699975d),
new NpgsqlTypes.NpgsqlLine(a: 0.8296644061505513d, b: 0.7440621584559013d, c: 0.6565220917173629d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7356104193524486d, b: 0.21971757034292672d, c: 0.7127674148304901d),
new NpgsqlTypes.NpgsqlLine(a: 0.3357552323391877d, b: 0.3123054268848784d, c: 0.6626654036988558d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.687180474909256d, b: 0.8061004994133959d, c: 0.020743852505088922d),
new NpgsqlTypes.NpgsqlLine(a: 0.4420717372984342d, b: 0.8850877516204788d, c: 0.4369929486920737d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.8137079646658593d, b: 0.2926383936143485d, c: 0.8521877242655798d),
new NpgsqlTypes.NpgsqlLine(a: 0.4878058342898418d, b: 0.41385554299737337d, c: 0.5966481448622679d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6303485170924735d, b: 0.10665758411739645d, c: 0.21768293616577394d),
new NpgsqlTypes.NpgsqlLine(a: 0.6287872615175586d, b: 0.8238761210718017d, c: 0.896984083083725d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.815774320032391d, b: 0.7155170173606857d, c: 0.9125586683386812d),
new NpgsqlTypes.NpgsqlLine(a: 0.6575732043440702d, b: 0.5314837808872107d, c: 0.5215596078855249d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5958704499180627d, b: 0.8885674715456949d, c: 0.0877496481229657d),
new NpgsqlTypes.NpgsqlLine(a: 0.5385899039680121d, b: 0.6747681494230462d, c: 0.9909455584473832d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.1330204871087617d, b: 0.26530523526619254d, c: 0.539691457810298d),
new NpgsqlTypes.NpgsqlLine(a: 0.8223755513809108d, b: 0.2538395421222127d, c: 0.6759942840208119d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7799355140048261d, b: 0.7440118436928342d, c: 0.07712674424265087d),
new NpgsqlTypes.NpgsqlLine(a: 0.8312386666355215d, b: 0.5550933820936014d, c: 0.596813957206458d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.933014618095644d, b: 0.34652394206565684d, c: 0.3905129304225601d),
new NpgsqlTypes.NpgsqlLine(a: 0.7315442319349799d, b: 0.7795076215821436d, c: 0.5397368723372921d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9093516414702674d, b: 0.5875801126696063d, c: 0.767126571850641d),
new NpgsqlTypes.NpgsqlLine(a: 0.420801430284209d, b: 0.2448490861212258d, c: 0.02874812604234256d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.237547009711646d, b: 0.7263380616811103d, c: 0.9222489384975688d),
new NpgsqlTypes.NpgsqlLine(a: 0.18118944448622887d, b: 0.6685242587519409d, c: 0.0018423580248417837d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.3777940527157735d, b: 0.344545826794874d, c: 0.27627480334060395d),
new NpgsqlTypes.NpgsqlLine(a: 0.44562571536173146d, b: 0.0960982579999815d, c: 0.6137114759650104d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.48277151800564444d, b: 0.9324582759914596d, c: 0.31865813445585645d),
new NpgsqlTypes.NpgsqlLine(a: 0.8627770262522266d, b: 0.334610899120904d, c: 0.9381783853777875d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9553639315751917d, b: 0.31262537888883146d, c: 0.29100186682390794d),
new NpgsqlTypes.NpgsqlLine(a: 0.017756920297226197d, b: 0.6384701229328549d, c: 0.1583397156304872d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.4949438875496486d, b: 0.8929141542505609d, c: 0.2637292808918088d),
new NpgsqlTypes.NpgsqlLine(a: 0.42332870396522393d, b: 0.157855002682055d, c: 0.05120062773723666d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.008847083591006388d, b: 0.007074881013891421d, c: 0.7329538517521482d),
new NpgsqlTypes.NpgsqlLine(a: 0.6235718667404221d, b: 0.317208499076324d, c: 0.9416594920538115d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6916129019152392d, b: 0.21218757410626032d, c: 0.19013222480088798d),
new NpgsqlTypes.NpgsqlLine(a: 0.43433345378943844d, b: 0.8522200192263577d, c: 0.39291598721516097d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.296593392447299d, b: 0.24867058339907167d, c: 0.7668470584738184d),
new NpgsqlTypes.NpgsqlLine(a: 0.700971179382636d, b: 0.009140862258274374d, c: 0.1583610652968649d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.32814152893936543d, b: 0.2699624752777239d, c: 0.4959162428814756d),
new NpgsqlTypes.NpgsqlLine(a: 0.36858640168848444d, b: 0.18445692045292705d, c: 0.5091924073135233d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.30606077385659214d, b: 0.5803497467296974d, c: 0.5239579132681167d),
new NpgsqlTypes.NpgsqlLine(a: 0.42779546703329996d, b: 0.46201321195823597d, c: 0.7693816623307885d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.10806394563296107d, b: 0.9019837595470096d, c: 0.1822383347471902d),
new NpgsqlTypes.NpgsqlLine(a: 0.41642485120026607d, b: 0.5788349348224019d, c: 0.4784722961479785d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6005736160218301d, b: 0.8941568208642633d, c: 0.5277263528438734d),
new NpgsqlTypes.NpgsqlLine(a: 0.40750064108982176d, b: 0.8160626189599853d, c: 0.6909902535542325d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.029690574428509864d, b: 0.15196892742385382d, c: 0.44187021808217364d),
new NpgsqlTypes.NpgsqlLine(a: 0.7806433649014011d, b: 0.14113874224001421d, c: 0.6960674847769076d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6947651460606814d, b: 0.39645441018304284d, c: 0.5565682512407827d),
new NpgsqlTypes.NpgsqlLine(a: 0.12725739684261062d, b: 0.3068643596991366d, c: 0.5882391516097041d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.42203460852138563d, b: 0.22871366935880488d, c: 0.2527058754567514d),
new NpgsqlTypes.NpgsqlLine(a: 0.32756185112930447d, b: 0.8865729322234711d, c: 0.4746142965306386d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.20267807057154463d, b: 0.52339559668001d, c: 0.7464820389390718d),
new NpgsqlTypes.NpgsqlLine(a: 0.9051152644482815d, b: 0.9585991929514124d, c: 0.6550484667605564d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6498379384314318d, b: 0.9135593950009153d, c: 0.6058400600818274d),
new NpgsqlTypes.NpgsqlLine(a: 0.5877555864249536d, b: 0.9430154190158773d, c: 0.7197071650746883d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7302719619399414d, b: 0.6904912515079332d, c: 0.5820599698481432d),
new NpgsqlTypes.NpgsqlLine(a: 0.022284898916641982d, b: 0.9161743256872681d, c: 0.45451959204001535d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.45720325076109936d, b: 0.7012588991303129d, c: 0.8128885703432055d),
new NpgsqlTypes.NpgsqlLine(a: 0.8491441295194491d, b: 0.542247845663607d, c: 0.9570078184826858d), } },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.49519294322121843d, b: 0.08163190465754455d, c: 0.897650685525099d),
new NpgsqlTypes.NpgsqlLine(a: 0.7013241784729324d, b: 0.7346741300256788d, c: 0.4673629080891175d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7367598911074515d, b: 0.8883095826362014d, c: 0.11303204490936081d),
new NpgsqlTypes.NpgsqlLine(a: 0.906788731463146d, b: 0.6931957477808297d, c: 0.9541367920261974d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.32621381975990804d, b: 0.6972435097385249d, c: 0.22973454432742146d),
new NpgsqlTypes.NpgsqlLine(a: 0.9455243314377997d, b: 0.6032241303041793d, c: 0.06591224400251772d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.20133795362570717d, b: 0.380513325437568d, c: 0.3769826658450225d),
new NpgsqlTypes.NpgsqlLine(a: 0.25536080175098474d, b: 0.5549847719001321d, c: 0.5204829876541631d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.07671623037989361d, b: 0.46582936746790093d, c: 0.11277906409568617d),
new NpgsqlTypes.NpgsqlLine(a: 0.2420894458534355d, b: 0.9706983055326991d, c: 0.010803607676327709d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.46584699579236777d, b: 0.5828637912208166d, c: 0.631809538545078d),
new NpgsqlTypes.NpgsqlLine(a: 0.0875777692177957d, b: 0.5285226234011849d, c: 0.6471113855225122d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9323463347208669d, b: 0.9699260596011287d, c: 0.2407652239793001d),
new NpgsqlTypes.NpgsqlLine(a: 0.7649381815439117d, b: 0.4040475637432551d, c: 0.3895691914468994d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7843966036410067d, b: 0.13903195750413555d, c: 0.19484544639607904d),
new NpgsqlTypes.NpgsqlLine(a: 0.17930960815642483d, b: 0.684189341507821d, c: 0.105814735262868d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9559853045223399d, b: 0.2194896349485086d, c: 0.4879378087861753d),
new NpgsqlTypes.NpgsqlLine(a: 0.9435690451629385d, b: 0.8379226327975144d, c: 0.12540163756747869d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.4159038835982555d, b: 0.772491331607185d, c: 0.17333917904226048d),
new NpgsqlTypes.NpgsqlLine(a: 0.6110917170708019d, b: 0.19179798460618314d, c: 0.5754067928870594d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.1203391435043959d, b: 0.8297776147393376d, c: 0.6006997032762901d),
new NpgsqlTypes.NpgsqlLine(a: 0.7680413580008894d, b: 0.8957133132168754d, c: 0.5431452089084194d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.06590841923209845d, b: 0.8734229829761763d, c: 0.9269722768242767d),
new NpgsqlTypes.NpgsqlLine(a: 0.40768908415143734d, b: 0.9605213697207483d, c: 0.8038955588808088d), } },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.897184418933734d, b: 0.9695074284037067d, c: 0.17603004240457132d),
new NpgsqlTypes.NpgsqlLine(a: 0.1520228492220731d, b: 0.020866667791179072d, c: 0.06559611143339328d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.24113983626528457d, b: 0.3997321376444313d, c: 0.6042467931724503d),
new NpgsqlTypes.NpgsqlLine(a: 0.9194082517795721d, b: 0.39373762073505825d, c: 0.12974193248348476d), } },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5770470634828638d, b: 0.20277380898155517d, c: 0.7327803531732003d),
new NpgsqlTypes.NpgsqlLine(a: 0.5072176606339875d, b: 0.3471927653534337d, c: 0.17504407556120072d), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.3238516669846313d, b: 0.767591335731818d, c: 0.9937445374185143d),
new NpgsqlTypes.NpgsqlLine(a: 0.519200980904512d, b: 0.6487461200828225d, c: 0.3509759003728572d), } }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5936746333705624d, b: 0.5630304651608167d, c: 0.07710267078028032d),
new NpgsqlTypes.NpgsqlLine(a: 0.41810683602262533d, b: 0.24475511304268427d, c: 0.5017148612269229d), } }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.837794806484738d, b: 0.00764050026975216d, c: 0.4138830288858628d),
new NpgsqlTypes.NpgsqlLine(a: 0.32509678176176626d, b: 0.1414231375099172d, c: 0.29691533531300796d), } }));
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 51;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 47, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 47, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 68, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 1, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 28, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 146, query1, 1, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 28, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 105, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
FROM public.binary_npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI), typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

