

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7541497476709496d, y: 0.08582947768084603d), new NpgsqlTypes.NpgsqlPoint(x: 0.41796934844733336d, y: 0.8881675838735069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5858977261234782d, y: 0.7467390904966442d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8805434743169469d, y: 0.015912752557593723d), new NpgsqlTypes.NpgsqlPoint(x: 0.1887330350765084d, y: 0.10413018983169497d), new NpgsqlTypes.NpgsqlPoint(x: 0.3404137878039567d, y: 0.4804693705066465d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6452660778668935d, y: 0.44654380548367734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4185346603203193d, y: 0.6713471408268467d), new NpgsqlTypes.NpgsqlPoint(x: 0.7481233176219595d, y: 0.30696176313930634d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2305911202088583d, y: 0.8154642866703988d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991817703111976d, y: 0.8538333981443402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369563621348096d, y: 0.4665490621358529d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48134950389252584d, y: 0.428053219268289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9935787507337944d, y: 0.22014301202084074d), new NpgsqlTypes.NpgsqlPoint(x: 0.035542701389785436d, y: 0.6033912286330038d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4404685288113035d, y: 0.2688049849772668d), new NpgsqlTypes.NpgsqlPoint(x: 0.6314378018713561d, y: 0.12179674820231245d), new NpgsqlTypes.NpgsqlPoint(x: 0.23587209739029835d, y: 0.9912337050353761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3571516826202633d, y: 0.28027042446324946d), new NpgsqlTypes.NpgsqlPoint(x: 0.01653300960767945d, y: 0.3436734194346037d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799336624102993d, y: 0.06373040345274095d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.712732511065687d, y: 0.5213285661844336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5801043677928498d, y: 0.7121865689789291d), new NpgsqlTypes.NpgsqlPoint(x: 0.6650350299616574d, y: 0.9971381837713277d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8033163452148865d, y: 0.8761254188633503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936941367178213d, y: 0.9555599611404609d), new NpgsqlTypes.NpgsqlPoint(x: 0.04245348538122751d, y: 0.70252222342274d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45834153906257225d, y: 0.3061396357358578d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661575613399768d, y: 0.08851389855914693d), new NpgsqlTypes.NpgsqlPoint(x: 0.3902705101522397d, y: 0.6270797723054606d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30812265171423303d, y: 0.13634545887374083d), new NpgsqlTypes.NpgsqlPoint(x: 0.45860309454741766d, y: 0.8129542608644962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975739279468961d, y: 0.4697826390994718d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.522255245370326d, y: 0.06593153040757671d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436466821480444d, y: 0.7441511793697737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066066486210667d, y: 0.7465784697373854d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.750265527218725d, y: 0.5241680475297654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345828882004091d, y: 0.46818804449327d), new NpgsqlTypes.NpgsqlPoint(x: 0.14408547312468367d, y: 0.5480589388606958d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6788925149985555d, y: 0.6914852911147651d), new NpgsqlTypes.NpgsqlPoint(x: 0.5989366315811026d, y: 0.171789941683667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279727503606883d, y: 0.3587275099098737d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09972676165425998d, y: 0.6974650035674489d), new NpgsqlTypes.NpgsqlPoint(x: 0.2938996520923991d, y: 0.1460883795089406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441281576972793d, y: 0.40375343378739437d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46750259266920824d, y: 0.3842947889269722d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288948919476236d, y: 0.38722095519647204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7287123268260552d, y: 0.5660681022672364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9092195381070668d, y: 0.33112679951077684d), new NpgsqlTypes.NpgsqlPoint(x: 0.2097907342564287d, y: 0.40290686476977977d), new NpgsqlTypes.NpgsqlPoint(x: 0.2116945108731153d, y: 0.9511435097304147d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8638944802122146d, y: 0.8161286027320138d), new NpgsqlTypes.NpgsqlPoint(x: 0.2945907357900087d, y: 0.7883131539732491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445734801564657d, y: 0.7102603727012099d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7561844373118899d, y: 0.3278727232176639d), new NpgsqlTypes.NpgsqlPoint(x: 0.8286254720455374d, y: 0.2091650723913545d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853432304149674d, y: 0.6672410889759054d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24287290250352234d, y: 0.5737547987127481d), new NpgsqlTypes.NpgsqlPoint(x: 0.49806752807301635d, y: 0.29577022062852587d), new NpgsqlTypes.NpgsqlPoint(x: 0.31399295608566624d, y: 0.835299772132979d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9886172414685415d, y: 0.42691588493151955d), new NpgsqlTypes.NpgsqlPoint(x: 0.19940145105629437d, y: 0.7237312720990283d), new NpgsqlTypes.NpgsqlPoint(x: 0.05546417985559848d, y: 0.2538962079451029d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1516226774471946d, y: 0.2569185893135809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6050926266488438d, y: 0.47184205332991547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422325714914452d, y: 0.1568156858344949d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07562634865001883d, y: 0.42743580417234817d), new NpgsqlTypes.NpgsqlPoint(x: 0.4820330705719641d, y: 0.3317130372382844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134145199757277d, y: 0.433216566358526d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06605758496843817d, y: 0.1897792551654076d), new NpgsqlTypes.NpgsqlPoint(x: 0.13371983156902456d, y: 0.18022994203463782d), new NpgsqlTypes.NpgsqlPoint(x: 0.43761452293016834d, y: 0.028053366286093673d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6848581404140219d, y: 0.7349241602567965d), new NpgsqlTypes.NpgsqlPoint(x: 0.1878881737619511d, y: 0.027922323409997007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900778251054554d, y: 0.644447794754852d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49583493526517475d, y: 0.020039339050439864d), new NpgsqlTypes.NpgsqlPoint(x: 0.30394749496971185d, y: 0.8297267161586395d), new NpgsqlTypes.NpgsqlPoint(x: 0.369044448887591d, y: 0.6651410749634397d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6228041110847725d, y: 0.6689972012642986d), new NpgsqlTypes.NpgsqlPoint(x: 0.2873102574744125d, y: 0.867829786874141d), new NpgsqlTypes.NpgsqlPoint(x: 0.044408682195740345d, y: 0.8179804320796833d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7925940781635674d, y: 0.03002523824150294d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932814252945964d, y: 0.17490429278665265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6226817100341092d, y: 0.10560290194716182d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8749083784405176d, y: 0.7881407645299415d), new NpgsqlTypes.NpgsqlPoint(x: 0.2181175714499034d, y: 0.9332575004217868d), new NpgsqlTypes.NpgsqlPoint(x: 0.507310674836524d, y: 0.20863393629556304d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9753226203666021d, y: 0.9853988600982544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5030688093175103d, y: 0.614765771609299d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409935536230244d, y: 0.47997719282245777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7337088688277699d, y: 0.31075065088884524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3121648578382955d, y: 0.199638973706038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9981883915851515d, y: 0.5054272107040048d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0636012069580486d, y: 0.5246329538506356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8504594519992493d, y: 0.3507201103133133d), new NpgsqlTypes.NpgsqlPoint(x: 0.2578911491153162d, y: 0.09273266139253988d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02907802800895254d, y: 0.31087800137784394d), new NpgsqlTypes.NpgsqlPoint(x: 0.07913283923453973d, y: 0.134588205297549d), new NpgsqlTypes.NpgsqlPoint(x: 0.37311954193302477d, y: 0.17044628248781268d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20893218235092648d, y: 0.005773960184093596d), new NpgsqlTypes.NpgsqlPoint(x: 0.0584146800102211d, y: 0.06398651071610795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463277850303501d, y: 0.994167931793687d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9110572570397546d, y: 0.6178182643851767d), new NpgsqlTypes.NpgsqlPoint(x: 0.17645509229697098d, y: 0.1260190241571163d), new NpgsqlTypes.NpgsqlPoint(x: 0.22489017601189554d, y: 0.9783667007923339d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7276981144560682d, y: 0.6660609395334733d), new NpgsqlTypes.NpgsqlPoint(x: 0.38540960611496256d, y: 0.3353023976789713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5277283818293727d, y: 0.02896228652250643d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1074826728629551d, y: 0.736361018898458d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183154058912269d, y: 0.5967252384731249d), new NpgsqlTypes.NpgsqlPoint(x: 0.4741606838203374d, y: 0.3994748678058513d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0004058043567778391d, y: 0.9497939660237806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3890803426947923d, y: 0.47198722433349083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7852248973277d, y: 0.09409513034501649d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8273485771443628d, y: 0.6255522277866935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384204410874263d, y: 0.5450106718506387d), new NpgsqlTypes.NpgsqlPoint(x: 0.33065102371412336d, y: 0.03026953120804088d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03938667401269014d, y: 0.09341341652349922d), new NpgsqlTypes.NpgsqlPoint(x: 0.7193207572032218d, y: 0.5018315172971871d), new NpgsqlTypes.NpgsqlPoint(x: 0.534497312135513d, y: 0.41222302638142416d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8164320547489936d, y: 0.04029574747057829d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530491185886137d, y: 0.7128191791894701d), new NpgsqlTypes.NpgsqlPoint(x: 0.32718974543928103d, y: 0.358196553840749d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5232982144156316d, y: 0.2881773480587211d), new NpgsqlTypes.NpgsqlPoint(x: 0.17925182134533835d, y: 0.23024051279287805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8833475774672102d, y: 0.9102490706956128d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8746512050611891d, y: 0.20551653027675698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469001307913505d, y: 0.7506895295863135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5320981025473255d, y: 0.2981651571000521d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17613318466498462d, y: 0.5549437205853697d), new NpgsqlTypes.NpgsqlPoint(x: 0.07323461343219273d, y: 0.16209580620264574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383711553731794d, y: 0.7590424535608121d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9879093611804896d, y: 0.33608303683114327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9843066397026989d, y: 0.5974059406430808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465040851128732d, y: 0.4920817180037509d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08116478237769831d, y: 0.30876188383224445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9361968995149907d, y: 0.21196083507378294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747614112859841d, y: 0.5332692651959973d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18095164026203248d, y: 0.40994207817666706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9298412094797796d, y: 0.6209902532109725d), new NpgsqlTypes.NpgsqlPoint(x: 0.3179748733107475d, y: 0.7689058528497235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3639008926179753d, y: 0.08315747095376858d), new NpgsqlTypes.NpgsqlPoint(x: 0.48447629057432795d, y: 0.2827931133001159d), new NpgsqlTypes.NpgsqlPoint(x: 0.4519954071593898d, y: 0.28740276308249646d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40740071985457726d, y: 0.2857502793755139d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732523094540371d, y: 0.8676752564498346d), new NpgsqlTypes.NpgsqlPoint(x: 0.5970302175377368d, y: 0.8621364171696707d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21616620232254025d, y: 0.11579143957216698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233170426385754d, y: 0.39204856982988445d), new NpgsqlTypes.NpgsqlPoint(x: 0.33617456625153397d, y: 0.039597481630450515d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32184244855275324d, y: 0.1483641123925432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7964840779771458d, y: 0.4290687920789771d), new NpgsqlTypes.NpgsqlPoint(x: 0.6096375839991125d, y: 0.5674459956026203d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1279017986463683d, y: 0.04436013218747514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4288630033844144d, y: 0.8613165246555192d), new NpgsqlTypes.NpgsqlPoint(x: 0.22701886490407808d, y: 0.938755916186153d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25278928977104176d, y: 0.7869169941385913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346061330604565d, y: 0.2844263972051565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3682995408886518d, y: 0.6011785051677041d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5620965224643683d, y: 0.01610178612766866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3189886959295839d, y: 0.7573364849328743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8187739382741236d, y: 0.40276337709784404d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06809736972511848d, y: 0.5929642826294639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5761076240293014d, y: 0.08440309452957495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6515810977676463d, y: 0.7501379471707663d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9462372171507735d, y: 0.5630727882107178d), new NpgsqlTypes.NpgsqlPoint(x: 0.8931467459284328d, y: 0.5698209973701102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962763987202272d, y: 0.4647284138784471d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37028624961830015d, y: 0.8734419795119652d), new NpgsqlTypes.NpgsqlPoint(x: 0.938623094092169d, y: 0.9463231830413579d), new NpgsqlTypes.NpgsqlPoint(x: 0.9578383190123613d, y: 0.3036155619999946d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8345127777636475d, y: 0.05066231983349723d), new NpgsqlTypes.NpgsqlPoint(x: 0.26788283524202805d, y: 0.5842378293529567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846750910138736d, y: 0.4951078638468407d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.263843238374861d, y: 0.6569717665954412d), new NpgsqlTypes.NpgsqlPoint(x: 0.2837135902108079d, y: 0.5971689870890651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3112500669334034d, y: 0.5457833979613733d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5569655670494089d, y: 0.6728266616833477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9084138104153211d, y: 0.30225832733585345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4917090756411754d, y: 0.5248482314621188d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07907480370935582d, y: 0.9829593732594165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550430203729309d, y: 0.777713458934419d), new NpgsqlTypes.NpgsqlPoint(x: 0.3054579692541308d, y: 0.5270619341374512d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.316333687578506d, y: 0.12512379663324014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091044597998331d, y: 0.49863250787937774d), new NpgsqlTypes.NpgsqlPoint(x: 0.018936417470960643d, y: 0.25251183919917286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008144596792224013d, y: 0.3996573458649112d), new NpgsqlTypes.NpgsqlPoint(x: 0.08483116061366391d, y: 0.4766098981318262d), new NpgsqlTypes.NpgsqlPoint(x: 0.43778834379653353d, y: 0.9759257873446784d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8291244786400116d, y: 0.0911622727899909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374524035255692d, y: 0.8145959662369604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4286982213606636d, y: 0.45346884545723565d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5746369061466365d, y: 0.4627512370425969d), new NpgsqlTypes.NpgsqlPoint(x: 0.9066761622595894d, y: 0.7522103218781938d), new NpgsqlTypes.NpgsqlPoint(x: 0.26663244312267764d, y: 0.20989790363950667d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9087087054706386d, y: 0.9593881581280179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085093026582426d, y: 0.09354952052045784d), new NpgsqlTypes.NpgsqlPoint(x: 0.18590792533915035d, y: 0.7468719480066611d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43153302629043855d, y: 0.5976712655101396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7546913482165999d, y: 0.30722643429520136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903143143813333d, y: 0.9955134498617427d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9042057448138755d, y: 0.05245364599768465d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808275516526693d, y: 0.22628895419072392d), new NpgsqlTypes.NpgsqlPoint(x: 0.05898148005663573d, y: 0.8276119264029851d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2875996513264967d, y: 0.11231536454723279d), new NpgsqlTypes.NpgsqlPoint(x: 0.27326432398359046d, y: 0.3853433456136238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8349074986281475d, y: 0.8312667244669706d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9712549896940726d, y: 0.8213204291197191d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974367831694643d, y: 0.5766427406194982d), new NpgsqlTypes.NpgsqlPoint(x: 0.6463417957218742d, y: 0.06862608182235252d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22427195738969286d, y: 0.6219988855552478d), new NpgsqlTypes.NpgsqlPoint(x: 0.029245259764946963d, y: 0.16702092738252394d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967219485832929d, y: 0.8628443854171463d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7134304467894805d, y: 0.6537319617430637d), new NpgsqlTypes.NpgsqlPoint(x: 0.47947796484852856d, y: 0.6900326694117292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5965641902501756d, y: 0.8034128202084811d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6678616699931713d, y: 0.7675839922819432d), new NpgsqlTypes.NpgsqlPoint(x: 0.09954676897891712d, y: 0.9809368717810191d), new NpgsqlTypes.NpgsqlPoint(x: 0.03380203460941733d, y: 0.28174849140441693d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16711879997919055d, y: 0.05779182793687543d), new NpgsqlTypes.NpgsqlPoint(x: 0.57044262562552d, y: 0.5829378019668182d), new NpgsqlTypes.NpgsqlPoint(x: 0.931992973925252d, y: 0.9866379687342416d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9532287397204601d, y: 0.9343120598441594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044777492242389d, y: 0.013274115582354362d), new NpgsqlTypes.NpgsqlPoint(x: 0.172741421628959d, y: 0.2284903233715866d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3505974376683715d, y: 0.47324326570807385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187508250574717d, y: 0.7226385653602221d), new NpgsqlTypes.NpgsqlPoint(x: 0.8636207677775164d, y: 0.4004687694068041d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9853180219639516d, y: 0.5979041184757402d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481109373688567d, y: 0.3192211405142733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6854524347166678d, y: 0.22539788343049494d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06871739697647927d, y: 0.5798605520723925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7952690684093372d, y: 0.6496951886182046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156764578408239d, y: 0.7090026230429135d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10340246275980691d, y: 0.005061352431250721d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029162398298963d, y: 0.4595447123028569d), new NpgsqlTypes.NpgsqlPoint(x: 0.030594778832658598d, y: 0.3435089928517072d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1742800849808266d, y: 0.31820107572664524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670521289427471d, y: 0.6589083609354538d), new NpgsqlTypes.NpgsqlPoint(x: 0.7878380304748769d, y: 0.8969782936784587d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29876096272093555d, y: 0.24554301692885006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7814438592724194d, y: 0.06607998701291584d), new NpgsqlTypes.NpgsqlPoint(x: 0.2002102844918371d, y: 0.1210334031225716d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9446528957003814d, y: 0.3522205981604588d), new NpgsqlTypes.NpgsqlPoint(x: 0.3842873970981874d, y: 0.26230467523940615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194391502590292d, y: 0.9970910209895718d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12354724226610725d, y: 0.3989010870003481d), new NpgsqlTypes.NpgsqlPoint(x: 0.05375372401991507d, y: 0.82078645181596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5337464768813344d, y: 0.017821063629885003d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.938362697044152d, y: 0.9688534510852664d), new NpgsqlTypes.NpgsqlPoint(x: 0.11148900657662464d, y: 0.4507199573516325d), new NpgsqlTypes.NpgsqlPoint(x: 0.21182868004387567d, y: 0.8141864501746859d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06401405950824468d, y: 0.1889829184321754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214750752352183d, y: 0.9117379929145585d), new NpgsqlTypes.NpgsqlPoint(x: 0.030383104855643772d, y: 0.6284731557093135d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3680724406926431d, y: 0.3084433022687363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6585568859754941d, y: 0.7685225381807065d), new NpgsqlTypes.NpgsqlPoint(x: 0.37627150461420245d, y: 0.14751636061534112d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13074125706639372d, y: 0.04664187722155144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219893507099419d, y: 0.6460341374565428d), new NpgsqlTypes.NpgsqlPoint(x: 0.6346830350997548d, y: 0.4836383541698974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7989247766563476d, y: 0.7422121788382279d), new NpgsqlTypes.NpgsqlPoint(x: 0.3415692525548776d, y: 0.9019793360356122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6052222197786362d, y: 0.6162935343937516d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32737397158810466d, y: 0.9021693668985145d), new NpgsqlTypes.NpgsqlPoint(x: 0.07405676550534812d, y: 0.07707273087141142d), new NpgsqlTypes.NpgsqlPoint(x: 0.9637157400873325d, y: 0.7189391020930987d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5084196709178822d, y: 0.12661396707525452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110523173902421d, y: 0.5783710158193205d), new NpgsqlTypes.NpgsqlPoint(x: 0.1745466745387202d, y: 0.6017317639944149d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31295100698752343d, y: 0.15236347913319215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564297543742323d, y: 0.9507486297836146d), new NpgsqlTypes.NpgsqlPoint(x: 0.45823795927316446d, y: 0.7742263917697149d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35013829112808825d, y: 0.04237649537560795d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639890634043265d, y: 0.5959624434904336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865168453508825d, y: 0.3576372288686497d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3898989508556284d, y: 0.309010836811322d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764065186334824d, y: 0.09576696639105353d), new NpgsqlTypes.NpgsqlPoint(x: 0.015757763502318722d, y: 0.6440901011309883d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9963451944030921d, y: 0.21449579678298336d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341709997851186d, y: 0.5239669093447906d), new NpgsqlTypes.NpgsqlPoint(x: 0.14947681011607816d, y: 0.7918451187444936d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4736130279074513d, y: 0.7437014474817237d), new NpgsqlTypes.NpgsqlPoint(x: 0.3368434335138144d, y: 0.8184326043114716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168107381495576d, y: 0.20343343940807046d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41419990550059216d, y: 0.44393894787653276d), new NpgsqlTypes.NpgsqlPoint(x: 0.3668198916567087d, y: 0.7874560407778146d), new NpgsqlTypes.NpgsqlPoint(x: 0.38100881428381306d, y: 0.25822365152969273d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23664266566564085d, y: 0.9433027926859701d), new NpgsqlTypes.NpgsqlPoint(x: 0.07751187902897227d, y: 0.509006316224072d), new NpgsqlTypes.NpgsqlPoint(x: 0.04189601048287661d, y: 0.10362303954972296d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7216761870019318d, y: 0.7884765416345136d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361966085155063d, y: 0.582380105727865d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260546138542888d, y: 0.8696130600298764d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.039445849629528795d, y: 0.03451203878596565d), new NpgsqlTypes.NpgsqlPoint(x: 0.12764125992645003d, y: 0.30261565251413114d), new NpgsqlTypes.NpgsqlPoint(x: 0.008150609192026814d, y: 0.171350507543632d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4607573506411895d, y: 0.6862379280358114d), new NpgsqlTypes.NpgsqlPoint(x: 0.943375561757405d, y: 0.4667360560360634d), new NpgsqlTypes.NpgsqlPoint(x: 0.3789624445128159d, y: 0.8233666219213596d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48777777901677d, y: 0.6961470436027983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626974671573292d, y: 0.1622322653397834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469590591388078d, y: 0.22903502932330744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5040671729874765d, y: 0.4628651733084823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412784905248441d, y: 0.5030878657282349d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180372119877935d, y: 0.9376355456975497d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4145431963327606d, y: 0.14912026775983123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8948504591054723d, y: 0.6597404108352077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021752022754345d, y: 0.44511227073536985d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25001717099786136d, y: 0.6659228450913389d), new NpgsqlTypes.NpgsqlPoint(x: 0.7986477831728924d, y: 0.15018291709833897d), new NpgsqlTypes.NpgsqlPoint(x: 0.40114676878332833d, y: 0.4848478905191782d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.630215672139799d, y: 0.7331001472480885d), new NpgsqlTypes.NpgsqlPoint(x: 0.4155339181218607d, y: 0.002170489883893123d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414387729221482d, y: 0.59499504904066d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30310199411990935d, y: 0.4264358115691942d), new NpgsqlTypes.NpgsqlPoint(x: 0.7876539277401201d, y: 0.12117701135915493d), new NpgsqlTypes.NpgsqlPoint(x: 0.80248130701622d, y: 0.5173607987196875d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9856968919324505d, y: 0.032311384855331915d), new NpgsqlTypes.NpgsqlPoint(x: 0.4870183165709364d, y: 0.5252922650063094d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247976852415178d, y: 0.6423626432326943d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42239281383271887d, y: 0.4162700730063934d), new NpgsqlTypes.NpgsqlPoint(x: 0.12571460272474366d, y: 0.47115854288465464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845235866207619d, y: 0.3185914821894118d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6082237938948308d, y: 0.2667065022262911d), new NpgsqlTypes.NpgsqlPoint(x: 0.014606517368161875d, y: 0.6715965401368464d), new NpgsqlTypes.NpgsqlPoint(x: 0.8058766440780868d, y: 0.10703498388661037d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8789437716944413d, y: 0.9059867395436537d), new NpgsqlTypes.NpgsqlPoint(x: 0.09652869197723435d, y: 0.8369250941479459d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590227975732804d, y: 0.1414174982037404d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9613816755736425d, y: 0.5565279321046326d), new NpgsqlTypes.NpgsqlPoint(x: 0.21554111337939774d, y: 0.40417518114397755d), new NpgsqlTypes.NpgsqlPoint(x: 0.4195423912283123d, y: 0.11510195968615022d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40902881896949994d, y: 0.8362115812417622d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070977798583982d, y: 0.5746573592991125d), new NpgsqlTypes.NpgsqlPoint(x: 0.29419339273247347d, y: 0.8110678980973726d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9221193757594167d, y: 0.44384403581577103d), new NpgsqlTypes.NpgsqlPoint(x: 0.13985761948666164d, y: 0.2829293121251606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608116002857988d, y: 0.5901738605069806d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6681524288831583d, y: 0.16686664404558404d), new NpgsqlTypes.NpgsqlPoint(x: 0.790606511673872d, y: 0.41059565975550905d), new NpgsqlTypes.NpgsqlPoint(x: 0.4829257426758833d, y: 0.061968637838656915d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3179386804064259d, y: 0.95080265524313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4221647149959583d, y: 0.6771434605014862d), new NpgsqlTypes.NpgsqlPoint(x: 0.22888165950963602d, y: 0.5895203713658129d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9537431705152195d, y: 0.07465230893024866d), new NpgsqlTypes.NpgsqlPoint(x: 0.1636023969682232d, y: 0.47003543251650626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8077494705481888d, y: 0.5374780885974869d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.948076220274641d, y: 0.5202209890754966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467274312064737d, y: 0.19904801893790414d), new NpgsqlTypes.NpgsqlPoint(x: 0.962473281701093d, y: 0.682127991839699d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9213614926439133d, y: 0.02537591403638373d), new NpgsqlTypes.NpgsqlPoint(x: 0.11435667978616437d, y: 0.8279788843781827d), new NpgsqlTypes.NpgsqlPoint(x: 0.04732983251824974d, y: 0.3680083621948744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09245755444166137d, y: 0.7851008098377156d), new NpgsqlTypes.NpgsqlPoint(x: 0.16659777451057245d, y: 0.10121083064007319d), new NpgsqlTypes.NpgsqlPoint(x: 0.5812954157900999d, y: 0.8080498785132029d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9600555529257914d, y: 0.6399815481294638d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712711895225819d, y: 0.6630785295253345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626511213710568d, y: 0.06435898215213842d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03383139480654196d, y: 0.5118289449467741d), new NpgsqlTypes.NpgsqlPoint(x: 0.4999229722735824d, y: 0.5900580677410739d), new NpgsqlTypes.NpgsqlPoint(x: 0.924381854885554d, y: 0.34721584415683615d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4776296031355115d, y: 0.34320459209167786d), new NpgsqlTypes.NpgsqlPoint(x: 0.3424806415431766d, y: 0.6074419246791162d), new NpgsqlTypes.NpgsqlPoint(x: 0.09477909540285501d, y: 0.5476074171388815d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5911802441437064d, y: 0.15070828121033475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610780200649164d, y: 0.521873962380216d), new NpgsqlTypes.NpgsqlPoint(x: 0.02618755866825051d, y: 0.6179028117314818d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13227826447540614d, y: 0.2383163235004676d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454182948195379d, y: 0.1801326542333922d), new NpgsqlTypes.NpgsqlPoint(x: 0.01009437008722669d, y: 0.03462660515611404d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6600215357627789d, y: 0.17436032207410257d), new NpgsqlTypes.NpgsqlPoint(x: 0.22028497078316045d, y: 0.8870615543755521d), new NpgsqlTypes.NpgsqlPoint(x: 0.18732148292584916d, y: 0.9744688972584803d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6701107256706533d, y: 0.708227080397112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914938016686597d, y: 0.7132122526200317d), new NpgsqlTypes.NpgsqlPoint(x: 0.4491331151596667d, y: 0.9703744849723306d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8706719936515677d, y: 0.8289706691793071d), new NpgsqlTypes.NpgsqlPoint(x: 0.5978380731324269d, y: 0.4609279555910002d), new NpgsqlTypes.NpgsqlPoint(x: 0.16240600817232165d, y: 0.6734064503136526d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7780136871071065d, y: 0.1033882012352264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6528581426673093d, y: 0.3192389273640954d), new NpgsqlTypes.NpgsqlPoint(x: 0.33599240022881194d, y: 0.06914256194019774d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.197562318431018d, y: 0.4339963448264347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617008827594891d, y: 0.2344851700092151d), new NpgsqlTypes.NpgsqlPoint(x: 0.042367206316642925d, y: 0.17798846283588254d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4748969639502667d, y: 0.3181081156309864d), new NpgsqlTypes.NpgsqlPoint(x: 0.3465110038435335d, y: 0.016963664957093894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3852548198288893d, y: 0.482533109337559d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3627423327932421d, y: 0.9747209258360053d), new NpgsqlTypes.NpgsqlPoint(x: 0.18281025012907992d, y: 0.5292537114914401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797586646595849d, y: 0.37497010330208114d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7487170763442547d, y: 0.821330764152854d), new NpgsqlTypes.NpgsqlPoint(x: 0.17543682431362784d, y: 0.2713564093363885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275124920899642d, y: 0.8163699783417073d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9365429293075132d, y: 0.18346518327698946d), new NpgsqlTypes.NpgsqlPoint(x: 0.3946605440785236d, y: 0.734819312997606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6241831343835282d, y: 0.42006265485133076d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5741565055300856d, y: 0.6685003065432276d), new NpgsqlTypes.NpgsqlPoint(x: 0.17389828270186347d, y: 0.4105906439696072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9581969816026052d, y: 0.7795938584477481d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.97394198573361d, y: 0.10250281962478591d), new NpgsqlTypes.NpgsqlPoint(x: 0.8277163054776282d, y: 0.7767925867683799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618797716936674d, y: 0.7075832280441959d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8356025735455551d, y: 0.4857468873741495d), new NpgsqlTypes.NpgsqlPoint(x: 0.14696231590111208d, y: 0.39807650637945646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790156984505607d, y: 0.3117784879809743d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.760780188791577d, y: 0.30710646995135715d), new NpgsqlTypes.NpgsqlPoint(x: 0.0004193098570287601d, y: 0.442973298980301d), new NpgsqlTypes.NpgsqlPoint(x: 0.794354203414175d, y: 0.11828563351557575d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3216919600238054d, y: 0.20731060000749446d), new NpgsqlTypes.NpgsqlPoint(x: 0.02286587397957729d, y: 0.38635130014079555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110738915911562d, y: 0.6499312015098015d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8439188653171737d, y: 0.3303408733076312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8779429629368559d, y: 0.7531724474943178d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761251302917819d, y: 0.4698030547535431d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08915482240349903d, y: 0.3201614827615742d), new NpgsqlTypes.NpgsqlPoint(x: 0.4569316930261854d, y: 0.2180343471222539d), new NpgsqlTypes.NpgsqlPoint(x: 0.08674164713380794d, y: 0.986763152823968d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6339531825002618d, y: 0.23281354633329665d), new NpgsqlTypes.NpgsqlPoint(x: 0.9067752143128189d, y: 0.9064577814217211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828792074788174d, y: 0.7285384138439475d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.047155973950795294d, y: 0.30338073623219863d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806317746696312d, y: 0.860214142819711d), new NpgsqlTypes.NpgsqlPoint(x: 0.4784603716525052d, y: 0.7591901370642005d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5294448304406525d, y: 0.08429759322061159d), new NpgsqlTypes.NpgsqlPoint(x: 0.24773242978496812d, y: 0.23862857653422842d), new NpgsqlTypes.NpgsqlPoint(x: 0.45674153449145904d, y: 0.8307088379776121d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4696965470729719d, y: 0.1415244927696605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8589234679626655d, y: 0.40726082352940374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9251803478235345d, y: 0.7895143391905859d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13003291921175497d, y: 0.20487579851060767d), new NpgsqlTypes.NpgsqlPoint(x: 0.18459085274522014d, y: 0.4885495198202733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660687803554106d, y: 0.45169310752400615d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1035627693932365d, y: 0.2289729302198633d), new NpgsqlTypes.NpgsqlPoint(x: 0.4947242808786094d, y: 0.14629996429518555d), new NpgsqlTypes.NpgsqlPoint(x: 0.969887908324683d, y: 0.8945132476143891d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06645304456720058d, y: 0.06706442164584003d), new NpgsqlTypes.NpgsqlPoint(x: 0.679391630757156d, y: 0.23458436522155268d), new NpgsqlTypes.NpgsqlPoint(x: 0.62818323388337d, y: 0.9898155530491216d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5760624502305136d, y: 0.2972941865710925d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560826459557189d, y: 0.974730028837975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689450359794072d, y: 0.34019413708995805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9185080182765292d, y: 0.8386731854003205d), new NpgsqlTypes.NpgsqlPoint(x: 0.37506479796216274d, y: 0.18199200740126475d), new NpgsqlTypes.NpgsqlPoint(x: 0.873986305694134d, y: 0.48694222665100106d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6923809773542181d, y: 0.12901025844857694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7693390993146099d, y: 0.4702156658706492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393669503898878d, y: 0.04425244769324854d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44617852032686967d, y: 0.5687041998597377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6686097354069699d, y: 0.7367700328207464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806438223293098d, y: 0.6021412616246115d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2664419856477743d, y: 0.5355228584344693d), new NpgsqlTypes.NpgsqlPoint(x: 0.3814376200818851d, y: 0.7156826357378969d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809530702368893d, y: 0.25107942835843655d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6895966448033495d, y: 0.3727123314052234d), new NpgsqlTypes.NpgsqlPoint(x: 0.722074990342348d, y: 0.21089564751861667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651253450235275d, y: 0.6240978761793531d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21314461222232228d, y: 0.7548427124369578d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610788876863708d, y: 0.25648209576027314d), new NpgsqlTypes.NpgsqlPoint(x: 0.8426285191766837d, y: 0.7448917185987862d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010449941535690455d, y: 0.4511133092304914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560243251675305d, y: 0.435371951676213d), new NpgsqlTypes.NpgsqlPoint(x: 0.8558428538089166d, y: 0.8274385789957825d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9152261321781624d, y: 0.31618251556140664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539503503021931d, y: 0.014287060141266239d), new NpgsqlTypes.NpgsqlPoint(x: 0.4103970596602514d, y: 0.7106878897919454d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5379255769671708d, y: 0.8940419843285967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393697125148906d, y: 0.01732531868074072d), new NpgsqlTypes.NpgsqlPoint(x: 0.31541172789232097d, y: 0.9388011189586359d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29523320128718444d, y: 0.006765946808830581d), new NpgsqlTypes.NpgsqlPoint(x: 0.48946629874820613d, y: 0.6011287461234736d), new NpgsqlTypes.NpgsqlPoint(x: 0.055733219592414396d, y: 0.9475998846086251d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.003223982574356854d, y: 0.29022776539624007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8878945009872978d, y: 0.16891435348325834d), new NpgsqlTypes.NpgsqlPoint(x: 0.8920785568505005d, y: 0.8325219833881969d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15879777861411415d, y: 0.5744902053626715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3116495751892904d, y: 0.5654027773901491d), new NpgsqlTypes.NpgsqlPoint(x: 0.09984015945750857d, y: 0.35953280602895754d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5272252054227776d, y: 0.12396100100505514d), new NpgsqlTypes.NpgsqlPoint(x: 0.15272314970634715d, y: 0.8621710843247274d), new NpgsqlTypes.NpgsqlPoint(x: 0.061582420397618076d, y: 0.12764667210733804d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8877206458876021d, y: 0.8604329517218184d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432886478371631d, y: 0.23297025131446314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7987859476947078d, y: 0.31046885078735476d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8343423342579934d, y: 0.5222455859273458d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848239489563504d, y: 0.16054250915330193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971126503276356d, y: 0.6593294557425525d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40468302724727045d, y: 0.6457068105321166d), new NpgsqlTypes.NpgsqlPoint(x: 0.6307361950723649d, y: 0.13604225960570138d), new NpgsqlTypes.NpgsqlPoint(x: 0.15989740221912208d, y: 0.9295848874704586d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8501054466220149d, y: 0.17883199739006528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4193487292073379d, y: 0.20589812387811623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7164842194181034d, y: 0.9661244149715822d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7985329748791797d, y: 0.4717222415736949d), new NpgsqlTypes.NpgsqlPoint(x: 0.032377910848133795d, y: 0.19189574242887109d), new NpgsqlTypes.NpgsqlPoint(x: 0.6109123802379791d, y: 0.26369474399924164d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.414803409987091d, y: 0.582884557020493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6906149917911886d, y: 0.7089870341833535d), new NpgsqlTypes.NpgsqlPoint(x: 0.05462563139593479d, y: 0.9022420471014116d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.796484209687644d, y: 0.6662914554650529d), new NpgsqlTypes.NpgsqlPoint(x: 0.8421227031268649d, y: 0.08837875759972924d), new NpgsqlTypes.NpgsqlPoint(x: 0.3140357095060513d, y: 0.556137917634943d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6654365529236551d, y: 0.7037888062327405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8322601583362782d, y: 0.3293669983478409d), new NpgsqlTypes.NpgsqlPoint(x: 0.822735688882013d, y: 0.18138379081240585d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1455911575314044d, y: 0.1115890576749976d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622244043899429d, y: 0.622618639120189d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159734183057513d, y: 0.8011681554897213d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8726939674725728d, y: 0.022214894165792365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5480679540507603d, y: 0.24695280225915184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5090761584798702d, y: 0.3614692172543179d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12371072737921496d, y: 0.24557886848356303d), new NpgsqlTypes.NpgsqlPoint(x: 0.19928581631068687d, y: 0.9738498891993446d), new NpgsqlTypes.NpgsqlPoint(x: 0.19306579092041043d, y: 0.18206397177560874d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6978019290999367d, y: 0.6126411236470856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6406228257822879d, y: 0.8050125736302497d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865093092565905d, y: 0.6389786147508955d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1546514136587629d, y: 0.8363928405944616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755675219761751d, y: 0.12378976015265575d), new NpgsqlTypes.NpgsqlPoint(x: 0.006411586367142674d, y: 0.8404330764499054d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.593751510569294d, y: 0.46558687652227215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7743333058945234d, y: 0.355093785098603d), new NpgsqlTypes.NpgsqlPoint(x: 0.012212437922603292d, y: 0.7929442041816616d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7336190177040987d, y: 0.9201764531951377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075972660690974d, y: 0.7318173413238936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568855085673336d, y: 0.7831650106049731d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4363138333748683d, y: 0.7605123210420441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7986820265465019d, y: 0.8040442246878597d), new NpgsqlTypes.NpgsqlPoint(x: 0.37394450970383475d, y: 0.9740118826636358d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35658256267560184d, y: 0.009610109018346358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891124417157988d, y: 0.6626425150134091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056610966399119d, y: 0.29231875304273636d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3323323587076399d, y: 0.005133488049917201d), new NpgsqlTypes.NpgsqlPoint(x: 0.8958227432980231d, y: 0.15375769946843365d), new NpgsqlTypes.NpgsqlPoint(x: 0.172358635098123d, y: 0.3948858786396875d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5119862780355023d, y: 0.15237296054792693d), new NpgsqlTypes.NpgsqlPoint(x: 0.20529203380765915d, y: 0.03144564863373889d), new NpgsqlTypes.NpgsqlPoint(x: 0.37394238577712335d, y: 0.4990387245434015d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.770712888147387d, y: 0.6349391777868808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311151930390281d, y: 0.05672186993433659d), new NpgsqlTypes.NpgsqlPoint(x: 0.1049584105949507d, y: 0.788858922568739d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3998201213056737d, y: 0.09268152022154053d), new NpgsqlTypes.NpgsqlPoint(x: 0.2793254153421958d, y: 0.6865767075803098d), new NpgsqlTypes.NpgsqlPoint(x: 0.5493363007755045d, y: 0.9104143249781809d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5135720680999762d, y: 0.5694743555960967d), new NpgsqlTypes.NpgsqlPoint(x: 0.41865322584451214d, y: 0.400814474615133d), new NpgsqlTypes.NpgsqlPoint(x: 0.3040155994062532d, y: 0.33602817559657794d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8741331898383182d, y: 0.597266364518596d), new NpgsqlTypes.NpgsqlPoint(x: 0.4367900122877636d, y: 0.9112004821841573d), new NpgsqlTypes.NpgsqlPoint(x: 0.155584041041674d, y: 0.3906012082679936d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44823958071586123d, y: 0.1501218599003019d), new NpgsqlTypes.NpgsqlPoint(x: 0.2392293701855649d, y: 0.9110781535478708d), new NpgsqlTypes.NpgsqlPoint(x: 0.4657700939370234d, y: 0.9325865917601645d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2625006018141286d, y: 0.028067637068401652d), new NpgsqlTypes.NpgsqlPoint(x: 0.2018005091326246d, y: 0.8777708135331266d), new NpgsqlTypes.NpgsqlPoint(x: 0.23255199491880674d, y: 0.5278954734595284d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5145389370789172d, y: 0.3908035919668803d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260812256382336d, y: 0.05904596810888629d), new NpgsqlTypes.NpgsqlPoint(x: 0.800459751063723d, y: 0.7693518641561536d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18520562177820143d, y: 0.6205793170184912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7796289576172407d, y: 0.05132258373170451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7648008729733998d, y: 0.6548314714409463d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9130030729569817d, y: 0.9554929519316202d), new NpgsqlTypes.NpgsqlPoint(x: 0.6709140184378853d, y: 0.30496896209914603d), new NpgsqlTypes.NpgsqlPoint(x: 0.20248713554866515d, y: 0.3331924609135657d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4520150298947263d, y: 0.11273284938785488d), new NpgsqlTypes.NpgsqlPoint(x: 0.03647811767313014d, y: 0.20490046983900745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552391413851636d, y: 0.21052013211006948d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3399166165499343d, y: 0.22427371927842477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8665432624314008d, y: 0.8706791758648276d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619150547865596d, y: 0.5859181750704751d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4537870290183932d, y: 0.2883997116768775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6397956554142872d, y: 0.9130790858014717d), new NpgsqlTypes.NpgsqlPoint(x: 0.3031723401628128d, y: 0.28965016063236815d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7275872819071192d, y: 0.5225430959046921d), new NpgsqlTypes.NpgsqlPoint(x: 0.5011216083249515d, y: 0.6509647262628699d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765572675293633d, y: 0.3058614139498277d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7942122056191415d, y: 0.8972715594139423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728198915404965d, y: 0.4468402106345025d), new NpgsqlTypes.NpgsqlPoint(x: 0.17978415756845056d, y: 0.45991305368544655d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5761021609837511d, y: 0.6756133231002774d), new NpgsqlTypes.NpgsqlPoint(x: 0.3479085693552312d, y: 0.768346774340152d), new NpgsqlTypes.NpgsqlPoint(x: 0.9825149366064944d, y: 0.6369787642082234d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6921173293601217d, y: 0.5024769450803713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076607909104805d, y: 0.23163479431068268d), new NpgsqlTypes.NpgsqlPoint(x: 0.10761575684634006d, y: 0.8004070226843351d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14789496043310113d, y: 0.8151932567692608d), new NpgsqlTypes.NpgsqlPoint(x: 0.19682078766273214d, y: 0.6856557135377049d), new NpgsqlTypes.NpgsqlPoint(x: 0.838368323309205d, y: 0.03575425160679491d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10555209546938493d, y: 0.8169681045231385d), new NpgsqlTypes.NpgsqlPoint(x: 0.711883685731831d, y: 0.35397201786841503d), new NpgsqlTypes.NpgsqlPoint(x: 0.21364713744955655d, y: 0.7746188840392384d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6885116724634585d, y: 0.8955448791601069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449231291072535d, y: 0.553043708420636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5672067057828302d, y: 0.10081195740448079d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6728285569477703d, y: 0.5403128865249055d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072040883855628d, y: 0.925703917395882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5000723192881223d, y: 0.026697664690982337d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28791882109254197d, y: 0.5211914297342205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015353672390465d, y: 0.13593186816693315d), new NpgsqlTypes.NpgsqlPoint(x: 0.6604364590670199d, y: 0.6726791678669725d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6349519382339371d, y: 0.177007704389883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027327153082099d, y: 0.2508839088366357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7284478824442437d, y: 0.5040363790183848d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9281501106510393d, y: 0.09971311134044358d), new NpgsqlTypes.NpgsqlPoint(x: 0.4355864802702418d, y: 0.4281217218793192d), new NpgsqlTypes.NpgsqlPoint(x: 0.35461634252467344d, y: 0.8288941178812489d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4081774235997607d, y: 0.6671328742824125d), new NpgsqlTypes.NpgsqlPoint(x: 0.3587435338900107d, y: 0.3798349959770122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551765932399523d, y: 0.4638196327111048d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04932755450809556d, y: 0.31412252616014347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866570941595284d, y: 0.4080564295896707d), new NpgsqlTypes.NpgsqlPoint(x: 0.24620505673095927d, y: 0.05823673478335212d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18654874637244634d, y: 0.8456475139268259d), new NpgsqlTypes.NpgsqlPoint(x: 0.08985765500552922d, y: 0.39911561862642475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7385335785701774d, y: 0.9238379436369237d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7443699703364319d, y: 0.42701795381933894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7267387789573322d, y: 0.09901858294293431d), new NpgsqlTypes.NpgsqlPoint(x: 0.25996713778655267d, y: 0.7901357827831651d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.737874811064555d, y: 0.8815481164421282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9925718373442873d, y: 0.1688633861236465d), new NpgsqlTypes.NpgsqlPoint(x: 0.3256043906685441d, y: 0.0638738375986998d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6869599414898175d, y: 0.5718804725393856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805868680014755d, y: 0.933338337046902d), new NpgsqlTypes.NpgsqlPoint(x: 0.326005069793025d, y: 0.6785837162338756d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8199062186786726d, y: 0.18972898892055867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7160892527293478d, y: 0.8751685102126873d), new NpgsqlTypes.NpgsqlPoint(x: 0.786938016579266d, y: 0.2735144125685075d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7301919970282585d, y: 0.9371106904030831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414387866792819d, y: 0.7882357341718111d), new NpgsqlTypes.NpgsqlPoint(x: 0.1108894763916769d, y: 0.52403004188394d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4260096996306012d, y: 0.7348218098815326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5361663836742572d, y: 0.7922638968378374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9788071250406525d, y: 0.43553868856894107d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5198178319046705d, y: 0.0448866801629666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8319447284226341d, y: 0.9441718219347128d), new NpgsqlTypes.NpgsqlPoint(x: 0.66804600062869d, y: 0.5665195655624016d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07581816797161456d, y: 0.3179209259757698d), new NpgsqlTypes.NpgsqlPoint(x: 0.05986657077112312d, y: 0.03625869812838678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8598189537078001d, y: 0.31016367735200323d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6518147747337232d, y: 0.16557765696539362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3481404408032932d, y: 0.6316427184070785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910681631072436d, y: 0.22168631263816108d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0067122085684645505d, y: 0.8801210261572326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449338041574203d, y: 0.32716148273307943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570989871609295d, y: 0.6098843226415462d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7585644761073249d, y: 0.6613146140044629d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479736329355832d, y: 0.7736483474954197d), new NpgsqlTypes.NpgsqlPoint(x: 0.490245576283755d, y: 0.8422270778407708d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.259028230718336d, y: 0.2540203218840942d), new NpgsqlTypes.NpgsqlPoint(x: 0.4873716069838002d, y: 0.6977310959700349d), new NpgsqlTypes.NpgsqlPoint(x: 0.15736782415530037d, y: 0.9362128543996242d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09391676815714167d, y: 0.19695956169286732d), new NpgsqlTypes.NpgsqlPoint(x: 0.1191190351595095d, y: 0.23451661534230728d), new NpgsqlTypes.NpgsqlPoint(x: 0.41788053716943085d, y: 0.2840952994171141d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8030308956540955d, y: 0.42814687885758884d), new NpgsqlTypes.NpgsqlPoint(x: 0.922682928943855d, y: 0.5247595254854506d), new NpgsqlTypes.NpgsqlPoint(x: 0.952376156950968d, y: 0.19054377626134456d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8899233964838629d, y: 0.7651043339125758d), new NpgsqlTypes.NpgsqlPoint(x: 0.2725611033477068d, y: 0.9367660374446091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167841978136762d, y: 0.7591873981306361d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.331464379623734d, y: 0.5995707629304102d), new NpgsqlTypes.NpgsqlPoint(x: 0.563237759645079d, y: 0.2925140535894152d), new NpgsqlTypes.NpgsqlPoint(x: 0.3189361755670935d, y: 0.9925002938902936d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6062517205201834d, y: 0.12418423281128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9125521844472162d, y: 0.3559856357646274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799112529853843d, y: 0.3682496851140541d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 173,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8156460883927183d, y: 0.7909192560139879d), new NpgsqlTypes.NpgsqlPoint(x: 0.1457137389698394d, y: 0.9104638071729864d), new NpgsqlTypes.NpgsqlPoint(x: 0.20348074690461304d, y: 0.22034338367739692d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8161127734996559d, y: 0.7444590988773426d), new NpgsqlTypes.NpgsqlPoint(x: 0.31414947701039275d, y: 0.2648095886836286d), new NpgsqlTypes.NpgsqlPoint(x: 0.4170791914014431d, y: 0.8449625778387353d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06746840629486828d, y: 0.012576979341424654d), new NpgsqlTypes.NpgsqlPoint(x: 0.10843397965826007d, y: 0.2813416443944038d), new NpgsqlTypes.NpgsqlPoint(x: 0.4287430823521138d, y: 0.40546110716548633d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3439543887740435d, y: 0.32576492179450967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6854515368675584d, y: 0.8005561918129331d), new NpgsqlTypes.NpgsqlPoint(x: 0.28707677001655985d, y: 0.14396588201074856d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7219316528150295d, y: 0.6693982462157073d), new NpgsqlTypes.NpgsqlPoint(x: 0.23176757169088746d, y: 0.12300453770178199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910928783817548d, y: 0.42966773333681463d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9298252708245636d, y: 0.3574689163059097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7048124496630129d, y: 0.4574172681762748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207869366174088d, y: 0.508047386334238d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 182,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1254365811986633d, y: 0.7809855388913262d), new NpgsqlTypes.NpgsqlPoint(x: 0.11293713997532229d, y: 0.8021377702834093d), new NpgsqlTypes.NpgsqlPoint(x: 0.26225563704407906d, y: 0.777556335996755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14150689494099034d, y: 0.4837116502401503d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386963963976194d, y: 0.05766589109472986d), new NpgsqlTypes.NpgsqlPoint(x: 0.26687407069389846d, y: 0.15678909019192522d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.972500201201271d, y: 0.6043902852419554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6813028797096872d, y: 0.08245062658551838d), new NpgsqlTypes.NpgsqlPoint(x: 0.06809555525229072d, y: 0.15570128776249326d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9167753008940652d, y: 0.0984614777528886d), new NpgsqlTypes.NpgsqlPoint(x: 0.17257048609909464d, y: 0.285384081653417d), new NpgsqlTypes.NpgsqlPoint(x: 0.9637026031566669d, y: 0.922995572155558d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 191,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.995154804927638d, y: 0.08519670502076959d), new NpgsqlTypes.NpgsqlPoint(x: 0.2587200747950693d, y: 0.7332775949930108d), new NpgsqlTypes.NpgsqlPoint(x: 0.36776445948495173d, y: 0.1408426780623373d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5254201619100679d, y: 0.9325356391788915d), new NpgsqlTypes.NpgsqlPoint(x: 0.9665244509482236d, y: 0.11618250091234672d), new NpgsqlTypes.NpgsqlPoint(x: 0.08199201886109031d, y: 0.4981697696334386d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37773207183307644d, y: 0.9822863295348576d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832442561949812d, y: 0.7176557811614614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9520197842978001d, y: 0.10710001892569443d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12966804594099424d, y: 0.8177449457843722d), new NpgsqlTypes.NpgsqlPoint(x: 0.922100433979038d, y: 0.6556610510143872d), new NpgsqlTypes.NpgsqlPoint(x: 0.23784337252285048d, y: 0.4151773451907026d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7651914760810667d, y: 0.1976532600174794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5706022977608665d, y: 0.8769762309191163d), new NpgsqlTypes.NpgsqlPoint(x: 0.23849022104946693d, y: 0.7042459410529427d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8022308114158113d, y: 0.37247890849925536d), new NpgsqlTypes.NpgsqlPoint(x: 0.487088441997543d, y: 0.00869129774427757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6558054164448711d, y: 0.15146299709092947d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22839662530788207d, y: 0.9751727809464571d), new NpgsqlTypes.NpgsqlPoint(x: 0.5885913203820462d, y: 0.94659988427981d), new NpgsqlTypes.NpgsqlPoint(x: 0.44737490079191555d, y: 0.8263264036090484d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8304812668999718d, y: 0.24508174774870017d), new NpgsqlTypes.NpgsqlPoint(x: 0.2287637094313607d, y: 0.6423235251205848d), new NpgsqlTypes.NpgsqlPoint(x: 0.07342769734473809d, y: 0.542620885770551d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5461781582182246d, y: 0.3290070298909573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8962955649364219d, y: 0.5584106222350607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9489778358994156d, y: 0.5360824211226339d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3545002434450766d, y: 0.31409725022566926d), new NpgsqlTypes.NpgsqlPoint(x: 0.05056604780471574d, y: 0.6558301561405018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8676712336158775d, y: 0.34276435490067625d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5521004545151071d, y: 0.37312605303682167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177916036430313d, y: 0.5615568920491413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407007800374292d, y: 0.5887785286501169d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38976913545003156d, y: 0.7930042437931016d), new NpgsqlTypes.NpgsqlPoint(x: 0.48724820092923615d, y: 0.16145028824322583d), new NpgsqlTypes.NpgsqlPoint(x: 0.7188032528790755d, y: 0.7874830314937238d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23181076166658787d, y: 0.5564831830250053d), new NpgsqlTypes.NpgsqlPoint(x: 0.06413952314503923d, y: 0.7116554366669638d), new NpgsqlTypes.NpgsqlPoint(x: 0.14911010005778846d, y: 0.3165101362573921d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23856298568008183d, y: 0.9585855588083798d), new NpgsqlTypes.NpgsqlPoint(x: 0.6640923190725317d, y: 0.7974823391125357d), new NpgsqlTypes.NpgsqlPoint(x: 0.1760222787643103d, y: 0.2446741339550247d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8887772293966495d, y: 0.9282147479744279d), new NpgsqlTypes.NpgsqlPoint(x: 0.07465229103608095d, y: 0.4991787813193662d), new NpgsqlTypes.NpgsqlPoint(x: 0.533928634286875d, y: 0.4881686172321723d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 198,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07372354275699877d, y: 0.6617108413029752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5856444584748535d, y: 0.8143607321375683d), new NpgsqlTypes.NpgsqlPoint(x: 0.7696035975835741d, y: 0.8404242783340459d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28015135190260854d, y: 0.15254007085754084d), new NpgsqlTypes.NpgsqlPoint(x: 0.38575134620681184d, y: 0.6233249166354832d), new NpgsqlTypes.NpgsqlPoint(x: 0.017624637682183808d, y: 0.03489268892276587d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6848731980430148d, y: 0.4402197990988642d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366960980318453d, y: 0.8214310286352244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4248038228785923d, y: 0.918704193920367d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4568757672835134d, y: 0.487689430579597d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899841211567889d, y: 0.9841403046689966d), new NpgsqlTypes.NpgsqlPoint(x: 0.07471545122944412d, y: 0.8026073446949714d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9013960085672589d, y: 0.6323177954559598d), new NpgsqlTypes.NpgsqlPoint(x: 0.26324893304432007d, y: 0.7861736708158604d), new NpgsqlTypes.NpgsqlPoint(x: 0.3963324038787992d, y: 0.6803183864003867d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49737774215655917d, y: 0.4041008030486489d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319470081658089d, y: 0.35142397120759494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9912760539345978d, y: 0.3083130544685039d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 202,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8128813985768739d, y: 0.20590133432121183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9404894236471755d, y: 0.18260519960061683d), new NpgsqlTypes.NpgsqlPoint(x: 0.6096830007892168d, y: 0.3919199002555662d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8771952822895108d, y: 0.3276992955241468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4591738060484163d, y: 0.7061296103604356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8691523628936497d, y: 0.5833171395327159d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9695613943670165d, y: 0.4827642857488582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628773965777287d, y: 0.5103070944395595d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088689102945421d, y: 0.054888779790789655d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09592291065045544d, y: 0.3750851669997024d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885285674908124d, y: 0.37284546021486664d), new NpgsqlTypes.NpgsqlPoint(x: 0.4255698220718088d, y: 0.7454120540639038d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7248034264892431d, y: 0.9833920723454904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8156840242027275d, y: 0.13807072312291158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105307113964957d, y: 0.0005713773537411315d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17459184854312626d, y: 0.5109039661365156d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413664616376822d, y: 0.9424144566264523d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372898148916309d, y: 0.07309735086355285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17922693275757973d, y: 0.8684269635090557d), new NpgsqlTypes.NpgsqlPoint(x: 0.32257496156505994d, y: 0.03849521100862108d), new NpgsqlTypes.NpgsqlPoint(x: 0.020921525268182473d, y: 0.6905149682196279d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48931873797763725d, y: 0.018369354952782024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5914487749155846d, y: 0.5829732360842341d), new NpgsqlTypes.NpgsqlPoint(x: 0.8191051806141112d, y: 0.61395367982691d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.58032191362463d, y: 0.7729572857041116d), new NpgsqlTypes.NpgsqlPoint(x: 0.4473719919298975d, y: 0.38401063072954333d), new NpgsqlTypes.NpgsqlPoint(x: 0.1921436380648751d, y: 0.39598985164429334d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24259212157269783d, y: 0.5228629673505578d), new NpgsqlTypes.NpgsqlPoint(x: 0.036454486855939994d, y: 0.5480030185059789d), new NpgsqlTypes.NpgsqlPoint(x: 0.8933939459655804d, y: 0.8674019009929248d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 206,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9519979505598094d, y: 0.055363256935144545d), new NpgsqlTypes.NpgsqlPoint(x: 0.22968883296556963d, y: 0.8437023877707049d), new NpgsqlTypes.NpgsqlPoint(x: 0.43201977248960866d, y: 0.5061127127282937d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14186999205933593d, y: 0.17093925306008229d), new NpgsqlTypes.NpgsqlPoint(x: 0.14388746101932792d, y: 0.3176130081723463d), new NpgsqlTypes.NpgsqlPoint(x: 0.36808740194041467d, y: 0.3246021134495546d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9731589795153188d, y: 0.11015320087121283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7293332873624492d, y: 0.3462230234125493d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590113231836308d, y: 0.2997386707025419d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7715687009085375d, y: 0.5747118458806072d), new NpgsqlTypes.NpgsqlPoint(x: 0.1438276701263791d, y: 0.6631566056362835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3461664986537407d, y: 0.4495507924336394d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44565403741984877d, y: 0.15638320761185842d), new NpgsqlTypes.NpgsqlPoint(x: 0.9119735524645614d, y: 0.9865300241513899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417184474290002d, y: 0.904617677681623d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4118670611462337d, y: 0.748678717141957d), new NpgsqlTypes.NpgsqlPoint(x: 0.10059783001285427d, y: 0.6620562796197348d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369690058425293d, y: 0.9280562748524596d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4491660187313955d, y: 0.8901914223766052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629327734601077d, y: 0.003761896534208664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3881296731570676d, y: 0.40078598311926006d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1392492875675554d, y: 0.5275049431099218d), new NpgsqlTypes.NpgsqlPoint(x: 0.34446968125162114d, y: 0.816479646416401d), new NpgsqlTypes.NpgsqlPoint(x: 0.18675484667730646d, y: 0.6912864700961532d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
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
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7276981144560682d, y: 0.6660609395334733d), new NpgsqlTypes.NpgsqlPoint(x: 0.38540960611496256d, y: 0.3353023976789713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5277283818293727d, y: 0.02896228652250643d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1074826728629551d, y: 0.736361018898458d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183154058912269d, y: 0.5967252384731249d), new NpgsqlTypes.NpgsqlPoint(x: 0.4741606838203374d, y: 0.3994748678058513d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0004058043567778391d, y: 0.9497939660237806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3890803426947923d, y: 0.47198722433349083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7852248973277d, y: 0.09409513034501649d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8273485771443628d, y: 0.6255522277866935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384204410874263d, y: 0.5450106718506387d), new NpgsqlTypes.NpgsqlPoint(x: 0.33065102371412336d, y: 0.03026953120804088d)),
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32184244855275324d, y: 0.1483641123925432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7964840779771458d, y: 0.4290687920789771d), new NpgsqlTypes.NpgsqlPoint(x: 0.6096375839991125d, y: 0.5674459956026203d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1279017986463683d, y: 0.04436013218747514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4288630033844144d, y: 0.8613165246555192d), new NpgsqlTypes.NpgsqlPoint(x: 0.22701886490407808d, y: 0.938755916186153d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25278928977104176d, y: 0.7869169941385913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346061330604565d, y: 0.2844263972051565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3682995408886518d, y: 0.6011785051677041d)),
}));
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07907480370935582d, y: 0.9829593732594165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550430203729309d, y: 0.777713458934419d), new NpgsqlTypes.NpgsqlPoint(x: 0.3054579692541308d, y: 0.5270619341374512d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.316333687578506d, y: 0.12512379663324014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091044597998331d, y: 0.49863250787937774d), new NpgsqlTypes.NpgsqlPoint(x: 0.018936417470960643d, y: 0.25251183919917286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008144596792224013d, y: 0.3996573458649112d), new NpgsqlTypes.NpgsqlPoint(x: 0.08483116061366391d, y: 0.4766098981318262d), new NpgsqlTypes.NpgsqlPoint(x: 0.43778834379653353d, y: 0.9759257873446784d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8291244786400116d, y: 0.0911622727899909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374524035255692d, y: 0.8145959662369604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4286982213606636d, y: 0.45346884545723565d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.938362697044152d, y: 0.9688534510852664d), new NpgsqlTypes.NpgsqlPoint(x: 0.11148900657662464d, y: 0.4507199573516325d), new NpgsqlTypes.NpgsqlPoint(x: 0.21182868004387567d, y: 0.8141864501746859d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06401405950824468d, y: 0.1889829184321754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214750752352183d, y: 0.9117379929145585d), new NpgsqlTypes.NpgsqlPoint(x: 0.030383104855643772d, y: 0.6284731557093135d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3680724406926431d, y: 0.3084433022687363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6585568859754941d, y: 0.7685225381807065d), new NpgsqlTypes.NpgsqlPoint(x: 0.37627150461420245d, y: 0.14751636061534112d)),
}));
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.039445849629528795d, y: 0.03451203878596565d), new NpgsqlTypes.NpgsqlPoint(x: 0.12764125992645003d, y: 0.30261565251413114d), new NpgsqlTypes.NpgsqlPoint(x: 0.008150609192026814d, y: 0.171350507543632d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4607573506411895d, y: 0.6862379280358114d), new NpgsqlTypes.NpgsqlPoint(x: 0.943375561757405d, y: 0.4667360560360634d), new NpgsqlTypes.NpgsqlPoint(x: 0.3789624445128159d, y: 0.8233666219213596d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48777777901677d, y: 0.6961470436027983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626974671573292d, y: 0.1622322653397834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469590591388078d, y: 0.22903502932330744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5040671729874765d, y: 0.4628651733084823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412784905248441d, y: 0.5030878657282349d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180372119877935d, y: 0.9376355456975497d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 182;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 4;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 191;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 14, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 93, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 182, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 59, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 191, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 149, query1, 158, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 93, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatch(connection, 22, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[30], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[31], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[32], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[33], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[29], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[30], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[31], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[32], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[33], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonArraypolygonArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonArraypolygonArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MI),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonArraypolygonArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonArraypolygonArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1M),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
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
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
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
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

