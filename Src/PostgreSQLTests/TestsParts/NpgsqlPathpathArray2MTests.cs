

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4240435471176506d, y: 0.3390371967093988d), new NpgsqlTypes.NpgsqlPoint(x: 0.04769747092752863d, y: 0.6253467258444996d), new NpgsqlTypes.NpgsqlPoint(x: 0.28971176462608605d, y: 0.9879153734596632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3727993466353563d, y: 0.19551628977771474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7039432324049266d, y: 0.26230790385587677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400542471790784d, y: 0.19329523100061297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36672973988364066d, y: 0.06405055698352136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690621356700753d, y: 0.47248233795774364d), new NpgsqlTypes.NpgsqlPoint(x: 0.008143076809467797d, y: 0.08828210687030225d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.053079456470020436d, y: 0.7072436518909d), new NpgsqlTypes.NpgsqlPoint(x: 0.6329868755532378d, y: 0.8776464477439735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9084445445613156d, y: 0.43138662178247333d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7608118131937041d, y: 0.6592681778432886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9102591638372886d, y: 0.05391190891301234d), new NpgsqlTypes.NpgsqlPoint(x: 0.5886874690235587d, y: 0.9029305204451005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8437822846561691d, y: 0.9746758480666786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211558723879349d, y: 0.570539820146175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8598451045991214d, y: 0.30170669077603884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35789811009670414d, y: 0.1699631284887343d), new NpgsqlTypes.NpgsqlPoint(x: 0.2495821940638554d, y: 0.310605968594448d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221163218473825d, y: 0.73496285635268d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9825538698736874d, y: 0.18720732249644567d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156600765164411d, y: 0.3139290498288797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539988676305358d, y: 0.8357809786300162d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24472662214128083d, y: 0.5352463629804654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5028509131350991d, y: 0.3820673997249968d), new NpgsqlTypes.NpgsqlPoint(x: 0.0487522686408457d, y: 0.4226075988489806d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6245455340381355d, y: 0.2627570922382777d), new NpgsqlTypes.NpgsqlPoint(x: 0.48695682977748966d, y: 0.7421202911597963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8370027514370657d, y: 0.5301786301255331d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7661452256061763d, y: 0.34619617813830705d), new NpgsqlTypes.NpgsqlPoint(x: 0.18271113765825053d, y: 0.22378595905221788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129425075765264d, y: 0.6071523494892921d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3104507270532242d, y: 0.20127836645181996d), new NpgsqlTypes.NpgsqlPoint(x: 0.21037157884849012d, y: 0.21873320332107649d), new NpgsqlTypes.NpgsqlPoint(x: 0.2090962679832833d, y: 0.22344197038504054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1723183452388961d, y: 0.31476585085276354d), new NpgsqlTypes.NpgsqlPoint(x: 0.738690741025476d, y: 0.08352874685030376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9657511885138886d, y: 0.8111323324200501d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4380038369612924d, y: 0.564199687060178d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832312640795325d, y: 0.5408610266588906d), new NpgsqlTypes.NpgsqlPoint(x: 0.37280848349943163d, y: 0.7371834017682904d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9483474211594188d, y: 0.6745251544508932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036130048596708d, y: 0.47815622977619443d), new NpgsqlTypes.NpgsqlPoint(x: 0.7013719009936338d, y: 0.4726439385339851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33923815475138996d, y: 0.47159310976804414d), new NpgsqlTypes.NpgsqlPoint(x: 0.10495985566966282d, y: 0.5512193092136537d), new NpgsqlTypes.NpgsqlPoint(x: 0.18322454211589767d, y: 0.3639732175296424d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41916878166841065d, y: 0.5242898526762921d), new NpgsqlTypes.NpgsqlPoint(x: 0.16071143004586375d, y: 0.324741913122527d), new NpgsqlTypes.NpgsqlPoint(x: 0.697240251141304d, y: 0.7844920537099865d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11487094242187268d, y: 0.4176297555695925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6143520620051991d, y: 0.6392527157843919d), new NpgsqlTypes.NpgsqlPoint(x: 0.3305010448942741d, y: 0.36253798648567337d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4737557394462223d, y: 0.6351625146472912d), new NpgsqlTypes.NpgsqlPoint(x: 0.44596364394638666d, y: 0.27055557579499123d), new NpgsqlTypes.NpgsqlPoint(x: 0.3619352762996646d, y: 0.742395911424288d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5964033736513943d, y: 0.13284686985081884d), new NpgsqlTypes.NpgsqlPoint(x: 0.03633224298918747d, y: 0.27188686325543776d), new NpgsqlTypes.NpgsqlPoint(x: 0.40255296625919834d, y: 0.2071083538377897d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8743708487208975d, y: 0.9524814296548094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8595243320531863d, y: 0.6370466828399023d), new NpgsqlTypes.NpgsqlPoint(x: 0.0659219461492957d, y: 0.5199551675598916d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1380416824303211d, y: 0.8226784289283827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165270906449251d, y: 0.9716687372031307d), new NpgsqlTypes.NpgsqlPoint(x: 0.6221803262194865d, y: 0.6762442918706169d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0010349617992663207d, y: 0.7561435785268569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800679472678175d, y: 0.7298375562925122d), new NpgsqlTypes.NpgsqlPoint(x: 0.06563873574005152d, y: 0.7210035501305732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5100148719255854d, y: 0.26776661757608045d), new NpgsqlTypes.NpgsqlPoint(x: 0.18411103638861392d, y: 0.8605175034325612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9410119752170071d, y: 0.3443504144407473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1789498401531393d, y: 0.9776741567289776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621491090657969d, y: 0.8597500306048906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961290848765508d, y: 0.3533715745231316d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5321835264160791d, y: 0.3367710271310478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7301413058978821d, y: 0.744618356889027d), new NpgsqlTypes.NpgsqlPoint(x: 0.4314651427874241d, y: 0.7634489664965718d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.992924649721895d, y: 0.8834585672734717d), new NpgsqlTypes.NpgsqlPoint(x: 0.11450655853454061d, y: 0.5409222583234164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7028173192793352d, y: 0.9970309982529294d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4685659983654932d, y: 0.15348747528556417d), new NpgsqlTypes.NpgsqlPoint(x: 0.36603165281713346d, y: 0.0780391844809778d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194753274522909d, y: 0.31947543003699075d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5263048842951943d, y: 0.7654110604694907d), new NpgsqlTypes.NpgsqlPoint(x: 0.07615863684199742d, y: 0.06941615076868268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9715950929563826d, y: 0.8195913038488098d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0992014302838754d, y: 0.475305327938772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5918529052937135d, y: 0.5135968689417746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002154948123307d, y: 0.8293710290180537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03491913951157455d, y: 0.9040319166126881d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145861774266833d, y: 0.6755983810152176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278977546161239d, y: 0.7105631646402691d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25497400500359513d, y: 0.7669011487083794d), new NpgsqlTypes.NpgsqlPoint(x: 0.991856306118096d, y: 0.13012508874667117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8529988831469355d, y: 0.6370167746934494d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.587389820564502d, y: 0.7530356531511926d), new NpgsqlTypes.NpgsqlPoint(x: 0.4125373407908678d, y: 0.4555961141114263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280954451851637d, y: 0.1653837620690949d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5494333018160958d, y: 0.7769095473942358d), new NpgsqlTypes.NpgsqlPoint(x: 0.732518823188872d, y: 0.49518204699231094d), new NpgsqlTypes.NpgsqlPoint(x: 0.905631738632524d, y: 0.15277293594675545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5766858196834378d, y: 0.034290200660498926d), new NpgsqlTypes.NpgsqlPoint(x: 0.2057183653377841d, y: 0.21825811786778637d), new NpgsqlTypes.NpgsqlPoint(x: 0.3419094370359176d, y: 0.32788512945862347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3181331569395599d, y: 0.976046373410879d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563313811452809d, y: 0.42423564545568815d), new NpgsqlTypes.NpgsqlPoint(x: 0.04526068877644607d, y: 0.030769273656477414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3261694349071561d, y: 0.7669145367128117d), new NpgsqlTypes.NpgsqlPoint(x: 0.4750148812848224d, y: 0.6898362856814119d), new NpgsqlTypes.NpgsqlPoint(x: 0.15909698792701077d, y: 0.2811572314706061d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15987143834183293d, y: 0.7866185176013011d), new NpgsqlTypes.NpgsqlPoint(x: 0.18009437488405655d, y: 0.4571086640663643d), new NpgsqlTypes.NpgsqlPoint(x: 0.33541447006007596d, y: 0.12141783683795138d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5157558643155434d, y: 0.4649801841663914d), new NpgsqlTypes.NpgsqlPoint(x: 0.1437883817587935d, y: 0.047914813004243495d), new NpgsqlTypes.NpgsqlPoint(x: 0.028784412952737815d, y: 0.8389203576376784d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9486610251549334d, y: 0.713997712131447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9177714272405009d, y: 0.07830401656394881d), new NpgsqlTypes.NpgsqlPoint(x: 0.16022569769173933d, y: 0.4201167184963106d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14697813864141396d, y: 0.9567068874095085d), new NpgsqlTypes.NpgsqlPoint(x: 0.24358248888043055d, y: 0.8105489594345231d), new NpgsqlTypes.NpgsqlPoint(x: 0.10838499550738467d, y: 0.43744537645640025d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9571522721908999d, y: 0.26908743789125444d), new NpgsqlTypes.NpgsqlPoint(x: 0.08960834463656042d, y: 0.11741070226841477d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116864576299429d, y: 0.4175438708729473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9738125699625659d, y: 0.16889540888469534d), new NpgsqlTypes.NpgsqlPoint(x: 0.04050567592990084d, y: 0.9038310393913043d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397188368756465d, y: 0.8353537615828057d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06765751843729617d, y: 0.035755392904530114d), new NpgsqlTypes.NpgsqlPoint(x: 0.47578324612673895d, y: 0.39789934441510455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4426757320319833d, y: 0.19055937079314644d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08879333790374655d, y: 0.29426851735291104d), new NpgsqlTypes.NpgsqlPoint(x: 0.4279709051123288d, y: 0.6552113672613092d), new NpgsqlTypes.NpgsqlPoint(x: 0.1011102435043919d, y: 0.8666521781808422d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7292791622548785d, y: 0.3708980602585329d), new NpgsqlTypes.NpgsqlPoint(x: 0.08564740662097947d, y: 0.4081821668261226d), new NpgsqlTypes.NpgsqlPoint(x: 0.5533759379754553d, y: 0.38422675467909584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38100162924466696d, y: 0.3252106067987852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3656570962648159d, y: 0.8038519782560538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026769596212517d, y: 0.9251304993155781d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5320683235556682d, y: 0.216154542519857d), new NpgsqlTypes.NpgsqlPoint(x: 0.3988815323378312d, y: 0.548531695370046d), new NpgsqlTypes.NpgsqlPoint(x: 0.29233182287553894d, y: 0.45963758191972703d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4820768220008228d, y: 0.4814908235191352d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275239311026829d, y: 0.266728476881539d), new NpgsqlTypes.NpgsqlPoint(x: 0.637656792235441d, y: 0.5270592861596523d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7038643005161772d, y: 0.7148258192276237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247075571272065d, y: 0.8872347919256169d), new NpgsqlTypes.NpgsqlPoint(x: 0.1833558093282931d, y: 0.6233359131686963d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8277006758577871d, y: 0.6567903679251242d), new NpgsqlTypes.NpgsqlPoint(x: 0.48913407485529814d, y: 0.6458320891795588d), new NpgsqlTypes.NpgsqlPoint(x: 0.30896060162741856d, y: 0.8745404637905156d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2965853050070528d, y: 0.44057018158885886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442057818819664d, y: 0.5181371922809362d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227611306692187d, y: 0.3770156373758691d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01789350173141835d, y: 0.11414390148167042d), new NpgsqlTypes.NpgsqlPoint(x: 0.8832324906273764d, y: 0.6409460728233018d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555007018386862d, y: 0.32818211116215235d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39287545816471725d, y: 0.47861074973556406d), new NpgsqlTypes.NpgsqlPoint(x: 0.48472993613649407d, y: 0.30540097608952055d), new NpgsqlTypes.NpgsqlPoint(x: 0.151272397012859d, y: 0.763843861901975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8503519403922464d, y: 0.7001585898913223d), new NpgsqlTypes.NpgsqlPoint(x: 0.20604572020542422d, y: 0.4382840846821988d), new NpgsqlTypes.NpgsqlPoint(x: 0.5959915427132275d, y: 0.10437918790611123d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5516769480209408d, y: 0.5213068017630968d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781462995198365d, y: 0.05348481960865992d), new NpgsqlTypes.NpgsqlPoint(x: 0.19017918466107842d, y: 0.6581510778400466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4659854683222886d, y: 0.8419206554256159d), new NpgsqlTypes.NpgsqlPoint(x: 0.4189680663531109d, y: 0.2854196021341059d), new NpgsqlTypes.NpgsqlPoint(x: 0.19768086869400292d, y: 0.05496925750087689d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590336555869758d, y: 0.6401763261145756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529352254161091d, y: 0.5785544976383025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400860970957368d, y: 0.7860880867382722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06631770960302208d, y: 0.9501204608667914d), new NpgsqlTypes.NpgsqlPoint(x: 0.2091689743436197d, y: 0.3750837626705411d), new NpgsqlTypes.NpgsqlPoint(x: 0.8615100539871032d, y: 0.7824713935752908d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4178443978155886d, y: 0.2826834974448177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638848124567813d, y: 0.2238502936055322d), new NpgsqlTypes.NpgsqlPoint(x: 0.22423654014686878d, y: 0.7408393674739031d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1760807819071324d, y: 0.3956787491547359d), new NpgsqlTypes.NpgsqlPoint(x: 0.08835197281196194d, y: 0.3867549115457868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061096061188202d, y: 0.8265729411180541d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8599026842944401d, y: 0.8052543980205474d), new NpgsqlTypes.NpgsqlPoint(x: 0.32452488470176133d, y: 0.6261507540376408d), new NpgsqlTypes.NpgsqlPoint(x: 0.32665188411135093d, y: 0.22508935973605648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.530492710063578d, y: 0.950489692934831d), new NpgsqlTypes.NpgsqlPoint(x: 0.976723993868882d, y: 0.4400209557806133d), new NpgsqlTypes.NpgsqlPoint(x: 0.48085128561719437d, y: 0.594582813552172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07599637601555975d, y: 0.9425244814980124d), new NpgsqlTypes.NpgsqlPoint(x: 0.045742386634788024d, y: 0.3007721477559625d), new NpgsqlTypes.NpgsqlPoint(x: 0.917286415732595d, y: 0.8038333840025718d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.843771159266593d, y: 0.6351374452620292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567418637018976d, y: 0.7866972566430109d), new NpgsqlTypes.NpgsqlPoint(x: 0.11418303544758213d, y: 0.9057834502694176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5815019121791227d, y: 0.5074407633042123d), new NpgsqlTypes.NpgsqlPoint(x: 0.943435057611781d, y: 0.26780820361878244d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005213952078472d, y: 0.10831266334674239d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06880218155007534d, y: 0.5000396210948101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183046963723375d, y: 0.8585862292592249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647314082906778d, y: 0.04345525475902223d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.876455802693256d, y: 0.8773091483941315d), new NpgsqlTypes.NpgsqlPoint(x: 0.94943982703445d, y: 0.4185396455940561d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806684983035476d, y: 0.15107925144134204d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09537318872027456d, y: 0.665356326993958d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823031997296592d, y: 0.4328016929481796d), new NpgsqlTypes.NpgsqlPoint(x: 0.2927153965029753d, y: 0.053581888554269264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29340304354408175d, y: 0.857111733955653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3862314006978854d, y: 0.9553155600056538d), new NpgsqlTypes.NpgsqlPoint(x: 0.44694990594453465d, y: 0.16277294575811008d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7470440273397989d, y: 0.501901688054847d), new NpgsqlTypes.NpgsqlPoint(x: 0.915445019505835d, y: 0.5727924087058796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4032931474972201d, y: 0.15020972099372054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3730669033941123d, y: 0.4617881711361619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217976153538648d, y: 0.2853907727046253d), new NpgsqlTypes.NpgsqlPoint(x: 0.10185448365065164d, y: 0.8110597837994847d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6782853141751937d, y: 0.00791318004438657d), new NpgsqlTypes.NpgsqlPoint(x: 0.30801660738102143d, y: 0.6737913448735158d), new NpgsqlTypes.NpgsqlPoint(x: 0.510743351251359d, y: 0.2695153914006061d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04141242354566077d, y: 0.43831043144859905d), new NpgsqlTypes.NpgsqlPoint(x: 0.2336205478739266d, y: 0.8754838354025378d), new NpgsqlTypes.NpgsqlPoint(x: 0.4523976491202333d, y: 0.9915651380360707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8235421529169049d, y: 0.018483902740001223d), new NpgsqlTypes.NpgsqlPoint(x: 0.28021516003673297d, y: 0.19001038017618554d), new NpgsqlTypes.NpgsqlPoint(x: 0.25692684795019294d, y: 0.14753770553527157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.915302707432073d, y: 0.7835604407658658d), new NpgsqlTypes.NpgsqlPoint(x: 0.399646837944035d, y: 0.15372384551690477d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603283072787688d, y: 0.053513834759061574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1602639178336026d, y: 0.20701399940123166d), new NpgsqlTypes.NpgsqlPoint(x: 0.36053857081737006d, y: 0.399498673363784d), new NpgsqlTypes.NpgsqlPoint(x: 0.2149465731084358d, y: 0.03716916909743628d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6184014874807199d, y: 0.3598499258950564d), new NpgsqlTypes.NpgsqlPoint(x: 0.651419563650864d, y: 0.5420930024342415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242430942643736d, y: 0.7465298855949367d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7643182072954965d, y: 0.39082093982474975d), new NpgsqlTypes.NpgsqlPoint(x: 0.3211316414924512d, y: 0.08592472838107867d), new NpgsqlTypes.NpgsqlPoint(x: 0.46881987634735334d, y: 0.12037736879998895d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19129114742072628d, y: 0.16505175959413942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571694064233699d, y: 0.12656435529279708d), new NpgsqlTypes.NpgsqlPoint(x: 0.9626457581135498d, y: 0.8670657571568474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4284583082573158d, y: 0.23384946419500474d), new NpgsqlTypes.NpgsqlPoint(x: 0.21608140693968514d, y: 0.831050906305465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2243218840450535d, y: 0.2524584665316363d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2348040205525449d, y: 0.0010600776499718467d), new NpgsqlTypes.NpgsqlPoint(x: 0.21211887066400248d, y: 0.510634148728835d), new NpgsqlTypes.NpgsqlPoint(x: 0.2965621735966051d, y: 0.043415566667074135d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9849330774032032d, y: 0.8867313670859784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6944811449978908d, y: 0.2484764487102964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747278266975297d, y: 0.10936711840812519d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2031679901178447d, y: 0.11769256801452077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9397378348159097d, y: 0.09585653862666565d), new NpgsqlTypes.NpgsqlPoint(x: 0.24891214337274448d, y: 0.011109735260549924d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13120219082213236d, y: 0.09328823755201288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6723030911996237d, y: 0.9499832382414249d), new NpgsqlTypes.NpgsqlPoint(x: 0.08198741193055814d, y: 0.5658325212319346d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021895725514234576d, y: 0.5966036557842771d), new NpgsqlTypes.NpgsqlPoint(x: 0.9476481695465963d, y: 0.4423052705885072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304535791581098d, y: 0.8174290515007165d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7208253972300634d, y: 0.24603035045371824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521850817449504d, y: 0.1723396146124745d), new NpgsqlTypes.NpgsqlPoint(x: 0.031288738771531266d, y: 0.938274790865144d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5605444852887241d, y: 0.0797091348296155d), new NpgsqlTypes.NpgsqlPoint(x: 0.1497967929548084d, y: 0.5250900261602236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831620172804847d, y: 0.3841772526191082d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10900213939328163d, y: 0.5988404280121281d), new NpgsqlTypes.NpgsqlPoint(x: 0.45492282610017465d, y: 0.5980580620083034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8841030187623132d, y: 0.5953881611692852d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9445193554506802d, y: 0.4837050218497868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4263969887605529d, y: 0.4170016409019818d), new NpgsqlTypes.NpgsqlPoint(x: 0.23464523119712344d, y: 0.8981287019223464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46649253071349206d, y: 0.833798050983631d), new NpgsqlTypes.NpgsqlPoint(x: 0.0010008911680022825d, y: 0.8015226976608005d), new NpgsqlTypes.NpgsqlPoint(x: 0.39235317126329816d, y: 0.7268419719801981d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7195515841537354d, y: 0.9136589987719599d), new NpgsqlTypes.NpgsqlPoint(x: 0.35042516366525744d, y: 0.5270907655881504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9460763547742099d, y: 0.0609423758533717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6591632437007385d, y: 0.14905309241801235d), new NpgsqlTypes.NpgsqlPoint(x: 0.0631520016873387d, y: 0.4640439017488448d), new NpgsqlTypes.NpgsqlPoint(x: 0.06318406867307491d, y: 0.3423188008166297d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8552855540358494d, y: 0.8471513698677582d), new NpgsqlTypes.NpgsqlPoint(x: 0.027112647027409564d, y: 0.36189914984380245d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063123950201583d, y: 0.5850932627665935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6470268441519723d, y: 0.051178909881181456d), new NpgsqlTypes.NpgsqlPoint(x: 0.17108021209101942d, y: 0.9558665161815781d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635649698431899d, y: 0.2818920639169177d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046818268121087914d, y: 0.791860742632189d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219634987876625d, y: 0.07905841189038187d), new NpgsqlTypes.NpgsqlPoint(x: 0.08078529217667263d, y: 0.21386442067880596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9070103313285264d, y: 0.9140852210868508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272435392415737d, y: 0.679312006757468d), new NpgsqlTypes.NpgsqlPoint(x: 0.1160040182356119d, y: 0.26557151323147377d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18374246353243007d, y: 0.6021655290224621d), new NpgsqlTypes.NpgsqlPoint(x: 0.1995061782700649d, y: 0.8311716906637583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802820964935506d, y: 0.3654171238354025d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43749880886195514d, y: 0.3605023282938794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540025884085497d, y: 0.215636767366558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758370049146375d, y: 0.5003382885160926d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6258236720739664d, y: 0.6798907919362455d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814102702648601d, y: 0.11380255062848377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454007094677941d, y: 0.8523027387748664d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4806756468418846d, y: 0.4547277806386354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5347294565109159d, y: 0.05072974987198531d), new NpgsqlTypes.NpgsqlPoint(x: 0.02419450728691408d, y: 0.045599507609419776d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9591570806060999d, y: 0.5134476163981672d), new NpgsqlTypes.NpgsqlPoint(x: 0.8070611010036891d, y: 0.9575588499225643d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386243383725428d, y: 0.2593861413286105d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.863355343504539d, y: 0.7931944617504217d), new NpgsqlTypes.NpgsqlPoint(x: 0.3124377965661692d, y: 0.9442757775140732d), new NpgsqlTypes.NpgsqlPoint(x: 0.07339906632453164d, y: 0.999040571085178d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8244432636983845d, y: 0.7786193417037228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976449227679971d, y: 0.754812053059135d), new NpgsqlTypes.NpgsqlPoint(x: 0.6761954503588942d, y: 0.1451134093805192d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5118307448241678d, y: 0.44188798389895123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7847397202859209d, y: 0.2263385016605699d), new NpgsqlTypes.NpgsqlPoint(x: 0.09671630002283982d, y: 0.12948872651313514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9476555115006948d, y: 0.37780705024377137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383191862152793d, y: 0.1432396089048521d), new NpgsqlTypes.NpgsqlPoint(x: 0.5513172110365822d, y: 0.9824499848305562d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8049830580727928d, y: 0.4959933066181482d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285679226226738d, y: 0.7380230439518275d), new NpgsqlTypes.NpgsqlPoint(x: 0.48734196830505316d, y: 0.7514744945322842d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8862526350876813d, y: 0.14712795066057827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5818869916552843d, y: 0.6581077972532452d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606709023919137d, y: 0.4284790665264042d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5964422237026621d, y: 0.9784212673981452d), new NpgsqlTypes.NpgsqlPoint(x: 0.03566806927311639d, y: 0.5442062952970075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9740035730774355d, y: 0.5174284123621308d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10412392742289d, y: 0.3951005393265169d), new NpgsqlTypes.NpgsqlPoint(x: 0.405508803832617d, y: 0.45452347897642986d), new NpgsqlTypes.NpgsqlPoint(x: 0.1647583529825951d, y: 0.17545726567921294d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.589487067202078d, y: 0.585442693113862d), new NpgsqlTypes.NpgsqlPoint(x: 0.9449866244028156d, y: 0.8965533143762653d), new NpgsqlTypes.NpgsqlPoint(x: 0.8786850885435079d, y: 0.16428140415291492d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.677098062734881d, y: 0.2213309999750137d), new NpgsqlTypes.NpgsqlPoint(x: 0.023599434900307248d, y: 0.2942573769000567d), new NpgsqlTypes.NpgsqlPoint(x: 0.3644284472073974d, y: 0.4697703874482032d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8004377667530012d, y: 0.3068331915103867d), new NpgsqlTypes.NpgsqlPoint(x: 0.01476534655229067d, y: 0.8983450927619167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7901057373357088d, y: 0.3736542489879834d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4577859540499015d, y: 0.7107966500501912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9387231734995002d, y: 0.3868687554578538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404332147035617d, y: 0.2147324625119239d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.843209760688029d, y: 0.9664809718197704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141031824049407d, y: 0.9524436940341217d), new NpgsqlTypes.NpgsqlPoint(x: 0.17876199924762048d, y: 0.6547502652679706d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7803935226004765d, y: 0.026454602223878854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256004175422259d, y: 0.6515632639521036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337277697158732d, y: 0.7288794180100121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8383570584970687d, y: 0.2638280813085617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558504895596939d, y: 0.34762017487514374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3289456789316063d, y: 0.9571478250044277d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24263602611277657d, y: 0.5577302850979493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6655889497423915d, y: 0.03844052790645058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004703095366208d, y: 0.6935023704991724d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05758308614152485d, y: 0.9215974303147673d), new NpgsqlTypes.NpgsqlPoint(x: 0.9872858372557156d, y: 0.41367244799956115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4490069483590906d, y: 0.3732616583544356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7460611354292244d, y: 0.18819162971167513d), new NpgsqlTypes.NpgsqlPoint(x: 0.9656848356010979d, y: 0.7320411110448151d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395985858172838d, y: 0.9087436965932085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5511341724379294d, y: 0.04229924035975208d), new NpgsqlTypes.NpgsqlPoint(x: 0.019746908086363035d, y: 0.859036452677254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8753792343749168d, y: 0.25581977593880845d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6330960193767959d, y: 0.2101295039847333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123734698787618d, y: 0.23697584000400784d), new NpgsqlTypes.NpgsqlPoint(x: 0.08955381252074823d, y: 0.2252150382068785d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005607075711230869d, y: 0.6727116149315551d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865759522503678d, y: 0.1447773289625386d), new NpgsqlTypes.NpgsqlPoint(x: 0.20863485568206697d, y: 0.9607983732555063d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.318261217636006d, y: 0.23770982763003934d), new NpgsqlTypes.NpgsqlPoint(x: 0.7115735485859342d, y: 0.6410616512270271d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428039507129985d, y: 0.25745195713725166d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43561386597893614d, y: 0.132638006816581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5460913370825095d, y: 0.839269322307697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577234817493173d, y: 0.6104843938963272d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024321845909949902d, y: 0.4569318476740988d), new NpgsqlTypes.NpgsqlPoint(x: 0.15749436029893704d, y: 0.8874145391654333d), new NpgsqlTypes.NpgsqlPoint(x: 0.20759909196017057d, y: 0.5624067565407797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6611256053827418d, y: 0.3009696408356639d), new NpgsqlTypes.NpgsqlPoint(x: 0.08864034838851675d, y: 0.46267552723746863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639208303070917d, y: 0.9930687943636404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8219588567539181d, y: 0.05089298545446996d), new NpgsqlTypes.NpgsqlPoint(x: 0.33619762546266063d, y: 0.41132547449152246d), new NpgsqlTypes.NpgsqlPoint(x: 0.21351023029583627d, y: 0.47182914220956584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7317439284603566d, y: 0.12149842691427859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7912145571010123d, y: 0.3400135884380522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085406950635471d, y: 0.40090888637074784d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1001746652520017d, y: 0.9723068820042937d), new NpgsqlTypes.NpgsqlPoint(x: 0.33276020736544965d, y: 0.003545346467418775d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642569681604252d, y: 0.2823211917335088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3835833768026913d, y: 0.7762281657689373d), new NpgsqlTypes.NpgsqlPoint(x: 0.41274991988001253d, y: 0.99831382736915d), new NpgsqlTypes.NpgsqlPoint(x: 0.40153172362959644d, y: 0.01664854548623662d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26215562937736725d, y: 0.17325283054433271d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989959642777414d, y: 0.3851926307394796d), new NpgsqlTypes.NpgsqlPoint(x: 0.046019729336548965d, y: 0.25241654156589566d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.97582252849502d, y: 0.9765253238756944d), new NpgsqlTypes.NpgsqlPoint(x: 0.2495065119241412d, y: 0.9391064472965416d), new NpgsqlTypes.NpgsqlPoint(x: 0.367792556128393d, y: 0.3150873326445097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46795261374561514d, y: 0.13538155724467837d), new NpgsqlTypes.NpgsqlPoint(x: 0.37913124594083514d, y: 0.6679736880830416d), new NpgsqlTypes.NpgsqlPoint(x: 0.43480636355712987d, y: 0.7034123049306816d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5055547006469823d, y: 0.6472588799633847d), new NpgsqlTypes.NpgsqlPoint(x: 0.3016943979738458d, y: 0.12810873953775004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776173493461475d, y: 0.40316616754493684d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22385803017299277d, y: 0.0033982378500179156d), new NpgsqlTypes.NpgsqlPoint(x: 0.293142659484528d, y: 0.7991811477464935d), new NpgsqlTypes.NpgsqlPoint(x: 0.37796043512819977d, y: 0.00348267343226516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0009068142129469159d, y: 0.19659025683628706d), new NpgsqlTypes.NpgsqlPoint(x: 0.31789771403477396d, y: 0.431387985185398d), new NpgsqlTypes.NpgsqlPoint(x: 0.42340060960056025d, y: 0.32859481793073675d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8645810301963605d, y: 0.8833197736105328d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929305424010614d, y: 0.6254669397307225d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265878515844062d, y: 0.5731966787237159d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3826921619054817d, y: 0.2687338394413984d), new NpgsqlTypes.NpgsqlPoint(x: 0.08833805402993311d, y: 0.3132378867322638d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307331535792992d, y: 0.7672706143432111d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9792249694924976d, y: 0.9886361532979054d), new NpgsqlTypes.NpgsqlPoint(x: 0.31991722608772566d, y: 0.2538870812333729d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657545021156954d, y: 0.6093252700162772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960123747016708d, y: 0.265300309564262d), new NpgsqlTypes.NpgsqlPoint(x: 0.029534411917643166d, y: 0.5727980646596182d), new NpgsqlTypes.NpgsqlPoint(x: 0.5042759277506144d, y: 0.8585100544823734d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2747978459774324d, y: 0.8301572542968624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6043366246830292d, y: 0.22987048142648314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495029196153569d, y: 0.20129258959640262d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0845830568672411d, y: 0.38699384151055094d), new NpgsqlTypes.NpgsqlPoint(x: 0.08221363724936714d, y: 0.7737736253590211d), new NpgsqlTypes.NpgsqlPoint(x: 0.9279896928345641d, y: 0.7946341129156124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44566387698440435d, y: 0.25321667487336674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861408358591346d, y: 0.4101756960476304d), new NpgsqlTypes.NpgsqlPoint(x: 0.7617206763224208d, y: 0.8847419093977245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1605900224593897d, y: 0.6778648939844409d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676391759144173d, y: 0.43938458247942225d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393801065163586d, y: 0.7208131570527668d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5526826522927195d, y: 0.6759502054993308d), new NpgsqlTypes.NpgsqlPoint(x: 0.45727439836567685d, y: 0.6067907654826451d), new NpgsqlTypes.NpgsqlPoint(x: 0.08254706460257988d, y: 0.31080431811291975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.742049801668711d, y: 0.17799526550884992d), new NpgsqlTypes.NpgsqlPoint(x: 0.3442146382366953d, y: 0.6784656576212029d), new NpgsqlTypes.NpgsqlPoint(x: 0.47816220636565443d, y: 0.4004224182230094d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2031712235285693d, y: 0.2504531698824417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113181585414082d, y: 0.5719812985830274d), new NpgsqlTypes.NpgsqlPoint(x: 0.786996590231636d, y: 0.5744743295278832d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19821148015698575d, y: 0.7716943788036545d), new NpgsqlTypes.NpgsqlPoint(x: 0.17743690597483763d, y: 0.34879320789264756d), new NpgsqlTypes.NpgsqlPoint(x: 0.4678303834576595d, y: 0.20435083843157598d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3689736576875612d, y: 0.7839322928233242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796566008478129d, y: 0.941863341955533d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272507577680561d, y: 0.026336072812082945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9960031116980422d, y: 0.8328146471824255d), new NpgsqlTypes.NpgsqlPoint(x: 0.40677680063067d, y: 0.6992838027820205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9670107136414419d, y: 0.0965715695057815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9007600616990618d, y: 0.4750988664803276d), new NpgsqlTypes.NpgsqlPoint(x: 0.2658478616137232d, y: 0.6932430537940514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4434575360079511d, y: 0.20354980603165207d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9628671348663621d, y: 0.37994157594835243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6950175177882004d, y: 0.3864553841257451d), new NpgsqlTypes.NpgsqlPoint(x: 0.44337353130430024d, y: 0.48729373227863193d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9905255820178361d, y: 0.7263438927372573d), new NpgsqlTypes.NpgsqlPoint(x: 0.07009252070699179d, y: 0.5779848147437506d), new NpgsqlTypes.NpgsqlPoint(x: 0.95566156118123d, y: 0.08554959300354292d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09331316557237102d, y: 0.3159243135926595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6122486129224592d, y: 0.031175144301134883d), new NpgsqlTypes.NpgsqlPoint(x: 0.05919240925725078d, y: 0.9740046787433199d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6664046391708086d, y: 0.2997346876995015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8163282620530489d, y: 0.14526466813664873d), new NpgsqlTypes.NpgsqlPoint(x: 0.7304025174695028d, y: 0.7811273824174565d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5320781453417747d, y: 0.20274863386221864d), new NpgsqlTypes.NpgsqlPoint(x: 0.14562306074772968d, y: 0.40410862871470354d), new NpgsqlTypes.NpgsqlPoint(x: 0.7311910252793528d, y: 0.6460202326370733d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36905484699439695d, y: 0.44516560887738854d), new NpgsqlTypes.NpgsqlPoint(x: 0.15438979551543852d, y: 0.6748142745647283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5018052762971831d, y: 0.4112288004210939d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03482929473115359d, y: 0.03975148175931753d), new NpgsqlTypes.NpgsqlPoint(x: 0.34359461035755656d, y: 0.04007363738194847d), new NpgsqlTypes.NpgsqlPoint(x: 0.703326392504084d, y: 0.35100075026593647d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21616009372372313d, y: 0.21835654778772962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539771232964832d, y: 0.707630718143489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5630315167954052d, y: 0.21465750980297416d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3764984224362017d, y: 0.7100024134147213d), new NpgsqlTypes.NpgsqlPoint(x: 0.11811095773730551d, y: 0.6733517614433571d), new NpgsqlTypes.NpgsqlPoint(x: 0.5588837444737939d, y: 0.254603621233527d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9447452089512318d, y: 0.34055707673888846d), new NpgsqlTypes.NpgsqlPoint(x: 0.6227041193772489d, y: 0.5622516672660284d), new NpgsqlTypes.NpgsqlPoint(x: 0.293537979661576d, y: 0.19216169586855647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07311442126962309d, y: 0.5237257182290768d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370993466222321d, y: 0.7239476295297738d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540219248989343d, y: 0.13198452895093238d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36787592815851666d, y: 0.5653421316807009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6289886488852205d, y: 0.965292443199228d), new NpgsqlTypes.NpgsqlPoint(x: 0.44040014953344164d, y: 0.31574134697382583d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9599828230050317d, y: 0.08384121900769848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2847782131015807d, y: 0.34255196050652503d), new NpgsqlTypes.NpgsqlPoint(x: 0.26997629876424545d, y: 0.7519739581861585d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44192517725838276d, y: 0.2850659753289555d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922127999817031d, y: 0.8875183576028769d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302933941027683d, y: 0.30687440067812455d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9795264637988029d, y: 0.36060048464947614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788337493051004d, y: 0.07693809425150189d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896246053350309d, y: 0.28290996201566554d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4466480538921279d, y: 0.2383890755222784d), new NpgsqlTypes.NpgsqlPoint(x: 0.1717660540910334d, y: 0.16904938330125407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980610184359721d, y: 0.8710633012144717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9815419739024311d, y: 0.22088235551683522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5642819889631555d, y: 0.8795862614927696d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826241986197404d, y: 0.3257863837230648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5451246842977899d, y: 0.04382874761104261d), new NpgsqlTypes.NpgsqlPoint(x: 0.11457897021051044d, y: 0.6578297002780884d), new NpgsqlTypes.NpgsqlPoint(x: 0.19566431783063087d, y: 0.012640885157195303d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9587715762517602d, y: 0.08529464596806613d), new NpgsqlTypes.NpgsqlPoint(x: 0.025019689914665855d, y: 0.6408128104479572d), new NpgsqlTypes.NpgsqlPoint(x: 0.44243826730501323d, y: 0.5762184360794582d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7465904112072869d, y: 0.03368558532743193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5079880382718645d, y: 0.6959956433430744d), new NpgsqlTypes.NpgsqlPoint(x: 0.3115169252436032d, y: 0.7908945461901382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3713610181376271d, y: 0.8221575322948584d), new NpgsqlTypes.NpgsqlPoint(x: 0.19004399101027913d, y: 0.1239885180761292d), new NpgsqlTypes.NpgsqlPoint(x: 0.37634783609683853d, y: 0.17185413677506922d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45860274628836073d, y: 0.5592325253059988d), new NpgsqlTypes.NpgsqlPoint(x: 0.037264436527032374d, y: 0.5749465691642031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9794100775695577d, y: 0.44926728838470686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8718928238300009d, y: 0.2405248156081684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848475935041099d, y: 0.124404545231245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757477662901754d, y: 0.8628925543328455d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7463049302017957d, y: 0.985499689408104d), new NpgsqlTypes.NpgsqlPoint(x: 0.39099707587520105d, y: 0.6245786608658622d), new NpgsqlTypes.NpgsqlPoint(x: 0.740237707940349d, y: 0.5545472448082069d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4201249986304756d, y: 0.17510066524381263d), new NpgsqlTypes.NpgsqlPoint(x: 0.23664194995025734d, y: 0.8644217576250985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5414501777131947d, y: 0.4396102458240869d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9377054229334696d, y: 0.7375198922614645d), new NpgsqlTypes.NpgsqlPoint(x: 0.17594206319343764d, y: 0.4972291613782869d), new NpgsqlTypes.NpgsqlPoint(x: 0.4965489783939676d, y: 0.8640559294204457d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22143405897111812d, y: 0.8003959319484323d), new NpgsqlTypes.NpgsqlPoint(x: 0.1739629269442119d, y: 0.9428799433272023d), new NpgsqlTypes.NpgsqlPoint(x: 0.030270385815288403d, y: 0.8344819378058481d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7146680048146439d, y: 0.372853000917182d), new NpgsqlTypes.NpgsqlPoint(x: 0.47504146598106d, y: 0.7671239404817831d), new NpgsqlTypes.NpgsqlPoint(x: 0.3850534823932541d, y: 0.46393853132175944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1516022455487419d, y: 0.14085939511683765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9900235382464369d, y: 0.22661349196247826d), new NpgsqlTypes.NpgsqlPoint(x: 0.35056595209064423d, y: 0.7367608531262717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7679287574111088d, y: 0.98579593375041d), new NpgsqlTypes.NpgsqlPoint(x: 0.8484221924988389d, y: 0.28050332969480085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8937526319536093d, y: 0.4693873767224952d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6939023486036987d, y: 0.41275930727957155d), new NpgsqlTypes.NpgsqlPoint(x: 0.13025112782327164d, y: 0.04958635536592815d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373196690036802d, y: 0.4343542759371495d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2060197214047731d, y: 0.35000576125548855d), new NpgsqlTypes.NpgsqlPoint(x: 0.21561577175501734d, y: 0.4227467074839957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653690191937413d, y: 0.598325704452471d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7547015131890323d, y: 0.7865819494539544d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666520625281554d, y: 0.8913005861023967d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613043250296d, y: 0.057430247571955695d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8218846750168172d, y: 0.7100909194561713d), new NpgsqlTypes.NpgsqlPoint(x: 0.4370761045453214d, y: 0.21540530206643937d), new NpgsqlTypes.NpgsqlPoint(x: 0.019920062622379664d, y: 0.07878550099656856d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00317442232793963d, y: 0.6753758452591734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817495956050508d, y: 0.33557325784317615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973899630088984d, y: 0.9648611702216762d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9980961188666736d, y: 0.2461455167254626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7928643153664754d, y: 0.8210819807954423d), new NpgsqlTypes.NpgsqlPoint(x: 0.2991842835841837d, y: 0.586412459139345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7203150137025174d, y: 0.8789908210827196d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038993794303177d, y: 0.9870859602006453d), new NpgsqlTypes.NpgsqlPoint(x: 0.9443329466685343d, y: 0.25050845868733485d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17848485919614587d, y: 0.3793975539776808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350592815497591d, y: 0.7552639473839741d), new NpgsqlTypes.NpgsqlPoint(x: 0.07600790992536854d, y: 0.06475611267700443d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9771618933941697d, y: 0.9278177027166747d), new NpgsqlTypes.NpgsqlPoint(x: 0.11455891082346104d, y: 0.814786322439745d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687539784721014d, y: 0.7831710338648783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08931290866149943d, y: 0.8024117206129576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4020742836280333d, y: 0.15679910401048047d), new NpgsqlTypes.NpgsqlPoint(x: 0.19677629940815555d, y: 0.8183175419357296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5332790071723827d, y: 0.6243737141097306d), new NpgsqlTypes.NpgsqlPoint(x: 0.2099674121168129d, y: 0.943691168221799d), new NpgsqlTypes.NpgsqlPoint(x: 0.765396688726351d, y: 0.4780431059116178d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9025557871741656d, y: 0.30822627875654895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363677164559222d, y: 0.8819312932239037d), new NpgsqlTypes.NpgsqlPoint(x: 0.025026163161443682d, y: 0.025447735736611632d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2423773796957588d, y: 0.5421459836875054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6913254158519935d, y: 0.293668407274595d), new NpgsqlTypes.NpgsqlPoint(x: 0.1333972112384355d, y: 0.3453829376460519d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5285669127279825d, y: 0.42221127652326895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493690794163085d, y: 0.45152838566479203d), new NpgsqlTypes.NpgsqlPoint(x: 0.05650953932919689d, y: 0.515898780471448d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5223089130563823d, y: 0.829857881679453d), new NpgsqlTypes.NpgsqlPoint(x: 0.7778512580811827d, y: 0.6541405618555918d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593764289186177d, y: 0.20887430529529782d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5962094975237316d, y: 0.2204676960915516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8318306181051832d, y: 0.317127151680606d), new NpgsqlTypes.NpgsqlPoint(x: 0.4626257783704052d, y: 0.991675354717875d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9703198359014865d, y: 0.5872835692435852d), new NpgsqlTypes.NpgsqlPoint(x: 0.878162394418281d, y: 0.1397301508686699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7718211221506197d, y: 0.11609295944377351d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03304064167890597d, y: 0.15805708166587007d), new NpgsqlTypes.NpgsqlPoint(x: 0.34405362869355527d, y: 0.625051198619904d), new NpgsqlTypes.NpgsqlPoint(x: 0.3009092119010959d, y: 0.8105219920866714d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.928797808531306d, y: 0.06594105195221678d), new NpgsqlTypes.NpgsqlPoint(x: 0.19153405877995422d, y: 0.3365980099027964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4163781832288912d, y: 0.028223216632044634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6402127213336686d, y: 0.5397833611732603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299124469919771d, y: 0.8626021444325213d), new NpgsqlTypes.NpgsqlPoint(x: 0.15492771645779801d, y: 0.1332163461644067d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5849555739967702d, y: 0.6123008464854253d), new NpgsqlTypes.NpgsqlPoint(x: 0.709404804000637d, y: 0.028580178096474396d), new NpgsqlTypes.NpgsqlPoint(x: 0.96790529114576d, y: 0.8692006959699389d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36817969324459743d, y: 0.07407169177290773d), new NpgsqlTypes.NpgsqlPoint(x: 0.4463340808810601d, y: 0.45279260188727966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4473121976126574d, y: 0.3493376322793855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34607471282489766d, y: 0.5858229851664397d), new NpgsqlTypes.NpgsqlPoint(x: 0.7718557505703825d, y: 0.7569751910498171d), new NpgsqlTypes.NpgsqlPoint(x: 0.35175130674933075d, y: 0.3947964717223441d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6228039540253839d, y: 0.6281926085977338d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789357063945172d, y: 0.3084615736646198d), new NpgsqlTypes.NpgsqlPoint(x: 0.7596282506812436d, y: 0.46976659102722484d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17006326012996975d, y: 0.9116156763469399d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218610420448334d, y: 0.36832877586847446d), new NpgsqlTypes.NpgsqlPoint(x: 0.40049496815617514d, y: 0.0027071828095662775d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.990825553728151d, y: 0.5505755992459526d), new NpgsqlTypes.NpgsqlPoint(x: 0.621481962426265d, y: 0.9032108016947226d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960915078486301d, y: 0.2638373622933182d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17127907942207055d, y: 0.4508338957496195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5444735446621417d, y: 0.6613776923370246d), new NpgsqlTypes.NpgsqlPoint(x: 0.20474267484567255d, y: 0.2737755918832655d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2832842911582161d, y: 0.9211959990249465d), new NpgsqlTypes.NpgsqlPoint(x: 0.6119738246241765d, y: 0.2740996395767097d), new NpgsqlTypes.NpgsqlPoint(x: 0.2006961255897559d, y: 0.2849492460442873d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7977443678842732d, y: 0.6273196353275893d), new NpgsqlTypes.NpgsqlPoint(x: 0.45068348908823375d, y: 0.09323189186242742d), new NpgsqlTypes.NpgsqlPoint(x: 0.541124211017676d, y: 0.5200189087211063d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6291627935569983d, y: 0.3097195999997284d), new NpgsqlTypes.NpgsqlPoint(x: 0.38355778471135793d, y: 0.17496085273054773d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092643352541977d, y: 0.34323648010851826d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09161599242756813d, y: 0.5813889362484445d), new NpgsqlTypes.NpgsqlPoint(x: 0.692493931912017d, y: 0.12282632071192301d), new NpgsqlTypes.NpgsqlPoint(x: 0.34505297125390444d, y: 0.40325364237141814d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35020748680557945d, y: 0.3974659952591747d), new NpgsqlTypes.NpgsqlPoint(x: 0.936904196941009d, y: 0.0008836810900498815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6854361475336707d, y: 0.5894552738427707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23961151520972512d, y: 0.8539608254696953d), new NpgsqlTypes.NpgsqlPoint(x: 0.49909491205302814d, y: 0.9675778051878312d), new NpgsqlTypes.NpgsqlPoint(x: 0.43081794561494313d, y: 0.6760197753990963d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08242496139336919d, y: 0.7812501198768297d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343838559763259d, y: 0.9404159237253332d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469336612669189d, y: 0.25857846263241724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5424487430006015d, y: 0.08338335431802879d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501099473572862d, y: 0.8947148983485457d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481072222575791d, y: 0.6238991008123268d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1081002245172552d, y: 0.9508659378438381d), new NpgsqlTypes.NpgsqlPoint(x: 0.18469865383984285d, y: 0.8857526583772821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311263706263332d, y: 0.8268211788119262d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5614142157552097d, y: 0.356763815625602d), new NpgsqlTypes.NpgsqlPoint(x: 0.934158808707507d, y: 0.20876908415097795d), new NpgsqlTypes.NpgsqlPoint(x: 0.3669356652052659d, y: 0.04634997320586265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0764888837236537d, y: 0.4305225488678951d), new NpgsqlTypes.NpgsqlPoint(x: 0.03978151852095768d, y: 0.3987033068316427d), new NpgsqlTypes.NpgsqlPoint(x: 0.2277346781627393d, y: 0.31116232079800143d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7427797836771416d, y: 0.736512322337749d), new NpgsqlTypes.NpgsqlPoint(x: 0.040746536090097485d, y: 0.550519951901339d), new NpgsqlTypes.NpgsqlPoint(x: 0.07008187399685073d, y: 0.7809427396181033d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.929016010916242d, y: 0.41451275236907315d), new NpgsqlTypes.NpgsqlPoint(x: 0.1592789482904201d, y: 0.9055068282294573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103879468005888d, y: 0.6492164419410568d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.174347809444652d, y: 0.8530794986624071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2941335980026285d, y: 0.7175422330494784d), new NpgsqlTypes.NpgsqlPoint(x: 0.2351408776117998d, y: 0.041850981330429304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5901915871881142d, y: 0.14267405727325944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6489662177540764d, y: 0.025772719332105454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8676233691522571d, y: 0.7853587526404958d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7904068630924785d, y: 0.9670179755860481d), new NpgsqlTypes.NpgsqlPoint(x: 0.35462093273652096d, y: 0.30075395223982593d), new NpgsqlTypes.NpgsqlPoint(x: 0.05485265951625873d, y: 0.9506621888555913d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2246830519557882d, y: 0.7965777108253252d), new NpgsqlTypes.NpgsqlPoint(x: 0.03603849384473601d, y: 0.4706515400858746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539563424291467d, y: 0.47376719416461033d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11497024465945693d, y: 0.8590010440279655d), new NpgsqlTypes.NpgsqlPoint(x: 0.40118228841545167d, y: 0.8684859690794603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8131246453829827d, y: 0.7716803063380261d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25596811151899257d, y: 0.9771839627584823d), new NpgsqlTypes.NpgsqlPoint(x: 0.2200620893628661d, y: 0.132222512253361d), new NpgsqlTypes.NpgsqlPoint(x: 0.7446707386740891d, y: 0.5044509552590869d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3092323437217591d, y: 0.13244824163919477d), new NpgsqlTypes.NpgsqlPoint(x: 0.6515206941385507d, y: 0.3304349883816954d), new NpgsqlTypes.NpgsqlPoint(x: 0.39287767923689754d, y: 0.06616198352586244d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03447801370291048d, y: 0.04710070788175491d), new NpgsqlTypes.NpgsqlPoint(x: 0.24915069393383615d, y: 0.3943060607030594d), new NpgsqlTypes.NpgsqlPoint(x: 0.297259118944877d, y: 0.9237649089987703d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6644956621937864d, y: 0.48368457620513483d), new NpgsqlTypes.NpgsqlPoint(x: 0.33937533309837276d, y: 0.27539911382515625d), new NpgsqlTypes.NpgsqlPoint(x: 0.29913981706706305d, y: 0.7782989967210269d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41978994127203795d, y: 0.5805363213888403d), new NpgsqlTypes.NpgsqlPoint(x: 0.054009082328495106d, y: 0.433228751049052d), new NpgsqlTypes.NpgsqlPoint(x: 0.3270294420293903d, y: 0.7918998894212097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.499746490991845d, y: 0.5768815116556303d), new NpgsqlTypes.NpgsqlPoint(x: 0.11611023637352502d, y: 0.4012823316196693d), new NpgsqlTypes.NpgsqlPoint(x: 0.24190070124945873d, y: 0.9805960723774448d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6638332191499996d, y: 0.8320655962546651d), new NpgsqlTypes.NpgsqlPoint(x: 0.1259173316231874d, y: 0.9899321760936883d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196939682721905d, y: 0.6766057255600618d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8170511412956286d, y: 0.3210640241206919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987550281503895d, y: 0.8111464629976601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4849884749516461d, y: 0.6971049143967597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6137219621152232d, y: 0.7406252321141863d), new NpgsqlTypes.NpgsqlPoint(x: 0.16878756593384192d, y: 0.05197808734337084d), new NpgsqlTypes.NpgsqlPoint(x: 0.2980576169390051d, y: 0.31040917654438527d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10929226238131895d, y: 0.6991319016667028d), new NpgsqlTypes.NpgsqlPoint(x: 0.08918435888648024d, y: 0.6972823550048992d), new NpgsqlTypes.NpgsqlPoint(x: 0.060338699973834675d, y: 0.8310058102615996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5323697834246255d, y: 0.49672454950737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5856004085022957d, y: 0.21892327501865727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150940541601233d, y: 0.8375151497588317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5448143503967094d, y: 0.5654431045376153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004276367735893d, y: 0.6232562325550017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6406599665010572d, y: 0.10983156701727204d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6467543475488285d, y: 0.6157108555244108d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023176000714033584d, y: 0.5834831785837394d), new NpgsqlTypes.NpgsqlPoint(x: 0.7301298759749186d, y: 0.08273902389718035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3495466661510308d, y: 0.6324502925449906d), new NpgsqlTypes.NpgsqlPoint(x: 0.45398875578814624d, y: 0.15105397656698438d), new NpgsqlTypes.NpgsqlPoint(x: 0.47339136108805846d, y: 0.7979198144671613d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7717083387646122d, y: 0.11172113891572677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6686316545575848d, y: 0.4564233491012616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161539604538265d, y: 0.4676544458525119d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7776731677275448d, y: 0.03749077471775353d), new NpgsqlTypes.NpgsqlPoint(x: 0.012200736908461352d, y: 0.1268602928261544d), new NpgsqlTypes.NpgsqlPoint(x: 0.4240925737331217d, y: 0.10331425424126184d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38407514340450766d, y: 0.9738582841773006d), new NpgsqlTypes.NpgsqlPoint(x: 0.101832511170317d, y: 0.3530446570193956d), new NpgsqlTypes.NpgsqlPoint(x: 0.3395786460999337d, y: 0.3440591841109041d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5918126955794155d, y: 0.43639530442601027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601891188212112d, y: 0.6819664625060777d), new NpgsqlTypes.NpgsqlPoint(x: 0.01827883957928067d, y: 0.037016479341619335d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8823753799229842d, y: 0.20868915940153854d), new NpgsqlTypes.NpgsqlPoint(x: 0.48309241513584955d, y: 0.7199883393065261d), new NpgsqlTypes.NpgsqlPoint(x: 0.027689647456384803d, y: 0.02934313041472636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8245865403238601d, y: 0.4994777778847148d), new NpgsqlTypes.NpgsqlPoint(x: 0.5015688879951515d, y: 0.09091337866669424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9691402893519289d, y: 0.4116391544851543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09488866081545433d, y: 0.9033547872529488d), new NpgsqlTypes.NpgsqlPoint(x: 0.2451652077579709d, y: 0.35229763288219784d), new NpgsqlTypes.NpgsqlPoint(x: 0.812267604127517d, y: 0.14224185662214006d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24783954111345063d, y: 0.24004315411011568d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345166011885918d, y: 0.6297002067922163d), new NpgsqlTypes.NpgsqlPoint(x: 0.14219378158488172d, y: 0.6242812797920371d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9364914879886436d, y: 0.6114393887786902d), new NpgsqlTypes.NpgsqlPoint(x: 0.07084145014792187d, y: 0.3767882313669586d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439016054033091d, y: 0.7333221751511664d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16629054887458394d, y: 0.4555751399994218d), new NpgsqlTypes.NpgsqlPoint(x: 0.45455509929272797d, y: 0.32010464564645447d), new NpgsqlTypes.NpgsqlPoint(x: 0.6409191628684275d, y: 0.2526821977689171d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9755282596980269d, y: 0.43552032901687576d), new NpgsqlTypes.NpgsqlPoint(x: 0.24494162823567867d, y: 0.41343769512713546d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369237682238753d, y: 0.1506753467634555d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6037543595423327d, y: 0.6220959564598033d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853812811909023d, y: 0.5555328937660572d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601908476369869d, y: 0.48074318331386157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24777980051207626d, y: 0.036602087578412656d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651142410693547d, y: 0.2128008436935135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7785641969555568d, y: 0.567036221736038d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13069904509528274d, y: 0.07903834503077822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510012782845812d, y: 0.3661542979804431d), new NpgsqlTypes.NpgsqlPoint(x: 0.3004160709147893d, y: 0.7831894594082618d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3860783878414591d, y: 0.8381567245098746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7017742179528711d, y: 0.9605133047263028d), new NpgsqlTypes.NpgsqlPoint(x: 0.7754493822231897d, y: 0.11373998996548218d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08611266831169295d, y: 0.9021170480440904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494471361437545d, y: 0.8113226400820652d), new NpgsqlTypes.NpgsqlPoint(x: 0.16252364933134877d, y: 0.28569202380554926d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8387496975069594d, y: 0.7473926350566489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5055830161224194d, y: 0.8942754306824617d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461360922984312d, y: 0.7880356126547747d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8780801173049219d, y: 0.6709981862252632d), new NpgsqlTypes.NpgsqlPoint(x: 0.32513580614807125d, y: 0.9302149934520437d), new NpgsqlTypes.NpgsqlPoint(x: 0.13065900080630588d, y: 0.7763792127959448d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24863147592425483d, y: 0.09021865526980899d), new NpgsqlTypes.NpgsqlPoint(x: 0.016362502829617376d, y: 0.9581608841424677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7214917631278389d, y: 0.2415272103687306d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1701335069556429d, y: 0.8952784154208495d), new NpgsqlTypes.NpgsqlPoint(x: 0.207833043250798d, y: 0.2320048346084066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6909865414697206d, y: 0.5597181386863918d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9071472156031841d, y: 0.5233206059926758d), new NpgsqlTypes.NpgsqlPoint(x: 0.1354266549002897d, y: 0.3355558993097536d), new NpgsqlTypes.NpgsqlPoint(x: 0.6991381822227788d, y: 0.7827875236976388d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9031069203964649d, y: 0.930866129875836d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126792704835336d, y: 0.5474247870931263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489853596387108d, y: 0.009631084488620267d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5616709456599218d, y: 0.14370570243290848d), new NpgsqlTypes.NpgsqlPoint(x: 0.14591032596086428d, y: 0.020831538052585863d), new NpgsqlTypes.NpgsqlPoint(x: 0.32983103510307077d, y: 0.4066242215630067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8576258046336441d, y: 0.8788535924146706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8950609858822511d, y: 0.702895498722979d), new NpgsqlTypes.NpgsqlPoint(x: 0.178445103197316d, y: 0.9798511619222245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13039923097680373d, y: 0.14752902936083068d), new NpgsqlTypes.NpgsqlPoint(x: 0.22400281770590635d, y: 0.5043424893673218d), new NpgsqlTypes.NpgsqlPoint(x: 0.3046881313799574d, y: 0.11066685758082251d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8412808969038508d, y: 0.19161586103129868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7992066956320062d, y: 0.5294790672821774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882463884589409d, y: 0.5236059807425938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41488202042797595d, y: 0.7308490640844177d), new NpgsqlTypes.NpgsqlPoint(x: 0.24114693947988275d, y: 0.9026452087578581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5258900086599421d, y: 0.5303866507415956d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8131647134167272d, y: 0.0045237655000435195d), new NpgsqlTypes.NpgsqlPoint(x: 0.12724175464681453d, y: 0.24363388053088642d), new NpgsqlTypes.NpgsqlPoint(x: 0.44058426551098273d, y: 0.6385722666064199d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.577942268878758d, y: 0.6326073562329232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9512855400686873d, y: 0.8512138178341631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455225837209095d, y: 0.7132132554852366d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8581081577153475d, y: 0.9176481262578818d), new NpgsqlTypes.NpgsqlPoint(x: 0.3163960326432702d, y: 0.7274610078022656d), new NpgsqlTypes.NpgsqlPoint(x: 0.7744548339000559d, y: 0.8238223720071994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27311152702527974d, y: 0.0398243301588338d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234219924270952d, y: 0.08223768046426239d), new NpgsqlTypes.NpgsqlPoint(x: 0.33429400667335263d, y: 0.2187767696035514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9114087114235948d, y: 0.710569733291112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7760278925935152d, y: 0.3386854507072732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281577648202573d, y: 0.1369232714281321d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9075542658180811d, y: 0.8892781178034184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7830378127374402d, y: 0.13749162312568985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549679426476046d, y: 0.012216131019075371d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.529993165031705d, y: 0.5976569467955709d), new NpgsqlTypes.NpgsqlPoint(x: 0.19228535176814399d, y: 0.7512219561274261d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531238371487048d, y: 0.9644186800936068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9227093898500958d, y: 0.24035523602467723d), new NpgsqlTypes.NpgsqlPoint(x: 0.16458868817980465d, y: 0.15035479646589456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495524785198372d, y: 0.041682532850354614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11002525357340598d, y: 0.6468504552345831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342855120548067d, y: 0.6236563345943101d), new NpgsqlTypes.NpgsqlPoint(x: 0.41673061393592115d, y: 0.6707897794149931d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2890251422067619d, y: 0.7187049679622732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8299959049442186d, y: 0.5643963531726106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5021621055059274d, y: 0.5376703615262397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9124079098454212d, y: 0.5821024518241682d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726007710687681d, y: 0.547953169889014d), new NpgsqlTypes.NpgsqlPoint(x: 0.5551701969658558d, y: 0.45239498972933545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34858179451043025d, y: 0.8366403316827064d), new NpgsqlTypes.NpgsqlPoint(x: 0.45384103501323003d, y: 0.5173095054492713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357525655218119d, y: 0.49729592806309453d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11773475448751325d, y: 0.18560629573835852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188023736835679d, y: 0.6648619942235906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7072812147949755d, y: 0.21561521024491714d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.992200468448941d, y: 0.23881391908742067d), new NpgsqlTypes.NpgsqlPoint(x: 0.47085768650801896d, y: 0.6146668307245807d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363507836636084d, y: 0.017890225167715323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7441510826793934d, y: 0.3955499180919826d), new NpgsqlTypes.NpgsqlPoint(x: 0.05905628285809028d, y: 0.9990106072521144d), new NpgsqlTypes.NpgsqlPoint(x: 0.35775249048509616d, y: 0.6456963794501082d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41905282829072d, y: 0.8855590616611867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8119151877536702d, y: 0.32494275346908075d), new NpgsqlTypes.NpgsqlPoint(x: 0.04969721300503971d, y: 0.15341827976563038d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2350410230909632d, y: 0.24286939018718545d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005273110137441d, y: 0.16252991831353492d), new NpgsqlTypes.NpgsqlPoint(x: 0.3698340402248127d, y: 0.056758736987864156d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 5.936807257356236E-05d, y: 0.6349511021343449d), new NpgsqlTypes.NpgsqlPoint(x: 0.030557727764632614d, y: 0.4004458948681531d), new NpgsqlTypes.NpgsqlPoint(x: 0.8365370656640722d, y: 0.3137533041975672d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4830657034079776d, y: 0.24180995704793729d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609238476555351d, y: 0.3183025497326146d), new NpgsqlTypes.NpgsqlPoint(x: 0.37139179275500633d, y: 0.6410334510347667d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06520111792549177d, y: 0.9890617012864047d), new NpgsqlTypes.NpgsqlPoint(x: 0.15712432076553795d, y: 0.8625060526457802d), new NpgsqlTypes.NpgsqlPoint(x: 0.2278448615320403d, y: 0.44605590310072973d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18593145602408812d, y: 0.21020169263812627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9546491480564797d, y: 0.6587925524701359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827089305121804d, y: 0.05485620417271253d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028856373120005663d, y: 0.5604466052571695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9066756365559699d, y: 0.8718547363834482d), new NpgsqlTypes.NpgsqlPoint(x: 0.658231501272683d, y: 0.461773278861746d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7897872525192658d, y: 0.7517956661294822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614574359270606d, y: 0.24876034802739733d), new NpgsqlTypes.NpgsqlPoint(x: 0.21632659529293197d, y: 0.3218312117142571d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2716523004716299d, y: 0.2042997337168363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9475123091757494d, y: 0.317446189701298d), new NpgsqlTypes.NpgsqlPoint(x: 0.4936306366633664d, y: 0.840319288349886d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8334974830194911d, y: 0.15929938612563666d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124068623575684d, y: 0.45606680832668733d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696763444044471d, y: 0.5472808997836243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050927029266063d, y: 0.9369112066501241d), new NpgsqlTypes.NpgsqlPoint(x: 0.827366833598848d, y: 0.2687878498859536d), new NpgsqlTypes.NpgsqlPoint(x: 0.1650861964358129d, y: 0.024930386988385123d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8239672235194054d, y: 0.9934414927355661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8516953295400854d, y: 0.7043896726977724d), new NpgsqlTypes.NpgsqlPoint(x: 0.7484669724135081d, y: 0.44358098610893104d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
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
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 63, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 19, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 114, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 150, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 152, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 98, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 56, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 116, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 44, 163))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[30],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[31],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[32],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

