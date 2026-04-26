

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5514957101719059d, y: 0.5589283901264703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8302050092773133d, y: 0.27337716934189904d), new NpgsqlTypes.NpgsqlPoint(x: 0.38261439592925073d, y: 0.44924074392642954d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14185634439180506d, y: 0.1238562410669325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676756890607551d, y: 0.37864357651880665d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502347811762035d, y: 0.19107095316119427d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9377384827433533d, y: 0.5324009696104125d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976400526635128d, y: 0.15916178435338668d), new NpgsqlTypes.NpgsqlPoint(x: 0.3306509025418791d, y: 0.946224804499552d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7541464011082541d, y: 0.6054697671593767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530990745956564d, y: 0.03340602674870308d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144450215321418d, y: 0.49466993104476165d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5687436432440137d, y: 0.8634788744779286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6091254838948453d, y: 0.24367658685863747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7630197419810231d, y: 0.3981593458128809d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.502197598213372d, y: 0.37885517395936674d), new NpgsqlTypes.NpgsqlPoint(x: 0.46573938029795725d, y: 0.8758700316405976d), new NpgsqlTypes.NpgsqlPoint(x: 0.685499674459574d, y: 0.8560363670396232d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7377347028704166d, y: 0.39288006063682257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637680049746219d, y: 0.3638227114190822d), new NpgsqlTypes.NpgsqlPoint(x: 0.959157300637775d, y: 0.9634898660090141d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25935479178885446d, y: 0.004840545088553028d), new NpgsqlTypes.NpgsqlPoint(x: 0.026860064003248252d, y: 0.8003725797452069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705800979911972d, y: 0.3171114889790544d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37654108734488834d, y: 0.40586054627320023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6230887847134076d, y: 0.8568648742791257d), new NpgsqlTypes.NpgsqlPoint(x: 0.3485363857436461d, y: 0.3382304836496477d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9329803130160527d, y: 0.6139820245973417d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271880084418774d, y: 0.09620714904606575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5895448077697639d, y: 0.9816424314394788d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8475747889841374d, y: 0.7098040526189822d), new NpgsqlTypes.NpgsqlPoint(x: 0.048421010333915326d, y: 0.013644835891071128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493725577680903d, y: 0.37023305032897347d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0357363537813451d, y: 0.14622445066800493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836748254369278d, y: 0.6337103611669751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7091635964939439d, y: 0.9672908291354155d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.403717936244126d, y: 0.778045457137456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176599711282881d, y: 0.4361458185888205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8389802314336025d, y: 0.06956286088982055d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46594521265247546d, y: 0.8625054901449327d), new NpgsqlTypes.NpgsqlPoint(x: 0.05046530291285767d, y: 0.6756705643519083d), new NpgsqlTypes.NpgsqlPoint(x: 0.37378336874613594d, y: 0.10299803658822604d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7039590479631503d, y: 0.987233620971242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027986597177915d, y: 0.26791517758608896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199084185620246d, y: 0.3717085574036223d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9425340904241131d, y: 0.11893192283459264d), new NpgsqlTypes.NpgsqlPoint(x: 0.41201820059005856d, y: 0.1911023191161918d), new NpgsqlTypes.NpgsqlPoint(x: 0.17383904378393766d, y: 0.05728138725985665d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6886622788118939d, y: 0.9377258706665983d), new NpgsqlTypes.NpgsqlPoint(x: 0.1789603267060016d, y: 0.694843884222284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750844849230235d, y: 0.13166640647791716d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.793865648464615d, y: 0.1376186450465564d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804606729330811d, y: 0.0984651967748914d), new NpgsqlTypes.NpgsqlPoint(x: 0.21856261091588558d, y: 0.39081009434290337d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43455530850010404d, y: 0.23688825879107778d), new NpgsqlTypes.NpgsqlPoint(x: 0.36764771413976793d, y: 0.06754552388635005d), new NpgsqlTypes.NpgsqlPoint(x: 0.1570512905567556d, y: 0.494829658531447d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3806659743010098d, y: 0.013499431054039612d), new NpgsqlTypes.NpgsqlPoint(x: 0.1559136524705269d, y: 0.09575735245512063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016083627315374d, y: 0.4590401764596269d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6869250135080678d, y: 0.43993990908438874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2860014247043319d, y: 0.8616681085479038d), new NpgsqlTypes.NpgsqlPoint(x: 0.17189741962603045d, y: 0.5726819099615421d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8532477924101293d, y: 0.5684028234848743d), new NpgsqlTypes.NpgsqlPoint(x: 0.3915951763731095d, y: 0.48920585961833085d), new NpgsqlTypes.NpgsqlPoint(x: 0.4913503532967719d, y: 0.42037016154267126d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.654230135955241d, y: 0.05302327673746532d), new NpgsqlTypes.NpgsqlPoint(x: 0.848048182801389d, y: 0.40787461531894587d), new NpgsqlTypes.NpgsqlPoint(x: 0.08418077000047997d, y: 0.23120751364051162d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6142821205390043d, y: 0.03269778094510334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9653474088893772d, y: 0.16252743780753132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6947460803023893d, y: 0.014092644275994659d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23367882870948165d, y: 0.9754214334382829d), new NpgsqlTypes.NpgsqlPoint(x: 0.8715679916217546d, y: 0.8406499109638849d), new NpgsqlTypes.NpgsqlPoint(x: 0.18724577238501217d, y: 0.39363580283877686d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.688356433016697d, y: 0.8280641922898387d), new NpgsqlTypes.NpgsqlPoint(x: 0.985203140006029d, y: 0.5559706826125228d), new NpgsqlTypes.NpgsqlPoint(x: 0.10670526882687847d, y: 0.970329159475659d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13251762195221206d, y: 0.8746405183229741d), new NpgsqlTypes.NpgsqlPoint(x: 0.9396092635419866d, y: 0.14788313573345924d), new NpgsqlTypes.NpgsqlPoint(x: 0.505593577025453d, y: 0.3278539847743215d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07329711680423134d, y: 0.7254737553183296d), new NpgsqlTypes.NpgsqlPoint(x: 0.616557888301858d, y: 0.38597966083483437d), new NpgsqlTypes.NpgsqlPoint(x: 0.24454602899005362d, y: 0.5139538409583966d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3794874571079785d, y: 0.9927850715511647d), new NpgsqlTypes.NpgsqlPoint(x: 0.20757360463948527d, y: 0.8328982752214671d), new NpgsqlTypes.NpgsqlPoint(x: 0.029102904592940626d, y: 0.7468323717986229d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02179210028507661d, y: 0.6203021075946291d), new NpgsqlTypes.NpgsqlPoint(x: 0.30187270849469616d, y: 0.13700911903260637d), new NpgsqlTypes.NpgsqlPoint(x: 0.3935997743382499d, y: 0.9074607203981642d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8519102239146721d, y: 0.04755028060196842d), new NpgsqlTypes.NpgsqlPoint(x: 0.44702818095049845d, y: 0.639774688253427d), new NpgsqlTypes.NpgsqlPoint(x: 0.575121319104557d, y: 0.5449696336364941d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7198914154232728d, y: 0.24743821937604926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6291684755362509d, y: 0.42672773699398303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512087374417299d, y: 0.9893006872415666d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6117714492605258d, y: 0.19606077049440418d), new NpgsqlTypes.NpgsqlPoint(x: 0.16770560016798752d, y: 0.0834022531475701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945244172764104d, y: 0.7451534445456167d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8267295074037199d, y: 0.1352469548544113d), new NpgsqlTypes.NpgsqlPoint(x: 0.427604361362681d, y: 0.6885384065587671d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087043712667836d, y: 0.7023736603224294d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6257086273883533d, y: 0.5684849035278493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1408214052877783d, y: 0.5573068511530544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200995163636335d, y: 0.5489059869071439d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.618406472268908d, y: 0.5641445255883627d), new NpgsqlTypes.NpgsqlPoint(x: 0.21313691516837074d, y: 0.5642274521823079d), new NpgsqlTypes.NpgsqlPoint(x: 0.27552907900557466d, y: 0.4155709407795979d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06751218012160165d, y: 0.16334042191200282d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886864742305115d, y: 0.00723697756065933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552349299695366d, y: 0.5145086812941644d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8461145481876473d, y: 0.723066930749995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404391777701378d, y: 0.858819247417645d), new NpgsqlTypes.NpgsqlPoint(x: 0.012435393412910445d, y: 0.7519095369786274d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015806557690143386d, y: 0.05018205482067928d), new NpgsqlTypes.NpgsqlPoint(x: 0.07994243233236553d, y: 0.25317654913844545d), new NpgsqlTypes.NpgsqlPoint(x: 0.850662633777117d, y: 0.042266297440207934d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6476458498455616d, y: 0.7110527180038024d), new NpgsqlTypes.NpgsqlPoint(x: 0.153586883747326d, y: 0.4450841891556607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442588407563558d, y: 0.904786574198741d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8007651190202638d, y: 0.06697504968919488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530423534950729d, y: 0.20495589408684933d), new NpgsqlTypes.NpgsqlPoint(x: 0.4314197589028511d, y: 0.4023845505818354d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5741901373521655d, y: 0.9855884172757988d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389698848450944d, y: 0.3997477229185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368260015688982d, y: 0.92546492897003d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4747278758813269d, y: 0.15732267246003973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848427365821663d, y: 0.9354267147884515d), new NpgsqlTypes.NpgsqlPoint(x: 0.601389325110592d, y: 0.5616146692923861d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23517266009284732d, y: 0.12059695436927009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6299362989790988d, y: 0.21440419887474604d), new NpgsqlTypes.NpgsqlPoint(x: 0.886952360342201d, y: 0.14751418943634886d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43995198019084203d, y: 0.9104630176884699d), new NpgsqlTypes.NpgsqlPoint(x: 0.17870417707639774d, y: 0.5042088193549271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015842203753216d, y: 0.01657058536262168d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8039999105664623d, y: 0.8744146001169794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899945506793099d, y: 0.7986216975860385d), new NpgsqlTypes.NpgsqlPoint(x: 0.28205442441265693d, y: 0.4045748052316849d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7306881067993177d, y: 0.8857346662143659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194118102093987d, y: 0.64322984864772d), new NpgsqlTypes.NpgsqlPoint(x: 0.1218979772988259d, y: 0.07944854340214902d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10409745979565643d, y: 0.38301246030012603d), new NpgsqlTypes.NpgsqlPoint(x: 0.21093342043374963d, y: 0.7938568974091599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810346362744673d, y: 0.3807943435098683d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10252980421640445d, y: 0.7935094071547312d), new NpgsqlTypes.NpgsqlPoint(x: 0.3454736745711723d, y: 0.7263008254928418d), new NpgsqlTypes.NpgsqlPoint(x: 0.33451469281431634d, y: 0.701493926348401d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9725821877463142d, y: 0.5645818107509031d), new NpgsqlTypes.NpgsqlPoint(x: 0.061758393786436105d, y: 0.8404043687442754d), new NpgsqlTypes.NpgsqlPoint(x: 0.932835907688725d, y: 0.5725495479094251d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1328642154177172d, y: 0.824839486231207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3051134637621854d, y: 0.8971365496577355d), new NpgsqlTypes.NpgsqlPoint(x: 0.20377510531733245d, y: 0.497167259630119d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.586838133831628d, y: 0.4188134210668283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932211673231192d, y: 0.42489669193316526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9113198727276198d, y: 0.7645724213510008d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43934567946023007d, y: 0.9375389817488204d), new NpgsqlTypes.NpgsqlPoint(x: 0.07660417708478384d, y: 0.6606954263188948d), new NpgsqlTypes.NpgsqlPoint(x: 0.498787918625779d, y: 0.15419926324476074d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19608316939582937d, y: 0.2966163053900206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225845872072606d, y: 0.8481233901332761d), new NpgsqlTypes.NpgsqlPoint(x: 0.33302821873067123d, y: 0.07821084646110654d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6001737615470322d, y: 0.25917245902362374d), new NpgsqlTypes.NpgsqlPoint(x: 0.4648052720626614d, y: 0.7930952449098025d), new NpgsqlTypes.NpgsqlPoint(x: 0.27127055227874375d, y: 0.5968408932448358d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3541164983795255d, y: 0.7512376282096972d), new NpgsqlTypes.NpgsqlPoint(x: 0.979699739975982d, y: 0.34536258171938117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9947679261106466d, y: 0.07807312641536679d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8098744724064529d, y: 0.2888544555433511d), new NpgsqlTypes.NpgsqlPoint(x: 0.18573184234376927d, y: 0.8231460352024285d), new NpgsqlTypes.NpgsqlPoint(x: 0.438589735003719d, y: 0.2194827317781063d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13782251535434653d, y: 0.41460750340157837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786953079445404d, y: 0.1120888072171693d), new NpgsqlTypes.NpgsqlPoint(x: 0.16953755694307537d, y: 0.2565802779020002d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8729539889569445d, y: 0.11327045596171403d), new NpgsqlTypes.NpgsqlPoint(x: 0.47272443399284436d, y: 0.046193043067417006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529231744913276d, y: 0.9911836189642688d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4141465989130517d, y: 0.27617801775592277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187988351801544d, y: 0.4066345048587824d), new NpgsqlTypes.NpgsqlPoint(x: 0.977983143948944d, y: 0.5127009865528194d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1805931401536348d, y: 0.1657685547667701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240732158859714d, y: 0.46487339102082126d), new NpgsqlTypes.NpgsqlPoint(x: 0.12707948136005653d, y: 0.31210339880992755d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9429501393963187d, y: 0.7972051267332732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4309393229764009d, y: 0.46223322222944907d), new NpgsqlTypes.NpgsqlPoint(x: 0.839069601545599d, y: 0.3719092767561756d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2543508837205467d, y: 0.9106788320041332d), new NpgsqlTypes.NpgsqlPoint(x: 0.2357692865650276d, y: 0.993462017738556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165850074858788d, y: 0.35210770900763677d)),
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.403717936244126d, y: 0.778045457137456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176599711282881d, y: 0.4361458185888205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8389802314336025d, y: 0.06956286088982055d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.793865648464615d, y: 0.1376186450465564d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804606729330811d, y: 0.0984651967748914d), new NpgsqlTypes.NpgsqlPoint(x: 0.21856261091588558d, y: 0.39081009434290337d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6869250135080678d, y: 0.43993990908438874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2860014247043319d, y: 0.8616681085479038d), new NpgsqlTypes.NpgsqlPoint(x: 0.17189741962603045d, y: 0.5726819099615421d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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

                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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

                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
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

                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 70, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 6, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelBatchAsync(connection, 12, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelBatch(connection, 108, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5514957101719059d, y: 0.5589283901264703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8302050092773133d, y: 0.27337716934189904d), new NpgsqlTypes.NpgsqlPoint(x: 0.38261439592925073d, y: 0.44924074392642954d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14185634439180506d, y: 0.1238562410669325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676756890607551d, y: 0.37864357651880665d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502347811762035d, y: 0.19107095316119427d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9377384827433533d, y: 0.5324009696104125d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976400526635128d, y: 0.15916178435338668d), new NpgsqlTypes.NpgsqlPoint(x: 0.3306509025418791d, y: 0.946224804499552d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7541464011082541d, y: 0.6054697671593767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530990745956564d, y: 0.03340602674870308d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144450215321418d, y: 0.49466993104476165d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5687436432440137d, y: 0.8634788744779286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6091254838948453d, y: 0.24367658685863747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7630197419810231d, y: 0.3981593458128809d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.502197598213372d, y: 0.37885517395936674d), new NpgsqlTypes.NpgsqlPoint(x: 0.46573938029795725d, y: 0.8758700316405976d), new NpgsqlTypes.NpgsqlPoint(x: 0.685499674459574d, y: 0.8560363670396232d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7377347028704166d, y: 0.39288006063682257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637680049746219d, y: 0.3638227114190822d), new NpgsqlTypes.NpgsqlPoint(x: 0.959157300637775d, y: 0.9634898660090141d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25935479178885446d, y: 0.004840545088553028d), new NpgsqlTypes.NpgsqlPoint(x: 0.026860064003248252d, y: 0.8003725797452069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705800979911972d, y: 0.3171114889790544d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37654108734488834d, y: 0.40586054627320023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6230887847134076d, y: 0.8568648742791257d), new NpgsqlTypes.NpgsqlPoint(x: 0.3485363857436461d, y: 0.3382304836496477d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9329803130160527d, y: 0.6139820245973417d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271880084418774d, y: 0.09620714904606575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5895448077697639d, y: 0.9816424314394788d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8475747889841374d, y: 0.7098040526189822d), new NpgsqlTypes.NpgsqlPoint(x: 0.048421010333915326d, y: 0.013644835891071128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493725577680903d, y: 0.37023305032897347d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0357363537813451d, y: 0.14622445066800493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836748254369278d, y: 0.6337103611669751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7091635964939439d, y: 0.9672908291354155d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.403717936244126d, y: 0.778045457137456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176599711282881d, y: 0.4361458185888205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8389802314336025d, y: 0.06956286088982055d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46594521265247546d, y: 0.8625054901449327d), new NpgsqlTypes.NpgsqlPoint(x: 0.05046530291285767d, y: 0.6756705643519083d), new NpgsqlTypes.NpgsqlPoint(x: 0.37378336874613594d, y: 0.10299803658822604d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7039590479631503d, y: 0.987233620971242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027986597177915d, y: 0.26791517758608896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199084185620246d, y: 0.3717085574036223d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9425340904241131d, y: 0.11893192283459264d), new NpgsqlTypes.NpgsqlPoint(x: 0.41201820059005856d, y: 0.1911023191161918d), new NpgsqlTypes.NpgsqlPoint(x: 0.17383904378393766d, y: 0.05728138725985665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6886622788118939d, y: 0.9377258706665983d), new NpgsqlTypes.NpgsqlPoint(x: 0.1789603267060016d, y: 0.694843884222284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750844849230235d, y: 0.13166640647791716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.793865648464615d, y: 0.1376186450465564d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804606729330811d, y: 0.0984651967748914d), new NpgsqlTypes.NpgsqlPoint(x: 0.21856261091588558d, y: 0.39081009434290337d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43455530850010404d, y: 0.23688825879107778d), new NpgsqlTypes.NpgsqlPoint(x: 0.36764771413976793d, y: 0.06754552388635005d), new NpgsqlTypes.NpgsqlPoint(x: 0.1570512905567556d, y: 0.494829658531447d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3806659743010098d, y: 0.013499431054039612d), new NpgsqlTypes.NpgsqlPoint(x: 0.1559136524705269d, y: 0.09575735245512063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016083627315374d, y: 0.4590401764596269d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6869250135080678d, y: 0.43993990908438874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2860014247043319d, y: 0.8616681085479038d), new NpgsqlTypes.NpgsqlPoint(x: 0.17189741962603045d, y: 0.5726819099615421d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8532477924101293d, y: 0.5684028234848743d), new NpgsqlTypes.NpgsqlPoint(x: 0.3915951763731095d, y: 0.48920585961833085d), new NpgsqlTypes.NpgsqlPoint(x: 0.4913503532967719d, y: 0.42037016154267126d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.654230135955241d, y: 0.05302327673746532d), new NpgsqlTypes.NpgsqlPoint(x: 0.848048182801389d, y: 0.40787461531894587d), new NpgsqlTypes.NpgsqlPoint(x: 0.08418077000047997d, y: 0.23120751364051162d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6142821205390043d, y: 0.03269778094510334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9653474088893772d, y: 0.16252743780753132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6947460803023893d, y: 0.014092644275994659d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23367882870948165d, y: 0.9754214334382829d), new NpgsqlTypes.NpgsqlPoint(x: 0.8715679916217546d, y: 0.8406499109638849d), new NpgsqlTypes.NpgsqlPoint(x: 0.18724577238501217d, y: 0.39363580283877686d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.688356433016697d, y: 0.8280641922898387d), new NpgsqlTypes.NpgsqlPoint(x: 0.985203140006029d, y: 0.5559706826125228d), new NpgsqlTypes.NpgsqlPoint(x: 0.10670526882687847d, y: 0.970329159475659d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13251762195221206d, y: 0.8746405183229741d), new NpgsqlTypes.NpgsqlPoint(x: 0.9396092635419866d, y: 0.14788313573345924d), new NpgsqlTypes.NpgsqlPoint(x: 0.505593577025453d, y: 0.3278539847743215d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07329711680423134d, y: 0.7254737553183296d), new NpgsqlTypes.NpgsqlPoint(x: 0.616557888301858d, y: 0.38597966083483437d), new NpgsqlTypes.NpgsqlPoint(x: 0.24454602899005362d, y: 0.5139538409583966d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3794874571079785d, y: 0.9927850715511647d), new NpgsqlTypes.NpgsqlPoint(x: 0.20757360463948527d, y: 0.8328982752214671d), new NpgsqlTypes.NpgsqlPoint(x: 0.029102904592940626d, y: 0.7468323717986229d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02179210028507661d, y: 0.6203021075946291d), new NpgsqlTypes.NpgsqlPoint(x: 0.30187270849469616d, y: 0.13700911903260637d), new NpgsqlTypes.NpgsqlPoint(x: 0.3935997743382499d, y: 0.9074607203981642d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8519102239146721d, y: 0.04755028060196842d), new NpgsqlTypes.NpgsqlPoint(x: 0.44702818095049845d, y: 0.639774688253427d), new NpgsqlTypes.NpgsqlPoint(x: 0.575121319104557d, y: 0.5449696336364941d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7198914154232728d, y: 0.24743821937604926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6291684755362509d, y: 0.42672773699398303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512087374417299d, y: 0.9893006872415666d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6117714492605258d, y: 0.19606077049440418d), new NpgsqlTypes.NpgsqlPoint(x: 0.16770560016798752d, y: 0.0834022531475701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945244172764104d, y: 0.7451534445456167d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8267295074037199d, y: 0.1352469548544113d), new NpgsqlTypes.NpgsqlPoint(x: 0.427604361362681d, y: 0.6885384065587671d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087043712667836d, y: 0.7023736603224294d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6257086273883533d, y: 0.5684849035278493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1408214052877783d, y: 0.5573068511530544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200995163636335d, y: 0.5489059869071439d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.618406472268908d, y: 0.5641445255883627d), new NpgsqlTypes.NpgsqlPoint(x: 0.21313691516837074d, y: 0.5642274521823079d), new NpgsqlTypes.NpgsqlPoint(x: 0.27552907900557466d, y: 0.4155709407795979d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06751218012160165d, y: 0.16334042191200282d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886864742305115d, y: 0.00723697756065933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552349299695366d, y: 0.5145086812941644d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8461145481876473d, y: 0.723066930749995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404391777701378d, y: 0.858819247417645d), new NpgsqlTypes.NpgsqlPoint(x: 0.012435393412910445d, y: 0.7519095369786274d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015806557690143386d, y: 0.05018205482067928d), new NpgsqlTypes.NpgsqlPoint(x: 0.07994243233236553d, y: 0.25317654913844545d), new NpgsqlTypes.NpgsqlPoint(x: 0.850662633777117d, y: 0.042266297440207934d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6476458498455616d, y: 0.7110527180038024d), new NpgsqlTypes.NpgsqlPoint(x: 0.153586883747326d, y: 0.4450841891556607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442588407563558d, y: 0.904786574198741d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8007651190202638d, y: 0.06697504968919488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530423534950729d, y: 0.20495589408684933d), new NpgsqlTypes.NpgsqlPoint(x: 0.4314197589028511d, y: 0.4023845505818354d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5741901373521655d, y: 0.9855884172757988d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389698848450944d, y: 0.3997477229185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368260015688982d, y: 0.92546492897003d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4747278758813269d, y: 0.15732267246003973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848427365821663d, y: 0.9354267147884515d), new NpgsqlTypes.NpgsqlPoint(x: 0.601389325110592d, y: 0.5616146692923861d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23517266009284732d, y: 0.12059695436927009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6299362989790988d, y: 0.21440419887474604d), new NpgsqlTypes.NpgsqlPoint(x: 0.886952360342201d, y: 0.14751418943634886d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43995198019084203d, y: 0.9104630176884699d), new NpgsqlTypes.NpgsqlPoint(x: 0.17870417707639774d, y: 0.5042088193549271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015842203753216d, y: 0.01657058536262168d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8039999105664623d, y: 0.8744146001169794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899945506793099d, y: 0.7986216975860385d), new NpgsqlTypes.NpgsqlPoint(x: 0.28205442441265693d, y: 0.4045748052316849d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7306881067993177d, y: 0.8857346662143659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194118102093987d, y: 0.64322984864772d), new NpgsqlTypes.NpgsqlPoint(x: 0.1218979772988259d, y: 0.07944854340214902d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10409745979565643d, y: 0.38301246030012603d), new NpgsqlTypes.NpgsqlPoint(x: 0.21093342043374963d, y: 0.7938568974091599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810346362744673d, y: 0.3807943435098683d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10252980421640445d, y: 0.7935094071547312d), new NpgsqlTypes.NpgsqlPoint(x: 0.3454736745711723d, y: 0.7263008254928418d), new NpgsqlTypes.NpgsqlPoint(x: 0.33451469281431634d, y: 0.701493926348401d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9725821877463142d, y: 0.5645818107509031d), new NpgsqlTypes.NpgsqlPoint(x: 0.061758393786436105d, y: 0.8404043687442754d), new NpgsqlTypes.NpgsqlPoint(x: 0.932835907688725d, y: 0.5725495479094251d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1328642154177172d, y: 0.824839486231207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3051134637621854d, y: 0.8971365496577355d), new NpgsqlTypes.NpgsqlPoint(x: 0.20377510531733245d, y: 0.497167259630119d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.586838133831628d, y: 0.4188134210668283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932211673231192d, y: 0.42489669193316526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9113198727276198d, y: 0.7645724213510008d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43934567946023007d, y: 0.9375389817488204d), new NpgsqlTypes.NpgsqlPoint(x: 0.07660417708478384d, y: 0.6606954263188948d), new NpgsqlTypes.NpgsqlPoint(x: 0.498787918625779d, y: 0.15419926324476074d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19608316939582937d, y: 0.2966163053900206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225845872072606d, y: 0.8481233901332761d), new NpgsqlTypes.NpgsqlPoint(x: 0.33302821873067123d, y: 0.07821084646110654d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6001737615470322d, y: 0.25917245902362374d), new NpgsqlTypes.NpgsqlPoint(x: 0.4648052720626614d, y: 0.7930952449098025d), new NpgsqlTypes.NpgsqlPoint(x: 0.27127055227874375d, y: 0.5968408932448358d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3541164983795255d, y: 0.7512376282096972d), new NpgsqlTypes.NpgsqlPoint(x: 0.979699739975982d, y: 0.34536258171938117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9947679261106466d, y: 0.07807312641536679d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8098744724064529d, y: 0.2888544555433511d), new NpgsqlTypes.NpgsqlPoint(x: 0.18573184234376927d, y: 0.8231460352024285d), new NpgsqlTypes.NpgsqlPoint(x: 0.438589735003719d, y: 0.2194827317781063d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13782251535434653d, y: 0.41460750340157837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786953079445404d, y: 0.1120888072171693d), new NpgsqlTypes.NpgsqlPoint(x: 0.16953755694307537d, y: 0.2565802779020002d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8729539889569445d, y: 0.11327045596171403d), new NpgsqlTypes.NpgsqlPoint(x: 0.47272443399284436d, y: 0.046193043067417006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529231744913276d, y: 0.9911836189642688d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4141465989130517d, y: 0.27617801775592277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187988351801544d, y: 0.4066345048587824d), new NpgsqlTypes.NpgsqlPoint(x: 0.977983143948944d, y: 0.5127009865528194d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1805931401536348d, y: 0.1657685547667701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240732158859714d, y: 0.46487339102082126d), new NpgsqlTypes.NpgsqlPoint(x: 0.12707948136005653d, y: 0.31210339880992755d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9429501393963187d, y: 0.7972051267332732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4309393229764009d, y: 0.46223322222944907d), new NpgsqlTypes.NpgsqlPoint(x: 0.839069601545599d, y: 0.3719092767561756d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2543508837205467d, y: 0.9106788320041332d), new NpgsqlTypes.NpgsqlPoint(x: 0.2357692865650276d, y: 0.993462017738556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165850074858788d, y: 0.35210770900763677d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5514957101719059d, y: 0.5589283901264703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8302050092773133d, y: 0.27337716934189904d), new NpgsqlTypes.NpgsqlPoint(x: 0.38261439592925073d, y: 0.44924074392642954d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14185634439180506d, y: 0.1238562410669325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676756890607551d, y: 0.37864357651880665d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502347811762035d, y: 0.19107095316119427d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9377384827433533d, y: 0.5324009696104125d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976400526635128d, y: 0.15916178435338668d), new NpgsqlTypes.NpgsqlPoint(x: 0.3306509025418791d, y: 0.946224804499552d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7541464011082541d, y: 0.6054697671593767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530990745956564d, y: 0.03340602674870308d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144450215321418d, y: 0.49466993104476165d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5687436432440137d, y: 0.8634788744779286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6091254838948453d, y: 0.24367658685863747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7630197419810231d, y: 0.3981593458128809d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.502197598213372d, y: 0.37885517395936674d), new NpgsqlTypes.NpgsqlPoint(x: 0.46573938029795725d, y: 0.8758700316405976d), new NpgsqlTypes.NpgsqlPoint(x: 0.685499674459574d, y: 0.8560363670396232d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7377347028704166d, y: 0.39288006063682257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637680049746219d, y: 0.3638227114190822d), new NpgsqlTypes.NpgsqlPoint(x: 0.959157300637775d, y: 0.9634898660090141d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25935479178885446d, y: 0.004840545088553028d), new NpgsqlTypes.NpgsqlPoint(x: 0.026860064003248252d, y: 0.8003725797452069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705800979911972d, y: 0.3171114889790544d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37654108734488834d, y: 0.40586054627320023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6230887847134076d, y: 0.8568648742791257d), new NpgsqlTypes.NpgsqlPoint(x: 0.3485363857436461d, y: 0.3382304836496477d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9329803130160527d, y: 0.6139820245973417d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271880084418774d, y: 0.09620714904606575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5895448077697639d, y: 0.9816424314394788d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8475747889841374d, y: 0.7098040526189822d), new NpgsqlTypes.NpgsqlPoint(x: 0.048421010333915326d, y: 0.013644835891071128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493725577680903d, y: 0.37023305032897347d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0357363537813451d, y: 0.14622445066800493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836748254369278d, y: 0.6337103611669751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7091635964939439d, y: 0.9672908291354155d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.403717936244126d, y: 0.778045457137456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176599711282881d, y: 0.4361458185888205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8389802314336025d, y: 0.06956286088982055d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46594521265247546d, y: 0.8625054901449327d), new NpgsqlTypes.NpgsqlPoint(x: 0.05046530291285767d, y: 0.6756705643519083d), new NpgsqlTypes.NpgsqlPoint(x: 0.37378336874613594d, y: 0.10299803658822604d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7039590479631503d, y: 0.987233620971242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027986597177915d, y: 0.26791517758608896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199084185620246d, y: 0.3717085574036223d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9425340904241131d, y: 0.11893192283459264d), new NpgsqlTypes.NpgsqlPoint(x: 0.41201820059005856d, y: 0.1911023191161918d), new NpgsqlTypes.NpgsqlPoint(x: 0.17383904378393766d, y: 0.05728138725985665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6886622788118939d, y: 0.9377258706665983d), new NpgsqlTypes.NpgsqlPoint(x: 0.1789603267060016d, y: 0.694843884222284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750844849230235d, y: 0.13166640647791716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.793865648464615d, y: 0.1376186450465564d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804606729330811d, y: 0.0984651967748914d), new NpgsqlTypes.NpgsqlPoint(x: 0.21856261091588558d, y: 0.39081009434290337d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43455530850010404d, y: 0.23688825879107778d), new NpgsqlTypes.NpgsqlPoint(x: 0.36764771413976793d, y: 0.06754552388635005d), new NpgsqlTypes.NpgsqlPoint(x: 0.1570512905567556d, y: 0.494829658531447d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3806659743010098d, y: 0.013499431054039612d), new NpgsqlTypes.NpgsqlPoint(x: 0.1559136524705269d, y: 0.09575735245512063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016083627315374d, y: 0.4590401764596269d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6869250135080678d, y: 0.43993990908438874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2860014247043319d, y: 0.8616681085479038d), new NpgsqlTypes.NpgsqlPoint(x: 0.17189741962603045d, y: 0.5726819099615421d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8532477924101293d, y: 0.5684028234848743d), new NpgsqlTypes.NpgsqlPoint(x: 0.3915951763731095d, y: 0.48920585961833085d), new NpgsqlTypes.NpgsqlPoint(x: 0.4913503532967719d, y: 0.42037016154267126d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.654230135955241d, y: 0.05302327673746532d), new NpgsqlTypes.NpgsqlPoint(x: 0.848048182801389d, y: 0.40787461531894587d), new NpgsqlTypes.NpgsqlPoint(x: 0.08418077000047997d, y: 0.23120751364051162d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6142821205390043d, y: 0.03269778094510334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9653474088893772d, y: 0.16252743780753132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6947460803023893d, y: 0.014092644275994659d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23367882870948165d, y: 0.9754214334382829d), new NpgsqlTypes.NpgsqlPoint(x: 0.8715679916217546d, y: 0.8406499109638849d), new NpgsqlTypes.NpgsqlPoint(x: 0.18724577238501217d, y: 0.39363580283877686d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.688356433016697d, y: 0.8280641922898387d), new NpgsqlTypes.NpgsqlPoint(x: 0.985203140006029d, y: 0.5559706826125228d), new NpgsqlTypes.NpgsqlPoint(x: 0.10670526882687847d, y: 0.970329159475659d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13251762195221206d, y: 0.8746405183229741d), new NpgsqlTypes.NpgsqlPoint(x: 0.9396092635419866d, y: 0.14788313573345924d), new NpgsqlTypes.NpgsqlPoint(x: 0.505593577025453d, y: 0.3278539847743215d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07329711680423134d, y: 0.7254737553183296d), new NpgsqlTypes.NpgsqlPoint(x: 0.616557888301858d, y: 0.38597966083483437d), new NpgsqlTypes.NpgsqlPoint(x: 0.24454602899005362d, y: 0.5139538409583966d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3794874571079785d, y: 0.9927850715511647d), new NpgsqlTypes.NpgsqlPoint(x: 0.20757360463948527d, y: 0.8328982752214671d), new NpgsqlTypes.NpgsqlPoint(x: 0.029102904592940626d, y: 0.7468323717986229d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02179210028507661d, y: 0.6203021075946291d), new NpgsqlTypes.NpgsqlPoint(x: 0.30187270849469616d, y: 0.13700911903260637d), new NpgsqlTypes.NpgsqlPoint(x: 0.3935997743382499d, y: 0.9074607203981642d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8519102239146721d, y: 0.04755028060196842d), new NpgsqlTypes.NpgsqlPoint(x: 0.44702818095049845d, y: 0.639774688253427d), new NpgsqlTypes.NpgsqlPoint(x: 0.575121319104557d, y: 0.5449696336364941d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7198914154232728d, y: 0.24743821937604926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6291684755362509d, y: 0.42672773699398303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512087374417299d, y: 0.9893006872415666d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6117714492605258d, y: 0.19606077049440418d), new NpgsqlTypes.NpgsqlPoint(x: 0.16770560016798752d, y: 0.0834022531475701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945244172764104d, y: 0.7451534445456167d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8267295074037199d, y: 0.1352469548544113d), new NpgsqlTypes.NpgsqlPoint(x: 0.427604361362681d, y: 0.6885384065587671d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087043712667836d, y: 0.7023736603224294d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6257086273883533d, y: 0.5684849035278493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1408214052877783d, y: 0.5573068511530544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200995163636335d, y: 0.5489059869071439d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.618406472268908d, y: 0.5641445255883627d), new NpgsqlTypes.NpgsqlPoint(x: 0.21313691516837074d, y: 0.5642274521823079d), new NpgsqlTypes.NpgsqlPoint(x: 0.27552907900557466d, y: 0.4155709407795979d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06751218012160165d, y: 0.16334042191200282d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886864742305115d, y: 0.00723697756065933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552349299695366d, y: 0.5145086812941644d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8461145481876473d, y: 0.723066930749995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404391777701378d, y: 0.858819247417645d), new NpgsqlTypes.NpgsqlPoint(x: 0.012435393412910445d, y: 0.7519095369786274d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015806557690143386d, y: 0.05018205482067928d), new NpgsqlTypes.NpgsqlPoint(x: 0.07994243233236553d, y: 0.25317654913844545d), new NpgsqlTypes.NpgsqlPoint(x: 0.850662633777117d, y: 0.042266297440207934d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6476458498455616d, y: 0.7110527180038024d), new NpgsqlTypes.NpgsqlPoint(x: 0.153586883747326d, y: 0.4450841891556607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442588407563558d, y: 0.904786574198741d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8007651190202638d, y: 0.06697504968919488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530423534950729d, y: 0.20495589408684933d), new NpgsqlTypes.NpgsqlPoint(x: 0.4314197589028511d, y: 0.4023845505818354d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5741901373521655d, y: 0.9855884172757988d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389698848450944d, y: 0.3997477229185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368260015688982d, y: 0.92546492897003d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4747278758813269d, y: 0.15732267246003973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848427365821663d, y: 0.9354267147884515d), new NpgsqlTypes.NpgsqlPoint(x: 0.601389325110592d, y: 0.5616146692923861d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23517266009284732d, y: 0.12059695436927009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6299362989790988d, y: 0.21440419887474604d), new NpgsqlTypes.NpgsqlPoint(x: 0.886952360342201d, y: 0.14751418943634886d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43995198019084203d, y: 0.9104630176884699d), new NpgsqlTypes.NpgsqlPoint(x: 0.17870417707639774d, y: 0.5042088193549271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015842203753216d, y: 0.01657058536262168d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8039999105664623d, y: 0.8744146001169794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899945506793099d, y: 0.7986216975860385d), new NpgsqlTypes.NpgsqlPoint(x: 0.28205442441265693d, y: 0.4045748052316849d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7306881067993177d, y: 0.8857346662143659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194118102093987d, y: 0.64322984864772d), new NpgsqlTypes.NpgsqlPoint(x: 0.1218979772988259d, y: 0.07944854340214902d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10409745979565643d, y: 0.38301246030012603d), new NpgsqlTypes.NpgsqlPoint(x: 0.21093342043374963d, y: 0.7938568974091599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810346362744673d, y: 0.3807943435098683d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10252980421640445d, y: 0.7935094071547312d), new NpgsqlTypes.NpgsqlPoint(x: 0.3454736745711723d, y: 0.7263008254928418d), new NpgsqlTypes.NpgsqlPoint(x: 0.33451469281431634d, y: 0.701493926348401d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9725821877463142d, y: 0.5645818107509031d), new NpgsqlTypes.NpgsqlPoint(x: 0.061758393786436105d, y: 0.8404043687442754d), new NpgsqlTypes.NpgsqlPoint(x: 0.932835907688725d, y: 0.5725495479094251d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1328642154177172d, y: 0.824839486231207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3051134637621854d, y: 0.8971365496577355d), new NpgsqlTypes.NpgsqlPoint(x: 0.20377510531733245d, y: 0.497167259630119d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.586838133831628d, y: 0.4188134210668283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932211673231192d, y: 0.42489669193316526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9113198727276198d, y: 0.7645724213510008d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43934567946023007d, y: 0.9375389817488204d), new NpgsqlTypes.NpgsqlPoint(x: 0.07660417708478384d, y: 0.6606954263188948d), new NpgsqlTypes.NpgsqlPoint(x: 0.498787918625779d, y: 0.15419926324476074d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19608316939582937d, y: 0.2966163053900206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225845872072606d, y: 0.8481233901332761d), new NpgsqlTypes.NpgsqlPoint(x: 0.33302821873067123d, y: 0.07821084646110654d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6001737615470322d, y: 0.25917245902362374d), new NpgsqlTypes.NpgsqlPoint(x: 0.4648052720626614d, y: 0.7930952449098025d), new NpgsqlTypes.NpgsqlPoint(x: 0.27127055227874375d, y: 0.5968408932448358d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3541164983795255d, y: 0.7512376282096972d), new NpgsqlTypes.NpgsqlPoint(x: 0.979699739975982d, y: 0.34536258171938117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9947679261106466d, y: 0.07807312641536679d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8098744724064529d, y: 0.2888544555433511d), new NpgsqlTypes.NpgsqlPoint(x: 0.18573184234376927d, y: 0.8231460352024285d), new NpgsqlTypes.NpgsqlPoint(x: 0.438589735003719d, y: 0.2194827317781063d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13782251535434653d, y: 0.41460750340157837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786953079445404d, y: 0.1120888072171693d), new NpgsqlTypes.NpgsqlPoint(x: 0.16953755694307537d, y: 0.2565802779020002d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8729539889569445d, y: 0.11327045596171403d), new NpgsqlTypes.NpgsqlPoint(x: 0.47272443399284436d, y: 0.046193043067417006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529231744913276d, y: 0.9911836189642688d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4141465989130517d, y: 0.27617801775592277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187988351801544d, y: 0.4066345048587824d), new NpgsqlTypes.NpgsqlPoint(x: 0.977983143948944d, y: 0.5127009865528194d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1805931401536348d, y: 0.1657685547667701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240732158859714d, y: 0.46487339102082126d), new NpgsqlTypes.NpgsqlPoint(x: 0.12707948136005653d, y: 0.31210339880992755d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9429501393963187d, y: 0.7972051267332732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4309393229764009d, y: 0.46223322222944907d), new NpgsqlTypes.NpgsqlPoint(x: 0.839069601545599d, y: 0.3719092767561756d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2543508837205467d, y: 0.9106788320041332d), new NpgsqlTypes.NpgsqlPoint(x: 0.2357692865650276d, y: 0.993462017738556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165850074858788d, y: 0.35210770900763677d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0M>(15);

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
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

