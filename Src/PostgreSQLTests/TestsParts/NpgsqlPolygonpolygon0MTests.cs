

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
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0507727226191752d, y: 0.12218723484290883d), new NpgsqlTypes.NpgsqlPoint(x: 0.3825358466115971d, y: 0.6944234496510914d), new NpgsqlTypes.NpgsqlPoint(x: 0.41743284174529705d, y: 0.3934445744612832d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6864665640768625d, y: 0.9662260280736962d), new NpgsqlTypes.NpgsqlPoint(x: 0.683284400328804d, y: 0.879061467778699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262856391673538d, y: 0.567670388632148d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9063095695691258d, y: 0.28323193077045494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719403466098587d, y: 0.3143224635162204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163918959307736d, y: 0.5002677311226174d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5315318322178741d, y: 0.431767782377655d), new NpgsqlTypes.NpgsqlPoint(x: 0.14986602813839656d, y: 0.3367453392730425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266111400778639d, y: 0.4424583874062006d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31262729015587754d, y: 0.3125866298451788d), new NpgsqlTypes.NpgsqlPoint(x: 0.44346004043488885d, y: 0.07232320832773653d), new NpgsqlTypes.NpgsqlPoint(x: 0.21329786524351457d, y: 0.6267381505816692d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7190038849102243d, y: 0.5212578713881871d), new NpgsqlTypes.NpgsqlPoint(x: 0.36087641098584977d, y: 0.160863611206297d), new NpgsqlTypes.NpgsqlPoint(x: 0.515176979507391d, y: 0.7345695015076541d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3900956257448184d, y: 0.5015035955631874d), new NpgsqlTypes.NpgsqlPoint(x: 0.21481074097623964d, y: 0.19886227738128948d), new NpgsqlTypes.NpgsqlPoint(x: 0.726889883630592d, y: 0.22578642598357224d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21787268078221522d, y: 0.11242142897685237d), new NpgsqlTypes.NpgsqlPoint(x: 0.26105045907093805d, y: 0.9901021479698736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6402806494458949d, y: 0.8374679252904246d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7019884830258548d, y: 0.4386049098160568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076625452138751d, y: 0.07642462765952474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598584768458119d, y: 0.008545296620350862d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9601684222038096d, y: 0.965029799286085d), new NpgsqlTypes.NpgsqlPoint(x: 0.708746466127262d, y: 0.7925080556705761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8708611621934511d, y: 0.2980166628758327d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9414460183857959d, y: 0.40626247042430663d), new NpgsqlTypes.NpgsqlPoint(x: 0.0369518222882248d, y: 0.7882665285474989d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319160495024196d, y: 0.6731092150271323d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23941877112369714d, y: 0.1546172223868868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4756619734413874d, y: 0.2478723176596126d), new NpgsqlTypes.NpgsqlPoint(x: 0.600407565074501d, y: 0.61150863714691d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3391020889218602d, y: 0.16229750086220662d), new NpgsqlTypes.NpgsqlPoint(x: 0.3852161153668644d, y: 0.2376705236747393d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973359984150181d, y: 0.12494075523812787d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3072032793697633d, y: 0.020013041876185356d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610194468978758d, y: 0.01482967774740973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6548627254572693d, y: 0.7862916955124992d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6263126277103985d, y: 0.9332654891825255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388929076238645d, y: 0.9363821979198766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6364908796250404d, y: 0.9758429721964024d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5264552165817247d, y: 0.654437036836235d), new NpgsqlTypes.NpgsqlPoint(x: 0.683941296177085d, y: 0.6655056436098675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554801296340609d, y: 0.04184385658875067d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07405107599857752d, y: 0.45282354046047624d), new NpgsqlTypes.NpgsqlPoint(x: 0.2362929751911711d, y: 0.7676072103380583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899400169149396d, y: 0.7595307396290437d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.869266409324077d, y: 0.6313942776740986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361965914706893d, y: 0.8344931489918891d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540860804637047d, y: 0.8333861763531335d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33041359830626105d, y: 0.5669202243117615d), new NpgsqlTypes.NpgsqlPoint(x: 0.22126137793148382d, y: 0.48832128972681454d), new NpgsqlTypes.NpgsqlPoint(x: 0.15415938718568678d, y: 0.012325324264515047d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.509918287322036d, y: 0.22197420598295137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500622271968532d, y: 0.9107917374042944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155999614803489d, y: 0.17395826279186166d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.632148566445792d, y: 0.586597205731795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752005394020421d, y: 0.5177195987236396d), new NpgsqlTypes.NpgsqlPoint(x: 0.794623045122616d, y: 0.2389951613374115d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813427741156939d, y: 0.032674754878682655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7206758375771833d, y: 0.28355403017997816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285364516705208d, y: 0.9284990923126807d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6521561450945554d, y: 0.6852359217571163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803150429592047d, y: 0.4250064056593379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904312889829358d, y: 0.16147075714520098d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6926255966489571d, y: 0.9506645377992807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236099830473095d, y: 0.6059131347696803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5883728547153171d, y: 0.6200187010355707d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1597335406139565d, y: 0.9071125213641927d), new NpgsqlTypes.NpgsqlPoint(x: 0.23716179869796905d, y: 0.1736370796695531d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086682841478109d, y: 0.2829239826055736d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17676814984545464d, y: 0.08503061464542538d), new NpgsqlTypes.NpgsqlPoint(x: 0.1114440243241629d, y: 0.47492763293763285d), new NpgsqlTypes.NpgsqlPoint(x: 0.017595524496797355d, y: 0.8691152363432574d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1976789042253948d, y: 0.5598558100430088d), new NpgsqlTypes.NpgsqlPoint(x: 0.014466284642517646d, y: 0.6023986248419803d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669986004055215d, y: 0.5182211376067106d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41799849997387617d, y: 0.2227383076912225d), new NpgsqlTypes.NpgsqlPoint(x: 0.25554755892159564d, y: 0.3288540095155482d), new NpgsqlTypes.NpgsqlPoint(x: 0.044693323131886786d, y: 0.843880016684539d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8028136369825059d, y: 0.3347096872019659d), new NpgsqlTypes.NpgsqlPoint(x: 0.6012021564252084d, y: 0.2672325621511876d), new NpgsqlTypes.NpgsqlPoint(x: 0.36300195201117913d, y: 0.5605050939476454d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9577644530958411d, y: 0.19155101282821574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652404807915767d, y: 0.18205474107638875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292419141510165d, y: 0.04601224453369246d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5616570570943118d, y: 0.08476912969847472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7448579431204789d, y: 0.23030579982912136d), new NpgsqlTypes.NpgsqlPoint(x: 0.36942649836653607d, y: 0.8864101336630755d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3326546691484038d, y: 0.6404013948177911d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190399427865619d, y: 0.6521974467944092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148197208355874d, y: 0.06169720942904722d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19656356012952558d, y: 0.38528798295591704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126175058810142d, y: 0.5582296796218399d), new NpgsqlTypes.NpgsqlPoint(x: 0.1403400630220718d, y: 0.978128087920674d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6025266207915223d, y: 0.17897841472123044d), new NpgsqlTypes.NpgsqlPoint(x: 0.3792732479344949d, y: 0.06783614053763132d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798256839262074d, y: 0.22108926060831857d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.601062882747738d, y: 0.03983099480661889d), new NpgsqlTypes.NpgsqlPoint(x: 0.463488181330866d, y: 0.527669331639656d), new NpgsqlTypes.NpgsqlPoint(x: 0.23794890859533724d, y: 0.7438583012994174d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8040203466445724d, y: 0.9858388280879221d), new NpgsqlTypes.NpgsqlPoint(x: 0.7437957039068409d, y: 0.8081505050285835d), new NpgsqlTypes.NpgsqlPoint(x: 0.2752206195100497d, y: 0.009551939587091995d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43335937953316783d, y: 0.4820703365789418d), new NpgsqlTypes.NpgsqlPoint(x: 0.2544330262904193d, y: 0.8409893680760455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890137362111397d, y: 0.41404989497486955d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22782768580702695d, y: 0.1922507492598422d), new NpgsqlTypes.NpgsqlPoint(x: 0.630477467005935d, y: 0.5648421372708143d), new NpgsqlTypes.NpgsqlPoint(x: 0.23431940740378343d, y: 0.9214256118916467d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9812074154837228d, y: 0.242958816115314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494232496503296d, y: 0.43461211707541925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8909588228538603d, y: 0.007732513879912362d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8881078570851432d, y: 0.5360200085382069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404574559479846d, y: 0.20707750596391172d), new NpgsqlTypes.NpgsqlPoint(x: 0.41786141006263555d, y: 0.1636059103816161d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1519230217644878d, y: 0.47590170790177966d), new NpgsqlTypes.NpgsqlPoint(x: 0.004837360428921245d, y: 0.2796085500333636d), new NpgsqlTypes.NpgsqlPoint(x: 0.35697234501804775d, y: 0.37670488250438816d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.190387352734124d, y: 0.401242884319579d), new NpgsqlTypes.NpgsqlPoint(x: 0.627240208240817d, y: 0.5532754372739698d), new NpgsqlTypes.NpgsqlPoint(x: 0.424260732416314d, y: 0.4482340046062996d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34579593153485233d, y: 0.9256054108681422d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261704527541025d, y: 0.3536802615067691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6065487186660686d, y: 0.7566904338579722d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07525166614081313d, y: 0.27596300569329524d), new NpgsqlTypes.NpgsqlPoint(x: 0.405803678335103d, y: 0.5532456588561334d), new NpgsqlTypes.NpgsqlPoint(x: 0.16552459284725052d, y: 0.25675714064807653d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23288827951789337d, y: 0.30755345411944435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8877803260139485d, y: 0.522291126441574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778503004968425d, y: 0.10604889401319728d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21457041744770944d, y: 0.43569745922614245d), new NpgsqlTypes.NpgsqlPoint(x: 0.2217184572328541d, y: 0.1768805794593935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240782740269481d, y: 0.7709353533725118d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5535927154459522d, y: 0.29548979170013134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4204022878607121d, y: 0.4064174701154455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5814001404490231d, y: 0.5172936103879592d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6550978619579618d, y: 0.0916537504853463d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048825205694516d, y: 0.2683159448628354d), new NpgsqlTypes.NpgsqlPoint(x: 0.2026501962231435d, y: 0.2090611561132999d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9611668587282927d, y: 0.08947869930025587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989005183801983d, y: 0.3730148678163733d), new NpgsqlTypes.NpgsqlPoint(x: 0.018735536775834394d, y: 0.7263889939269809d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8779381108333186d, y: 0.8038419482648664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745226580896577d, y: 0.4520558431970857d), new NpgsqlTypes.NpgsqlPoint(x: 0.10625496603793139d, y: 0.6890666668368499d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6456573938182041d, y: 0.968218080932761d), new NpgsqlTypes.NpgsqlPoint(x: 0.3529681602139595d, y: 0.7472428761365081d), new NpgsqlTypes.NpgsqlPoint(x: 0.3939191597826637d, y: 0.03269233255301873d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8832993138143599d, y: 0.486416038729255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906928537127451d, y: 0.632710978000731d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832878342953779d, y: 0.05158543344169875d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3567852144568612d, y: 0.7516486097487833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162540107438876d, y: 0.4228359554171368d), new NpgsqlTypes.NpgsqlPoint(x: 0.2867976362756738d, y: 0.42355686155224803d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3348761931398323d, y: 0.5789440501056375d), new NpgsqlTypes.NpgsqlPoint(x: 0.7470548012510428d, y: 0.8303699089774349d), new NpgsqlTypes.NpgsqlPoint(x: 0.22914933767606693d, y: 0.6287566180887717d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0882492494502618d, y: 0.4376002280147714d), new NpgsqlTypes.NpgsqlPoint(x: 0.054922433656637404d, y: 0.48906766162586146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250514382957397d, y: 0.6219867102241103d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8060841407935981d, y: 0.01123426252993509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7814675521924194d, y: 0.5236827990122732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939607445577223d, y: 0.41178796526509764d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34187844723497596d, y: 0.12934941470625094d), new NpgsqlTypes.NpgsqlPoint(x: 0.042867272392767886d, y: 0.8519326679304335d), new NpgsqlTypes.NpgsqlPoint(x: 0.49524174910909247d, y: 0.971011283844549d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31144591413277145d, y: 0.09317443630328315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145065181303487d, y: 0.6298498734693253d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826327178252452d, y: 0.3567463794977561d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7937905625103643d, y: 0.1852520297667496d), new NpgsqlTypes.NpgsqlPoint(x: 0.1468667953497086d, y: 0.16817181297746686d), new NpgsqlTypes.NpgsqlPoint(x: 0.32177006747582093d, y: 0.24547262104771805d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9374221545666985d, y: 0.29804471160069945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989130082221456d, y: 0.39733825779297194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015081562430515d, y: 0.6927991128738658d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8028663213492626d, y: 0.8000695834079514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068261918584511d, y: 0.4343485888956462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6400461813865399d, y: 0.6868533132823003d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9157721299299816d, y: 0.9652477866846623d), new NpgsqlTypes.NpgsqlPoint(x: 0.22630196518444468d, y: 0.40639931283667197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388539392190163d, y: 0.5642928510397599d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.545446590900523d, y: 0.8136611679714254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9628711013295793d, y: 0.9693723060826721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579863664577273d, y: 0.39796040889218665d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4785251050660537d, y: 0.7539591902513954d), new NpgsqlTypes.NpgsqlPoint(x: 0.13515408924950612d, y: 0.43946838226216334d), new NpgsqlTypes.NpgsqlPoint(x: 0.00767037119485281d, y: 0.250536626413972d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9075152657511983d, y: 0.27946160541384835d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002488350135923d, y: 0.7499890102754071d), new NpgsqlTypes.NpgsqlPoint(x: 0.1849557960341509d, y: 0.3247539065752372d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6022920047978941d, y: 0.7154846185639441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418928018932514d, y: 0.48779850652056955d), new NpgsqlTypes.NpgsqlPoint(x: 0.19523404519187293d, y: 0.6764925916147647d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2781447867679213d, y: 0.8718031568866573d), new NpgsqlTypes.NpgsqlPoint(x: 0.46509041604777945d, y: 0.5948205383816865d), new NpgsqlTypes.NpgsqlPoint(x: 0.41640973300736306d, y: 0.2285843663344762d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5111307691867915d, y: 0.018677066845373402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369161794929478d, y: 0.7689446269849495d), new NpgsqlTypes.NpgsqlPoint(x: 0.4905397922080881d, y: 0.052061782002389534d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12714038122190863d, y: 0.6837201368262043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152699788592437d, y: 0.6402321037076699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056157426821301d, y: 0.6820161722643867d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32347996010515334d, y: 0.31129441890094034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923698250712496d, y: 0.813714480228363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8927410218583672d, y: 0.5915629449957911d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 175,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24334250758224885d, y: 0.6437975529672162d), new NpgsqlTypes.NpgsqlPoint(x: 0.47820042841213917d, y: 0.11593567770261415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181761937043542d, y: 0.1689806353380966d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.439342081118255d, y: 0.5336966043170288d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993822716455508d, y: 0.04500232258675019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304983613346489d, y: 0.9716358711031859d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21401607263302658d, y: 0.2952895851166678d), new NpgsqlTypes.NpgsqlPoint(x: 0.42025753361348306d, y: 0.3491466519520027d), new NpgsqlTypes.NpgsqlPoint(x: 0.22290859657549966d, y: 0.10531430200890923d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7024124433073395d, y: 0.9239926529626704d), new NpgsqlTypes.NpgsqlPoint(x: 0.10186857061481969d, y: 0.12120973380120892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551188817660642d, y: 0.34821788937987586d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13176233135373117d, y: 0.9985811635165381d), new NpgsqlTypes.NpgsqlPoint(x: 0.007540825080165403d, y: 0.4190470044285398d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520206796605174d, y: 0.6285470892355595d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.044875113833753755d, y: 0.41123902245229527d), new NpgsqlTypes.NpgsqlPoint(x: 0.11888711661387386d, y: 0.442972155353192d), new NpgsqlTypes.NpgsqlPoint(x: 0.3763735465029068d, y: 0.49952009979812506d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22495912725542289d, y: 0.21340232601796194d), new NpgsqlTypes.NpgsqlPoint(x: 0.11153256534509692d, y: 0.9995448321361199d), new NpgsqlTypes.NpgsqlPoint(x: 0.2457688763304533d, y: 0.7117361233553776d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.709783420694132d, y: 0.284808401484544d), new NpgsqlTypes.NpgsqlPoint(x: 0.13781095167723367d, y: 0.84906231567458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927924068491514d, y: 0.13226796094747695d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.535154782659057d, y: 0.22430091690257037d), new NpgsqlTypes.NpgsqlPoint(x: 0.31925326713498103d, y: 0.045086957820659634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2333829937965176d, y: 0.1615635143450609d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 185,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7485432930958816d, y: 0.7385761515537508d), new NpgsqlTypes.NpgsqlPoint(x: 0.48819655185442534d, y: 0.6466239486813304d), new NpgsqlTypes.NpgsqlPoint(x: 0.40301911508607924d, y: 0.028496624735321552d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 186,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18857381414731922d, y: 0.37807603497751663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993845268520922d, y: 0.7395573397556372d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084759502925208d, y: 0.5138853081847782d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01518089119255317d, y: 0.6545600031614411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468298640392485d, y: 0.516648506384087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511591911132691d, y: 0.42602149302693426d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48728027522980577d, y: 0.6312545885013678d), new NpgsqlTypes.NpgsqlPoint(x: 0.14630774904963673d, y: 0.2962134086367879d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137257161794148d, y: 0.7934911018292655d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8363489245040295d, y: 0.7413131577978642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133719558123798d, y: 0.16786855735086736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599616504891807d, y: 0.06441058494858731d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 193,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7801502245275796d, y: 0.9621648286981411d), new NpgsqlTypes.NpgsqlPoint(x: 0.04498733266457455d, y: 0.8092917085465478d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374276508670246d, y: 0.5932565686454526d)),
    ModelInner = null,
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5264552165817247d, y: 0.654437036836235d), new NpgsqlTypes.NpgsqlPoint(x: 0.683941296177085d, y: 0.6655056436098675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554801296340609d, y: 0.04184385658875067d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813427741156939d, y: 0.032674754878682655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7206758375771833d, y: 0.28355403017997816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285364516705208d, y: 0.9284990923126807d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1976789042253948d, y: 0.5598558100430088d), new NpgsqlTypes.NpgsqlPoint(x: 0.014466284642517646d, y: 0.6023986248419803d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669986004055215d, y: 0.5182211376067106d))));
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.npgsqlpolygonpolygon0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.npgsqlpolygonpolygon0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 183;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[30],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 134, query1, 175, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 47, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 21, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 103, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 125, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 183, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 183, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[34], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 175);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0507727226191752d, y: 0.12218723484290883d), new NpgsqlTypes.NpgsqlPoint(x: 0.3825358466115971d, y: 0.6944234496510914d), new NpgsqlTypes.NpgsqlPoint(x: 0.41743284174529705d, y: 0.3934445744612832d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6864665640768625d, y: 0.9662260280736962d), new NpgsqlTypes.NpgsqlPoint(x: 0.683284400328804d, y: 0.879061467778699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262856391673538d, y: 0.567670388632148d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9063095695691258d, y: 0.28323193077045494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719403466098587d, y: 0.3143224635162204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163918959307736d, y: 0.5002677311226174d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5315318322178741d, y: 0.431767782377655d), new NpgsqlTypes.NpgsqlPoint(x: 0.14986602813839656d, y: 0.3367453392730425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266111400778639d, y: 0.4424583874062006d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31262729015587754d, y: 0.3125866298451788d), new NpgsqlTypes.NpgsqlPoint(x: 0.44346004043488885d, y: 0.07232320832773653d), new NpgsqlTypes.NpgsqlPoint(x: 0.21329786524351457d, y: 0.6267381505816692d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7190038849102243d, y: 0.5212578713881871d), new NpgsqlTypes.NpgsqlPoint(x: 0.36087641098584977d, y: 0.160863611206297d), new NpgsqlTypes.NpgsqlPoint(x: 0.515176979507391d, y: 0.7345695015076541d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3900956257448184d, y: 0.5015035955631874d), new NpgsqlTypes.NpgsqlPoint(x: 0.21481074097623964d, y: 0.19886227738128948d), new NpgsqlTypes.NpgsqlPoint(x: 0.726889883630592d, y: 0.22578642598357224d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21787268078221522d, y: 0.11242142897685237d), new NpgsqlTypes.NpgsqlPoint(x: 0.26105045907093805d, y: 0.9901021479698736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6402806494458949d, y: 0.8374679252904246d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7019884830258548d, y: 0.4386049098160568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076625452138751d, y: 0.07642462765952474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598584768458119d, y: 0.008545296620350862d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9601684222038096d, y: 0.965029799286085d), new NpgsqlTypes.NpgsqlPoint(x: 0.708746466127262d, y: 0.7925080556705761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8708611621934511d, y: 0.2980166628758327d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9414460183857959d, y: 0.40626247042430663d), new NpgsqlTypes.NpgsqlPoint(x: 0.0369518222882248d, y: 0.7882665285474989d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319160495024196d, y: 0.6731092150271323d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23941877112369714d, y: 0.1546172223868868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4756619734413874d, y: 0.2478723176596126d), new NpgsqlTypes.NpgsqlPoint(x: 0.600407565074501d, y: 0.61150863714691d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3391020889218602d, y: 0.16229750086220662d), new NpgsqlTypes.NpgsqlPoint(x: 0.3852161153668644d, y: 0.2376705236747393d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973359984150181d, y: 0.12494075523812787d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3072032793697633d, y: 0.020013041876185356d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610194468978758d, y: 0.01482967774740973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6548627254572693d, y: 0.7862916955124992d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6263126277103985d, y: 0.9332654891825255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388929076238645d, y: 0.9363821979198766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6364908796250404d, y: 0.9758429721964024d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5264552165817247d, y: 0.654437036836235d), new NpgsqlTypes.NpgsqlPoint(x: 0.683941296177085d, y: 0.6655056436098675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554801296340609d, y: 0.04184385658875067d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07405107599857752d, y: 0.45282354046047624d), new NpgsqlTypes.NpgsqlPoint(x: 0.2362929751911711d, y: 0.7676072103380583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899400169149396d, y: 0.7595307396290437d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.869266409324077d, y: 0.6313942776740986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361965914706893d, y: 0.8344931489918891d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540860804637047d, y: 0.8333861763531335d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33041359830626105d, y: 0.5669202243117615d), new NpgsqlTypes.NpgsqlPoint(x: 0.22126137793148382d, y: 0.48832128972681454d), new NpgsqlTypes.NpgsqlPoint(x: 0.15415938718568678d, y: 0.012325324264515047d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.509918287322036d, y: 0.22197420598295137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500622271968532d, y: 0.9107917374042944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155999614803489d, y: 0.17395826279186166d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.632148566445792d, y: 0.586597205731795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752005394020421d, y: 0.5177195987236396d), new NpgsqlTypes.NpgsqlPoint(x: 0.794623045122616d, y: 0.2389951613374115d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813427741156939d, y: 0.032674754878682655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7206758375771833d, y: 0.28355403017997816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285364516705208d, y: 0.9284990923126807d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6521561450945554d, y: 0.6852359217571163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803150429592047d, y: 0.4250064056593379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904312889829358d, y: 0.16147075714520098d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6926255966489571d, y: 0.9506645377992807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236099830473095d, y: 0.6059131347696803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5883728547153171d, y: 0.6200187010355707d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1597335406139565d, y: 0.9071125213641927d), new NpgsqlTypes.NpgsqlPoint(x: 0.23716179869796905d, y: 0.1736370796695531d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086682841478109d, y: 0.2829239826055736d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17676814984545464d, y: 0.08503061464542538d), new NpgsqlTypes.NpgsqlPoint(x: 0.1114440243241629d, y: 0.47492763293763285d), new NpgsqlTypes.NpgsqlPoint(x: 0.017595524496797355d, y: 0.8691152363432574d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1976789042253948d, y: 0.5598558100430088d), new NpgsqlTypes.NpgsqlPoint(x: 0.014466284642517646d, y: 0.6023986248419803d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669986004055215d, y: 0.5182211376067106d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41799849997387617d, y: 0.2227383076912225d), new NpgsqlTypes.NpgsqlPoint(x: 0.25554755892159564d, y: 0.3288540095155482d), new NpgsqlTypes.NpgsqlPoint(x: 0.044693323131886786d, y: 0.843880016684539d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8028136369825059d, y: 0.3347096872019659d), new NpgsqlTypes.NpgsqlPoint(x: 0.6012021564252084d, y: 0.2672325621511876d), new NpgsqlTypes.NpgsqlPoint(x: 0.36300195201117913d, y: 0.5605050939476454d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9577644530958411d, y: 0.19155101282821574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652404807915767d, y: 0.18205474107638875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292419141510165d, y: 0.04601224453369246d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5616570570943118d, y: 0.08476912969847472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7448579431204789d, y: 0.23030579982912136d), new NpgsqlTypes.NpgsqlPoint(x: 0.36942649836653607d, y: 0.8864101336630755d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3326546691484038d, y: 0.6404013948177911d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190399427865619d, y: 0.6521974467944092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148197208355874d, y: 0.06169720942904722d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19656356012952558d, y: 0.38528798295591704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126175058810142d, y: 0.5582296796218399d), new NpgsqlTypes.NpgsqlPoint(x: 0.1403400630220718d, y: 0.978128087920674d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6025266207915223d, y: 0.17897841472123044d), new NpgsqlTypes.NpgsqlPoint(x: 0.3792732479344949d, y: 0.06783614053763132d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798256839262074d, y: 0.22108926060831857d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.601062882747738d, y: 0.03983099480661889d), new NpgsqlTypes.NpgsqlPoint(x: 0.463488181330866d, y: 0.527669331639656d), new NpgsqlTypes.NpgsqlPoint(x: 0.23794890859533724d, y: 0.7438583012994174d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8040203466445724d, y: 0.9858388280879221d), new NpgsqlTypes.NpgsqlPoint(x: 0.7437957039068409d, y: 0.8081505050285835d), new NpgsqlTypes.NpgsqlPoint(x: 0.2752206195100497d, y: 0.009551939587091995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43335937953316783d, y: 0.4820703365789418d), new NpgsqlTypes.NpgsqlPoint(x: 0.2544330262904193d, y: 0.8409893680760455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890137362111397d, y: 0.41404989497486955d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22782768580702695d, y: 0.1922507492598422d), new NpgsqlTypes.NpgsqlPoint(x: 0.630477467005935d, y: 0.5648421372708143d), new NpgsqlTypes.NpgsqlPoint(x: 0.23431940740378343d, y: 0.9214256118916467d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9812074154837228d, y: 0.242958816115314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494232496503296d, y: 0.43461211707541925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8909588228538603d, y: 0.007732513879912362d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8881078570851432d, y: 0.5360200085382069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404574559479846d, y: 0.20707750596391172d), new NpgsqlTypes.NpgsqlPoint(x: 0.41786141006263555d, y: 0.1636059103816161d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1519230217644878d, y: 0.47590170790177966d), new NpgsqlTypes.NpgsqlPoint(x: 0.004837360428921245d, y: 0.2796085500333636d), new NpgsqlTypes.NpgsqlPoint(x: 0.35697234501804775d, y: 0.37670488250438816d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.190387352734124d, y: 0.401242884319579d), new NpgsqlTypes.NpgsqlPoint(x: 0.627240208240817d, y: 0.5532754372739698d), new NpgsqlTypes.NpgsqlPoint(x: 0.424260732416314d, y: 0.4482340046062996d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34579593153485233d, y: 0.9256054108681422d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261704527541025d, y: 0.3536802615067691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6065487186660686d, y: 0.7566904338579722d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07525166614081313d, y: 0.27596300569329524d), new NpgsqlTypes.NpgsqlPoint(x: 0.405803678335103d, y: 0.5532456588561334d), new NpgsqlTypes.NpgsqlPoint(x: 0.16552459284725052d, y: 0.25675714064807653d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23288827951789337d, y: 0.30755345411944435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8877803260139485d, y: 0.522291126441574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778503004968425d, y: 0.10604889401319728d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21457041744770944d, y: 0.43569745922614245d), new NpgsqlTypes.NpgsqlPoint(x: 0.2217184572328541d, y: 0.1768805794593935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240782740269481d, y: 0.7709353533725118d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5535927154459522d, y: 0.29548979170013134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4204022878607121d, y: 0.4064174701154455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5814001404490231d, y: 0.5172936103879592d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6550978619579618d, y: 0.0916537504853463d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048825205694516d, y: 0.2683159448628354d), new NpgsqlTypes.NpgsqlPoint(x: 0.2026501962231435d, y: 0.2090611561132999d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9611668587282927d, y: 0.08947869930025587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989005183801983d, y: 0.3730148678163733d), new NpgsqlTypes.NpgsqlPoint(x: 0.018735536775834394d, y: 0.7263889939269809d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8779381108333186d, y: 0.8038419482648664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745226580896577d, y: 0.4520558431970857d), new NpgsqlTypes.NpgsqlPoint(x: 0.10625496603793139d, y: 0.6890666668368499d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6456573938182041d, y: 0.968218080932761d), new NpgsqlTypes.NpgsqlPoint(x: 0.3529681602139595d, y: 0.7472428761365081d), new NpgsqlTypes.NpgsqlPoint(x: 0.3939191597826637d, y: 0.03269233255301873d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8832993138143599d, y: 0.486416038729255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906928537127451d, y: 0.632710978000731d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832878342953779d, y: 0.05158543344169875d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3567852144568612d, y: 0.7516486097487833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162540107438876d, y: 0.4228359554171368d), new NpgsqlTypes.NpgsqlPoint(x: 0.2867976362756738d, y: 0.42355686155224803d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3348761931398323d, y: 0.5789440501056375d), new NpgsqlTypes.NpgsqlPoint(x: 0.7470548012510428d, y: 0.8303699089774349d), new NpgsqlTypes.NpgsqlPoint(x: 0.22914933767606693d, y: 0.6287566180887717d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0882492494502618d, y: 0.4376002280147714d), new NpgsqlTypes.NpgsqlPoint(x: 0.054922433656637404d, y: 0.48906766162586146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250514382957397d, y: 0.6219867102241103d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8060841407935981d, y: 0.01123426252993509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7814675521924194d, y: 0.5236827990122732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939607445577223d, y: 0.41178796526509764d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34187844723497596d, y: 0.12934941470625094d), new NpgsqlTypes.NpgsqlPoint(x: 0.042867272392767886d, y: 0.8519326679304335d), new NpgsqlTypes.NpgsqlPoint(x: 0.49524174910909247d, y: 0.971011283844549d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31144591413277145d, y: 0.09317443630328315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145065181303487d, y: 0.6298498734693253d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826327178252452d, y: 0.3567463794977561d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7937905625103643d, y: 0.1852520297667496d), new NpgsqlTypes.NpgsqlPoint(x: 0.1468667953497086d, y: 0.16817181297746686d), new NpgsqlTypes.NpgsqlPoint(x: 0.32177006747582093d, y: 0.24547262104771805d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9374221545666985d, y: 0.29804471160069945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989130082221456d, y: 0.39733825779297194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015081562430515d, y: 0.6927991128738658d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8028663213492626d, y: 0.8000695834079514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068261918584511d, y: 0.4343485888956462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6400461813865399d, y: 0.6868533132823003d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9157721299299816d, y: 0.9652477866846623d), new NpgsqlTypes.NpgsqlPoint(x: 0.22630196518444468d, y: 0.40639931283667197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388539392190163d, y: 0.5642928510397599d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.545446590900523d, y: 0.8136611679714254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9628711013295793d, y: 0.9693723060826721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579863664577273d, y: 0.39796040889218665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4785251050660537d, y: 0.7539591902513954d), new NpgsqlTypes.NpgsqlPoint(x: 0.13515408924950612d, y: 0.43946838226216334d), new NpgsqlTypes.NpgsqlPoint(x: 0.00767037119485281d, y: 0.250536626413972d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9075152657511983d, y: 0.27946160541384835d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002488350135923d, y: 0.7499890102754071d), new NpgsqlTypes.NpgsqlPoint(x: 0.1849557960341509d, y: 0.3247539065752372d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6022920047978941d, y: 0.7154846185639441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418928018932514d, y: 0.48779850652056955d), new NpgsqlTypes.NpgsqlPoint(x: 0.19523404519187293d, y: 0.6764925916147647d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2781447867679213d, y: 0.8718031568866573d), new NpgsqlTypes.NpgsqlPoint(x: 0.46509041604777945d, y: 0.5948205383816865d), new NpgsqlTypes.NpgsqlPoint(x: 0.41640973300736306d, y: 0.2285843663344762d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5111307691867915d, y: 0.018677066845373402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369161794929478d, y: 0.7689446269849495d), new NpgsqlTypes.NpgsqlPoint(x: 0.4905397922080881d, y: 0.052061782002389534d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12714038122190863d, y: 0.6837201368262043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152699788592437d, y: 0.6402321037076699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056157426821301d, y: 0.6820161722643867d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32347996010515334d, y: 0.31129441890094034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923698250712496d, y: 0.813714480228363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8927410218583672d, y: 0.5915629449957911d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24334250758224885d, y: 0.6437975529672162d), new NpgsqlTypes.NpgsqlPoint(x: 0.47820042841213917d, y: 0.11593567770261415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181761937043542d, y: 0.1689806353380966d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.439342081118255d, y: 0.5336966043170288d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993822716455508d, y: 0.04500232258675019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304983613346489d, y: 0.9716358711031859d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21401607263302658d, y: 0.2952895851166678d), new NpgsqlTypes.NpgsqlPoint(x: 0.42025753361348306d, y: 0.3491466519520027d), new NpgsqlTypes.NpgsqlPoint(x: 0.22290859657549966d, y: 0.10531430200890923d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7024124433073395d, y: 0.9239926529626704d), new NpgsqlTypes.NpgsqlPoint(x: 0.10186857061481969d, y: 0.12120973380120892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551188817660642d, y: 0.34821788937987586d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13176233135373117d, y: 0.9985811635165381d), new NpgsqlTypes.NpgsqlPoint(x: 0.007540825080165403d, y: 0.4190470044285398d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520206796605174d, y: 0.6285470892355595d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.044875113833753755d, y: 0.41123902245229527d), new NpgsqlTypes.NpgsqlPoint(x: 0.11888711661387386d, y: 0.442972155353192d), new NpgsqlTypes.NpgsqlPoint(x: 0.3763735465029068d, y: 0.49952009979812506d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22495912725542289d, y: 0.21340232601796194d), new NpgsqlTypes.NpgsqlPoint(x: 0.11153256534509692d, y: 0.9995448321361199d), new NpgsqlTypes.NpgsqlPoint(x: 0.2457688763304533d, y: 0.7117361233553776d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.709783420694132d, y: 0.284808401484544d), new NpgsqlTypes.NpgsqlPoint(x: 0.13781095167723367d, y: 0.84906231567458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927924068491514d, y: 0.13226796094747695d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.535154782659057d, y: 0.22430091690257037d), new NpgsqlTypes.NpgsqlPoint(x: 0.31925326713498103d, y: 0.045086957820659634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2333829937965176d, y: 0.1615635143450609d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7485432930958816d, y: 0.7385761515537508d), new NpgsqlTypes.NpgsqlPoint(x: 0.48819655185442534d, y: 0.6466239486813304d), new NpgsqlTypes.NpgsqlPoint(x: 0.40301911508607924d, y: 0.028496624735321552d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18857381414731922d, y: 0.37807603497751663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993845268520922d, y: 0.7395573397556372d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084759502925208d, y: 0.5138853081847782d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01518089119255317d, y: 0.6545600031614411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468298640392485d, y: 0.516648506384087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511591911132691d, y: 0.42602149302693426d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48728027522980577d, y: 0.6312545885013678d), new NpgsqlTypes.NpgsqlPoint(x: 0.14630774904963673d, y: 0.2962134086367879d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137257161794148d, y: 0.7934911018292655d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8363489245040295d, y: 0.7413131577978642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133719558123798d, y: 0.16786855735086736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599616504891807d, y: 0.06441058494858731d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((193)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7801502245275796d, y: 0.9621648286981411d), new NpgsqlTypes.NpgsqlPoint(x: 0.04498733266457455d, y: 0.8092917085465478d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374276508670246d, y: 0.5932565686454526d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0507727226191752d, y: 0.12218723484290883d), new NpgsqlTypes.NpgsqlPoint(x: 0.3825358466115971d, y: 0.6944234496510914d), new NpgsqlTypes.NpgsqlPoint(x: 0.41743284174529705d, y: 0.3934445744612832d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6864665640768625d, y: 0.9662260280736962d), new NpgsqlTypes.NpgsqlPoint(x: 0.683284400328804d, y: 0.879061467778699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262856391673538d, y: 0.567670388632148d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9063095695691258d, y: 0.28323193077045494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719403466098587d, y: 0.3143224635162204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163918959307736d, y: 0.5002677311226174d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5315318322178741d, y: 0.431767782377655d), new NpgsqlTypes.NpgsqlPoint(x: 0.14986602813839656d, y: 0.3367453392730425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266111400778639d, y: 0.4424583874062006d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31262729015587754d, y: 0.3125866298451788d), new NpgsqlTypes.NpgsqlPoint(x: 0.44346004043488885d, y: 0.07232320832773653d), new NpgsqlTypes.NpgsqlPoint(x: 0.21329786524351457d, y: 0.6267381505816692d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7190038849102243d, y: 0.5212578713881871d), new NpgsqlTypes.NpgsqlPoint(x: 0.36087641098584977d, y: 0.160863611206297d), new NpgsqlTypes.NpgsqlPoint(x: 0.515176979507391d, y: 0.7345695015076541d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3900956257448184d, y: 0.5015035955631874d), new NpgsqlTypes.NpgsqlPoint(x: 0.21481074097623964d, y: 0.19886227738128948d), new NpgsqlTypes.NpgsqlPoint(x: 0.726889883630592d, y: 0.22578642598357224d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21787268078221522d, y: 0.11242142897685237d), new NpgsqlTypes.NpgsqlPoint(x: 0.26105045907093805d, y: 0.9901021479698736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6402806494458949d, y: 0.8374679252904246d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7019884830258548d, y: 0.4386049098160568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076625452138751d, y: 0.07642462765952474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598584768458119d, y: 0.008545296620350862d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9601684222038096d, y: 0.965029799286085d), new NpgsqlTypes.NpgsqlPoint(x: 0.708746466127262d, y: 0.7925080556705761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8708611621934511d, y: 0.2980166628758327d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9414460183857959d, y: 0.40626247042430663d), new NpgsqlTypes.NpgsqlPoint(x: 0.0369518222882248d, y: 0.7882665285474989d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319160495024196d, y: 0.6731092150271323d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23941877112369714d, y: 0.1546172223868868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4756619734413874d, y: 0.2478723176596126d), new NpgsqlTypes.NpgsqlPoint(x: 0.600407565074501d, y: 0.61150863714691d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3391020889218602d, y: 0.16229750086220662d), new NpgsqlTypes.NpgsqlPoint(x: 0.3852161153668644d, y: 0.2376705236747393d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973359984150181d, y: 0.12494075523812787d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3072032793697633d, y: 0.020013041876185356d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610194468978758d, y: 0.01482967774740973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6548627254572693d, y: 0.7862916955124992d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6263126277103985d, y: 0.9332654891825255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388929076238645d, y: 0.9363821979198766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6364908796250404d, y: 0.9758429721964024d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5264552165817247d, y: 0.654437036836235d), new NpgsqlTypes.NpgsqlPoint(x: 0.683941296177085d, y: 0.6655056436098675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554801296340609d, y: 0.04184385658875067d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07405107599857752d, y: 0.45282354046047624d), new NpgsqlTypes.NpgsqlPoint(x: 0.2362929751911711d, y: 0.7676072103380583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899400169149396d, y: 0.7595307396290437d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.869266409324077d, y: 0.6313942776740986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361965914706893d, y: 0.8344931489918891d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540860804637047d, y: 0.8333861763531335d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33041359830626105d, y: 0.5669202243117615d), new NpgsqlTypes.NpgsqlPoint(x: 0.22126137793148382d, y: 0.48832128972681454d), new NpgsqlTypes.NpgsqlPoint(x: 0.15415938718568678d, y: 0.012325324264515047d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.509918287322036d, y: 0.22197420598295137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500622271968532d, y: 0.9107917374042944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155999614803489d, y: 0.17395826279186166d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.632148566445792d, y: 0.586597205731795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752005394020421d, y: 0.5177195987236396d), new NpgsqlTypes.NpgsqlPoint(x: 0.794623045122616d, y: 0.2389951613374115d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813427741156939d, y: 0.032674754878682655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7206758375771833d, y: 0.28355403017997816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285364516705208d, y: 0.9284990923126807d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6521561450945554d, y: 0.6852359217571163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803150429592047d, y: 0.4250064056593379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904312889829358d, y: 0.16147075714520098d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6926255966489571d, y: 0.9506645377992807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236099830473095d, y: 0.6059131347696803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5883728547153171d, y: 0.6200187010355707d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1597335406139565d, y: 0.9071125213641927d), new NpgsqlTypes.NpgsqlPoint(x: 0.23716179869796905d, y: 0.1736370796695531d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086682841478109d, y: 0.2829239826055736d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17676814984545464d, y: 0.08503061464542538d), new NpgsqlTypes.NpgsqlPoint(x: 0.1114440243241629d, y: 0.47492763293763285d), new NpgsqlTypes.NpgsqlPoint(x: 0.017595524496797355d, y: 0.8691152363432574d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1976789042253948d, y: 0.5598558100430088d), new NpgsqlTypes.NpgsqlPoint(x: 0.014466284642517646d, y: 0.6023986248419803d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669986004055215d, y: 0.5182211376067106d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41799849997387617d, y: 0.2227383076912225d), new NpgsqlTypes.NpgsqlPoint(x: 0.25554755892159564d, y: 0.3288540095155482d), new NpgsqlTypes.NpgsqlPoint(x: 0.044693323131886786d, y: 0.843880016684539d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8028136369825059d, y: 0.3347096872019659d), new NpgsqlTypes.NpgsqlPoint(x: 0.6012021564252084d, y: 0.2672325621511876d), new NpgsqlTypes.NpgsqlPoint(x: 0.36300195201117913d, y: 0.5605050939476454d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9577644530958411d, y: 0.19155101282821574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652404807915767d, y: 0.18205474107638875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292419141510165d, y: 0.04601224453369246d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5616570570943118d, y: 0.08476912969847472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7448579431204789d, y: 0.23030579982912136d), new NpgsqlTypes.NpgsqlPoint(x: 0.36942649836653607d, y: 0.8864101336630755d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3326546691484038d, y: 0.6404013948177911d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190399427865619d, y: 0.6521974467944092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148197208355874d, y: 0.06169720942904722d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19656356012952558d, y: 0.38528798295591704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126175058810142d, y: 0.5582296796218399d), new NpgsqlTypes.NpgsqlPoint(x: 0.1403400630220718d, y: 0.978128087920674d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6025266207915223d, y: 0.17897841472123044d), new NpgsqlTypes.NpgsqlPoint(x: 0.3792732479344949d, y: 0.06783614053763132d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798256839262074d, y: 0.22108926060831857d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.601062882747738d, y: 0.03983099480661889d), new NpgsqlTypes.NpgsqlPoint(x: 0.463488181330866d, y: 0.527669331639656d), new NpgsqlTypes.NpgsqlPoint(x: 0.23794890859533724d, y: 0.7438583012994174d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8040203466445724d, y: 0.9858388280879221d), new NpgsqlTypes.NpgsqlPoint(x: 0.7437957039068409d, y: 0.8081505050285835d), new NpgsqlTypes.NpgsqlPoint(x: 0.2752206195100497d, y: 0.009551939587091995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43335937953316783d, y: 0.4820703365789418d), new NpgsqlTypes.NpgsqlPoint(x: 0.2544330262904193d, y: 0.8409893680760455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890137362111397d, y: 0.41404989497486955d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22782768580702695d, y: 0.1922507492598422d), new NpgsqlTypes.NpgsqlPoint(x: 0.630477467005935d, y: 0.5648421372708143d), new NpgsqlTypes.NpgsqlPoint(x: 0.23431940740378343d, y: 0.9214256118916467d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9812074154837228d, y: 0.242958816115314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494232496503296d, y: 0.43461211707541925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8909588228538603d, y: 0.007732513879912362d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8881078570851432d, y: 0.5360200085382069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404574559479846d, y: 0.20707750596391172d), new NpgsqlTypes.NpgsqlPoint(x: 0.41786141006263555d, y: 0.1636059103816161d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1519230217644878d, y: 0.47590170790177966d), new NpgsqlTypes.NpgsqlPoint(x: 0.004837360428921245d, y: 0.2796085500333636d), new NpgsqlTypes.NpgsqlPoint(x: 0.35697234501804775d, y: 0.37670488250438816d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.190387352734124d, y: 0.401242884319579d), new NpgsqlTypes.NpgsqlPoint(x: 0.627240208240817d, y: 0.5532754372739698d), new NpgsqlTypes.NpgsqlPoint(x: 0.424260732416314d, y: 0.4482340046062996d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34579593153485233d, y: 0.9256054108681422d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261704527541025d, y: 0.3536802615067691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6065487186660686d, y: 0.7566904338579722d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07525166614081313d, y: 0.27596300569329524d), new NpgsqlTypes.NpgsqlPoint(x: 0.405803678335103d, y: 0.5532456588561334d), new NpgsqlTypes.NpgsqlPoint(x: 0.16552459284725052d, y: 0.25675714064807653d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23288827951789337d, y: 0.30755345411944435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8877803260139485d, y: 0.522291126441574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778503004968425d, y: 0.10604889401319728d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21457041744770944d, y: 0.43569745922614245d), new NpgsqlTypes.NpgsqlPoint(x: 0.2217184572328541d, y: 0.1768805794593935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240782740269481d, y: 0.7709353533725118d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5535927154459522d, y: 0.29548979170013134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4204022878607121d, y: 0.4064174701154455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5814001404490231d, y: 0.5172936103879592d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6550978619579618d, y: 0.0916537504853463d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048825205694516d, y: 0.2683159448628354d), new NpgsqlTypes.NpgsqlPoint(x: 0.2026501962231435d, y: 0.2090611561132999d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9611668587282927d, y: 0.08947869930025587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989005183801983d, y: 0.3730148678163733d), new NpgsqlTypes.NpgsqlPoint(x: 0.018735536775834394d, y: 0.7263889939269809d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8779381108333186d, y: 0.8038419482648664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745226580896577d, y: 0.4520558431970857d), new NpgsqlTypes.NpgsqlPoint(x: 0.10625496603793139d, y: 0.6890666668368499d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6456573938182041d, y: 0.968218080932761d), new NpgsqlTypes.NpgsqlPoint(x: 0.3529681602139595d, y: 0.7472428761365081d), new NpgsqlTypes.NpgsqlPoint(x: 0.3939191597826637d, y: 0.03269233255301873d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8832993138143599d, y: 0.486416038729255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906928537127451d, y: 0.632710978000731d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832878342953779d, y: 0.05158543344169875d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3567852144568612d, y: 0.7516486097487833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162540107438876d, y: 0.4228359554171368d), new NpgsqlTypes.NpgsqlPoint(x: 0.2867976362756738d, y: 0.42355686155224803d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3348761931398323d, y: 0.5789440501056375d), new NpgsqlTypes.NpgsqlPoint(x: 0.7470548012510428d, y: 0.8303699089774349d), new NpgsqlTypes.NpgsqlPoint(x: 0.22914933767606693d, y: 0.6287566180887717d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0882492494502618d, y: 0.4376002280147714d), new NpgsqlTypes.NpgsqlPoint(x: 0.054922433656637404d, y: 0.48906766162586146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250514382957397d, y: 0.6219867102241103d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8060841407935981d, y: 0.01123426252993509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7814675521924194d, y: 0.5236827990122732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939607445577223d, y: 0.41178796526509764d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34187844723497596d, y: 0.12934941470625094d), new NpgsqlTypes.NpgsqlPoint(x: 0.042867272392767886d, y: 0.8519326679304335d), new NpgsqlTypes.NpgsqlPoint(x: 0.49524174910909247d, y: 0.971011283844549d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31144591413277145d, y: 0.09317443630328315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145065181303487d, y: 0.6298498734693253d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826327178252452d, y: 0.3567463794977561d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7937905625103643d, y: 0.1852520297667496d), new NpgsqlTypes.NpgsqlPoint(x: 0.1468667953497086d, y: 0.16817181297746686d), new NpgsqlTypes.NpgsqlPoint(x: 0.32177006747582093d, y: 0.24547262104771805d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9374221545666985d, y: 0.29804471160069945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989130082221456d, y: 0.39733825779297194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015081562430515d, y: 0.6927991128738658d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8028663213492626d, y: 0.8000695834079514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068261918584511d, y: 0.4343485888956462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6400461813865399d, y: 0.6868533132823003d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9157721299299816d, y: 0.9652477866846623d), new NpgsqlTypes.NpgsqlPoint(x: 0.22630196518444468d, y: 0.40639931283667197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388539392190163d, y: 0.5642928510397599d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.545446590900523d, y: 0.8136611679714254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9628711013295793d, y: 0.9693723060826721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579863664577273d, y: 0.39796040889218665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4785251050660537d, y: 0.7539591902513954d), new NpgsqlTypes.NpgsqlPoint(x: 0.13515408924950612d, y: 0.43946838226216334d), new NpgsqlTypes.NpgsqlPoint(x: 0.00767037119485281d, y: 0.250536626413972d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9075152657511983d, y: 0.27946160541384835d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002488350135923d, y: 0.7499890102754071d), new NpgsqlTypes.NpgsqlPoint(x: 0.1849557960341509d, y: 0.3247539065752372d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6022920047978941d, y: 0.7154846185639441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418928018932514d, y: 0.48779850652056955d), new NpgsqlTypes.NpgsqlPoint(x: 0.19523404519187293d, y: 0.6764925916147647d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2781447867679213d, y: 0.8718031568866573d), new NpgsqlTypes.NpgsqlPoint(x: 0.46509041604777945d, y: 0.5948205383816865d), new NpgsqlTypes.NpgsqlPoint(x: 0.41640973300736306d, y: 0.2285843663344762d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5111307691867915d, y: 0.018677066845373402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369161794929478d, y: 0.7689446269849495d), new NpgsqlTypes.NpgsqlPoint(x: 0.4905397922080881d, y: 0.052061782002389534d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12714038122190863d, y: 0.6837201368262043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152699788592437d, y: 0.6402321037076699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056157426821301d, y: 0.6820161722643867d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32347996010515334d, y: 0.31129441890094034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923698250712496d, y: 0.813714480228363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8927410218583672d, y: 0.5915629449957911d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24334250758224885d, y: 0.6437975529672162d), new NpgsqlTypes.NpgsqlPoint(x: 0.47820042841213917d, y: 0.11593567770261415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181761937043542d, y: 0.1689806353380966d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.439342081118255d, y: 0.5336966043170288d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993822716455508d, y: 0.04500232258675019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304983613346489d, y: 0.9716358711031859d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21401607263302658d, y: 0.2952895851166678d), new NpgsqlTypes.NpgsqlPoint(x: 0.42025753361348306d, y: 0.3491466519520027d), new NpgsqlTypes.NpgsqlPoint(x: 0.22290859657549966d, y: 0.10531430200890923d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7024124433073395d, y: 0.9239926529626704d), new NpgsqlTypes.NpgsqlPoint(x: 0.10186857061481969d, y: 0.12120973380120892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551188817660642d, y: 0.34821788937987586d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13176233135373117d, y: 0.9985811635165381d), new NpgsqlTypes.NpgsqlPoint(x: 0.007540825080165403d, y: 0.4190470044285398d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520206796605174d, y: 0.6285470892355595d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.044875113833753755d, y: 0.41123902245229527d), new NpgsqlTypes.NpgsqlPoint(x: 0.11888711661387386d, y: 0.442972155353192d), new NpgsqlTypes.NpgsqlPoint(x: 0.3763735465029068d, y: 0.49952009979812506d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22495912725542289d, y: 0.21340232601796194d), new NpgsqlTypes.NpgsqlPoint(x: 0.11153256534509692d, y: 0.9995448321361199d), new NpgsqlTypes.NpgsqlPoint(x: 0.2457688763304533d, y: 0.7117361233553776d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.709783420694132d, y: 0.284808401484544d), new NpgsqlTypes.NpgsqlPoint(x: 0.13781095167723367d, y: 0.84906231567458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927924068491514d, y: 0.13226796094747695d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.535154782659057d, y: 0.22430091690257037d), new NpgsqlTypes.NpgsqlPoint(x: 0.31925326713498103d, y: 0.045086957820659634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2333829937965176d, y: 0.1615635143450609d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7485432930958816d, y: 0.7385761515537508d), new NpgsqlTypes.NpgsqlPoint(x: 0.48819655185442534d, y: 0.6466239486813304d), new NpgsqlTypes.NpgsqlPoint(x: 0.40301911508607924d, y: 0.028496624735321552d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18857381414731922d, y: 0.37807603497751663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993845268520922d, y: 0.7395573397556372d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084759502925208d, y: 0.5138853081847782d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01518089119255317d, y: 0.6545600031614411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468298640392485d, y: 0.516648506384087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511591911132691d, y: 0.42602149302693426d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48728027522980577d, y: 0.6312545885013678d), new NpgsqlTypes.NpgsqlPoint(x: 0.14630774904963673d, y: 0.2962134086367879d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137257161794148d, y: 0.7934911018292655d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8363489245040295d, y: 0.7413131577978642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133719558123798d, y: 0.16786855735086736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599616504891807d, y: 0.06441058494858731d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((193)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7801502245275796d, y: 0.9621648286981411d), new NpgsqlTypes.NpgsqlPoint(x: 0.04498733266457455d, y: 0.8092917085465478d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374276508670246d, y: 0.5932565686454526d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI), typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

