

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7380674488939872d, y: 0.5283532911254286d), new NpgsqlTypes.NpgsqlPoint(x: 0.1416714026648347d, y: 0.12617288045391872d), new NpgsqlTypes.NpgsqlPoint(x: 0.32296121773308073d, y: 0.8831166201995564d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29159525155496346d, y: 0.8937617373061376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960242795584341d, y: 0.3145590399471956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5125166304107229d, y: 0.5407290593404361d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12996412703425664d, y: 0.4963608651828293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164322346017265d, y: 0.4308270299495055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674283281825973d, y: 0.07897228507978737d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8833071521394376d, y: 0.6358045780522941d), new NpgsqlTypes.NpgsqlPoint(x: 0.40610336626999655d, y: 0.19456991419032155d), new NpgsqlTypes.NpgsqlPoint(x: 0.22706178646395025d, y: 0.4482309092760558d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36631359860732793d, y: 0.013544993350581458d), new NpgsqlTypes.NpgsqlPoint(x: 0.4009341740775917d, y: 0.3014151032317195d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328072081854722d, y: 0.31583137263770245d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35022615794645573d, y: 0.2755015763550518d), new NpgsqlTypes.NpgsqlPoint(x: 0.9731415698924042d, y: 0.5718866173515628d), new NpgsqlTypes.NpgsqlPoint(x: 0.31454047242239214d, y: 0.717092290092387d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7141521292227057d, y: 0.34969188812182095d), new NpgsqlTypes.NpgsqlPoint(x: 0.3420155337668159d, y: 0.6286627100235942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080109656130495d, y: 0.0053671650809800076d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5296487879468949d, y: 0.9431178466983026d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979628381336238d, y: 0.271860277146297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9643375247970022d, y: 0.3397758554331354d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.71436433422356d, y: 0.9860771923238866d), new NpgsqlTypes.NpgsqlPoint(x: 0.45038438086788357d, y: 0.5523324269767022d), new NpgsqlTypes.NpgsqlPoint(x: 0.17275545178497775d, y: 0.3891384889281334d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08326513732107887d, y: 0.1705464015731678d), new NpgsqlTypes.NpgsqlPoint(x: 0.9702771774230479d, y: 0.39817256056899564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6721866757280729d, y: 0.19748871468986784d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7300373064715843d, y: 0.9198902464210273d), new NpgsqlTypes.NpgsqlPoint(x: 0.1474580183528562d, y: 0.2574379695266551d), new NpgsqlTypes.NpgsqlPoint(x: 0.09043018530959634d, y: 0.5611324405094145d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3354075797603321d, y: 0.13826519721800157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8461317064869552d, y: 0.8165069654235153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875725853452735d, y: 0.6489175698629265d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3733172308377761d, y: 0.8783910530053934d), new NpgsqlTypes.NpgsqlPoint(x: 0.013941697957944643d, y: 0.7361550165604372d), new NpgsqlTypes.NpgsqlPoint(x: 0.49539619266568613d, y: 0.48110340857149403d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30060665291743427d, y: 0.9663440710998964d), new NpgsqlTypes.NpgsqlPoint(x: 0.1977018780580564d, y: 0.4141496260316172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6074604238916153d, y: 0.6217586778366997d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43275489874146966d, y: 0.20378604988733195d), new NpgsqlTypes.NpgsqlPoint(x: 0.22380963203636173d, y: 0.2530338427981018d), new NpgsqlTypes.NpgsqlPoint(x: 0.20586578890792817d, y: 0.7059541120994447d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1781139147402211d, y: 0.3128580181241848d), new NpgsqlTypes.NpgsqlPoint(x: 0.64751599928628d, y: 0.3953556454525554d), new NpgsqlTypes.NpgsqlPoint(x: 0.095063531785881d, y: 0.18633861090730797d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.539479066652231d, y: 0.3892641327388028d), new NpgsqlTypes.NpgsqlPoint(x: 0.07231795069197133d, y: 0.7558398798643677d), new NpgsqlTypes.NpgsqlPoint(x: 0.030539317388526332d, y: 0.42413007818877524d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19567312540348647d, y: 0.282668005046664d), new NpgsqlTypes.NpgsqlPoint(x: 0.07337643426311313d, y: 0.8148940704910198d), new NpgsqlTypes.NpgsqlPoint(x: 0.857916823529281d, y: 0.0033595583513581495d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.044835832929253305d, y: 0.8602261140535731d), new NpgsqlTypes.NpgsqlPoint(x: 0.5855756426555973d, y: 0.039585965562586534d), new NpgsqlTypes.NpgsqlPoint(x: 0.3630713787837774d, y: 0.3686466766243871d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6329399577253101d, y: 0.023364167355002463d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441384925868163d, y: 0.4211502872901949d), new NpgsqlTypes.NpgsqlPoint(x: 0.4258145355601568d, y: 0.6412797438936158d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9806879973330688d, y: 0.3022067012619225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5208105743231572d, y: 0.33783302850675523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068251304599219d, y: 0.6663689957597259d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.642234858921526d, y: 0.6665215968285599d), new NpgsqlTypes.NpgsqlPoint(x: 0.4032622908778861d, y: 0.3003849540512946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5318586210119001d, y: 0.9028453176144049d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12178039561808007d, y: 0.10089122060664546d), new NpgsqlTypes.NpgsqlPoint(x: 0.13497133462805588d, y: 0.003960785624003926d), new NpgsqlTypes.NpgsqlPoint(x: 0.32928866384687505d, y: 0.5511664301097761d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.025501852663703306d, y: 0.01865264828285862d), new NpgsqlTypes.NpgsqlPoint(x: 0.7857413188074484d, y: 0.6474587756496296d), new NpgsqlTypes.NpgsqlPoint(x: 0.580204889029242d, y: 0.1820684375323084d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06627408224697484d, y: 0.21793807565321266d), new NpgsqlTypes.NpgsqlPoint(x: 0.07402864125279784d, y: 0.2807490232904414d), new NpgsqlTypes.NpgsqlPoint(x: 0.983072730998319d, y: 0.6824521986678214d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25758273969362977d, y: 0.0678108163882668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8168206536920989d, y: 0.34420521395418135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7362151335579369d, y: 0.920157307291687d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.75653722449396d, y: 0.8465370210903064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7181282501239065d, y: 0.8741906581657654d), new NpgsqlTypes.NpgsqlPoint(x: 0.4451250364057666d, y: 0.8290524240537174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9632130330081763d, y: 0.786265023016488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290974966552425d, y: 0.5879434157003552d), new NpgsqlTypes.NpgsqlPoint(x: 0.48074463588899685d, y: 0.37136755624166295d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9033422183278778d, y: 0.06631106538774867d), new NpgsqlTypes.NpgsqlPoint(x: 0.35555934050013094d, y: 0.41999435193876d), new NpgsqlTypes.NpgsqlPoint(x: 0.2052213551272043d, y: 0.6167296731597359d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46221555508405154d, y: 0.804652154456639d), new NpgsqlTypes.NpgsqlPoint(x: 0.18057879357237006d, y: 0.47880664695863673d), new NpgsqlTypes.NpgsqlPoint(x: 0.04920376766923307d, y: 0.1954660908636503d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32016358434867054d, y: 0.5815309034180428d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639380126703978d, y: 0.49280825515794746d), new NpgsqlTypes.NpgsqlPoint(x: 0.14469680955293396d, y: 0.3455111139031547d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4687641145333852d, y: 0.15873480585616728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4938492818771105d, y: 0.36276454319176943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074349078009458d, y: 0.4025311391116785d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48883936731858046d, y: 0.4126227954561531d), new NpgsqlTypes.NpgsqlPoint(x: 0.729676440916933d, y: 0.9563262175209261d), new NpgsqlTypes.NpgsqlPoint(x: 0.667174992739563d, y: 0.636544976508969d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9310576483419727d, y: 0.7291898212681605d), new NpgsqlTypes.NpgsqlPoint(x: 0.3795643230739719d, y: 0.0177399507132181d), new NpgsqlTypes.NpgsqlPoint(x: 0.1412329648482894d, y: 0.7676686826263502d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2043617005501337d, y: 0.8294776138173268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7046848908499818d, y: 0.09014229571977905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209895376455422d, y: 0.4598805378373104d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13553049504752224d, y: 0.031023311951762333d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334117872261999d, y: 0.8098895237583814d), new NpgsqlTypes.NpgsqlPoint(x: 0.6485387795761202d, y: 0.9539792717741785d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6771833210247973d, y: 0.4770409795688393d), new NpgsqlTypes.NpgsqlPoint(x: 0.11144936282674467d, y: 0.0785133103428931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032636298004296d, y: 0.42344123722418336d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9070101187635508d, y: 0.1337629410370348d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008678225413873d, y: 0.3716081647254521d), new NpgsqlTypes.NpgsqlPoint(x: 0.11932024675287456d, y: 0.6366528605593726d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5798040933835478d, y: 0.13227154163749677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6951928944435465d, y: 0.3896700367114777d), new NpgsqlTypes.NpgsqlPoint(x: 0.02846836232499972d, y: 0.12173174563038602d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7923491866183517d, y: 0.4360595454621129d), new NpgsqlTypes.NpgsqlPoint(x: 0.6730246477426649d, y: 0.5351397777323091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9868955971966926d, y: 0.2823642579607897d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5395361633051635d, y: 0.3665137212601136d), new NpgsqlTypes.NpgsqlPoint(x: 0.09612066404510888d, y: 0.6613095817645965d), new NpgsqlTypes.NpgsqlPoint(x: 0.3769063741909645d, y: 0.04544474681018307d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052115313700633825d, y: 0.6496939869283174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9474812368878629d, y: 0.875129254208516d), new NpgsqlTypes.NpgsqlPoint(x: 0.42228261024627356d, y: 0.4106195810419153d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3457203873754813d, y: 0.2825096315183909d), new NpgsqlTypes.NpgsqlPoint(x: 0.22278815659537166d, y: 0.012018636576555997d), new NpgsqlTypes.NpgsqlPoint(x: 0.20290519812148788d, y: 0.5835398090553058d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1311382194856745d, y: 0.9732369332505081d), new NpgsqlTypes.NpgsqlPoint(x: 0.029233133847431092d, y: 0.7260082278691072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6642904445320823d, y: 0.9439013800582209d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38064912616336777d, y: 0.7735002762053779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4497624835124935d, y: 0.34163370296882545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9051763221973427d, y: 0.08071900841702084d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6284585689717327d, y: 0.8340568773251493d), new NpgsqlTypes.NpgsqlPoint(x: 0.16397345423738274d, y: 0.7363993263096977d), new NpgsqlTypes.NpgsqlPoint(x: 0.4050310437907977d, y: 0.4350358748165396d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5844070925681804d, y: 0.49114560461422263d), new NpgsqlTypes.NpgsqlPoint(x: 0.12647380319570467d, y: 0.047085986610528985d), new NpgsqlTypes.NpgsqlPoint(x: 0.13079503071475373d, y: 0.16551303148988217d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9211266836100929d, y: 0.6320865655141367d), new NpgsqlTypes.NpgsqlPoint(x: 0.44675564455738936d, y: 0.17897057827172602d), new NpgsqlTypes.NpgsqlPoint(x: 0.14122424578489745d, y: 0.5610045434469696d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8436121941546227d, y: 0.9438164592576043d), new NpgsqlTypes.NpgsqlPoint(x: 0.940785118121527d, y: 0.6907053706033258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8263858260149387d, y: 0.41130527787337656d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2384143909242613d, y: 0.12724356548234783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761673926789899d, y: 0.17337828691085855d), new NpgsqlTypes.NpgsqlPoint(x: 0.12996112779571223d, y: 0.19957114602663462d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44217406618879274d, y: 0.8682154865571245d), new NpgsqlTypes.NpgsqlPoint(x: 0.554966492392459d, y: 0.047289386272890144d), new NpgsqlTypes.NpgsqlPoint(x: 0.22381875024418518d, y: 0.9788290040190226d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38771614194842885d, y: 0.1552815664077929d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684894604484798d, y: 0.3423283026077293d), new NpgsqlTypes.NpgsqlPoint(x: 0.29993270277604267d, y: 0.3590152319433574d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5221218576035163d, y: 0.9727235401730278d), new NpgsqlTypes.NpgsqlPoint(x: 0.12870688889159065d, y: 0.7778232922304551d), new NpgsqlTypes.NpgsqlPoint(x: 0.46532222006360524d, y: 0.34084646790259654d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4131249274719073d, y: 0.9465395813573332d), new NpgsqlTypes.NpgsqlPoint(x: 0.49428975146495857d, y: 0.7357007575154123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9339631159799547d, y: 0.5957066803248697d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3266704305821734d, y: 0.5077629013706633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205961798883169d, y: 0.4289019574427826d), new NpgsqlTypes.NpgsqlPoint(x: 0.20730058665455564d, y: 0.8161443612984075d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5026770735438906d, y: 0.14313825426336835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722322951102181d, y: 0.36036295425533615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664992790134882d, y: 0.1801957033898507d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3828801175158931d, y: 0.07982916129437234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123586625486765d, y: 0.6514788700436978d), new NpgsqlTypes.NpgsqlPoint(x: 0.1851943026486237d, y: 0.8369805876554572d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7452162263607782d, y: 0.5536825706892923d), new NpgsqlTypes.NpgsqlPoint(x: 0.7632066858266199d, y: 0.18900111814278608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5926267016314225d, y: 0.5563247538084738d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4610379302515535d, y: 0.921846066202253d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606912395574662d, y: 0.43342755788747644d), new NpgsqlTypes.NpgsqlPoint(x: 0.4003206342230974d, y: 0.2523741406526725d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7979073383652047d, y: 0.9138572634736543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914946656273515d, y: 0.9811543029139806d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032527454071477d, y: 0.25569911073359153d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5891494400766463d, y: 0.4388822957210704d), new NpgsqlTypes.NpgsqlPoint(x: 0.624128687623445d, y: 0.619337975942325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3101105699013431d, y: 0.4360837984193823d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2101396778070408d, y: 0.692782578551684d), new NpgsqlTypes.NpgsqlPoint(x: 0.10812266889475075d, y: 0.35266147858044605d), new NpgsqlTypes.NpgsqlPoint(x: 0.3722757749056139d, y: 0.6523137474079139d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.058369129693459976d, y: 0.7926231433925753d), new NpgsqlTypes.NpgsqlPoint(x: 0.1771102510848318d, y: 0.23441830581598222d), new NpgsqlTypes.NpgsqlPoint(x: 0.673705750083031d, y: 0.2723014741603266d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3678594622077954d, y: 0.10091159705136432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730137926102701d, y: 0.6113208778266684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5726005858638702d, y: 0.23156495408436584d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9431545642304585d, y: 0.8478048988026535d), new NpgsqlTypes.NpgsqlPoint(x: 0.36256415386358654d, y: 0.477627471237003d), new NpgsqlTypes.NpgsqlPoint(x: 0.97429329626531d, y: 0.5998105620373085d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7143603524993514d, y: 0.05281050405901122d), new NpgsqlTypes.NpgsqlPoint(x: 0.4022735948227175d, y: 0.3437717314367703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032135202587554d, y: 0.1404529359079022d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7080120461564676d, y: 0.8612467608440285d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160522969255326d, y: 0.31653452253114733d), new NpgsqlTypes.NpgsqlPoint(x: 0.5277647864926835d, y: 0.47005266795248624d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2249665545751891d, y: 0.19772338306147963d), new NpgsqlTypes.NpgsqlPoint(x: 0.4730596907908594d, y: 0.06498477374623446d), new NpgsqlTypes.NpgsqlPoint(x: 0.4859141350625825d, y: 0.2855901131448847d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.991381969796041d, y: 0.5746311851607493d), new NpgsqlTypes.NpgsqlPoint(x: 0.11217946853441585d, y: 0.8586416120751637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7007984801586434d, y: 0.13912543717358195d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5071819158471121d, y: 0.5731384722915692d), new NpgsqlTypes.NpgsqlPoint(x: 0.37113658346637834d, y: 0.8090577274498044d), new NpgsqlTypes.NpgsqlPoint(x: 0.8120534191671177d, y: 0.7586066543871124d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47006062646025726d, y: 0.5802693955441399d), new NpgsqlTypes.NpgsqlPoint(x: 0.1671348481801942d, y: 0.8538195052548955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657835928396122d, y: 0.8586555589270555d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6551412530063182d, y: 0.2834383092583963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540797810632331d, y: 0.6913145702136878d), new NpgsqlTypes.NpgsqlPoint(x: 0.176285942841501d, y: 0.9875331840573557d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4056081405428108d, y: 0.12478914442059208d), new NpgsqlTypes.NpgsqlPoint(x: 0.4138758423917669d, y: 0.9886066062552072d), new NpgsqlTypes.NpgsqlPoint(x: 0.16175642598522733d, y: 0.8747895063433868d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6405885842327367d, y: 0.6496055891832321d), new NpgsqlTypes.NpgsqlPoint(x: 0.730799926575635d, y: 0.3962052075141693d), new NpgsqlTypes.NpgsqlPoint(x: 0.13811774296902957d, y: 0.9261552672326457d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09229199215719563d, y: 0.5815217982316341d), new NpgsqlTypes.NpgsqlPoint(x: 0.3655378620484252d, y: 0.888354825119384d), new NpgsqlTypes.NpgsqlPoint(x: 0.09908054451300685d, y: 0.7294789141802016d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24882947094295293d, y: 0.5551854358369746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651736704641812d, y: 0.40754355446754675d), new NpgsqlTypes.NpgsqlPoint(x: 0.0742336346289787d, y: 0.5468153028858714d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.424765924688284d, y: 0.8465726984637415d), new NpgsqlTypes.NpgsqlPoint(x: 0.882280126655451d, y: 0.2611428223735023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276158087073799d, y: 0.5382297946810207d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3067772473680055d, y: 0.6899415004825964d), new NpgsqlTypes.NpgsqlPoint(x: 0.929676452944506d, y: 0.49556710265292014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6633255125467256d, y: 0.7917478613564735d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8891197526148701d, y: 0.6808956893754777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390464729600741d, y: 0.9706401203215841d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115745344736529d, y: 0.3101384890771298d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7841826083545183d, y: 0.6294492426342482d), new NpgsqlTypes.NpgsqlPoint(x: 0.2670071030106548d, y: 0.8705045963073881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9863593837135227d, y: 0.506136931283227d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7487035028609165d, y: 0.6103496796967183d), new NpgsqlTypes.NpgsqlPoint(x: 0.4238596590005922d, y: 0.4592236463469386d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991606313723813d, y: 0.7596348556975018d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15643400328356494d, y: 0.048298633239631905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3123130756780593d, y: 0.5251092606613971d), new NpgsqlTypes.NpgsqlPoint(x: 0.21609132160585198d, y: 0.38902078467197354d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3319510876282292d, y: 0.5707200503608167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7720108033796786d, y: 0.036680221964777715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282188385392088d, y: 0.8845918600372494d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6285036278472387d, y: 0.15161762198793904d), new NpgsqlTypes.NpgsqlPoint(x: 0.41019122745762726d, y: 0.2060114763554347d), new NpgsqlTypes.NpgsqlPoint(x: 0.11911185374324951d, y: 0.4200084261777104d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10830000769806236d, y: 0.14050793370263948d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318647461997241d, y: 0.5142764546722467d), new NpgsqlTypes.NpgsqlPoint(x: 0.5007184628129654d, y: 0.7832199813909468d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6490369202668406d, y: 0.29094702069806067d), new NpgsqlTypes.NpgsqlPoint(x: 0.25262082710631084d, y: 0.9759409082168536d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283377975527927d, y: 0.4974080954143354d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9773945615317938d, y: 0.914056929907764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6819056210014335d, y: 0.04082477920805472d), new NpgsqlTypes.NpgsqlPoint(x: 0.29455712144058244d, y: 0.28357211226573154d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.344012520368569d, y: 0.548254455406272d), new NpgsqlTypes.NpgsqlPoint(x: 0.1502667005755629d, y: 0.13367436951509748d), new NpgsqlTypes.NpgsqlPoint(x: 0.873285813356333d, y: 0.8377148043605517d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7586775569089317d, y: 0.39018682313486774d), new NpgsqlTypes.NpgsqlPoint(x: 0.4882246240152187d, y: 0.13139132748608662d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998919804901597d, y: 0.8691519944112153d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.550786460417509d, y: 0.562618999547561d), new NpgsqlTypes.NpgsqlPoint(x: 0.1402766394146383d, y: 0.14771397576316936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738419901745506d, y: 0.9077337901799809d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6515793602993603d, y: 0.6527575257570183d), new NpgsqlTypes.NpgsqlPoint(x: 0.25689876245672016d, y: 0.9714618298766046d), new NpgsqlTypes.NpgsqlPoint(x: 0.3642030559307514d, y: 0.01693751135959365d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13163451904761403d, y: 0.9939419773466245d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883931240006034d, y: 0.17052438145587612d), new NpgsqlTypes.NpgsqlPoint(x: 0.18132383142096753d, y: 0.9004861841487326d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4308295376202904d, y: 0.030626191352746024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5079520601448556d, y: 0.1211527537647965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160662829372613d, y: 0.26533939430672937d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9720488649394969d, y: 0.12189779554629432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7409369987354131d, y: 0.32333932554980194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110144488300594d, y: 0.8620642775990958d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4138071774320219d, y: 0.24189680969172533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977509732905217d, y: 0.5126870667512414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6730686147422462d, y: 0.428374518656898d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5237100598476075d, y: 0.02023982068268715d), new NpgsqlTypes.NpgsqlPoint(x: 0.05007951084372353d, y: 0.4523001561015251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113367620972022d, y: 0.34576865972971016d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37195118654390136d, y: 0.002765017061663988d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173005833997357d, y: 0.540158889992718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775517177475862d, y: 0.4834120043186889d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7390203907568134d, y: 0.11933876604442673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8897104646921856d, y: 0.09944909844005667d), new NpgsqlTypes.NpgsqlPoint(x: 0.2983758458197281d, y: 0.15847337067636902d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8692304574653081d, y: 0.7376076409020251d), new NpgsqlTypes.NpgsqlPoint(x: 0.6605568292160627d, y: 0.40274616380408146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8680908576599679d, y: 0.8764537770284685d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5098265615852204d, y: 0.19289336439454163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4031216734421904d, y: 0.9245546130582515d), new NpgsqlTypes.NpgsqlPoint(x: 0.983044336453645d, y: 0.29585290031653455d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9006517885550497d, y: 0.7309357224042582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6051461184002144d, y: 0.5900620062822642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6389834170126548d, y: 0.9782208872512157d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35432207988131037d, y: 0.18818244932823147d), new NpgsqlTypes.NpgsqlPoint(x: 0.49618261582406353d, y: 0.15112946483690837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8566136638582977d, y: 0.7003013955751983d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6798003222011899d, y: 0.2666162103019133d), new NpgsqlTypes.NpgsqlPoint(x: 0.15805939145874226d, y: 0.29898188127657155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930485337533081d, y: 0.2808278390498592d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24800914537402885d, y: 0.30568669114256886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599310755258132d, y: 0.7309591741594247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3278272572069628d, y: 0.655712144498735d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8043096646073519d, y: 0.9069772336416002d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606877651490052d, y: 0.29879992803091093d), new NpgsqlTypes.NpgsqlPoint(x: 0.302845938889701d, y: 0.7339917128241361d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6984282569554469d, y: 0.48389681593443934d), new NpgsqlTypes.NpgsqlPoint(x: 0.14229982292443677d, y: 0.546052547942774d), new NpgsqlTypes.NpgsqlPoint(x: 0.021084982701541133d, y: 0.9400602425872319d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16862942697245953d, y: 0.3652205009747017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7491575370999412d, y: 0.3427931313287431d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068809796790601d, y: 0.9552010741823933d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6754558360642693d, y: 0.025578264750244606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6217803817123829d, y: 0.20165378669003464d), new NpgsqlTypes.NpgsqlPoint(x: 0.259789425361336d, y: 0.6563802462329826d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5029831146683974d, y: 0.24475568763071265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443350650760989d, y: 0.8094547654310915d), new NpgsqlTypes.NpgsqlPoint(x: 0.4641168768720765d, y: 0.178155357105228d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24972446447383367d, y: 0.6681994715751605d), new NpgsqlTypes.NpgsqlPoint(x: 0.08592797088367699d, y: 0.9039339390963587d), new NpgsqlTypes.NpgsqlPoint(x: 0.412818703260758d, y: 0.892985852389444d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18523514469724234d, y: 0.6020697864804061d), new NpgsqlTypes.NpgsqlPoint(x: 0.00046383518373971366d, y: 0.023585540853737652d), new NpgsqlTypes.NpgsqlPoint(x: 0.49088356678638223d, y: 0.9656100699404949d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4377942352533464d, y: 0.7665000260330708d), new NpgsqlTypes.NpgsqlPoint(x: 0.26965651136299695d, y: 0.6942102357430966d), new NpgsqlTypes.NpgsqlPoint(x: 0.08891040918130833d, y: 0.1231702413634358d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37180393983709736d, y: 0.3640124255282805d), new NpgsqlTypes.NpgsqlPoint(x: 0.3065299664640636d, y: 0.6194084967710031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131506997068507d, y: 0.043827307192047193d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8443459010885173d, y: 0.4850099060117756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844477506198638d, y: 0.625851827811281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8723686699399904d, y: 0.27995736907744295d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4902855606972306d, y: 0.9035945233179951d), new NpgsqlTypes.NpgsqlPoint(x: 0.18228343038931671d, y: 0.36270677205523727d), new NpgsqlTypes.NpgsqlPoint(x: 0.873633034315613d, y: 0.3763507455947427d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04095333765121478d, y: 0.03654911330928157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729181745155037d, y: 0.3114907099102723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111430096050638d, y: 0.6723171370447962d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1550427455934219d, y: 0.3832193751693084d), new NpgsqlTypes.NpgsqlPoint(x: 0.34343728843663535d, y: 0.19635315887327331d), new NpgsqlTypes.NpgsqlPoint(x: 0.8007833669130663d, y: 0.1303432767993873d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7182305191225982d, y: 0.21318777332101924d), new NpgsqlTypes.NpgsqlPoint(x: 0.359453175503882d, y: 0.3485732822670218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585487661845902d, y: 0.10517369425524514d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5735653629354776d, y: 0.26664197669001344d), new NpgsqlTypes.NpgsqlPoint(x: 0.2667049835704779d, y: 0.0027850011756425097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8151386080349868d, y: 0.4665975603287297d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20509356187274985d, y: 0.32878984051810856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9774670930427409d, y: 0.30660094921017655d), new NpgsqlTypes.NpgsqlPoint(x: 0.2546306389499091d, y: 0.1640956839784865d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.79858014196634d, y: 0.3811289567323237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8506313494299352d, y: 0.004620533896545376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001985785953516d, y: 0.31623471183122387d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3461992832886579d, y: 0.6288047982698273d), new NpgsqlTypes.NpgsqlPoint(x: 0.22177476156435638d, y: 0.7316368448978644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7713996369346642d, y: 0.17597903282228688d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12999485217549178d, y: 0.0028839737256294296d), new NpgsqlTypes.NpgsqlPoint(x: 0.2832096925205414d, y: 0.3732193231418851d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845165601599753d, y: 0.5932342383952086d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021844480675505262d, y: 0.0624976991251075d), new NpgsqlTypes.NpgsqlPoint(x: 0.17860205749005797d, y: 0.7997800371138436d), new NpgsqlTypes.NpgsqlPoint(x: 0.16567984963166882d, y: 0.8588300135344398d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6600561188213694d, y: 0.02560814256691679d), new NpgsqlTypes.NpgsqlPoint(x: 0.983768568092455d, y: 0.6862754036001115d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802571089071826d, y: 0.19441483694217954d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3209449198678138d, y: 0.8301246619781238d), new NpgsqlTypes.NpgsqlPoint(x: 0.06640690610018984d, y: 0.24819435700819115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379689821934915d, y: 0.6280828380803413d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4000317041816108d, y: 0.6943644283141154d), new NpgsqlTypes.NpgsqlPoint(x: 0.09670056178723785d, y: 0.35977258984255434d), new NpgsqlTypes.NpgsqlPoint(x: 0.6636592980617702d, y: 0.8245659987741953d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.907890581307483d, y: 0.2192929228998759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045098125201161d, y: 0.8338571140453432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331409212456376d, y: 0.3911999788375201d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10047276212520884d, y: 0.5800770845710569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788297575766496d, y: 0.73310413889232d), new NpgsqlTypes.NpgsqlPoint(x: 0.5979490642366689d, y: 0.6853740557733241d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.544358273487012d, y: 0.9278011183685738d), new NpgsqlTypes.NpgsqlPoint(x: 0.3870359834587004d, y: 0.23351183418238564d), new NpgsqlTypes.NpgsqlPoint(x: 0.0049952955988384895d, y: 0.945831943545456d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4082603871723737d, y: 0.025857864765949312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928496433727981d, y: 0.9239085802217086d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696814772402225d, y: 0.237510821274303d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4167185119678931d, y: 0.32155772802438154d), new NpgsqlTypes.NpgsqlPoint(x: 0.29659936544630716d, y: 0.3428324060846205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198547280044943d, y: 0.20635922382700256d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3655791950551547d, y: 0.5089934549145796d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646328476411295d, y: 0.8351509396755239d), new NpgsqlTypes.NpgsqlPoint(x: 0.3557397446718875d, y: 0.0664483008730361d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.421481525522161d, y: 0.3879672067344485d), new NpgsqlTypes.NpgsqlPoint(x: 0.05413487488597957d, y: 0.9663642436705877d), new NpgsqlTypes.NpgsqlPoint(x: 0.3509080230547068d, y: 0.6653538361182576d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019339070353965204d, y: 0.5277882111253513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4188856023269839d, y: 0.2718379323678396d), new NpgsqlTypes.NpgsqlPoint(x: 0.28869026527222563d, y: 0.01307899476185892d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04011099094509629d, y: 0.7330781513850925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9512579990658356d, y: 0.6593051859691604d), new NpgsqlTypes.NpgsqlPoint(x: 0.1594969521346552d, y: 0.3843098890141067d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40695507779648066d, y: 0.013116699335848025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993969131458369d, y: 0.357664376857716d), new NpgsqlTypes.NpgsqlPoint(x: 0.11702008103281925d, y: 0.4805730681130259d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7067632134312329d, y: 0.10712559101109431d), new NpgsqlTypes.NpgsqlPoint(x: 0.9285792183757793d, y: 0.41315016968839213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572111194291385d, y: 0.7931021954236872d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4431853519319833d, y: 0.4457261120383821d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425268151524393d, y: 0.6577019584063543d), new NpgsqlTypes.NpgsqlPoint(x: 0.022404261735770148d, y: 0.5724870280709594d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7142835951885054d, y: 0.4824221394351098d), new NpgsqlTypes.NpgsqlPoint(x: 0.34741494866723954d, y: 0.8461887525375817d), new NpgsqlTypes.NpgsqlPoint(x: 0.571366904607991d, y: 0.6540656823105644d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9282299883915999d, y: 0.46349096254293365d), new NpgsqlTypes.NpgsqlPoint(x: 0.21392703489277964d, y: 0.991920095021826d), new NpgsqlTypes.NpgsqlPoint(x: 0.039288864803973644d, y: 0.7216577528885612d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5572501451510364d, y: 0.005136112615967359d), new NpgsqlTypes.NpgsqlPoint(x: 0.010769638707763152d, y: 0.2483599804461173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273343194594053d, y: 0.7384408853396763d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12093991579561458d, y: 0.9130260755659733d), new NpgsqlTypes.NpgsqlPoint(x: 0.3316687668239279d, y: 0.40442899264390386d), new NpgsqlTypes.NpgsqlPoint(x: 0.725134636323618d, y: 0.23879438290751887d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48834369776995223d, y: 0.9764663840992319d), new NpgsqlTypes.NpgsqlPoint(x: 0.44264324668715105d, y: 0.7618258598529025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860116182396399d, y: 0.8708447818046471d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8020429983902803d, y: 0.5079881729488259d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471239412182837d, y: 0.15316781020033698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029329599873755d, y: 0.7914734400464869d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7236412467089741d, y: 0.8816324183693247d), new NpgsqlTypes.NpgsqlPoint(x: 0.03327498781551008d, y: 0.37725344957544527d), new NpgsqlTypes.NpgsqlPoint(x: 0.467201713519924d, y: 0.45712454827869464d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9768100679317651d, y: 0.9991367313027119d), new NpgsqlTypes.NpgsqlPoint(x: 0.4928078661336627d, y: 0.0695836932882623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5847791664905462d, y: 0.05508915635154832d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35103689287107853d, y: 0.8899671320891254d), new NpgsqlTypes.NpgsqlPoint(x: 0.15213157554808254d, y: 0.0018550104575426607d), new NpgsqlTypes.NpgsqlPoint(x: 0.45748931302841755d, y: 0.018828109157140838d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9081441636991138d, y: 0.7813832502777731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8089460131590666d, y: 0.0800008486979531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273649850296983d, y: 0.11023059979670968d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8360826507380202d, y: 0.5678535876516895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5365614397868215d, y: 0.09564668113048069d), new NpgsqlTypes.NpgsqlPoint(x: 0.7041585587263968d, y: 0.7650522391611073d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020151513385900266d, y: 0.9084702917264446d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021227218052277d, y: 0.5664184571923793d), new NpgsqlTypes.NpgsqlPoint(x: 0.21970792231059044d, y: 0.12156197259815937d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8737973851873596d, y: 0.41070346495418086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115934380506552d, y: 0.15033939563214826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002593988941603d, y: 0.16938173085730568d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9357156607163473d, y: 0.3502243872392823d), new NpgsqlTypes.NpgsqlPoint(x: 0.26119052428468936d, y: 0.7184993792376804d), new NpgsqlTypes.NpgsqlPoint(x: 0.32332913117576634d, y: 0.7173456535983275d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8726550640206995d, y: 0.022426771606872675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741402780499667d, y: 0.6514501437862515d), new NpgsqlTypes.NpgsqlPoint(x: 0.4276587306678544d, y: 0.2557806048902669d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5695311885132813d, y: 0.12944867243129388d), new NpgsqlTypes.NpgsqlPoint(x: 0.7596907446047763d, y: 0.5803589804647482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6146141381705129d, y: 0.1917082198942882d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6967845494183734d, y: 0.27261127354193726d), new NpgsqlTypes.NpgsqlPoint(x: 0.14140922026194835d, y: 0.9082895442974439d), new NpgsqlTypes.NpgsqlPoint(x: 0.5259489002790714d, y: 0.9179349886725338d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7509615906887925d, y: 0.6203466788141757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8210685849099912d, y: 0.8363206071301966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426031611257917d, y: 0.7243884616426384d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04418177568547077d, y: 0.017754464762060218d), new NpgsqlTypes.NpgsqlPoint(x: 0.10919036513009062d, y: 0.9898834967089647d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862528868406473d, y: 0.37441124835067574d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09474387605801016d, y: 0.789717149099291d), new NpgsqlTypes.NpgsqlPoint(x: 0.04757153053493701d, y: 0.595280158681091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009520586314866d, y: 0.1457696915732476d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6504584023544816d, y: 0.2543362045217661d), new NpgsqlTypes.NpgsqlPoint(x: 0.54919085232201d, y: 0.2161076754567426d), new NpgsqlTypes.NpgsqlPoint(x: 0.5593239786965399d, y: 0.9442062288328545d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17959569581543333d, y: 0.36438115801943605d), new NpgsqlTypes.NpgsqlPoint(x: 0.0028144565345419315d, y: 0.6632948754189688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9984153298912335d, y: 0.7101246913166622d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0981755871143909d, y: 0.5537022478297766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415637465164147d, y: 0.2509631985354217d), new NpgsqlTypes.NpgsqlPoint(x: 0.3997884221088238d, y: 0.2571990933140169d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8351765529601367d, y: 0.06408866123925716d), new NpgsqlTypes.NpgsqlPoint(x: 0.07810932619016642d, y: 0.3540105863368812d), new NpgsqlTypes.NpgsqlPoint(x: 0.2688617313464404d, y: 0.21186517181980835d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4347131511858636d, y: 0.45206627322841597d), new NpgsqlTypes.NpgsqlPoint(x: 0.6886559282727001d, y: 0.6019157649029215d), new NpgsqlTypes.NpgsqlPoint(x: 0.030278950205107624d, y: 0.29270607391241277d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23017936745155088d, y: 0.38112663851493345d), new NpgsqlTypes.NpgsqlPoint(x: 0.46521688696937147d, y: 0.2509377882891236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3078125004686655d, y: 0.269026643833398d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37448409917258385d, y: 0.624526293765556d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323331633636522d, y: 0.02392258643816103d), new NpgsqlTypes.NpgsqlPoint(x: 0.882908923767821d, y: 0.20401336851238228d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.665006369749396d, y: 0.7154296134440397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385783960085728d, y: 0.677217676513681d), new NpgsqlTypes.NpgsqlPoint(x: 0.4718051488476903d, y: 0.44802952091433523d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.642158558019718d, y: 0.4391513191194173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153802373651977d, y: 0.7392226022158747d), new NpgsqlTypes.NpgsqlPoint(x: 0.22497744018259302d, y: 0.3063945921323039d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33406140446750554d, y: 0.05655278315695489d), new NpgsqlTypes.NpgsqlPoint(x: 0.2081102183896637d, y: 0.38768905912633145d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232643743126688d, y: 0.469449131860869d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8779785230355502d, y: 0.20941576586366661d), new NpgsqlTypes.NpgsqlPoint(x: 0.998446965888277d, y: 0.9053588456188d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742802497766138d, y: 0.21547731704449768d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3184584212555376d, y: 0.9482093399282842d), new NpgsqlTypes.NpgsqlPoint(x: 0.06747325655240244d, y: 0.9599926203832784d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816885481638254d, y: 0.2460586048077753d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3483158488583379d, y: 0.6352469112203136d), new NpgsqlTypes.NpgsqlPoint(x: 0.6882928929376957d, y: 0.10492776129487391d), new NpgsqlTypes.NpgsqlPoint(x: 0.8544032420546017d, y: 0.5391265904346916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10823972421421657d, y: 0.7255040582696519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8053523642226968d, y: 0.6450309978621763d), new NpgsqlTypes.NpgsqlPoint(x: 0.18435161063448757d, y: 0.14000200087844683d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7999772156693904d, y: 0.01568280822666146d), new NpgsqlTypes.NpgsqlPoint(x: 0.7799546127604252d, y: 0.807488075309703d), new NpgsqlTypes.NpgsqlPoint(x: 0.028466555196543175d, y: 0.7903206053218831d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2227585466438773d, y: 0.14906099406323292d), new NpgsqlTypes.NpgsqlPoint(x: 0.4469830271881624d, y: 0.057323498339322376d), new NpgsqlTypes.NpgsqlPoint(x: 0.2795403043434924d, y: 0.10593106295481058d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48277278172803617d, y: 0.9616579104394238d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052915860853213d, y: 0.39942299821875504d), new NpgsqlTypes.NpgsqlPoint(x: 0.13300110473521487d, y: 0.26955117360906866d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8648625667064517d, y: 0.7732800812904564d), new NpgsqlTypes.NpgsqlPoint(x: 0.24221318892689236d, y: 0.4109794028887441d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402255910868871d, y: 0.1693886173211704d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4200021505302898d, y: 0.6367661129281252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6775329670700841d, y: 0.49007862878782593d), new NpgsqlTypes.NpgsqlPoint(x: 0.880957581930054d, y: 0.3296135900321059d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.054914726934571334d, y: 0.4456291324089152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671791465719135d, y: 0.5965157761474754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2658869572797553d, y: 0.26242243154659883d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11493197347552886d, y: 0.6695100702209423d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735708645718859d, y: 0.07093836109622698d), new NpgsqlTypes.NpgsqlPoint(x: 0.47922781602406017d, y: 0.869233104805887d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09088360318011413d, y: 0.945719694611338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3810484652864812d, y: 0.2692738903078643d), new NpgsqlTypes.NpgsqlPoint(x: 0.3893147478321132d, y: 0.3797499786974028d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8648733625566113d, y: 0.10928368907635533d), new NpgsqlTypes.NpgsqlPoint(x: 0.04988336421353834d, y: 0.93850783855276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8137001141475918d, y: 0.280092628346191d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9204283288670827d, y: 0.48270296384472766d), new NpgsqlTypes.NpgsqlPoint(x: 0.18963736404264442d, y: 0.034862526416893136d), new NpgsqlTypes.NpgsqlPoint(x: 0.26550613539571455d, y: 0.5282405503617325d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8297208508301607d, y: 0.3524179779460278d), new NpgsqlTypes.NpgsqlPoint(x: 0.11562110742441223d, y: 0.01041729083636378d), new NpgsqlTypes.NpgsqlPoint(x: 0.006476818943610518d, y: 0.5880841104400527d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9213087117037777d, y: 0.5309187438078833d), new NpgsqlTypes.NpgsqlPoint(x: 0.14007356834375628d, y: 0.7631464009980102d), new NpgsqlTypes.NpgsqlPoint(x: 0.738716881955216d, y: 0.21715681552695032d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9563356933109086d, y: 0.9353774532726032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4059093252367215d, y: 0.9961016798699734d), new NpgsqlTypes.NpgsqlPoint(x: 0.14000126055020645d, y: 0.433371849051728d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06850374894307631d, y: 0.009372796386482585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5090644934659296d, y: 0.7942429763634644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3868753517621464d, y: 0.6735356932599887d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8424439293509076d, y: 0.6234813471675499d), new NpgsqlTypes.NpgsqlPoint(x: 0.49894392814251054d, y: 0.5487525904139834d), new NpgsqlTypes.NpgsqlPoint(x: 0.15845158207385002d, y: 0.05618140890394252d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5330481079622414d, y: 0.6962080655489471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791096737415832d, y: 0.021944190184009393d), new NpgsqlTypes.NpgsqlPoint(x: 0.959913628537434d, y: 0.9769896435541198d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41844945347533613d, y: 0.5638177068110393d), new NpgsqlTypes.NpgsqlPoint(x: 0.1772924859335746d, y: 0.48966069134505796d), new NpgsqlTypes.NpgsqlPoint(x: 0.36561931332593844d, y: 0.7296849481617171d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6970350688909019d, y: 0.7816464325246798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4166813253150561d, y: 0.9119116356594282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105037670747409d, y: 0.20884976972782554d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26563367282387906d, y: 0.809641291524092d), new NpgsqlTypes.NpgsqlPoint(x: 0.9705465567480853d, y: 0.74796993133356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739085873382846d, y: 0.017935531179287922d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8134972249448558d, y: 0.5245230791531011d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568335768341356d, y: 0.6707917014378196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6326631612041026d, y: 0.42262198902332204d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7995620631917775d, y: 0.4769617767431372d), new NpgsqlTypes.NpgsqlPoint(x: 0.46844888617230385d, y: 0.6871112151727604d), new NpgsqlTypes.NpgsqlPoint(x: 0.34551400796857235d, y: 0.6444557518540136d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5799082860691138d, y: 0.30048348729191643d), new NpgsqlTypes.NpgsqlPoint(x: 0.22704723936161175d, y: 0.5504910629828585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364677774911672d, y: 0.24049747108566588d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6392465337831676d, y: 0.21384583593621742d), new NpgsqlTypes.NpgsqlPoint(x: 0.4241450062340988d, y: 0.9785526242492636d), new NpgsqlTypes.NpgsqlPoint(x: 0.48220886922734296d, y: 0.7227968945382804d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08511485572177213d, y: 0.10876374840824221d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327230877554219d, y: 0.16945585784199424d), new NpgsqlTypes.NpgsqlPoint(x: 0.583488047274059d, y: 0.10398556322161545d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4000769999577831d, y: 0.14929156328196524d), new NpgsqlTypes.NpgsqlPoint(x: 0.07195318018097052d, y: 0.26045459442114005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945601459229648d, y: 0.3871030004703693d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7594783299558935d, y: 0.23211014759204485d), new NpgsqlTypes.NpgsqlPoint(x: 0.2566268833037164d, y: 0.06134298054839327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887949813993391d, y: 0.9435870816716704d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.556420819837131d, y: 0.5644066562732323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307328325379041d, y: 0.9324229299081105d), new NpgsqlTypes.NpgsqlPoint(x: 0.27282269380362967d, y: 0.7445786425373767d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3449506870990626d, y: 0.35588380175729817d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115497376484575d, y: 0.6303850900307786d), new NpgsqlTypes.NpgsqlPoint(x: 0.35026727557191106d, y: 0.07939764720485709d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27970812865146877d, y: 0.2740158618259807d), new NpgsqlTypes.NpgsqlPoint(x: 0.04409778348061466d, y: 0.9794398559575874d), new NpgsqlTypes.NpgsqlPoint(x: 0.839258295191615d, y: 0.8887151338041743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2125308318182949d, y: 0.7446144829229939d), new NpgsqlTypes.NpgsqlPoint(x: 0.3003814974787611d, y: 0.8176593561280907d), new NpgsqlTypes.NpgsqlPoint(x: 0.2503886987444509d, y: 0.9298710179827194d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10273196545661867d, y: 0.9706006396403104d), new NpgsqlTypes.NpgsqlPoint(x: 0.10872535070357658d, y: 0.13674979523349184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5363821284614522d, y: 0.11007041471955836d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2095895805203658d, y: 0.9439663215937213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9745610750728304d, y: 0.5903435623166807d), new NpgsqlTypes.NpgsqlPoint(x: 0.016716969137116178d, y: 0.08652491438888843d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9465367666335028d, y: 0.6627823109866003d), new NpgsqlTypes.NpgsqlPoint(x: 0.09034798340292893d, y: 0.9117265160783379d), new NpgsqlTypes.NpgsqlPoint(x: 0.841276435275032d, y: 0.9994204043115099d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4278706117903829d, y: 0.17108026563095657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019147223269662d, y: 0.07311873467697116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006512206925314d, y: 0.7331028460603478d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4481741158327043d, y: 0.7706582783552248d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411362792440175d, y: 0.7092125909455529d), new NpgsqlTypes.NpgsqlPoint(x: 0.03832995519094917d, y: 0.524239520638544d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5481296029571989d, y: 0.19601495596615104d), new NpgsqlTypes.NpgsqlPoint(x: 0.19443703446678695d, y: 0.29761415746977615d), new NpgsqlTypes.NpgsqlPoint(x: 0.4957991917811273d, y: 0.7376474533010626d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1531997305992705d, y: 0.9588299305976866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8808012212051594d, y: 0.6620334006213446d), new NpgsqlTypes.NpgsqlPoint(x: 0.30054922430213415d, y: 0.362701869084482d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5998175460893178d, y: 0.11795067064111675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4259151276261922d, y: 0.003890643019726081d), new NpgsqlTypes.NpgsqlPoint(x: 0.4571739049609045d, y: 0.7144222381708941d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0029170925914917545d, y: 0.5702947620489965d), new NpgsqlTypes.NpgsqlPoint(x: 0.06701865494880588d, y: 0.14996206970089787d), new NpgsqlTypes.NpgsqlPoint(x: 0.7214604958171843d, y: 0.6031123033261666d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2585105572517554d, y: 0.7011584626821635d), new NpgsqlTypes.NpgsqlPoint(x: 0.06719116700044614d, y: 0.8480566812514895d), new NpgsqlTypes.NpgsqlPoint(x: 0.1376993413308928d, y: 0.07405291768568878d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8579159515759238d, y: 0.3464497875378215d), new NpgsqlTypes.NpgsqlPoint(x: 0.05434224394091636d, y: 0.9398468392794324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7505451254800951d, y: 0.17309195742654349d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8798496711299398d, y: 0.933653651520421d), new NpgsqlTypes.NpgsqlPoint(x: 0.06954729888850208d, y: 0.6623149518200768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248029372608857d, y: 0.6136221468127923d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.138741370216641d, y: 0.11127542838844318d), new NpgsqlTypes.NpgsqlPoint(x: 0.21651975537167623d, y: 0.7816138993761869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6686889677254048d, y: 0.9500604728804566d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9638568070999701d, y: 0.6659938022426466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7152193533715394d, y: 0.27567288847313587d), new NpgsqlTypes.NpgsqlPoint(x: 0.25439722694853306d, y: 0.13291179074981474d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19327107129655752d, y: 0.43743989531801286d), new NpgsqlTypes.NpgsqlPoint(x: 0.3619252870224485d, y: 0.9941535326969464d), new NpgsqlTypes.NpgsqlPoint(x: 0.5697551820083934d, y: 0.10754663052808988d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.619029188284751d, y: 0.3724357828856054d), new NpgsqlTypes.NpgsqlPoint(x: 0.798472593459713d, y: 0.900394629402307d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613442508077606d, y: 0.7034717052736512d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28721322913013636d, y: 0.670177311040919d), new NpgsqlTypes.NpgsqlPoint(x: 0.01566661903654687d, y: 0.9072800396711475d), new NpgsqlTypes.NpgsqlPoint(x: 0.07990753067998246d, y: 0.4296286923864626d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04153042275460361d, y: 0.10892482651890978d), new NpgsqlTypes.NpgsqlPoint(x: 0.7902871850851142d, y: 0.758901800978236d), new NpgsqlTypes.NpgsqlPoint(x: 0.2830063301498822d, y: 0.09670773620116013d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7690758562307523d, y: 0.758952449332532d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945695716959551d, y: 0.5340494918451113d), new NpgsqlTypes.NpgsqlPoint(x: 0.9780481541095032d, y: 0.8307178457716338d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.857235549335073d, y: 0.1126875634888781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7884297938685647d, y: 0.12691819105852642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974291361684537d, y: 0.6289078139590046d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9290630627987192d, y: 0.5597204645595473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7782635208089087d, y: 0.0016468922203598524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5218969222620127d, y: 0.9285090041779404d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3632558815282768d, y: 0.6421144503824888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322112288122448d, y: 0.13417902653632097d), new NpgsqlTypes.NpgsqlPoint(x: 0.18394760840600155d, y: 0.47739987444121557d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21984487947161402d, y: 0.46855920585392274d), new NpgsqlTypes.NpgsqlPoint(x: 0.01296189630533473d, y: 0.6504818978322155d), new NpgsqlTypes.NpgsqlPoint(x: 0.17002902849580892d, y: 0.5977574584131905d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07979700123943756d, y: 0.7031166907909208d), new NpgsqlTypes.NpgsqlPoint(x: 0.3567935753398396d, y: 0.2234181059087227d), new NpgsqlTypes.NpgsqlPoint(x: 0.1519780150051082d, y: 0.04928646047590479d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7778582889292328d, y: 0.5214903533401727d), new NpgsqlTypes.NpgsqlPoint(x: 0.4350677856057048d, y: 0.625811979871912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080279202119969d, y: 0.5731432019237148d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1843345456933707d, y: 0.8423895113440416d), new NpgsqlTypes.NpgsqlPoint(x: 0.18851999558455002d, y: 0.022607205693574994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801931806170204d, y: 0.5057082043722857d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14681792537616611d, y: 0.5404891727140649d), new NpgsqlTypes.NpgsqlPoint(x: 0.7884215539459346d, y: 0.6206511127397203d), new NpgsqlTypes.NpgsqlPoint(x: 0.2482354027825815d, y: 0.4263360967426725d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07601763976062037d, y: 0.762353422940238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884024916604922d, y: 0.9463006819188851d), new NpgsqlTypes.NpgsqlPoint(x: 0.17515552744122187d, y: 0.07118518989917d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9195303241589994d, y: 0.6585232177460318d), new NpgsqlTypes.NpgsqlPoint(x: 0.23443531790132022d, y: 0.056240225821129974d), new NpgsqlTypes.NpgsqlPoint(x: 0.990978834120519d, y: 0.008724841605419975d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.047970116363184157d, y: 0.16662448615424985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8447963636792138d, y: 0.9742881999311597d), new NpgsqlTypes.NpgsqlPoint(x: 0.0938847444237193d, y: 0.8719327789399669d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.633287189553104d, y: 0.7704881511669913d), new NpgsqlTypes.NpgsqlPoint(x: 0.23101163518604306d, y: 0.7561524702514066d), new NpgsqlTypes.NpgsqlPoint(x: 0.877474643534206d, y: 0.40854710521535575d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6542519558191877d, y: 0.6464705249160745d), new NpgsqlTypes.NpgsqlPoint(x: 0.12351617947652382d, y: 0.47748170164162274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8015501230843474d, y: 0.35375014054803355d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08087683226134734d, y: 0.7004423101442958d), new NpgsqlTypes.NpgsqlPoint(x: 0.49581757451182573d, y: 0.7784516777956814d), new NpgsqlTypes.NpgsqlPoint(x: 0.47379902755064107d, y: 0.635085775384005d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.765528203066469d, y: 0.447373889253319d), new NpgsqlTypes.NpgsqlPoint(x: 0.05392378700966394d, y: 0.8987782924502932d), new NpgsqlTypes.NpgsqlPoint(x: 0.4243038633658036d, y: 0.636659112237008d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.888868163930889d, y: 0.5165327901265029d), new NpgsqlTypes.NpgsqlPoint(x: 0.14363567844591119d, y: 0.357173416701704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133685171680782d, y: 0.4923509637812734d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26174572426873455d, y: 0.38511473996929135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5614023110488313d, y: 0.6559550899564967d), new NpgsqlTypes.NpgsqlPoint(x: 0.7367208085697783d, y: 0.4018534308742192d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8203803714334655d, y: 0.38191932647166793d), new NpgsqlTypes.NpgsqlPoint(x: 0.08150637971769858d, y: 0.3747850356594462d), new NpgsqlTypes.NpgsqlPoint(x: 0.09654603833941011d, y: 0.8930629752973657d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6004443167580166d, y: 0.9028483314201239d), new NpgsqlTypes.NpgsqlPoint(x: 0.03735664436126618d, y: 0.05760519402156339d), new NpgsqlTypes.NpgsqlPoint(x: 0.3398491147173205d, y: 0.7518298083563464d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20293801793711275d, y: 0.44325895401012005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6485050777801598d, y: 0.9504619458056881d), new NpgsqlTypes.NpgsqlPoint(x: 0.3105690007086389d, y: 0.43421663829504564d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2743567280472726d, y: 0.1962480410498405d), new NpgsqlTypes.NpgsqlPoint(x: 0.5052396460647052d, y: 0.47469904071752456d), new NpgsqlTypes.NpgsqlPoint(x: 0.8666055645534712d, y: 0.1270140322369917d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7377616418351088d, y: 0.8687961046551819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6733955436313348d, y: 0.29613901604691917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5125101479379466d, y: 0.6528002019598639d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8520330589436038d, y: 0.8654633890161967d), new NpgsqlTypes.NpgsqlPoint(x: 0.692015156614862d, y: 0.578043650271301d), new NpgsqlTypes.NpgsqlPoint(x: 0.9553814224457841d, y: 0.606644063000903d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1893233557208246d, y: 0.13572580143586677d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249257353637825d, y: 0.02916654226097848d), new NpgsqlTypes.NpgsqlPoint(x: 0.48419205730403536d, y: 0.00048608360957225205d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3101457396836842d, y: 0.5337790078634013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6728379777334078d, y: 0.7858732362472812d), new NpgsqlTypes.NpgsqlPoint(x: 0.020621478821959527d, y: 0.6408272408820899d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7544960449162937d, y: 0.8028638648117407d), new NpgsqlTypes.NpgsqlPoint(x: 0.17607023011570955d, y: 0.8088932629765203d), new NpgsqlTypes.NpgsqlPoint(x: 0.24124389352346443d, y: 0.9505500612279331d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15872366416019923d, y: 0.2532304074237347d), new NpgsqlTypes.NpgsqlPoint(x: 0.34424135559319036d, y: 0.8062130298109746d), new NpgsqlTypes.NpgsqlPoint(x: 0.32345434327614686d, y: 0.7245763658824387d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46290515473947313d, y: 0.8902207295493387d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455755150516589d, y: 0.9843075194980231d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794959892351402d, y: 0.691526528845542d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32838697555010965d, y: 0.10157901150987103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023851261050909d, y: 0.5973158112494781d), new NpgsqlTypes.NpgsqlPoint(x: 0.8057943204552486d, y: 0.9772861850418254d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5872408346822787d, y: 0.7190139116368619d), new NpgsqlTypes.NpgsqlPoint(x: 0.16804575719616122d, y: 0.600980103651972d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024302191088463d, y: 0.4613241540362433d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8850968650529814d, y: 0.8304860815267993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7645903247967403d, y: 0.6512992306345499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464852338763326d, y: 0.8661800619692974d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028313794369795864d, y: 0.04803535943066817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6944565736464052d, y: 0.3810373728323718d), new NpgsqlTypes.NpgsqlPoint(x: 0.9005345547969128d, y: 0.5777019141318035d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2747769845262057d, y: 0.8041213792950679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8981181808779377d, y: 0.06154457003268421d), new NpgsqlTypes.NpgsqlPoint(x: 0.36319036148848394d, y: 0.8598031502777026d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6926134075294519d, y: 0.257181160132386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875717159451267d, y: 0.5038529601678565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7500896270776893d, y: 0.9746602776978909d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7739492016279906d, y: 0.07765848690361166d), new NpgsqlTypes.NpgsqlPoint(x: 0.05591513370043921d, y: 0.4653878730690455d), new NpgsqlTypes.NpgsqlPoint(x: 0.42891324777894113d, y: 0.3188609644842304d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7943820602768923d, y: 0.8775096356498328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644730770838978d, y: 0.6487668634944753d), new NpgsqlTypes.NpgsqlPoint(x: 0.2169640234386091d, y: 0.7764433643815931d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28914780813439456d, y: 0.023138267139881874d), new NpgsqlTypes.NpgsqlPoint(x: 0.08051620297941042d, y: 0.8520247828143809d), new NpgsqlTypes.NpgsqlPoint(x: 0.07369297997507429d, y: 0.7358904605916369d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9008024121793422d, y: 0.3456088822470731d), new NpgsqlTypes.NpgsqlPoint(x: 0.595798331350729d, y: 0.29955199716307335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3421304645076161d, y: 0.2533691067538941d)),

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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 43, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 33, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 33, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 57, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 40, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 59, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatch(connection, 114, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[29], false);
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
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPolygonpolygonArray2M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonListpolygonArray)this).ExportModelInner(connection).ToList();
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

