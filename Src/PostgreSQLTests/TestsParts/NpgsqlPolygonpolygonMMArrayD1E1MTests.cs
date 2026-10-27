

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD1
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD1 : INpgsqlPolygonMArraypolygonMMArrayD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD1E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD1E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1682952531973234d, y: 0.9376692417528055d), new NpgsqlTypes.NpgsqlPoint(x: 0.5634830756258207d, y: 0.4420326503279669d), new NpgsqlTypes.NpgsqlPoint(x: 0.1397791422651279d, y: 0.6858499590762185d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8241007744977793d, y: 0.45884839626309826d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435671582075867d, y: 0.7260498846433762d), new NpgsqlTypes.NpgsqlPoint(x: 0.3918668293143479d, y: 0.5357526588300712d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6102399101526288d, y: 0.587971728726475d), new NpgsqlTypes.NpgsqlPoint(x: 0.07871667182982012d, y: 0.37379279403606047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7181324426379468d, y: 0.5166851316776542d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.970114409170869d, y: 0.4789641234021301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161551484482925d, y: 0.3013249200734307d), new NpgsqlTypes.NpgsqlPoint(x: 0.808823368789005d, y: 0.9597135573844882d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43668368171777994d, y: 0.3557784027901163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7710381760680666d, y: 0.8668260467703249d), new NpgsqlTypes.NpgsqlPoint(x: 0.2044095617406877d, y: 0.6225708142228638d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8622618283447606d, y: 0.029633546718706993d), new NpgsqlTypes.NpgsqlPoint(x: 0.2634783371862054d, y: 0.29352935922642565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5043980355628357d, y: 0.422882610205475d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03385813717662256d, y: 0.3263653806754644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127839991675481d, y: 0.10491215992896008d), new NpgsqlTypes.NpgsqlPoint(x: 0.485716074260361d, y: 0.22575509531644244d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012542238902631397d, y: 0.16789861980121434d), new NpgsqlTypes.NpgsqlPoint(x: 0.46203001030831226d, y: 0.9194097683711068d), new NpgsqlTypes.NpgsqlPoint(x: 0.25357551674325773d, y: 0.7550464250290635d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7845201099518456d, y: 0.2005735457799317d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720121482722843d, y: 0.4394964775314302d), new NpgsqlTypes.NpgsqlPoint(x: 0.34816380696574645d, y: 0.9658550366173497d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7223576568710215d, y: 0.08462400669625414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796649729460659d, y: 0.3439702268336018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7461572333526967d, y: 0.5376666387463244d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6067172144612668d, y: 0.21394522982200703d), new NpgsqlTypes.NpgsqlPoint(x: 0.09679252432849383d, y: 0.736494795666377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5182003452699653d, y: 0.28636574616646826d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8537034744513494d, y: 0.1176482685265785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679074153870716d, y: 0.6085620858839554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7714691420302908d, y: 0.4791283057632799d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4268180624316932d, y: 0.8619236001381232d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494860859395516d, y: 0.1304930259413627d), new NpgsqlTypes.NpgsqlPoint(x: 0.7478651592407345d, y: 0.24588462186536442d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3899326237754176d, y: 0.41453266542672573d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445490607270876d, y: 0.3409564494458317d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269545359680686d, y: 0.9136637347874458d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.984031011559703d, y: 0.09945507502810469d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281652180637837d, y: 0.5050053901601697d), new NpgsqlTypes.NpgsqlPoint(x: 0.24807244287354246d, y: 0.26312402645748145d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8671073401810958d, y: 0.20725886441842412d), new NpgsqlTypes.NpgsqlPoint(x: 0.22051072048563214d, y: 0.10473611420446827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803707013199718d, y: 0.9483433339101908d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017159166943916282d, y: 0.4447675918012892d), new NpgsqlTypes.NpgsqlPoint(x: 0.30029654503736125d, y: 0.841065836143525d), new NpgsqlTypes.NpgsqlPoint(x: 0.318348012313724d, y: 0.9509524506293935d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7526068293354151d, y: 0.6099713660775569d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531626182261101d, y: 0.9020854864657368d), new NpgsqlTypes.NpgsqlPoint(x: 0.19216715148403296d, y: 0.26326829415461683d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03987586572216073d, y: 0.6555182650802491d), new NpgsqlTypes.NpgsqlPoint(x: 0.5689964532981513d, y: 0.12237290243928467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8155995048912851d, y: 0.8873465006953792d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30219267807331196d, y: 0.767445830603966d), new NpgsqlTypes.NpgsqlPoint(x: 0.2567387385550822d, y: 0.7158759513752585d), new NpgsqlTypes.NpgsqlPoint(x: 0.721397933179026d, y: 0.9087556292333807d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.422203434194236d, y: 0.25487250197247235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477011963210673d, y: 0.8965654515984363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9424293528705359d, y: 0.701270514320925d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6998497021607489d, y: 0.5634849615737034d), new NpgsqlTypes.NpgsqlPoint(x: 0.3110482301489347d, y: 0.26611004370429114d), new NpgsqlTypes.NpgsqlPoint(x: 0.007643665410072331d, y: 0.09687754339412591d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2749932725377302d, y: 0.7057207100772939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554703878456224d, y: 0.1429661677132379d), new NpgsqlTypes.NpgsqlPoint(x: 0.08040443527685492d, y: 0.8133866185995625d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7031388185901866d, y: 0.3310559699664636d), new NpgsqlTypes.NpgsqlPoint(x: 0.6812283128078088d, y: 0.4120128888163628d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511537561074725d, y: 0.4333852616329209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03723430993459376d, y: 0.6035955432194273d), new NpgsqlTypes.NpgsqlPoint(x: 0.31151599124418994d, y: 0.8995677123649904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182220257085839d, y: 0.9127661380685747d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9373767424450938d, y: 0.9210884871777744d), new NpgsqlTypes.NpgsqlPoint(x: 0.09137060680636044d, y: 0.9782612449659781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4434497278395281d, y: 0.37389166649837824d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8010415403788437d, y: 0.7498411140408873d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040667569763462d, y: 0.45424358847022994d), new NpgsqlTypes.NpgsqlPoint(x: 0.4968826114351208d, y: 0.11494151048618617d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.194779080656875d, y: 0.40140246314531214d), new NpgsqlTypes.NpgsqlPoint(x: 0.3159276455756551d, y: 0.002423356972231283d), new NpgsqlTypes.NpgsqlPoint(x: 0.3680817458853125d, y: 0.6945762680699411d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45803509127883146d, y: 0.5619584016590504d), new NpgsqlTypes.NpgsqlPoint(x: 0.18076899522054302d, y: 0.44648996877434377d), new NpgsqlTypes.NpgsqlPoint(x: 0.32806098218089264d, y: 0.6619163116356747d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7007324156961697d, y: 0.47883860198070816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9705260365064439d, y: 0.8398601722276196d), new NpgsqlTypes.NpgsqlPoint(x: 0.9044394446760702d, y: 0.9286824867926197d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6079184817687324d, y: 0.5986111354167515d), new NpgsqlTypes.NpgsqlPoint(x: 0.29956532857230955d, y: 0.6405761038042961d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348649104943308d, y: 0.8460244728562868d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.892742647894433d, y: 0.7922289604351664d), new NpgsqlTypes.NpgsqlPoint(x: 0.4980234776883471d, y: 0.3024872954951364d), new NpgsqlTypes.NpgsqlPoint(x: 0.12821519486313981d, y: 0.2628901488676276d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5305272612180525d, y: 0.13586935200504535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8749997586694763d, y: 0.7505236472795553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642181831185659d, y: 0.2531766523144583d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5662974821229929d, y: 0.13391015271923912d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794742796570274d, y: 0.8590977933146813d), new NpgsqlTypes.NpgsqlPoint(x: 0.025603043707672524d, y: 0.842556351817373d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6776357937223364d, y: 0.34623745966028097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796350422901326d, y: 0.6657942995080228d), new NpgsqlTypes.NpgsqlPoint(x: 0.9897157322001814d, y: 0.8869158478962234d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45117525280601556d, y: 0.3579759377207068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550175929455454d, y: 0.7199967602428021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5969440610619362d, y: 0.7558735031037166d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23543481385766596d, y: 0.06780917674483122d), new NpgsqlTypes.NpgsqlPoint(x: 0.4608868036660341d, y: 0.09883925892740397d), new NpgsqlTypes.NpgsqlPoint(x: 0.5781159935027035d, y: 0.25376902689374403d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8118180751506079d, y: 0.11479263474974288d), new NpgsqlTypes.NpgsqlPoint(x: 0.0248579078945782d, y: 0.9911881381665513d), new NpgsqlTypes.NpgsqlPoint(x: 0.30591358044794115d, y: 0.42005314896411583d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25372096129801547d, y: 0.6098973288810602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6529021967993469d, y: 0.8319067236193554d), new NpgsqlTypes.NpgsqlPoint(x: 0.21944537226731786d, y: 0.895192435158816d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5428408045636677d, y: 0.6508350827572045d), new NpgsqlTypes.NpgsqlPoint(x: 0.04045267634174998d, y: 0.2916967986345467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595333572866926d, y: 0.983972180225456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8142308344169598d, y: 0.15020470516146722d), new NpgsqlTypes.NpgsqlPoint(x: 0.3119672349063257d, y: 0.10962041027685177d), new NpgsqlTypes.NpgsqlPoint(x: 0.1415720718510688d, y: 0.5574199563023801d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6895238263515574d, y: 0.3149173238615076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835949807772567d, y: 0.06349728734951632d), new NpgsqlTypes.NpgsqlPoint(x: 0.3279698745780869d, y: 0.27977120477351114d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.718677101169877d, y: 0.8294694331324117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329208382950433d, y: 0.2197490283878325d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606021529326031d, y: 0.832354041774167d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7912172267259974d, y: 0.4269308429589722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8212648116916391d, y: 0.1805150488893641d), new NpgsqlTypes.NpgsqlPoint(x: 0.9866517271205676d, y: 0.4381648749001915d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4216927164731298d, y: 0.1119054821997576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4933028352446166d, y: 0.47715839851299124d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908987296530202d, y: 0.8523525021152861d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3413203165405183d, y: 0.6739182163087091d), new NpgsqlTypes.NpgsqlPoint(x: 0.15629455840522666d, y: 0.8115791297259115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8112457566400029d, y: 0.36715963537926743d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9825831089351337d, y: 0.6555614184662665d), new NpgsqlTypes.NpgsqlPoint(x: 0.15794878471896745d, y: 0.10609588381391821d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739638029885499d, y: 0.35391449722103907d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1154115145955028d, y: 0.09168743862245077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9721048355380387d, y: 0.6202102577125068d), new NpgsqlTypes.NpgsqlPoint(x: 0.752389006558923d, y: 0.3479040131625093d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7036900057858885d, y: 0.9809039468403141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5101585099866907d, y: 0.9777285288554243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5860784982402172d, y: 0.9015141716229385d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6571998142680874d, y: 0.08117687055657608d), new NpgsqlTypes.NpgsqlPoint(x: 0.45230969146370026d, y: 0.43686625125367473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489427299881025d, y: 0.701911244747925d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03284930255309826d, y: 0.7390666251715952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750990795345079d, y: 0.4052586947494201d), new NpgsqlTypes.NpgsqlPoint(x: 0.3895629374461336d, y: 0.6044698189586708d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3706159430552063d, y: 0.2648274585878593d), new NpgsqlTypes.NpgsqlPoint(x: 0.12650876300618374d, y: 0.16473769732806098d), new NpgsqlTypes.NpgsqlPoint(x: 0.692265393370646d, y: 0.17404185051707022d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1337070600507828d, y: 0.790486056958434d), new NpgsqlTypes.NpgsqlPoint(x: 0.19753885242688862d, y: 0.7467628783879304d), new NpgsqlTypes.NpgsqlPoint(x: 0.1731831808423755d, y: 0.5799647293458207d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3760643019642237d, y: 0.3179504904303416d), new NpgsqlTypes.NpgsqlPoint(x: 0.49638529642876605d, y: 0.6875500319872958d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275066688638905d, y: 0.9652748459568089d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0016709513976396195d, y: 0.9599816995011833d), new NpgsqlTypes.NpgsqlPoint(x: 0.821945075313206d, y: 0.5648260308926966d), new NpgsqlTypes.NpgsqlPoint(x: 0.8377752157299474d, y: 0.31945051588119566d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34892546884960685d, y: 0.28724520141758236d), new NpgsqlTypes.NpgsqlPoint(x: 0.8640068598454201d, y: 0.5068020851490849d), new NpgsqlTypes.NpgsqlPoint(x: 0.16757901276661136d, y: 0.5926446010630682d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5210112103807437d, y: 0.5774819928001782d), new NpgsqlTypes.NpgsqlPoint(x: 0.9944643131848039d, y: 0.5349752587808103d), new NpgsqlTypes.NpgsqlPoint(x: 0.06376501961743497d, y: 0.5690164662580287d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.479274079024809d, y: 0.21379464511791935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5865644645580828d, y: 0.10485206997183383d), new NpgsqlTypes.NpgsqlPoint(x: 0.05471838902108328d, y: 0.2359668017355222d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6785293838874028d, y: 0.5093623072972878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322844850789063d, y: 0.4746450289917773d), new NpgsqlTypes.NpgsqlPoint(x: 0.8482649029714601d, y: 0.07210615156979816d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15752996046812817d, y: 0.32028300354489236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7399415094028969d, y: 0.6023431201485647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7030256097000186d, y: 0.6909536609193406d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8407509408874386d, y: 0.7881275947168557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4127446958037726d, y: 0.501754882169779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256153229463887d, y: 0.8412131680510754d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9118012494229097d, y: 0.04793405781097093d), new NpgsqlTypes.NpgsqlPoint(x: 0.9855707518838139d, y: 0.9081627760353456d), new NpgsqlTypes.NpgsqlPoint(x: 0.48082863434159684d, y: 0.3697306007979456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7489635552274176d, y: 0.2689217978437465d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373240914401727d, y: 0.8299736461346279d), new NpgsqlTypes.NpgsqlPoint(x: 0.418564338007992d, y: 0.04085135251387173d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12054020591268733d, y: 0.16623337145033723d), new NpgsqlTypes.NpgsqlPoint(x: 0.3479774923375146d, y: 0.49901036002366694d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241646251089489d, y: 0.43650298859784653d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34830715702697645d, y: 0.5841858984154338d), new NpgsqlTypes.NpgsqlPoint(x: 0.15771456412526164d, y: 0.16201772842966633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824924121711278d, y: 0.3221790981590914d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9148118052974297d, y: 0.22940684958548818d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431790958983264d, y: 0.19070155315750226d), new NpgsqlTypes.NpgsqlPoint(x: 0.17516531862274098d, y: 0.24232126549366695d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5855462704277471d, y: 0.9171087295406541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9077417423479733d, y: 0.07979770842872047d), new NpgsqlTypes.NpgsqlPoint(x: 0.4004966976552311d, y: 0.5812221900827497d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1164254900354752d, y: 0.7708818253221266d), new NpgsqlTypes.NpgsqlPoint(x: 0.47742133138807596d, y: 0.7237883160064982d), new NpgsqlTypes.NpgsqlPoint(x: 0.2688535546794679d, y: 0.3074228965544813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13207305426904925d, y: 0.9837539078960129d), new NpgsqlTypes.NpgsqlPoint(x: 0.3579149359324493d, y: 0.23819301701048812d), new NpgsqlTypes.NpgsqlPoint(x: 0.49012489927888636d, y: 0.9959849970300501d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3956534237343211d, y: 0.6624434721118216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316724755609829d, y: 0.9474002800345848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6882380658569125d, y: 0.18989545837563648d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7343110704043727d, y: 0.6362207984175469d), new NpgsqlTypes.NpgsqlPoint(x: 0.015932669673908162d, y: 0.019277515530954692d), new NpgsqlTypes.NpgsqlPoint(x: 0.02813080300647275d, y: 0.0905583103775851d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40010486506257337d, y: 0.3551034619764577d), new NpgsqlTypes.NpgsqlPoint(x: 0.33725776490666026d, y: 0.34400554473644573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652643189231652d, y: 0.3533032025917805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45896064340280684d, y: 0.43843334912734755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7055994259296997d, y: 0.24960950185317932d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600276162113408d, y: 0.7751443211384145d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04630950151419966d, y: 0.38878648679864913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351842665200597d, y: 0.6733108902038968d), new NpgsqlTypes.NpgsqlPoint(x: 0.38269716755975935d, y: 0.005991830457489855d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7265305341082942d, y: 0.8321352883188653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5845370846869575d, y: 0.7977231424199616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3186557855964406d, y: 0.6059865579310538d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7629514149958564d, y: 0.5680619443879127d), new NpgsqlTypes.NpgsqlPoint(x: 0.08435619530807748d, y: 0.6351632061214253d), new NpgsqlTypes.NpgsqlPoint(x: 0.4790965841819884d, y: 0.3548790640990005d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5707887845321116d, y: 0.36423055114465763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1660918398775858d, y: 0.7318926628142669d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531019290520908d, y: 0.3604443809324933d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9916852222242627d, y: 0.42381371797410794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9501149092734011d, y: 0.5727885244903222d), new NpgsqlTypes.NpgsqlPoint(x: 0.8147379254755037d, y: 0.28493718997814754d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1598947789392784d, y: 0.7093333941340878d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657804803402366d, y: 0.7950236205704315d), new NpgsqlTypes.NpgsqlPoint(x: 0.5713307938637744d, y: 0.3467575643179569d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30169227805833554d, y: 0.2043947058859238d), new NpgsqlTypes.NpgsqlPoint(x: 0.07446930273848484d, y: 0.03655514066279797d), new NpgsqlTypes.NpgsqlPoint(x: 0.1380435119456358d, y: 0.7594160876074875d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8748725475493675d, y: 0.2811046697938404d), new NpgsqlTypes.NpgsqlPoint(x: 0.036434609419694564d, y: 0.6762473232527807d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526366970276731d, y: 0.026996738049340552d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8508012114744192d, y: 0.5055631609526238d), new NpgsqlTypes.NpgsqlPoint(x: 0.41023352406267655d, y: 0.6804235450527281d), new NpgsqlTypes.NpgsqlPoint(x: 0.26431815494094946d, y: 0.06589210449552318d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37077006834648074d, y: 0.016705559210914767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6626076085269522d, y: 0.7312275240739502d), new NpgsqlTypes.NpgsqlPoint(x: 0.2958582163708512d, y: 0.44112723490965267d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6819573490528839d, y: 0.47933429440399433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5587468097264148d, y: 0.17532930676224512d), new NpgsqlTypes.NpgsqlPoint(x: 0.4709934345708233d, y: 0.5320379387079767d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19519923057471988d, y: 0.05034140634031825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459893825987104d, y: 0.008235642209918126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5999442535039349d, y: 0.7377817893747984d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7402273394438139d, y: 0.23946903406299647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7325766880605196d, y: 0.027911503751954614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9267554512377774d, y: 0.3226900358331859d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12614717374057527d, y: 0.5162481879591921d), new NpgsqlTypes.NpgsqlPoint(x: 0.02137424939557031d, y: 0.6768341291399615d), new NpgsqlTypes.NpgsqlPoint(x: 0.4163401358279192d, y: 0.5653938744515855d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.254543804991588d, y: 0.22256512925877658d), new NpgsqlTypes.NpgsqlPoint(x: 0.32404488553362254d, y: 0.04172685169741541d), new NpgsqlTypes.NpgsqlPoint(x: 0.04847011091651576d, y: 0.5905685696716445d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0030390929720052196d, y: 0.18212910291432738d), new NpgsqlTypes.NpgsqlPoint(x: 0.3547784021916751d, y: 0.5823600070904877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080798841419346d, y: 0.9953310047409741d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8121718001356366d, y: 0.008379054509132677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6879170724185343d, y: 0.3963384582718106d), new NpgsqlTypes.NpgsqlPoint(x: 0.05386623413201008d, y: 0.17181892209262728d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7363274816023586d, y: 0.5647749851916927d), new NpgsqlTypes.NpgsqlPoint(x: 0.4191973906991001d, y: 0.5642900015281984d), new NpgsqlTypes.NpgsqlPoint(x: 0.3709476852492787d, y: 0.1774184410009142d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04138063968591443d, y: 0.45061715563515947d), new NpgsqlTypes.NpgsqlPoint(x: 0.21892310393217385d, y: 0.32599308064598764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493173268952303d, y: 0.9428489586948321d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19505181512961522d, y: 0.38628711906746904d), new NpgsqlTypes.NpgsqlPoint(x: 0.46422426865509714d, y: 0.7628809479589035d), new NpgsqlTypes.NpgsqlPoint(x: 0.651150152937997d, y: 0.7447358109646982d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4446464807091227d, y: 0.05098357500421413d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998198523671184d, y: 0.5125591225087558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859403596494667d, y: 0.6941015023774676d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6275061878630293d, y: 0.5044403463793724d), new NpgsqlTypes.NpgsqlPoint(x: 0.08939634637577432d, y: 0.602540373519067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781498343603594d, y: 0.8009004575919041d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6986130609324237d, y: 0.6088507134731486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875917680148276d, y: 0.3781307903595431d), new NpgsqlTypes.NpgsqlPoint(x: 0.3467005481322677d, y: 0.28093605937293564d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6984670299745045d, y: 0.3635800425623378d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911827621153506d, y: 0.46049100838171575d), new NpgsqlTypes.NpgsqlPoint(x: 0.28759566739028586d, y: 0.2658721084590461d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6517016991778295d, y: 0.9214677768009361d), new NpgsqlTypes.NpgsqlPoint(x: 0.15504492923037771d, y: 0.1424461749197422d), new NpgsqlTypes.NpgsqlPoint(x: 0.35206603256063007d, y: 0.20929289898238923d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3769542237153314d, y: 0.8019991981799938d), new NpgsqlTypes.NpgsqlPoint(x: 0.30645520617972555d, y: 0.4673505593289775d), new NpgsqlTypes.NpgsqlPoint(x: 0.004237768956545596d, y: 0.07261011139123641d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23917636919132668d, y: 0.36933109032109646d), new NpgsqlTypes.NpgsqlPoint(x: 0.46717259836447267d, y: 0.4188511202956853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5745313742814153d, y: 0.8563102009837666d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.397506228284214d, y: 0.6845151206398437d), new NpgsqlTypes.NpgsqlPoint(x: 0.05230668087041501d, y: 0.7910532888384583d), new NpgsqlTypes.NpgsqlPoint(x: 0.028928068258300854d, y: 0.2616195028954055d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7596013348926326d, y: 0.46082696284135816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3798532255516962d, y: 0.20916835900355235d), new NpgsqlTypes.NpgsqlPoint(x: 0.40910176416759636d, y: 0.917470173963059d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8400646074808926d, y: 0.809872031838509d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581152677330603d, y: 0.7500600747479569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729853239272269d, y: 0.1774970551160231d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05914906482073623d, y: 0.944540720032272d), new NpgsqlTypes.NpgsqlPoint(x: 0.4369509998191028d, y: 0.6052217585713979d), new NpgsqlTypes.NpgsqlPoint(x: 0.07360454447677434d, y: 0.5313324521025076d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16250138212489973d, y: 0.9670590981018901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701990742811653d, y: 0.8170757735965671d), new NpgsqlTypes.NpgsqlPoint(x: 0.1689977451593192d, y: 0.2988550597036831d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22059754062135317d, y: 0.8989590278609307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232024844165212d, y: 0.4125761378337659d), new NpgsqlTypes.NpgsqlPoint(x: 0.40607661029485154d, y: 0.9811230778572393d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8718627846770814d, y: 0.5316832782376293d), new NpgsqlTypes.NpgsqlPoint(x: 0.2406691481384029d, y: 0.7029059665549713d), new NpgsqlTypes.NpgsqlPoint(x: 0.20181684099548214d, y: 0.29261763917306416d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47413875305872744d, y: 0.9988651281271586d), new NpgsqlTypes.NpgsqlPoint(x: 0.3443299038237958d, y: 0.2204229372949874d), new NpgsqlTypes.NpgsqlPoint(x: 0.9201226858767662d, y: 0.6590926493560446d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6763843575401445d, y: 0.8054078870022914d), new NpgsqlTypes.NpgsqlPoint(x: 0.19459361647593587d, y: 0.7037281583714444d), new NpgsqlTypes.NpgsqlPoint(x: 0.21021502779745382d, y: 0.128411411115822d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49206725653952677d, y: 0.6101618352091255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851723149208334d, y: 0.7954993720553865d), new NpgsqlTypes.NpgsqlPoint(x: 0.16327606361324476d, y: 0.769248748242613d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21728383173839183d, y: 0.5397568276279223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066109489751757d, y: 0.8627927661303284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3515659043997701d, y: 0.34125440405197016d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8463387512374853d, y: 0.3968665644279227d), new NpgsqlTypes.NpgsqlPoint(x: 0.3366729089223873d, y: 0.7294065983477395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5300840338964941d, y: 0.14102433129503988d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38595186082075394d, y: 0.6786363561949681d), new NpgsqlTypes.NpgsqlPoint(x: 0.7919466307812243d, y: 0.5964027312226015d), new NpgsqlTypes.NpgsqlPoint(x: 0.20894539844045434d, y: 0.5129867744583206d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.89476413669473d, y: 0.9037451184665957d), new NpgsqlTypes.NpgsqlPoint(x: 0.5152718869692452d, y: 0.028274723361802923d), new NpgsqlTypes.NpgsqlPoint(x: 0.49242917510127027d, y: 0.3559099188305963d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5758792223391574d, y: 0.06634878151338008d), new NpgsqlTypes.NpgsqlPoint(x: 0.2340400044433283d, y: 0.2527288542843351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472740459427619d, y: 0.17873974602758902d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6006216729504629d, y: 0.7027537394190485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139087243374301d, y: 0.5684804335159284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837954026181593d, y: 0.6515384537927061d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3953546679901172d, y: 0.6048327443508318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6312748787081762d, y: 0.7088345954400894d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013082321805137d, y: 0.0243047432698833d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1700157775560568d, y: 0.8024701689831037d), new NpgsqlTypes.NpgsqlPoint(x: 0.45490304113890523d, y: 0.32632742964111094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8200600418556112d, y: 0.3802709496755845d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45468585680947493d, y: 0.7035098030014875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256785664240322d, y: 0.2257970269295525d), new NpgsqlTypes.NpgsqlPoint(x: 0.028222069886602585d, y: 0.37998940418724303d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3338337913234125d, y: 0.006542946673863348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867336217092478d, y: 0.7248469294055336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117248818853072d, y: 0.6852380717337994d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02495408209597305d, y: 0.9534175995328558d), new NpgsqlTypes.NpgsqlPoint(x: 0.15907222861377668d, y: 0.16921334783494912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7182890564750305d, y: 0.22580356332494111d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2641297381570137d, y: 0.3771650169225841d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728096677469965d, y: 0.752800446269164d), new NpgsqlTypes.NpgsqlPoint(x: 0.06333674605924877d, y: 0.45512086407343755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1287257943672725d, y: 0.13407742472753315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9893874622922928d, y: 0.8796925905123439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403415559334156d, y: 0.5390160038668473d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5082024697962714d, y: 0.7683015119522846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7347629668035988d, y: 0.6218882939679791d), new NpgsqlTypes.NpgsqlPoint(x: 0.42681560544524233d, y: 0.24886468872294898d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0594502217363001d, y: 0.8163384899251134d), new NpgsqlTypes.NpgsqlPoint(x: 0.46663457719683743d, y: 0.33265458878446175d), new NpgsqlTypes.NpgsqlPoint(x: 0.14965397760168164d, y: 0.3508272103874893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2802178139042788d, y: 0.11200198076517642d), new NpgsqlTypes.NpgsqlPoint(x: 0.186674744302878d, y: 0.2519918943498113d), new NpgsqlTypes.NpgsqlPoint(x: 0.8999642211531006d, y: 0.3835070536595737d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6017099150223658d, y: 0.2773363136320849d), new NpgsqlTypes.NpgsqlPoint(x: 0.3298577088650717d, y: 0.6960810037417521d), new NpgsqlTypes.NpgsqlPoint(x: 0.8927386791557664d, y: 0.6167927834147019d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14207284006329235d, y: 0.29387044858028266d), new NpgsqlTypes.NpgsqlPoint(x: 0.904329958844862d, y: 0.6786086604793243d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018977958276386042d, y: 0.9820891586643072d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2982378370695491d, y: 0.09292720828861478d), new NpgsqlTypes.NpgsqlPoint(x: 0.19857589901189432d, y: 0.5147319669790854d), new NpgsqlTypes.NpgsqlPoint(x: 0.04685719435458391d, y: 0.5397959084311265d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9458905160694865d, y: 0.4342982133672362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825922631339786d, y: 0.8167831066428773d), new NpgsqlTypes.NpgsqlPoint(x: 0.0941501316654435d, y: 0.018704793424204835d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7092773707985088d, y: 0.2782726140820472d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282598141432541d, y: 0.3596689911097779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4478476442563454d, y: 0.7941395522116874d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06950898751669776d, y: 0.4993960768536968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8887297049075503d, y: 0.2597422490096656d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469880210523687d, y: 0.838320697042839d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8168995294206691d, y: 0.7162457054928183d), new NpgsqlTypes.NpgsqlPoint(x: 0.6075607344707065d, y: 0.7108098420326628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5594012254445637d, y: 0.5666926237647795d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48768589902976434d, y: 0.7812654230861348d), new NpgsqlTypes.NpgsqlPoint(x: 0.80902672821544d, y: 0.3540665947303403d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887531523823528d, y: 0.9395248810858615d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8755912662970529d, y: 0.04982294846558455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4777525607279147d, y: 0.5339044440300398d), new NpgsqlTypes.NpgsqlPoint(x: 0.35607693943812346d, y: 0.2098132160731606d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11519047665062421d, y: 0.9342631375621765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5912076264078083d, y: 0.321058587775782d), new NpgsqlTypes.NpgsqlPoint(x: 0.06390773670542982d, y: 0.6827456022519303d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8330271046725595d, y: 0.6766155512432566d), new NpgsqlTypes.NpgsqlPoint(x: 0.20637558040909842d, y: 0.6442885086790344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4293367682457253d, y: 0.6376515499771264d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2835437236987035d, y: 0.5535006082659772d), new NpgsqlTypes.NpgsqlPoint(x: 0.7787148966931647d, y: 0.7474460745829691d), new NpgsqlTypes.NpgsqlPoint(x: 0.8594065078912594d, y: 0.601764031914935d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3844806260631296d, y: 0.2913765414725866d), new NpgsqlTypes.NpgsqlPoint(x: 0.18935791389425838d, y: 0.9230299017545609d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418107411492058d, y: 0.5279615729959634d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6969562006932963d, y: 0.8365869856930341d), new NpgsqlTypes.NpgsqlPoint(x: 0.7126279986626556d, y: 0.603815910164531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9380997551853786d, y: 0.9468399620131077d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8401194695997414d, y: 0.648302353105238d), new NpgsqlTypes.NpgsqlPoint(x: 0.0964575835429955d, y: 0.13047953697730996d), new NpgsqlTypes.NpgsqlPoint(x: 0.28226873531637264d, y: 0.427263201128539d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2274083830160024d, y: 0.31644818520235973d), new NpgsqlTypes.NpgsqlPoint(x: 0.4423139261903981d, y: 0.7098740122909346d), new NpgsqlTypes.NpgsqlPoint(x: 0.14359399933865147d, y: 0.2528485135170848d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9131372154315498d, y: 0.15853664383283406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766476344128893d, y: 0.2403051321902917d), new NpgsqlTypes.NpgsqlPoint(x: 0.3591464056216508d, y: 0.659892324853372d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01095668899229929d, y: 0.2998487354201649d), new NpgsqlTypes.NpgsqlPoint(x: 0.364946033008569d, y: 0.5503375033873648d), new NpgsqlTypes.NpgsqlPoint(x: 0.7635797865463556d, y: 0.055645001438802355d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7348526876732289d, y: 0.5532133416379756d), new NpgsqlTypes.NpgsqlPoint(x: 0.12463589664496988d, y: 0.8985600783984916d), new NpgsqlTypes.NpgsqlPoint(x: 0.008560084242968724d, y: 0.570128739400302d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04553652613162584d, y: 0.8234085884284249d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533930835431446d, y: 0.7353858785655181d), new NpgsqlTypes.NpgsqlPoint(x: 0.044559434713801194d, y: 0.9628129493724298d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04884565862134704d, y: 0.8543285025528573d), new NpgsqlTypes.NpgsqlPoint(x: 0.7126223079902885d, y: 0.9395066334568043d), new NpgsqlTypes.NpgsqlPoint(x: 0.4572219714971474d, y: 0.8131429713443549d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4424632449909075d, y: 0.7398487748045183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9809606640219769d, y: 0.222524538734017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6740541164069118d, y: 0.6001671995148794d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019423390405981955d, y: 0.27633784792902183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9542971126449482d, y: 0.8488338896755532d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045749417899702d, y: 0.7972687680807842d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7621878628364903d, y: 0.2113953100928443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8895912996797622d, y: 0.37949813492820306d), new NpgsqlTypes.NpgsqlPoint(x: 0.024160131714555333d, y: 0.8266780762186153d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39157925398545024d, y: 0.4533258385283345d), new NpgsqlTypes.NpgsqlPoint(x: 0.2287305180569873d, y: 0.8904347664352998d), new NpgsqlTypes.NpgsqlPoint(x: 0.23041724231934624d, y: 0.21248660005343945d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20736442759137708d, y: 0.7349702068218105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693096852638233d, y: 0.24373762258866016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396833650969187d, y: 0.9898701035337869d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7372470734712454d, y: 0.4571905045812821d), new NpgsqlTypes.NpgsqlPoint(x: 0.516149372120404d, y: 0.3557934588553082d), new NpgsqlTypes.NpgsqlPoint(x: 0.678169092584448d, y: 0.14016923993141184d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3270269764169874d, y: 0.2923535391047234d), new NpgsqlTypes.NpgsqlPoint(x: 0.17620842226643596d, y: 0.375769221794954d), new NpgsqlTypes.NpgsqlPoint(x: 0.13600884096030275d, y: 0.9804897401327869d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22389519332652397d, y: 0.28693333718384784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556532938371783d, y: 0.324108628978522d), new NpgsqlTypes.NpgsqlPoint(x: 0.08479619807813876d, y: 0.6371827886276622d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25046387968269823d, y: 0.5868359248122025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7640381265308234d, y: 0.7416653800143612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5948077941164207d, y: 0.4545795599913818d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6346416061046439d, y: 0.6284062747715046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471294301518924d, y: 0.790172034195831d), new NpgsqlTypes.NpgsqlPoint(x: 0.005300133472471047d, y: 0.7735359887682466d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17347944404389448d, y: 0.9628973720218481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856328187723014d, y: 0.34030959986155007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651444732747624d, y: 0.7981800784083694d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8516395105779002d, y: 0.5258848627761578d), new NpgsqlTypes.NpgsqlPoint(x: 0.2967458706283649d, y: 0.8537191916015362d), new NpgsqlTypes.NpgsqlPoint(x: 0.8025542504626327d, y: 0.3631489414419018d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0897623644564578d, y: 0.5059210495861087d), new NpgsqlTypes.NpgsqlPoint(x: 0.3202038075909205d, y: 0.49750779487470276d), new NpgsqlTypes.NpgsqlPoint(x: 0.21308359448931335d, y: 0.30315141705582893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8345920525168214d, y: 0.1979066689130562d), new NpgsqlTypes.NpgsqlPoint(x: 0.0749217326798004d, y: 0.12928731503953084d), new NpgsqlTypes.NpgsqlPoint(x: 0.07471730737864402d, y: 0.18457722013007505d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1543881972685932d, y: 0.39149786387202223d), new NpgsqlTypes.NpgsqlPoint(x: 0.20631345977932258d, y: 0.9610097966779216d), new NpgsqlTypes.NpgsqlPoint(x: 0.9979997497149468d, y: 0.33641823360126755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24816108936395276d, y: 0.8793461954664029d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219304023285498d, y: 0.17705963464104157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242274342273141d, y: 0.34822415039554866d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.701346226582639d, y: 0.1326648525893941d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400538269946091d, y: 0.6501755586348714d), new NpgsqlTypes.NpgsqlPoint(x: 0.922810413762572d, y: 0.24974529731358142d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.421659705058021d, y: 0.03707339782403318d), new NpgsqlTypes.NpgsqlPoint(x: 0.2059427694542889d, y: 0.3471896589753781d), new NpgsqlTypes.NpgsqlPoint(x: 0.3744054252821184d, y: 0.8825311473422149d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5329055132689985d, y: 0.9858011311828295d), new NpgsqlTypes.NpgsqlPoint(x: 0.46358008011945384d, y: 0.2945235727341605d), new NpgsqlTypes.NpgsqlPoint(x: 0.371519838768691d, y: 0.6384144080848209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.002460657854393089d, y: 0.5865208789433572d), new NpgsqlTypes.NpgsqlPoint(x: 0.9610261012572542d, y: 0.7629625078437817d), new NpgsqlTypes.NpgsqlPoint(x: 0.07945941626096942d, y: 0.9697304578403944d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6632248903116318d, y: 0.2082096939478021d), new NpgsqlTypes.NpgsqlPoint(x: 0.8598267306219926d, y: 0.8926454216512397d), new NpgsqlTypes.NpgsqlPoint(x: 0.2061095181591852d, y: 0.5726817797958252d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36944196168488475d, y: 0.7235203982549769d), new NpgsqlTypes.NpgsqlPoint(x: 0.7077319240760056d, y: 0.8671371360686462d), new NpgsqlTypes.NpgsqlPoint(x: 0.32855029263368696d, y: 0.7906710644368017d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.282337889608654d, y: 0.941878544543733d), new NpgsqlTypes.NpgsqlPoint(x: 0.13044576289863075d, y: 0.8557805200811285d), new NpgsqlTypes.NpgsqlPoint(x: 0.356180873292547d, y: 0.2781719524863382d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5523218734977563d, y: 0.5161492209278613d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798169117440974d, y: 0.7667962282871825d), new NpgsqlTypes.NpgsqlPoint(x: 0.3240976125898256d, y: 0.41337984441898024d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906423749631557d, y: 0.03141802646564995d), new NpgsqlTypes.NpgsqlPoint(x: 0.1844238806175157d, y: 0.7916378265310988d), new NpgsqlTypes.NpgsqlPoint(x: 0.32473856436175397d, y: 0.14116666201624117d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3852019622715923d, y: 0.33897962668675696d), new NpgsqlTypes.NpgsqlPoint(x: 0.1454040833225273d, y: 0.060008193919875996d), new NpgsqlTypes.NpgsqlPoint(x: 0.5318870538032688d, y: 0.001878169029491339d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47277697542608277d, y: 0.5023363321532751d), new NpgsqlTypes.NpgsqlPoint(x: 0.17770211166959782d, y: 0.25710271009319696d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902276923069637d, y: 0.7317754408893373d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2791916536620983d, y: 0.8591936387150824d), new NpgsqlTypes.NpgsqlPoint(x: 0.6120966251929896d, y: 0.45333215577886554d), new NpgsqlTypes.NpgsqlPoint(x: 0.997347950480798d, y: 0.9410388382585395d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7661820752046821d, y: 0.40720360608002626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7616533428360829d, y: 0.603302842222784d), new NpgsqlTypes.NpgsqlPoint(x: 0.22553531575475327d, y: 0.45115060016162256d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3380427044916925d, y: 0.07080343550983903d), new NpgsqlTypes.NpgsqlPoint(x: 0.36098945946269423d, y: 0.6224842830574093d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394702111112392d, y: 0.3990115410688493d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7449948246101522d, y: 0.6658283637792692d), new NpgsqlTypes.NpgsqlPoint(x: 0.3945000709141746d, y: 0.8213276927780522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9428033393552551d, y: 0.17698963830727032d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7421069498679495d, y: 0.5843680875708627d), new NpgsqlTypes.NpgsqlPoint(x: 0.039221477727238385d, y: 0.46103569597195937d), new NpgsqlTypes.NpgsqlPoint(x: 0.9806056065522988d, y: 0.19272922910220314d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4370004108100094d, y: 0.19313645165568982d), new NpgsqlTypes.NpgsqlPoint(x: 0.27529405467848234d, y: 0.11486032533145485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711803073775251d, y: 0.741539837465964d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6279227993950683d, y: 0.6034023978445506d), new NpgsqlTypes.NpgsqlPoint(x: 0.1732222777632888d, y: 0.9661372222036795d), new NpgsqlTypes.NpgsqlPoint(x: 0.2698304530378034d, y: 0.9933247251961427d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8379326698608154d, y: 0.857105755461893d), new NpgsqlTypes.NpgsqlPoint(x: 0.46034113837075197d, y: 0.0881535898432404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514811389837369d, y: 0.7247960334491018d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37299208551538054d, y: 0.06078667114731473d), new NpgsqlTypes.NpgsqlPoint(x: 0.8887799934768009d, y: 0.35859407623607875d), new NpgsqlTypes.NpgsqlPoint(x: 0.1702911003233143d, y: 0.759545214552009d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8424906158363784d, y: 0.6344339434903001d), new NpgsqlTypes.NpgsqlPoint(x: 0.21485824125921027d, y: 0.8560125260919935d), new NpgsqlTypes.NpgsqlPoint(x: 0.36711495444929276d, y: 0.7572756764880368d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6581523001970897d, y: 0.938891470930649d), new NpgsqlTypes.NpgsqlPoint(x: 0.04408374561714612d, y: 0.4132506754174312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8287312402041973d, y: 0.5862684491343372d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9407848234361988d, y: 0.6248443156623791d), new NpgsqlTypes.NpgsqlPoint(x: 0.38592750927852804d, y: 0.7324109732943226d), new NpgsqlTypes.NpgsqlPoint(x: 0.08069775880114904d, y: 0.10256780614519112d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3411122219540058d, y: 0.25626052599175686d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454067748298163d, y: 0.3918303993837111d), new NpgsqlTypes.NpgsqlPoint(x: 0.10044074739082709d, y: 0.86215010064126d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6283352783842662d, y: 0.2079254374885119d), new NpgsqlTypes.NpgsqlPoint(x: 0.10458960435608389d, y: 0.2719415697623273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687888136331771d, y: 0.13118761521866806d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0023926543533574485d, y: 0.9320134972489114d), new NpgsqlTypes.NpgsqlPoint(x: 0.4956989905186082d, y: 0.8053809578678938d), new NpgsqlTypes.NpgsqlPoint(x: 0.49194780206865263d, y: 0.4335924319094888d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6438935838048127d, y: 0.17405140636716698d), new NpgsqlTypes.NpgsqlPoint(x: 0.012415338801420539d, y: 0.798513441607841d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816439816257568d, y: 0.790741081817244d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7995919141295728d, y: 0.1775812548194705d), new NpgsqlTypes.NpgsqlPoint(x: 0.4556311462377054d, y: 0.7897976711312774d), new NpgsqlTypes.NpgsqlPoint(x: 0.07261093878997227d, y: 0.1399678581585153d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39675408546358604d, y: 0.048209681120545134d), new NpgsqlTypes.NpgsqlPoint(x: 0.627935535476248d, y: 0.7417823625035616d), new NpgsqlTypes.NpgsqlPoint(x: 0.659678018935931d, y: 0.37431526488695044d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03981476450153831d, y: 0.846831455178561d), new NpgsqlTypes.NpgsqlPoint(x: 0.35265094800039376d, y: 0.6740840918969624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579271113556201d, y: 0.8144511065800751d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23230508099684777d, y: 0.14214858778284156d), new NpgsqlTypes.NpgsqlPoint(x: 0.3531853594249521d, y: 0.8244010155703487d), new NpgsqlTypes.NpgsqlPoint(x: 0.33796497419547267d, y: 0.3207083787397714d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8274696569830765d, y: 0.771663532129972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6543795807675945d, y: 0.4401048330190962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646836573250119d, y: 0.6007744136329334d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11605211616608402d, y: 0.20766034886250273d), new NpgsqlTypes.NpgsqlPoint(x: 0.972537907164112d, y: 0.13409257196357727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7996142000229882d, y: 0.6936445035301037d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3263616477593442d, y: 0.45280600888610945d), new NpgsqlTypes.NpgsqlPoint(x: 0.2885061653395521d, y: 0.6384832250875169d), new NpgsqlTypes.NpgsqlPoint(x: 0.04578375533774792d, y: 0.9767445814101084d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6846849902982953d, y: 0.09771662276302606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852313437709662d, y: 0.5792741048846208d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648781302256644d, y: 0.8736220195581959d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9316793080069105d, y: 0.3971107323591391d), new NpgsqlTypes.NpgsqlPoint(x: 0.26307587499580776d, y: 0.2623951728145023d), new NpgsqlTypes.NpgsqlPoint(x: 0.7405020545228045d, y: 0.9829169740922699d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7029329052281921d, y: 0.44671623091203894d), new NpgsqlTypes.NpgsqlPoint(x: 0.8667948186836416d, y: 0.6795410772602983d), new NpgsqlTypes.NpgsqlPoint(x: 0.706417043882447d, y: 0.577936880015113d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1569446722450365d, y: 0.923445648556856d), new NpgsqlTypes.NpgsqlPoint(x: 0.29447336485638875d, y: 0.004033270910314246d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464878581093552d, y: 0.8315694378647044d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8081213890908377d, y: 0.2950956470325159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758631564901706d, y: 0.7112595246961274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106532404321168d, y: 0.6963305894289786d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17828939355787798d, y: 0.9275336038722694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6484610201166462d, y: 0.6738810957307603d), new NpgsqlTypes.NpgsqlPoint(x: 0.4024283598186007d, y: 0.23388868555065667d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01951652213394428d, y: 0.5871433876419618d), new NpgsqlTypes.NpgsqlPoint(x: 0.3897719650398618d, y: 0.5225350691512856d), new NpgsqlTypes.NpgsqlPoint(x: 0.17964200811762965d, y: 0.544410138308868d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8828100353616205d, y: 0.5026191661553431d), new NpgsqlTypes.NpgsqlPoint(x: 0.987649326468794d, y: 0.10849792955503479d), new NpgsqlTypes.NpgsqlPoint(x: 0.36053295992154366d, y: 0.2150013411656847d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13296813308818178d, y: 0.7038033060646054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454717999584327d, y: 0.015637841249298567d), new NpgsqlTypes.NpgsqlPoint(x: 0.6453870684820378d, y: 0.08977477947924939d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4887626912526313d, y: 0.12311600468625639d), new NpgsqlTypes.NpgsqlPoint(x: 0.060779601242681d, y: 0.6180968324087257d), new NpgsqlTypes.NpgsqlPoint(x: 0.04515228988088482d, y: 0.08775991955904205d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8173067921652466d, y: 0.780014816282359d), new NpgsqlTypes.NpgsqlPoint(x: 0.17510056662426066d, y: 0.28930049552682213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6187449245653579d, y: 0.9766206536042094d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7654389940272743d, y: 0.3139797742685908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9660468617450403d, y: 0.30582082348299655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7405090554920081d, y: 0.6178145012364777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5253981156152399d, y: 0.9147059256163532d), new NpgsqlTypes.NpgsqlPoint(x: 0.3256102050803882d, y: 0.43621871814425817d), new NpgsqlTypes.NpgsqlPoint(x: 0.25243822035057606d, y: 0.19985299531546308d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6980881991612419d, y: 0.7049788488294776d), new NpgsqlTypes.NpgsqlPoint(x: 0.01569933192452122d, y: 0.2842814618993067d), new NpgsqlTypes.NpgsqlPoint(x: 0.054948186327817616d, y: 0.16993246074182333d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6221104541647914d, y: 0.7647267339341299d), new NpgsqlTypes.NpgsqlPoint(x: 0.18454256684582304d, y: 0.21425101058928242d), new NpgsqlTypes.NpgsqlPoint(x: 0.3674485816994437d, y: 0.19312697127554923d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22321160419735642d, y: 0.6807983808988436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245935857235028d, y: 0.6192253754480411d), new NpgsqlTypes.NpgsqlPoint(x: 0.2408300591236633d, y: 0.13193208970526238d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7287101700179335d, y: 0.290619009301899d), new NpgsqlTypes.NpgsqlPoint(x: 0.31340248601707954d, y: 0.9223130360473425d), new NpgsqlTypes.NpgsqlPoint(x: 0.12343576196154615d, y: 0.6584652802863162d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7419420184877696d, y: 0.34487808453484825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536470903926219d, y: 0.9495488288010968d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542203462918104d, y: 0.2764253222457873d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5854965446122187d, y: 0.6334173384032377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642522339559573d, y: 0.6150060233248998d), new NpgsqlTypes.NpgsqlPoint(x: 0.43168209386588385d, y: 0.5099311116035765d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5378038646381702d, y: 0.48007020484053053d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356742553222834d, y: 0.8086160443488344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5254195598723276d, y: 0.03984887364019596d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7165823674839752d, y: 0.14128546909353368d), new NpgsqlTypes.NpgsqlPoint(x: 0.822496453238172d, y: 0.33533565045981606d), new NpgsqlTypes.NpgsqlPoint(x: 0.1918510940482394d, y: 0.3529568262784166d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0028128223538919084d, y: 0.7188216241392019d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320593837713453d, y: 0.8502449217728797d), new NpgsqlTypes.NpgsqlPoint(x: 0.3372763005031113d, y: 0.39654910226091933d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2195681889234734d, y: 0.08395836912979415d), new NpgsqlTypes.NpgsqlPoint(x: 0.08680486557732259d, y: 0.6861794013064607d), new NpgsqlTypes.NpgsqlPoint(x: 0.16649477612056607d, y: 0.883458970841723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09577397993161996d, y: 0.036537656232435656d), new NpgsqlTypes.NpgsqlPoint(x: 0.26253109199403823d, y: 0.7683974391099785d), new NpgsqlTypes.NpgsqlPoint(x: 0.17267884014214996d, y: 0.6044991241050977d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8087627467124766d, y: 0.02271353472206905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7717502686012041d, y: 0.49677456938222064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276527124794827d, y: 0.8187262036162841d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6316148900254737d, y: 0.17812742404536952d), new NpgsqlTypes.NpgsqlPoint(x: 0.21999776786601222d, y: 0.13332258621768822d), new NpgsqlTypes.NpgsqlPoint(x: 0.15971089335800004d, y: 0.06941708553911774d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.277845884872741d, y: 0.8978468090413659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7392223082851298d, y: 0.36468300124435316d), new NpgsqlTypes.NpgsqlPoint(x: 0.21522922455125304d, y: 0.029873463140265843d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07869612428802686d, y: 0.11207946872096419d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145654125038461d, y: 0.746224772392735d), new NpgsqlTypes.NpgsqlPoint(x: 0.46749720004894935d, y: 0.15624428862473938d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5930127897797275d, y: 0.4855388647245784d), new NpgsqlTypes.NpgsqlPoint(x: 0.01902838036542731d, y: 0.46418026648055144d), new NpgsqlTypes.NpgsqlPoint(x: 0.3054027206504297d, y: 0.3216505476501599d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44027462317235455d, y: 0.37384239511403583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619866613255139d, y: 0.6270450006602788d), new NpgsqlTypes.NpgsqlPoint(x: 0.18970513808472877d, y: 0.688640793079903d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19610467772729412d, y: 0.5915560212657937d), new NpgsqlTypes.NpgsqlPoint(x: 0.3534567113826039d, y: 0.9807034468711273d), new NpgsqlTypes.NpgsqlPoint(x: 0.32061267653957537d, y: 0.172024224368579d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9069242356028823d, y: 0.38668187987142777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7966572997524503d, y: 0.21909588485387788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5705721432562258d, y: 0.6928677968482677d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25871354459178697d, y: 0.2852301443453218d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218452096789818d, y: 0.8221406654031872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225297829937787d, y: 0.3928906433401843d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09838069107049807d, y: 0.48077385073242884d), new NpgsqlTypes.NpgsqlPoint(x: 0.18159503197738214d, y: 0.9674321667565979d), new NpgsqlTypes.NpgsqlPoint(x: 0.21264132535972746d, y: 0.391461270627533d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21078109419956714d, y: 0.6221396171433051d), new NpgsqlTypes.NpgsqlPoint(x: 0.3446331107622378d, y: 0.5151928201046891d), new NpgsqlTypes.NpgsqlPoint(x: 0.4732700974932028d, y: 0.2390717792477196d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21154496364794595d, y: 0.05924089077670036d), new NpgsqlTypes.NpgsqlPoint(x: 0.40380038065416446d, y: 0.9029149584316303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5008478954058444d, y: 0.4991742038023236d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7561971801020313d, y: 0.4353512291032826d), new NpgsqlTypes.NpgsqlPoint(x: 0.30097794206446293d, y: 0.2979477443257058d), new NpgsqlTypes.NpgsqlPoint(x: 0.915921363305241d, y: 0.03325096398128213d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.710850909588808d, y: 0.7515665137676859d), new NpgsqlTypes.NpgsqlPoint(x: 0.43107754227167816d, y: 0.4074267700114954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104432819469679d, y: 0.04975883015894367d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042126504106064666d, y: 0.864726087211224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628022963034176d, y: 0.6997852181194157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764371871033794d, y: 0.34565064088822084d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6554606733504317d, y: 0.877807153475908d), new NpgsqlTypes.NpgsqlPoint(x: 0.24611259397225538d, y: 0.13807287082945485d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063936932550982d, y: 0.5590410279762948d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18486955630212776d, y: 0.22745630777432724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8629743746287335d, y: 0.7492847345293302d), new NpgsqlTypes.NpgsqlPoint(x: 0.40707773619559395d, y: 0.8694895755132075d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8024683519379355d, y: 0.0071772099765413655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3769042370811423d, y: 0.10095426833869303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393049118397796d, y: 0.7297593593575391d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0956234212945749d, y: 0.5878091730198816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282597119340637d, y: 0.2894855183118783d), new NpgsqlTypes.NpgsqlPoint(x: 0.2147973973484093d, y: 0.4966649080526867d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.83562471006486d, y: 0.37454010571992047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8054806285318155d, y: 0.33136012162520967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8356574326781818d, y: 0.2065147394857375d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7478654138300636d, y: 0.5376964818088046d), new NpgsqlTypes.NpgsqlPoint(x: 0.13489974753474732d, y: 0.5037983625164061d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786655850314327d, y: 0.6286105961385087d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1368527661012272d, y: 0.4240341409510284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914800684867591d, y: 0.20073521431053987d), new NpgsqlTypes.NpgsqlPoint(x: 0.8665818087539353d, y: 0.7557644019147937d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41340611759203094d, y: 0.8928778011126056d), new NpgsqlTypes.NpgsqlPoint(x: 0.01880866424758909d, y: 0.29879013424117684d), new NpgsqlTypes.NpgsqlPoint(x: 0.3207823397776334d, y: 0.3731023267243181d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9736451245370629d, y: 0.2082069510424901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224979084280926d, y: 0.8503348967339798d), new NpgsqlTypes.NpgsqlPoint(x: 0.021910729681882013d, y: 0.096168449643108d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5837264534982528d, y: 0.9735883429690727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703163527846872d, y: 0.2605355232583446d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299281363134463d, y: 0.09526003064767552d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17078443580063318d, y: 0.6223203565668296d), new NpgsqlTypes.NpgsqlPoint(x: 0.529055920143145d, y: 0.4244725638988306d), new NpgsqlTypes.NpgsqlPoint(x: 0.138971483527501d, y: 0.692932558469695d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8374236798243131d, y: 0.24402533991601183d), new NpgsqlTypes.NpgsqlPoint(x: 0.4523375748520979d, y: 0.1287591766518671d), new NpgsqlTypes.NpgsqlPoint(x: 0.014870495593814703d, y: 0.4251024138691606d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.484955834130233d, y: 0.6801904166387014d), new NpgsqlTypes.NpgsqlPoint(x: 0.555716549356984d, y: 0.9333896843793142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8181632966022313d, y: 0.5254180330531224d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7447452626861483d, y: 0.10954136277803594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679063646387259d, y: 0.7583655116355748d), new NpgsqlTypes.NpgsqlPoint(x: 0.1564219376105348d, y: 0.5558456590446036d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03594051775384588d, y: 0.23171478187778638d), new NpgsqlTypes.NpgsqlPoint(x: 0.6774907282283417d, y: 0.966098800143192d), new NpgsqlTypes.NpgsqlPoint(x: 0.3552927651271176d, y: 0.00389118178773018d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9727998637308815d, y: 0.6429436303581532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972177032102046d, y: 0.36311973054688285d), new NpgsqlTypes.NpgsqlPoint(x: 0.23483282395025018d, y: 0.5401003406239284d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11660816438828037d, y: 0.18848553431732684d), new NpgsqlTypes.NpgsqlPoint(x: 0.2828907302166347d, y: 0.42848281483857686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6202558319773511d, y: 0.6032918794919025d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033114945709050825d, y: 0.9236589970735277d), new NpgsqlTypes.NpgsqlPoint(x: 0.026042357188743925d, y: 0.4305069814983179d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209550997649233d, y: 0.13361467183885745d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9068254590287926d, y: 0.0609126673984669d), new NpgsqlTypes.NpgsqlPoint(x: 0.7496052732487994d, y: 0.41729792392080267d), new NpgsqlTypes.NpgsqlPoint(x: 0.3279588439566825d, y: 0.7416458231073285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8926010677405399d, y: 0.3091166666882139d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194085132069477d, y: 0.13175469579753007d), new NpgsqlTypes.NpgsqlPoint(x: 0.11231485638521954d, y: 0.08414851894201769d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5959196797974041d, y: 0.6642454785917928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628100040982858d, y: 0.06005614498478773d), new NpgsqlTypes.NpgsqlPoint(x: 0.52700027678073d, y: 0.2716378749563234d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2500813511852421d, y: 0.7636361946451621d), new NpgsqlTypes.NpgsqlPoint(x: 0.7210952313761605d, y: 0.6853430245379784d), new NpgsqlTypes.NpgsqlPoint(x: 0.09429210041307545d, y: 0.3568136987925009d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6498099235009153d, y: 0.8712772260565724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6909831036957921d, y: 0.10450952459607588d), new NpgsqlTypes.NpgsqlPoint(x: 0.38484604892522967d, y: 0.35731214573790726d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9760893792000129d, y: 0.4918615851877465d), new NpgsqlTypes.NpgsqlPoint(x: 0.24411447430569d, y: 0.2342085182515058d), new NpgsqlTypes.NpgsqlPoint(x: 0.34943542275004535d, y: 0.38339268334063625d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6151694622230864d, y: 0.1933887324663054d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815300012039736d, y: 0.684216528588378d), new NpgsqlTypes.NpgsqlPoint(x: 0.6071378671437745d, y: 0.9843460829428775d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6219378264993005d, y: 0.2642734954826803d), new NpgsqlTypes.NpgsqlPoint(x: 0.09270900108901259d, y: 0.005924593623211294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140414762064107d, y: 0.934247500911469d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5201693184644234d, y: 0.39644043844583954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2791685542568746d, y: 0.9499389146149164d), new NpgsqlTypes.NpgsqlPoint(x: 0.3591175145628259d, y: 0.6929403092947838d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 173,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6962766109111072d, y: 0.02421325604057034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8543117402393944d, y: 0.48250937612665035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903543200067023d, y: 0.32518109319981237d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28121775876802113d, y: 0.7221993437792108d), new NpgsqlTypes.NpgsqlPoint(x: 0.21621016360452294d, y: 0.5754991642876398d), new NpgsqlTypes.NpgsqlPoint(x: 0.2175742578585902d, y: 0.33215469265779496d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.633056500559498d, y: 0.5443300655325687d), new NpgsqlTypes.NpgsqlPoint(x: 0.7504915527481116d, y: 0.8098710402533327d), new NpgsqlTypes.NpgsqlPoint(x: 0.17562332853833296d, y: 0.8758423181057864d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9320463194548055d, y: 0.8279956207201722d), new NpgsqlTypes.NpgsqlPoint(x: 0.5483417165145263d, y: 0.8055601028725545d), new NpgsqlTypes.NpgsqlPoint(x: 0.7871014496664333d, y: 0.7089755613884873d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1704527983795059d, y: 0.32718197804980753d), new NpgsqlTypes.NpgsqlPoint(x: 0.04060655709613725d, y: 0.5022512701672301d), new NpgsqlTypes.NpgsqlPoint(x: 0.2076161126601085d, y: 0.12130761953967739d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6776862636260259d, y: 0.8928170136566287d), new NpgsqlTypes.NpgsqlPoint(x: 0.32554133777833894d, y: 0.9269915715075983d), new NpgsqlTypes.NpgsqlPoint(x: 0.14556954199545125d, y: 0.01531698412789484d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1354788540831935d, y: 0.38144377216249803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367134896740549d, y: 0.14342246924562418d), new NpgsqlTypes.NpgsqlPoint(x: 0.11771743311294869d, y: 0.6067544423705039d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05428616107548356d, y: 0.6286987952432103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982389119369975d, y: 0.014895560426025689d), new NpgsqlTypes.NpgsqlPoint(x: 0.5011260498155294d, y: 0.8256609527521646d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40309635732187554d, y: 0.6649892017172708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600107419162977d, y: 0.32911952783841236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5990712344988226d, y: 0.4679602145271533d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9264451000998623d, y: 0.8559963274138502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6323257421951748d, y: 0.1529938903906145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4393304000704342d, y: 0.6162628463215777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4214625092700297d, y: 0.3148625417524715d), new NpgsqlTypes.NpgsqlPoint(x: 0.16752658447412605d, y: 0.21250702634300644d), new NpgsqlTypes.NpgsqlPoint(x: 0.39590768589592995d, y: 0.498132391993255d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.874105197588533d, y: 0.1817394475285956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8263998181666052d, y: 0.8402937787033294d), new NpgsqlTypes.NpgsqlPoint(x: 0.8291245829171507d, y: 0.0652017948959035d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22246917941485944d, y: 0.8385726697374692d), new NpgsqlTypes.NpgsqlPoint(x: 0.47645111589645794d, y: 0.8269620826165958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350647570437111d, y: 0.9363790003067706d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8142841521281693d, y: 0.7372256290886489d), new NpgsqlTypes.NpgsqlPoint(x: 0.36661274666315113d, y: 0.26816738521939143d), new NpgsqlTypes.NpgsqlPoint(x: 0.18576558210979766d, y: 0.4377814994276862d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16934770994226334d, y: 0.02462399238150459d), new NpgsqlTypes.NpgsqlPoint(x: 0.9397193142333522d, y: 0.09874452524372823d), new NpgsqlTypes.NpgsqlPoint(x: 0.5815663319082406d, y: 0.737921141248395d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23768120771451373d, y: 0.12258531391415806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503732536833036d, y: 0.4513706608190551d), new NpgsqlTypes.NpgsqlPoint(x: 0.22649958549665705d, y: 0.06370999491487161d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46114184833290595d, y: 0.7980680310510485d), new NpgsqlTypes.NpgsqlPoint(x: 0.3602939934855097d, y: 0.7929193931077003d), new NpgsqlTypes.NpgsqlPoint(x: 0.07374288301600684d, y: 0.7732664486725994d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4490903912788644d, y: 0.2281072844522597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7174493394406922d, y: 0.8937081649766947d), new NpgsqlTypes.NpgsqlPoint(x: 0.07958322073486479d, y: 0.51542742910189d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17254585607739037d, y: 0.10406727602361943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7491132856456542d, y: 0.15674904736809225d), new NpgsqlTypes.NpgsqlPoint(x: 0.07522277238455133d, y: 0.15369070750340263d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.801842679627904d, y: 0.4141880225967748d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027692624946192d, y: 0.4044250614501067d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612532084126066d, y: 0.7832188590083423d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 186,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5460645545997663d, y: 0.8368037596830279d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066449089924385d, y: 0.8589360147954599d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749157396348306d, y: 0.1988312243468312d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8140887549188024d, y: 0.25354473763552776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7427734226749472d, y: 0.15446838802157214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8135790287853102d, y: 0.01954277628510681d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18330107136439944d, y: 0.8510153460602651d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256131647978703d, y: 0.016682524554499478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457512982771627d, y: 0.2319130323121592d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3336077257327452d, y: 0.6159817520736727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7300147798948002d, y: 0.7866445022453397d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664279951649462d, y: 0.7472071452333657d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9080063114183329d, y: 0.42759852186736114d), new NpgsqlTypes.NpgsqlPoint(x: 0.22644635371372335d, y: 0.6023276952039616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9897859738448989d, y: 0.2825337628299869d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14887524265838314d, y: 0.7811189781938637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6132446631841014d, y: 0.3135920702382532d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539578321686784d, y: 0.041425108559451806d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3754981068268922d, y: 0.053927724056434645d), new NpgsqlTypes.NpgsqlPoint(x: 0.6300345211358915d, y: 0.031031729581913026d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477455299518267d, y: 0.8784565843606204d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3998195927354342d, y: 0.22244979519973995d), new NpgsqlTypes.NpgsqlPoint(x: 0.8906255188660189d, y: 0.11642079960433271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466709701661702d, y: 0.49458819726134173d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.920358187709573d, y: 0.5667644802210462d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879910912773839d, y: 0.3634820057582442d), new NpgsqlTypes.NpgsqlPoint(x: 0.6688044877574063d, y: 0.9229939564443845d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005331734364058982d, y: 0.5749750883089875d), new NpgsqlTypes.NpgsqlPoint(x: 0.08100343132865606d, y: 0.717318163514304d), new NpgsqlTypes.NpgsqlPoint(x: 0.3969895131269583d, y: 0.4934270890291146d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8393554260135928d, y: 0.5010831608230262d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793698152629511d, y: 0.8198318046309351d), new NpgsqlTypes.NpgsqlPoint(x: 0.539856605844485d, y: 0.5124225798844336d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007401457483267593d, y: 0.761391158804775d), new NpgsqlTypes.NpgsqlPoint(x: 0.14849611334159363d, y: 0.029049911363487668d), new NpgsqlTypes.NpgsqlPoint(x: 0.19093855266238313d, y: 0.6619093968206033d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9910824359015573d, y: 0.42608264297996523d), new NpgsqlTypes.NpgsqlPoint(x: 0.13072908029297436d, y: 0.04809026035095387d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306868848540646d, y: 0.32237086833895967d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3650843012690318d, y: 0.19218111557223416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640159326877229d, y: 0.8802472325048066d), new NpgsqlTypes.NpgsqlPoint(x: 0.18989402903320207d, y: 0.3221154621815009d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 192,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0008266802685883423d, y: 0.7517322696607402d), new NpgsqlTypes.NpgsqlPoint(x: 0.43983021123237875d, y: 0.6115145984467566d), new NpgsqlTypes.NpgsqlPoint(x: 0.22351679770995825d, y: 0.2049565875291386d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.280571223482706d, y: 0.4713259293821084d), new NpgsqlTypes.NpgsqlPoint(x: 0.018387613031174532d, y: 0.7386155275662346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395366706528501d, y: 0.726845067088598d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7012990470510595d, y: 0.8359643434217692d), new NpgsqlTypes.NpgsqlPoint(x: 0.08305801915267619d, y: 0.9415741943220736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8094366741755438d, y: 0.8229794151877841d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8697137841839377d, y: 0.793304568137988d), new NpgsqlTypes.NpgsqlPoint(x: 0.3535768400913877d, y: 0.6204181845582076d), new NpgsqlTypes.NpgsqlPoint(x: 0.6463845400039434d, y: 0.9212046860849931d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5428408045636677d, y: 0.6508350827572045d), new NpgsqlTypes.NpgsqlPoint(x: 0.04045267634174998d, y: 0.2916967986345467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595333572866926d, y: 0.983972180225456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8142308344169598d, y: 0.15020470516146722d), new NpgsqlTypes.NpgsqlPoint(x: 0.3119672349063257d, y: 0.10962041027685177d), new NpgsqlTypes.NpgsqlPoint(x: 0.1415720718510688d, y: 0.5574199563023801d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6895238263515574d, y: 0.3149173238615076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835949807772567d, y: 0.06349728734951632d), new NpgsqlTypes.NpgsqlPoint(x: 0.3279698745780869d, y: 0.27977120477351114d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1164254900354752d, y: 0.7708818253221266d), new NpgsqlTypes.NpgsqlPoint(x: 0.47742133138807596d, y: 0.7237883160064982d), new NpgsqlTypes.NpgsqlPoint(x: 0.2688535546794679d, y: 0.3074228965544813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13207305426904925d, y: 0.9837539078960129d), new NpgsqlTypes.NpgsqlPoint(x: 0.3579149359324493d, y: 0.23819301701048812d), new NpgsqlTypes.NpgsqlPoint(x: 0.49012489927888636d, y: 0.9959849970300501d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3956534237343211d, y: 0.6624434721118216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316724755609829d, y: 0.9474002800345848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6882380658569125d, y: 0.18989545837563648d)),
}));
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8508012114744192d, y: 0.5055631609526238d), new NpgsqlTypes.NpgsqlPoint(x: 0.41023352406267655d, y: 0.6804235450527281d), new NpgsqlTypes.NpgsqlPoint(x: 0.26431815494094946d, y: 0.06589210449552318d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37077006834648074d, y: 0.016705559210914767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6626076085269522d, y: 0.7312275240739502d), new NpgsqlTypes.NpgsqlPoint(x: 0.2958582163708512d, y: 0.44112723490965267d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6819573490528839d, y: 0.47933429440399433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5587468097264148d, y: 0.17532930676224512d), new NpgsqlTypes.NpgsqlPoint(x: 0.4709934345708233d, y: 0.5320379387079767d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19519923057471988d, y: 0.05034140634031825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459893825987104d, y: 0.008235642209918126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5999442535039349d, y: 0.7377817893747984d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.397506228284214d, y: 0.6845151206398437d), new NpgsqlTypes.NpgsqlPoint(x: 0.05230668087041501d, y: 0.7910532888384583d), new NpgsqlTypes.NpgsqlPoint(x: 0.028928068258300854d, y: 0.2616195028954055d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7596013348926326d, y: 0.46082696284135816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3798532255516962d, y: 0.20916835900355235d), new NpgsqlTypes.NpgsqlPoint(x: 0.40910176416759636d, y: 0.917470173963059d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8400646074808926d, y: 0.809872031838509d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581152677330603d, y: 0.7500600747479569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729853239272269d, y: 0.1774970551160231d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05914906482073623d, y: 0.944540720032272d), new NpgsqlTypes.NpgsqlPoint(x: 0.4369509998191028d, y: 0.6052217585713979d), new NpgsqlTypes.NpgsqlPoint(x: 0.07360454447677434d, y: 0.5313324521025076d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD1E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD1E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr2.Value = 8;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 114;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 178;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 158;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 180, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 164, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 158, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 148, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 178, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 152, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 46, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 173, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI), typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

