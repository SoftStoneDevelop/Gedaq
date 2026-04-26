

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5178566034724457d, y: 0.9890908157907585d), new NpgsqlTypes.NpgsqlPoint(x: 0.24547655661379908d, y: 0.8319166908601228d), new NpgsqlTypes.NpgsqlPoint(x: 0.04896757187294776d, y: 0.011346589095718063d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24025010777618772d, y: 0.2395356753081046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429215331117991d, y: 0.7880788010124399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510170814620991d, y: 0.2615644267115076d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15071845536874395d, y: 0.03458748686299473d), new NpgsqlTypes.NpgsqlPoint(x: 0.32067352535394733d, y: 0.5529594173115239d), new NpgsqlTypes.NpgsqlPoint(x: 0.21254838831302958d, y: 0.39797328118276176d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2783658431956031d, y: 0.7797295667682349d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580942270734541d, y: 0.18584343024642036d), new NpgsqlTypes.NpgsqlPoint(x: 0.824540646313541d, y: 0.20596599538457083d)),
},
            new NpgsqlPathpath0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3327852214034034d, y: 0.5347312139313676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120691552258945d, y: 0.5294432543202526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314699560210477d, y: 0.15521093698220445d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09028584316597899d, y: 0.8526189083358974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545649371046951d, y: 0.36315502209821615d), new NpgsqlTypes.NpgsqlPoint(x: 0.11144976874775403d, y: 0.24809720621510523d)),
},
            new NpgsqlPathpath0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9278460925418128d, y: 0.135934611596514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852457757512887d, y: 0.3436962831917091d), new NpgsqlTypes.NpgsqlPoint(x: 0.1658033130949933d, y: 0.33503905879677043d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2866147738945638d, y: 0.23182520554464858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442800829040163d, y: 0.377345577011175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6787049961157855d, y: 0.6692593045212428d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8736236307106573d, y: 0.3782659201029942d), new NpgsqlTypes.NpgsqlPoint(x: 0.3844154457650125d, y: 0.43785780367198746d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273161704854888d, y: 0.7513270607909328d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7349398322730877d, y: 0.9395747164491621d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988314619785166d, y: 0.8720686348848449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712365734480034d, y: 0.9187491134191713d)),
},
            new NpgsqlPathpath0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.737892338639903d, y: 0.3668694128861295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797309500573081d, y: 0.9492097391218973d), new NpgsqlTypes.NpgsqlPoint(x: 0.07301024864596439d, y: 0.5717228047263629d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9385220413281843d, y: 0.6232265085521113d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129234403539985d, y: 0.6203404897095002d), new NpgsqlTypes.NpgsqlPoint(x: 0.23174995772661733d, y: 0.053267019291975415d)),
},
            new NpgsqlPathpath0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7581087721066982d, y: 0.8791347690747809d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910515126493366d, y: 0.6626698995617885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313130577260136d, y: 0.49874857500560754d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9095107601437861d, y: 0.4386847850097503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867631643295919d, y: 0.11676576284797846d), new NpgsqlTypes.NpgsqlPoint(x: 0.10791507330230143d, y: 0.9207910459104685d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3949085490223626d, y: 0.3378029381819132d), new NpgsqlTypes.NpgsqlPoint(x: 0.706481191941818d, y: 0.32818766011411293d), new NpgsqlTypes.NpgsqlPoint(x: 0.23866936523035576d, y: 0.7714320856247373d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10556151248245482d, y: 0.920819582152123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895756415155171d, y: 0.00861889282968853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8030376124883927d, y: 0.4538351437253043d)),
},
            new NpgsqlPathpath0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.697292122768739d, y: 0.47607065590134723d), new NpgsqlTypes.NpgsqlPoint(x: 0.08927168792320772d, y: 0.6200145328105995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435398552275946d, y: 0.9335519820322145d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993924124060259d, y: 0.34251430676123806d), new NpgsqlTypes.NpgsqlPoint(x: 0.32100533457967784d, y: 0.9278336100909453d), new NpgsqlTypes.NpgsqlPoint(x: 0.12742496282443339d, y: 0.9145249737814741d)),
},
            new NpgsqlPathpath0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3056874323061446d, y: 0.9281223344420012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8891712457489614d, y: 0.971134719586449d), new NpgsqlTypes.NpgsqlPoint(x: 0.758008284852643d, y: 0.32076426048747886d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.734139776880252d, y: 0.30551351171492347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8117862389184318d, y: 0.10848309149690982d), new NpgsqlTypes.NpgsqlPoint(x: 0.24894809041535404d, y: 0.4868673820219147d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8749777445188505d, y: 0.15129876471606285d), new NpgsqlTypes.NpgsqlPoint(x: 0.18442635289188147d, y: 0.14337187725074996d), new NpgsqlTypes.NpgsqlPoint(x: 0.055606150544516675d, y: 0.24901935118434815d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6094106705229743d, y: 0.18642454674622022d), new NpgsqlTypes.NpgsqlPoint(x: 0.12546826837783664d, y: 0.6071099537442332d), new NpgsqlTypes.NpgsqlPoint(x: 0.1568517690904344d, y: 0.8049680295448007d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7214134348357717d, y: 0.915763497289318d), new NpgsqlTypes.NpgsqlPoint(x: 0.08160860418587335d, y: 0.6048397331573425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9435844650993354d, y: 0.2067857863770085d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6575555272269487d, y: 0.17416333127817152d), new NpgsqlTypes.NpgsqlPoint(x: 0.14791874680884076d, y: 0.9912727459605403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3362557620415051d, y: 0.1094943334112346d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173367631489004d, y: 0.5165487999144958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375208820369664d, y: 0.3030085658258137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615977911282695d, y: 0.3145968279419973d)),
},
            new NpgsqlPathpath0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8488734533935199d, y: 0.0948057037226605d), new NpgsqlTypes.NpgsqlPoint(x: 0.22179563432090732d, y: 0.8475210096640665d), new NpgsqlTypes.NpgsqlPoint(x: 0.21411939725644946d, y: 0.631547716131771d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12046062490615794d, y: 0.375716705223616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104212369670716d, y: 0.9365310352753099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214752957690212d, y: 0.5262723920585365d)),
},
            new NpgsqlPathpath0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945973484285842d, y: 0.41021759275084857d), new NpgsqlTypes.NpgsqlPoint(x: 0.26528036284740897d, y: 0.0747215679941543d), new NpgsqlTypes.NpgsqlPoint(x: 0.47280273667116113d, y: 0.0707136187070293d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9949343054722434d, y: 0.2762506670406881d), new NpgsqlTypes.NpgsqlPoint(x: 0.4365011351571454d, y: 0.16094032013987425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823646134736285d, y: 0.9414765951450438d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05072163572391497d, y: 0.26000534141805176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174647680880047d, y: 0.240799904933942d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600262492293897d, y: 0.989078755199572d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3003496722114426d, y: 0.6004183313913214d), new NpgsqlTypes.NpgsqlPoint(x: 0.14086962502679057d, y: 0.33069066276883674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788235129316892d, y: 0.7463675573290458d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9512158523138073d, y: 0.03416071523013253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787697025841669d, y: 0.26810729352024487d), new NpgsqlTypes.NpgsqlPoint(x: 0.09622380553635501d, y: 0.7693402109075784d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29843979423370315d, y: 0.9466013809263254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264336117894955d, y: 0.6897974077005232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2132931210170118d, y: 0.05800376608406965d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9510378104078384d, y: 0.1642292335002199d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798079526843287d, y: 0.14347757632467972d), new NpgsqlTypes.NpgsqlPoint(x: 0.3869914376188168d, y: 0.3634317890234229d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3468056856434678d, y: 0.5778724050380439d), new NpgsqlTypes.NpgsqlPoint(x: 0.9097333653834665d, y: 0.0918415507899275d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200522807562972d, y: 0.7185723426355172d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3526949253223781d, y: 0.3508015790342335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7620199053797057d, y: 0.9724546159513722d), new NpgsqlTypes.NpgsqlPoint(x: 0.4388446666243516d, y: 0.542759593652918d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33376087589740233d, y: 0.33005124078337555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655128620916874d, y: 0.176945833780783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155611171400679d, y: 0.6519237584527295d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10060448214721363d, y: 0.5005349123333235d), new NpgsqlTypes.NpgsqlPoint(x: 0.960943705455037d, y: 0.5857707659498005d), new NpgsqlTypes.NpgsqlPoint(x: 0.2931681582157961d, y: 0.2717638397643679d)),
},
            new NpgsqlPathpath0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27928379693290295d, y: 0.07632575146961706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155907667985221d, y: 0.25903025587485584d), new NpgsqlTypes.NpgsqlPoint(x: 0.20717144643778185d, y: 0.43892091825903645d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08856240515961211d, y: 0.9441628613129962d), new NpgsqlTypes.NpgsqlPoint(x: 0.025580224511290384d, y: 0.24912559454842653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967742009286609d, y: 0.5429663465832524d)),
},
            new NpgsqlPathpath0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41974622545681317d, y: 0.1654300597251097d), new NpgsqlTypes.NpgsqlPoint(x: 0.40736951272659294d, y: 0.2919390102276471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807435999875072d, y: 0.28087071059964763d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.876288830555236d, y: 0.8334258517840212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126051385710112d, y: 0.5366905971500628d), new NpgsqlTypes.NpgsqlPoint(x: 0.4898780433495967d, y: 0.24251467016630013d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5507445759284733d, y: 0.7395911084074157d), new NpgsqlTypes.NpgsqlPoint(x: 0.4776379512736253d, y: 0.6870241167185124d), new NpgsqlTypes.NpgsqlPoint(x: 0.07227597974602995d, y: 0.1407543137221986d)),
},
            new NpgsqlPathpath0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5089688825857237d, y: 0.9291469544692426d), new NpgsqlTypes.NpgsqlPoint(x: 0.733799894262944d, y: 0.5876960971290345d), new NpgsqlTypes.NpgsqlPoint(x: 0.000883652125819756d, y: 0.21333566759838962d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9570214638337458d, y: 0.042383863219580875d), new NpgsqlTypes.NpgsqlPoint(x: 0.21969204189487257d, y: 0.0741580007199012d), new NpgsqlTypes.NpgsqlPoint(x: 0.40058174012198733d, y: 0.9143647198123122d)),
},
            new NpgsqlPathpath0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8806683284518004d, y: 0.4142337780554015d), new NpgsqlTypes.NpgsqlPoint(x: 0.0280059908290885d, y: 0.7302271448772465d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537477641032295d, y: 0.09438018238319712d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3784732203514254d, y: 0.46655907825898857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603326631852353d, y: 0.9434735932075994d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058439959651734d, y: 0.5077705095025387d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8993414657153231d, y: 0.06977979222751751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5656926315995339d, y: 0.06328142706692619d), new NpgsqlTypes.NpgsqlPoint(x: 0.4780942102922936d, y: 0.6767905049032198d)),
},
            new NpgsqlPathpath0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8306579822483513d, y: 0.9083125799675569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4170994638559504d, y: 0.22299847207159362d), new NpgsqlTypes.NpgsqlPoint(x: 0.1836312841715272d, y: 0.9020946114817401d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4379677247890055d, y: 0.22471923728687415d), new NpgsqlTypes.NpgsqlPoint(x: 0.023058968129876622d, y: 0.9330971424825106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631801047059811d, y: 0.5778346244183228d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3223485406605484d, y: 0.33952098004523545d), new NpgsqlTypes.NpgsqlPoint(x: 0.819437769690443d, y: 0.3596813232939542d), new NpgsqlTypes.NpgsqlPoint(x: 0.445319244476148d, y: 0.9043450085575712d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9988012351603277d, y: 0.4217760492620056d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423686830671979d, y: 0.953472817883485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7662164194844929d, y: 0.6814222914111998d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5597454583546585d, y: 0.7183714530813133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843850457756084d, y: 0.563981608179708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275931538857766d, y: 0.3706124065291446d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17722595597795265d, y: 0.003943034869036244d), new NpgsqlTypes.NpgsqlPoint(x: 0.47096654760383927d, y: 0.7548255475672506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178630742252184d, y: 0.14415624624836698d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5283394690317297d, y: 0.8500535103828243d), new NpgsqlTypes.NpgsqlPoint(x: 0.24673308437790387d, y: 0.9108308066229233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853145381338789d, y: 0.6345281494849675d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8657661963510609d, y: 0.3033705732911074d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635154466470809d, y: 0.26311947931302715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3010090629433112d, y: 0.16745349951803734d)),
},
            new NpgsqlPathpath0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5082792739991986d, y: 0.5403720373516425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2921132367796728d, y: 0.16692207980546703d), new NpgsqlTypes.NpgsqlPoint(x: 0.11469916157402404d, y: 0.856749130545725d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8714218797249335d, y: 0.36244246841226546d), new NpgsqlTypes.NpgsqlPoint(x: 0.10540474645432985d, y: 0.39301969400274217d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855197580714854d, y: 0.6528834561795892d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.854146624852061d, y: 0.8084304689685999d), new NpgsqlTypes.NpgsqlPoint(x: 0.15974942171917528d, y: 0.8777721382204018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529013077415955d, y: 0.8120634137292817d)),
},
            new NpgsqlPathpath0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7471593523351652d, y: 0.689215235589936d), new NpgsqlTypes.NpgsqlPoint(x: 0.04082315957874727d, y: 0.49062518135911026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995021941524486d, y: 0.7796639677894829d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8104029514472665d, y: 0.6969759636312538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408632079217833d, y: 0.19568229165320106d), new NpgsqlTypes.NpgsqlPoint(x: 0.4414044910555144d, y: 0.8583399637720655d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1651123435192997d, y: 0.5432170639787833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5717220344745465d, y: 0.45492839620994063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605210384059911d, y: 0.8929646073366293d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25503933583994987d, y: 0.04094805277720426d), new NpgsqlTypes.NpgsqlPoint(x: 0.10588184585135507d, y: 0.05395265908260105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5073819381039896d, y: 0.06317677872483662d)),
},
            new NpgsqlPathpath0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9353205170338442d, y: 0.7566331122956952d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038075740106203737d, y: 0.06942305061662302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003650560470791d, y: 0.5388879678461879d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17065279332381966d, y: 0.025926879713556894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547743950774469d, y: 0.71524346791437d), new NpgsqlTypes.NpgsqlPoint(x: 0.9942399373026922d, y: 0.6956981259037365d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20428489145678075d, y: 0.4794585752607209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5675327854262048d, y: 0.38210541291772215d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686584290624884d, y: 0.4640056593598525d)),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9385220413281843d, y: 0.6232265085521113d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129234403539985d, y: 0.6203404897095002d), new NpgsqlTypes.NpgsqlPoint(x: 0.23174995772661733d, y: 0.053267019291975415d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10556151248245482d, y: 0.920819582152123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895756415155171d, y: 0.00861889282968853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8030376124883927d, y: 0.4538351437253043d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993924124060259d, y: 0.34251430676123806d), new NpgsqlTypes.NpgsqlPoint(x: 0.32100533457967784d, y: 0.9278336100909453d), new NpgsqlTypes.NpgsqlPoint(x: 0.12742496282443339d, y: 0.9145249737814741d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173367631489004d, y: 0.5165487999144958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375208820369664d, y: 0.3030085658258137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615977911282695d, y: 0.3145968279419973d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12046062490615794d, y: 0.375716705223616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104212369670716d, y: 0.9365310352753099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214752957690212d, y: 0.5262723920585365d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPathpath0M.AssertModel(models[0],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelBatchAsync(connection, 47, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPathpath0M.AssertModel(models[0],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelBatch(connection, 32, 32))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPathpath0M.AssertModel(models[0],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5178566034724457d, y: 0.9890908157907585d), new NpgsqlTypes.NpgsqlPoint(x: 0.24547655661379908d, y: 0.8319166908601228d), new NpgsqlTypes.NpgsqlPoint(x: 0.04896757187294776d, y: 0.011346589095718063d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24025010777618772d, y: 0.2395356753081046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429215331117991d, y: 0.7880788010124399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510170814620991d, y: 0.2615644267115076d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15071845536874395d, y: 0.03458748686299473d), new NpgsqlTypes.NpgsqlPoint(x: 0.32067352535394733d, y: 0.5529594173115239d), new NpgsqlTypes.NpgsqlPoint(x: 0.21254838831302958d, y: 0.39797328118276176d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2783658431956031d, y: 0.7797295667682349d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580942270734541d, y: 0.18584343024642036d), new NpgsqlTypes.NpgsqlPoint(x: 0.824540646313541d, y: 0.20596599538457083d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3327852214034034d, y: 0.5347312139313676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120691552258945d, y: 0.5294432543202526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314699560210477d, y: 0.15521093698220445d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09028584316597899d, y: 0.8526189083358974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545649371046951d, y: 0.36315502209821615d), new NpgsqlTypes.NpgsqlPoint(x: 0.11144976874775403d, y: 0.24809720621510523d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9278460925418128d, y: 0.135934611596514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852457757512887d, y: 0.3436962831917091d), new NpgsqlTypes.NpgsqlPoint(x: 0.1658033130949933d, y: 0.33503905879677043d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2866147738945638d, y: 0.23182520554464858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442800829040163d, y: 0.377345577011175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6787049961157855d, y: 0.6692593045212428d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8736236307106573d, y: 0.3782659201029942d), new NpgsqlTypes.NpgsqlPoint(x: 0.3844154457650125d, y: 0.43785780367198746d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273161704854888d, y: 0.7513270607909328d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7349398322730877d, y: 0.9395747164491621d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988314619785166d, y: 0.8720686348848449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712365734480034d, y: 0.9187491134191713d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.737892338639903d, y: 0.3668694128861295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797309500573081d, y: 0.9492097391218973d), new NpgsqlTypes.NpgsqlPoint(x: 0.07301024864596439d, y: 0.5717228047263629d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9385220413281843d, y: 0.6232265085521113d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129234403539985d, y: 0.6203404897095002d), new NpgsqlTypes.NpgsqlPoint(x: 0.23174995772661733d, y: 0.053267019291975415d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7581087721066982d, y: 0.8791347690747809d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910515126493366d, y: 0.6626698995617885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313130577260136d, y: 0.49874857500560754d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9095107601437861d, y: 0.4386847850097503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867631643295919d, y: 0.11676576284797846d), new NpgsqlTypes.NpgsqlPoint(x: 0.10791507330230143d, y: 0.9207910459104685d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3949085490223626d, y: 0.3378029381819132d), new NpgsqlTypes.NpgsqlPoint(x: 0.706481191941818d, y: 0.32818766011411293d), new NpgsqlTypes.NpgsqlPoint(x: 0.23866936523035576d, y: 0.7714320856247373d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10556151248245482d, y: 0.920819582152123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895756415155171d, y: 0.00861889282968853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8030376124883927d, y: 0.4538351437253043d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.697292122768739d, y: 0.47607065590134723d), new NpgsqlTypes.NpgsqlPoint(x: 0.08927168792320772d, y: 0.6200145328105995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435398552275946d, y: 0.9335519820322145d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993924124060259d, y: 0.34251430676123806d), new NpgsqlTypes.NpgsqlPoint(x: 0.32100533457967784d, y: 0.9278336100909453d), new NpgsqlTypes.NpgsqlPoint(x: 0.12742496282443339d, y: 0.9145249737814741d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3056874323061446d, y: 0.9281223344420012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8891712457489614d, y: 0.971134719586449d), new NpgsqlTypes.NpgsqlPoint(x: 0.758008284852643d, y: 0.32076426048747886d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.734139776880252d, y: 0.30551351171492347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8117862389184318d, y: 0.10848309149690982d), new NpgsqlTypes.NpgsqlPoint(x: 0.24894809041535404d, y: 0.4868673820219147d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8749777445188505d, y: 0.15129876471606285d), new NpgsqlTypes.NpgsqlPoint(x: 0.18442635289188147d, y: 0.14337187725074996d), new NpgsqlTypes.NpgsqlPoint(x: 0.055606150544516675d, y: 0.24901935118434815d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6094106705229743d, y: 0.18642454674622022d), new NpgsqlTypes.NpgsqlPoint(x: 0.12546826837783664d, y: 0.6071099537442332d), new NpgsqlTypes.NpgsqlPoint(x: 0.1568517690904344d, y: 0.8049680295448007d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7214134348357717d, y: 0.915763497289318d), new NpgsqlTypes.NpgsqlPoint(x: 0.08160860418587335d, y: 0.6048397331573425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9435844650993354d, y: 0.2067857863770085d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6575555272269487d, y: 0.17416333127817152d), new NpgsqlTypes.NpgsqlPoint(x: 0.14791874680884076d, y: 0.9912727459605403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3362557620415051d, y: 0.1094943334112346d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173367631489004d, y: 0.5165487999144958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375208820369664d, y: 0.3030085658258137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615977911282695d, y: 0.3145968279419973d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8488734533935199d, y: 0.0948057037226605d), new NpgsqlTypes.NpgsqlPoint(x: 0.22179563432090732d, y: 0.8475210096640665d), new NpgsqlTypes.NpgsqlPoint(x: 0.21411939725644946d, y: 0.631547716131771d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12046062490615794d, y: 0.375716705223616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104212369670716d, y: 0.9365310352753099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214752957690212d, y: 0.5262723920585365d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945973484285842d, y: 0.41021759275084857d), new NpgsqlTypes.NpgsqlPoint(x: 0.26528036284740897d, y: 0.0747215679941543d), new NpgsqlTypes.NpgsqlPoint(x: 0.47280273667116113d, y: 0.0707136187070293d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9949343054722434d, y: 0.2762506670406881d), new NpgsqlTypes.NpgsqlPoint(x: 0.4365011351571454d, y: 0.16094032013987425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823646134736285d, y: 0.9414765951450438d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05072163572391497d, y: 0.26000534141805176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174647680880047d, y: 0.240799904933942d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600262492293897d, y: 0.989078755199572d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3003496722114426d, y: 0.6004183313913214d), new NpgsqlTypes.NpgsqlPoint(x: 0.14086962502679057d, y: 0.33069066276883674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788235129316892d, y: 0.7463675573290458d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9512158523138073d, y: 0.03416071523013253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787697025841669d, y: 0.26810729352024487d), new NpgsqlTypes.NpgsqlPoint(x: 0.09622380553635501d, y: 0.7693402109075784d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29843979423370315d, y: 0.9466013809263254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264336117894955d, y: 0.6897974077005232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2132931210170118d, y: 0.05800376608406965d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9510378104078384d, y: 0.1642292335002199d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798079526843287d, y: 0.14347757632467972d), new NpgsqlTypes.NpgsqlPoint(x: 0.3869914376188168d, y: 0.3634317890234229d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3468056856434678d, y: 0.5778724050380439d), new NpgsqlTypes.NpgsqlPoint(x: 0.9097333653834665d, y: 0.0918415507899275d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200522807562972d, y: 0.7185723426355172d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3526949253223781d, y: 0.3508015790342335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7620199053797057d, y: 0.9724546159513722d), new NpgsqlTypes.NpgsqlPoint(x: 0.4388446666243516d, y: 0.542759593652918d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33376087589740233d, y: 0.33005124078337555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655128620916874d, y: 0.176945833780783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155611171400679d, y: 0.6519237584527295d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10060448214721363d, y: 0.5005349123333235d), new NpgsqlTypes.NpgsqlPoint(x: 0.960943705455037d, y: 0.5857707659498005d), new NpgsqlTypes.NpgsqlPoint(x: 0.2931681582157961d, y: 0.2717638397643679d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27928379693290295d, y: 0.07632575146961706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155907667985221d, y: 0.25903025587485584d), new NpgsqlTypes.NpgsqlPoint(x: 0.20717144643778185d, y: 0.43892091825903645d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08856240515961211d, y: 0.9441628613129962d), new NpgsqlTypes.NpgsqlPoint(x: 0.025580224511290384d, y: 0.24912559454842653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967742009286609d, y: 0.5429663465832524d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41974622545681317d, y: 0.1654300597251097d), new NpgsqlTypes.NpgsqlPoint(x: 0.40736951272659294d, y: 0.2919390102276471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807435999875072d, y: 0.28087071059964763d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.876288830555236d, y: 0.8334258517840212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126051385710112d, y: 0.5366905971500628d), new NpgsqlTypes.NpgsqlPoint(x: 0.4898780433495967d, y: 0.24251467016630013d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5507445759284733d, y: 0.7395911084074157d), new NpgsqlTypes.NpgsqlPoint(x: 0.4776379512736253d, y: 0.6870241167185124d), new NpgsqlTypes.NpgsqlPoint(x: 0.07227597974602995d, y: 0.1407543137221986d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5089688825857237d, y: 0.9291469544692426d), new NpgsqlTypes.NpgsqlPoint(x: 0.733799894262944d, y: 0.5876960971290345d), new NpgsqlTypes.NpgsqlPoint(x: 0.000883652125819756d, y: 0.21333566759838962d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9570214638337458d, y: 0.042383863219580875d), new NpgsqlTypes.NpgsqlPoint(x: 0.21969204189487257d, y: 0.0741580007199012d), new NpgsqlTypes.NpgsqlPoint(x: 0.40058174012198733d, y: 0.9143647198123122d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8806683284518004d, y: 0.4142337780554015d), new NpgsqlTypes.NpgsqlPoint(x: 0.0280059908290885d, y: 0.7302271448772465d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537477641032295d, y: 0.09438018238319712d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3784732203514254d, y: 0.46655907825898857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603326631852353d, y: 0.9434735932075994d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058439959651734d, y: 0.5077705095025387d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8993414657153231d, y: 0.06977979222751751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5656926315995339d, y: 0.06328142706692619d), new NpgsqlTypes.NpgsqlPoint(x: 0.4780942102922936d, y: 0.6767905049032198d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8306579822483513d, y: 0.9083125799675569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4170994638559504d, y: 0.22299847207159362d), new NpgsqlTypes.NpgsqlPoint(x: 0.1836312841715272d, y: 0.9020946114817401d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4379677247890055d, y: 0.22471923728687415d), new NpgsqlTypes.NpgsqlPoint(x: 0.023058968129876622d, y: 0.9330971424825106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631801047059811d, y: 0.5778346244183228d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3223485406605484d, y: 0.33952098004523545d), new NpgsqlTypes.NpgsqlPoint(x: 0.819437769690443d, y: 0.3596813232939542d), new NpgsqlTypes.NpgsqlPoint(x: 0.445319244476148d, y: 0.9043450085575712d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9988012351603277d, y: 0.4217760492620056d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423686830671979d, y: 0.953472817883485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7662164194844929d, y: 0.6814222914111998d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5597454583546585d, y: 0.7183714530813133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843850457756084d, y: 0.563981608179708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275931538857766d, y: 0.3706124065291446d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17722595597795265d, y: 0.003943034869036244d), new NpgsqlTypes.NpgsqlPoint(x: 0.47096654760383927d, y: 0.7548255475672506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178630742252184d, y: 0.14415624624836698d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5283394690317297d, y: 0.8500535103828243d), new NpgsqlTypes.NpgsqlPoint(x: 0.24673308437790387d, y: 0.9108308066229233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853145381338789d, y: 0.6345281494849675d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8657661963510609d, y: 0.3033705732911074d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635154466470809d, y: 0.26311947931302715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3010090629433112d, y: 0.16745349951803734d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5082792739991986d, y: 0.5403720373516425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2921132367796728d, y: 0.16692207980546703d), new NpgsqlTypes.NpgsqlPoint(x: 0.11469916157402404d, y: 0.856749130545725d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8714218797249335d, y: 0.36244246841226546d), new NpgsqlTypes.NpgsqlPoint(x: 0.10540474645432985d, y: 0.39301969400274217d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855197580714854d, y: 0.6528834561795892d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.854146624852061d, y: 0.8084304689685999d), new NpgsqlTypes.NpgsqlPoint(x: 0.15974942171917528d, y: 0.8777721382204018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529013077415955d, y: 0.8120634137292817d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7471593523351652d, y: 0.689215235589936d), new NpgsqlTypes.NpgsqlPoint(x: 0.04082315957874727d, y: 0.49062518135911026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995021941524486d, y: 0.7796639677894829d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8104029514472665d, y: 0.6969759636312538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408632079217833d, y: 0.19568229165320106d), new NpgsqlTypes.NpgsqlPoint(x: 0.4414044910555144d, y: 0.8583399637720655d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1651123435192997d, y: 0.5432170639787833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5717220344745465d, y: 0.45492839620994063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605210384059911d, y: 0.8929646073366293d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25503933583994987d, y: 0.04094805277720426d), new NpgsqlTypes.NpgsqlPoint(x: 0.10588184585135507d, y: 0.05395265908260105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5073819381039896d, y: 0.06317677872483662d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9353205170338442d, y: 0.7566331122956952d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038075740106203737d, y: 0.06942305061662302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003650560470791d, y: 0.5388879678461879d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17065279332381966d, y: 0.025926879713556894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547743950774469d, y: 0.71524346791437d), new NpgsqlTypes.NpgsqlPoint(x: 0.9942399373026922d, y: 0.6956981259037365d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20428489145678075d, y: 0.4794585752607209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5675327854262048d, y: 0.38210541291772215d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686584290624884d, y: 0.4640056593598525d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5178566034724457d, y: 0.9890908157907585d), new NpgsqlTypes.NpgsqlPoint(x: 0.24547655661379908d, y: 0.8319166908601228d), new NpgsqlTypes.NpgsqlPoint(x: 0.04896757187294776d, y: 0.011346589095718063d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24025010777618772d, y: 0.2395356753081046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429215331117991d, y: 0.7880788010124399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510170814620991d, y: 0.2615644267115076d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15071845536874395d, y: 0.03458748686299473d), new NpgsqlTypes.NpgsqlPoint(x: 0.32067352535394733d, y: 0.5529594173115239d), new NpgsqlTypes.NpgsqlPoint(x: 0.21254838831302958d, y: 0.39797328118276176d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2783658431956031d, y: 0.7797295667682349d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580942270734541d, y: 0.18584343024642036d), new NpgsqlTypes.NpgsqlPoint(x: 0.824540646313541d, y: 0.20596599538457083d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3327852214034034d, y: 0.5347312139313676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120691552258945d, y: 0.5294432543202526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314699560210477d, y: 0.15521093698220445d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09028584316597899d, y: 0.8526189083358974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545649371046951d, y: 0.36315502209821615d), new NpgsqlTypes.NpgsqlPoint(x: 0.11144976874775403d, y: 0.24809720621510523d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9278460925418128d, y: 0.135934611596514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852457757512887d, y: 0.3436962831917091d), new NpgsqlTypes.NpgsqlPoint(x: 0.1658033130949933d, y: 0.33503905879677043d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2866147738945638d, y: 0.23182520554464858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442800829040163d, y: 0.377345577011175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6787049961157855d, y: 0.6692593045212428d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8736236307106573d, y: 0.3782659201029942d), new NpgsqlTypes.NpgsqlPoint(x: 0.3844154457650125d, y: 0.43785780367198746d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273161704854888d, y: 0.7513270607909328d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7349398322730877d, y: 0.9395747164491621d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988314619785166d, y: 0.8720686348848449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712365734480034d, y: 0.9187491134191713d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.737892338639903d, y: 0.3668694128861295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797309500573081d, y: 0.9492097391218973d), new NpgsqlTypes.NpgsqlPoint(x: 0.07301024864596439d, y: 0.5717228047263629d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9385220413281843d, y: 0.6232265085521113d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129234403539985d, y: 0.6203404897095002d), new NpgsqlTypes.NpgsqlPoint(x: 0.23174995772661733d, y: 0.053267019291975415d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7581087721066982d, y: 0.8791347690747809d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910515126493366d, y: 0.6626698995617885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313130577260136d, y: 0.49874857500560754d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9095107601437861d, y: 0.4386847850097503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867631643295919d, y: 0.11676576284797846d), new NpgsqlTypes.NpgsqlPoint(x: 0.10791507330230143d, y: 0.9207910459104685d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3949085490223626d, y: 0.3378029381819132d), new NpgsqlTypes.NpgsqlPoint(x: 0.706481191941818d, y: 0.32818766011411293d), new NpgsqlTypes.NpgsqlPoint(x: 0.23866936523035576d, y: 0.7714320856247373d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10556151248245482d, y: 0.920819582152123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895756415155171d, y: 0.00861889282968853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8030376124883927d, y: 0.4538351437253043d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.697292122768739d, y: 0.47607065590134723d), new NpgsqlTypes.NpgsqlPoint(x: 0.08927168792320772d, y: 0.6200145328105995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435398552275946d, y: 0.9335519820322145d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993924124060259d, y: 0.34251430676123806d), new NpgsqlTypes.NpgsqlPoint(x: 0.32100533457967784d, y: 0.9278336100909453d), new NpgsqlTypes.NpgsqlPoint(x: 0.12742496282443339d, y: 0.9145249737814741d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3056874323061446d, y: 0.9281223344420012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8891712457489614d, y: 0.971134719586449d), new NpgsqlTypes.NpgsqlPoint(x: 0.758008284852643d, y: 0.32076426048747886d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.734139776880252d, y: 0.30551351171492347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8117862389184318d, y: 0.10848309149690982d), new NpgsqlTypes.NpgsqlPoint(x: 0.24894809041535404d, y: 0.4868673820219147d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8749777445188505d, y: 0.15129876471606285d), new NpgsqlTypes.NpgsqlPoint(x: 0.18442635289188147d, y: 0.14337187725074996d), new NpgsqlTypes.NpgsqlPoint(x: 0.055606150544516675d, y: 0.24901935118434815d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6094106705229743d, y: 0.18642454674622022d), new NpgsqlTypes.NpgsqlPoint(x: 0.12546826837783664d, y: 0.6071099537442332d), new NpgsqlTypes.NpgsqlPoint(x: 0.1568517690904344d, y: 0.8049680295448007d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7214134348357717d, y: 0.915763497289318d), new NpgsqlTypes.NpgsqlPoint(x: 0.08160860418587335d, y: 0.6048397331573425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9435844650993354d, y: 0.2067857863770085d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6575555272269487d, y: 0.17416333127817152d), new NpgsqlTypes.NpgsqlPoint(x: 0.14791874680884076d, y: 0.9912727459605403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3362557620415051d, y: 0.1094943334112346d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173367631489004d, y: 0.5165487999144958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375208820369664d, y: 0.3030085658258137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615977911282695d, y: 0.3145968279419973d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8488734533935199d, y: 0.0948057037226605d), new NpgsqlTypes.NpgsqlPoint(x: 0.22179563432090732d, y: 0.8475210096640665d), new NpgsqlTypes.NpgsqlPoint(x: 0.21411939725644946d, y: 0.631547716131771d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12046062490615794d, y: 0.375716705223616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104212369670716d, y: 0.9365310352753099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214752957690212d, y: 0.5262723920585365d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945973484285842d, y: 0.41021759275084857d), new NpgsqlTypes.NpgsqlPoint(x: 0.26528036284740897d, y: 0.0747215679941543d), new NpgsqlTypes.NpgsqlPoint(x: 0.47280273667116113d, y: 0.0707136187070293d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9949343054722434d, y: 0.2762506670406881d), new NpgsqlTypes.NpgsqlPoint(x: 0.4365011351571454d, y: 0.16094032013987425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823646134736285d, y: 0.9414765951450438d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05072163572391497d, y: 0.26000534141805176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174647680880047d, y: 0.240799904933942d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600262492293897d, y: 0.989078755199572d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3003496722114426d, y: 0.6004183313913214d), new NpgsqlTypes.NpgsqlPoint(x: 0.14086962502679057d, y: 0.33069066276883674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788235129316892d, y: 0.7463675573290458d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9512158523138073d, y: 0.03416071523013253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787697025841669d, y: 0.26810729352024487d), new NpgsqlTypes.NpgsqlPoint(x: 0.09622380553635501d, y: 0.7693402109075784d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29843979423370315d, y: 0.9466013809263254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264336117894955d, y: 0.6897974077005232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2132931210170118d, y: 0.05800376608406965d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9510378104078384d, y: 0.1642292335002199d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798079526843287d, y: 0.14347757632467972d), new NpgsqlTypes.NpgsqlPoint(x: 0.3869914376188168d, y: 0.3634317890234229d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3468056856434678d, y: 0.5778724050380439d), new NpgsqlTypes.NpgsqlPoint(x: 0.9097333653834665d, y: 0.0918415507899275d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200522807562972d, y: 0.7185723426355172d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3526949253223781d, y: 0.3508015790342335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7620199053797057d, y: 0.9724546159513722d), new NpgsqlTypes.NpgsqlPoint(x: 0.4388446666243516d, y: 0.542759593652918d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33376087589740233d, y: 0.33005124078337555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655128620916874d, y: 0.176945833780783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155611171400679d, y: 0.6519237584527295d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10060448214721363d, y: 0.5005349123333235d), new NpgsqlTypes.NpgsqlPoint(x: 0.960943705455037d, y: 0.5857707659498005d), new NpgsqlTypes.NpgsqlPoint(x: 0.2931681582157961d, y: 0.2717638397643679d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27928379693290295d, y: 0.07632575146961706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155907667985221d, y: 0.25903025587485584d), new NpgsqlTypes.NpgsqlPoint(x: 0.20717144643778185d, y: 0.43892091825903645d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08856240515961211d, y: 0.9441628613129962d), new NpgsqlTypes.NpgsqlPoint(x: 0.025580224511290384d, y: 0.24912559454842653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967742009286609d, y: 0.5429663465832524d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41974622545681317d, y: 0.1654300597251097d), new NpgsqlTypes.NpgsqlPoint(x: 0.40736951272659294d, y: 0.2919390102276471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807435999875072d, y: 0.28087071059964763d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.876288830555236d, y: 0.8334258517840212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126051385710112d, y: 0.5366905971500628d), new NpgsqlTypes.NpgsqlPoint(x: 0.4898780433495967d, y: 0.24251467016630013d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5507445759284733d, y: 0.7395911084074157d), new NpgsqlTypes.NpgsqlPoint(x: 0.4776379512736253d, y: 0.6870241167185124d), new NpgsqlTypes.NpgsqlPoint(x: 0.07227597974602995d, y: 0.1407543137221986d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5089688825857237d, y: 0.9291469544692426d), new NpgsqlTypes.NpgsqlPoint(x: 0.733799894262944d, y: 0.5876960971290345d), new NpgsqlTypes.NpgsqlPoint(x: 0.000883652125819756d, y: 0.21333566759838962d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9570214638337458d, y: 0.042383863219580875d), new NpgsqlTypes.NpgsqlPoint(x: 0.21969204189487257d, y: 0.0741580007199012d), new NpgsqlTypes.NpgsqlPoint(x: 0.40058174012198733d, y: 0.9143647198123122d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8806683284518004d, y: 0.4142337780554015d), new NpgsqlTypes.NpgsqlPoint(x: 0.0280059908290885d, y: 0.7302271448772465d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537477641032295d, y: 0.09438018238319712d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3784732203514254d, y: 0.46655907825898857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603326631852353d, y: 0.9434735932075994d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058439959651734d, y: 0.5077705095025387d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8993414657153231d, y: 0.06977979222751751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5656926315995339d, y: 0.06328142706692619d), new NpgsqlTypes.NpgsqlPoint(x: 0.4780942102922936d, y: 0.6767905049032198d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8306579822483513d, y: 0.9083125799675569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4170994638559504d, y: 0.22299847207159362d), new NpgsqlTypes.NpgsqlPoint(x: 0.1836312841715272d, y: 0.9020946114817401d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4379677247890055d, y: 0.22471923728687415d), new NpgsqlTypes.NpgsqlPoint(x: 0.023058968129876622d, y: 0.9330971424825106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631801047059811d, y: 0.5778346244183228d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3223485406605484d, y: 0.33952098004523545d), new NpgsqlTypes.NpgsqlPoint(x: 0.819437769690443d, y: 0.3596813232939542d), new NpgsqlTypes.NpgsqlPoint(x: 0.445319244476148d, y: 0.9043450085575712d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9988012351603277d, y: 0.4217760492620056d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423686830671979d, y: 0.953472817883485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7662164194844929d, y: 0.6814222914111998d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5597454583546585d, y: 0.7183714530813133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843850457756084d, y: 0.563981608179708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275931538857766d, y: 0.3706124065291446d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17722595597795265d, y: 0.003943034869036244d), new NpgsqlTypes.NpgsqlPoint(x: 0.47096654760383927d, y: 0.7548255475672506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178630742252184d, y: 0.14415624624836698d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5283394690317297d, y: 0.8500535103828243d), new NpgsqlTypes.NpgsqlPoint(x: 0.24673308437790387d, y: 0.9108308066229233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853145381338789d, y: 0.6345281494849675d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8657661963510609d, y: 0.3033705732911074d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635154466470809d, y: 0.26311947931302715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3010090629433112d, y: 0.16745349951803734d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5082792739991986d, y: 0.5403720373516425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2921132367796728d, y: 0.16692207980546703d), new NpgsqlTypes.NpgsqlPoint(x: 0.11469916157402404d, y: 0.856749130545725d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8714218797249335d, y: 0.36244246841226546d), new NpgsqlTypes.NpgsqlPoint(x: 0.10540474645432985d, y: 0.39301969400274217d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855197580714854d, y: 0.6528834561795892d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.854146624852061d, y: 0.8084304689685999d), new NpgsqlTypes.NpgsqlPoint(x: 0.15974942171917528d, y: 0.8777721382204018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529013077415955d, y: 0.8120634137292817d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7471593523351652d, y: 0.689215235589936d), new NpgsqlTypes.NpgsqlPoint(x: 0.04082315957874727d, y: 0.49062518135911026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995021941524486d, y: 0.7796639677894829d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8104029514472665d, y: 0.6969759636312538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408632079217833d, y: 0.19568229165320106d), new NpgsqlTypes.NpgsqlPoint(x: 0.4414044910555144d, y: 0.8583399637720655d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1651123435192997d, y: 0.5432170639787833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5717220344745465d, y: 0.45492839620994063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605210384059911d, y: 0.8929646073366293d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25503933583994987d, y: 0.04094805277720426d), new NpgsqlTypes.NpgsqlPoint(x: 0.10588184585135507d, y: 0.05395265908260105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5073819381039896d, y: 0.06317677872483662d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9353205170338442d, y: 0.7566331122956952d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038075740106203737d, y: 0.06942305061662302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003650560470791d, y: 0.5388879678461879d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17065279332381966d, y: 0.025926879713556894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547743950774469d, y: 0.71524346791437d), new NpgsqlTypes.NpgsqlPoint(x: 0.9942399373026922d, y: 0.6956981259037365d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20428489145678075d, y: 0.4794585752607209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5675327854262048d, y: 0.38210541291772215d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686584290624884d, y: 0.4640056593598525d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

