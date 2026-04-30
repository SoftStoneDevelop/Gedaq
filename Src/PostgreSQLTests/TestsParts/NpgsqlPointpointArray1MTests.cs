

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9200389493333205d, y: 0.3265690944177303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8733756213785545d, y: 0.7922258326428362d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6062139517682889d, y: 0.3475663739486411d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1795610352298581d, y: 0.6579078426771402d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3698623095424691d, y: 0.7072816688581487d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2426517404419143d, y: 0.15048120487437844d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22829934089116388d, y: 0.29566488097258325d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8613118354764258d, y: 0.24519725537447967d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7522656061057025d, y: 0.6283643902409977d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19947964806802732d, y: 0.6231295317262217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5041164505744506d, y: 0.41296364119546525d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8270403274567404d, y: 0.8834096363629804d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6345517693971096d, y: 0.9461821805799788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22951934898363946d, y: 0.29048196956401473d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8709023150210944d, y: 0.29849690169639387d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2933418709128798d, y: 0.5019527186434346d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2134558988051798d, y: 0.9040379793967815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23151763277943727d, y: 0.35471557309591883d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11490620455459777d, y: 0.11132550864816781d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04340988801775314d, y: 0.25385105712087064d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20390228451460213d, y: 0.6993470678263622d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.505689869689386d, y: 0.22328312073317713d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9094671232984401d, y: 0.1568889845841207d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1246526238868868d, y: 0.16333966516060539d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03553910813967853d, y: 0.08982014654525927d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3868159836827263d, y: 0.0543830403544574d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29178004610385433d, y: 0.5975936060153171d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6989829779367872d, y: 0.5703691256687231d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3699309858460922d, y: 0.7046731822656946d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9644540011618234d, y: 0.01944985301280333d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07615297721734304d, y: 0.9350060941633801d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03258114998741546d, y: 0.19557415727226435d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07391165581813397d, y: 0.4878375396190986d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8809189377804222d, y: 0.5256899699554013d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19529103883156718d, y: 0.7674081898847042d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7269723901766789d, y: 0.20175934469981305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5449607717121728d, y: 0.934021005491356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9568795854936082d, y: 0.7299260418712412d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20722524746433535d, y: 0.3245804840056502d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4454339867605157d, y: 0.17886123859871272d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28762278057112123d, y: 0.9095927816738879d),
new NpgsqlTypes.NpgsqlPoint(x: 0.027181059029976584d, y: 0.4019923306411448d),
new NpgsqlTypes.NpgsqlPoint(x: 0.523223172880909d, y: 0.43559316478703825d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39807206378533366d, y: 0.002721961447649468d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1623076458956687d, y: 0.889038800484006d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11478501018973841d, y: 0.6593122922175415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.79343824476914d, y: 0.07915728613097617d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13866831529199786d, y: 0.9178107561916834d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2249886555709677d, y: 0.4148526921757215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20774130847458006d, y: 0.9524507870730716d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2915690095909953d, y: 0.0867825507824248d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13032671654757144d, y: 0.4816850139239405d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2758578231499391d, y: 0.04681188187565788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7352368090192448d, y: 0.25576876889714106d),
new NpgsqlTypes.NpgsqlPoint(x: 0.056285572163805475d, y: 0.03876655457337563d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.832876734636209d, y: 0.302016169885579d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9705531872324725d, y: 0.505428785029434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7688485631600451d, y: 0.329534726730181d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9769210993862534d, y: 0.5523236202220929d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5085805461013104d, y: 0.11589503172470583d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5477019629414638d, y: 0.7620464179121782d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5164556998370993d, y: 0.3343427437992663d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.100725142710135d, y: 0.4163840615499409d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3165955661478178d, y: 0.47381574179676933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7120428631108799d, y: 0.11780992042161798d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7124857011810292d, y: 0.9155004343727089d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6283646451199189d, y: 0.18749108729293484d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15901066176126566d, y: 0.8283387039487249d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5476961563850693d, y: 0.2757480642796516d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5959279884747974d, y: 0.7569006462856284d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34752600591324134d, y: 0.8647993802991313d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9109966278004921d, y: 0.2974291587939992d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8029301379433171d, y: 0.22638984155827413d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9974570559935206d, y: 0.25133753856766683d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36702303733622055d, y: 0.5424087086804228d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18574519517953914d, y: 0.724889272636548d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4962475538213146d, y: 0.7377682700352881d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9603218896188238d, y: 0.22099767295034134d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18786744858476845d, y: 0.5110223901570092d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20396711443093019d, y: 0.5160336404629411d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6886930861042694d, y: 0.913894027933669d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6682827322028453d, y: 0.8294227581869936d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8333847410221438d, y: 0.7012529186777686d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6293161028062522d, y: 0.7332566257218995d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8948080698647202d, y: 0.7617857231289814d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37673966037402473d, y: 0.7868177536234076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08252066293683291d, y: 0.13296011192834234d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1155752106249085d, y: 0.5825103301561221d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3700066344660006d, y: 0.7733713585640424d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05836670379061015d, y: 0.923264716828434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.01708278210497105d, y: 0.6918202257527919d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1299115747756402d, y: 0.2921057542959764d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03567701075427787d, y: 0.2871133195090927d),
new NpgsqlTypes.NpgsqlPoint(x: 0.636742472761184d, y: 0.397245379869123d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9967266817202441d, y: 0.9010119913621741d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30935728177658506d, y: 0.7719243718387756d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6245420649854138d, y: 0.2175308375209789d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13433536743581453d, y: 0.40028303749905436d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42304566575982183d, y: 0.9518488135173745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0697117795000044d, y: 0.6521389671584379d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09990834588208386d, y: 0.32053170354711d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7444677744685992d, y: 0.012278353274092657d),
new NpgsqlTypes.NpgsqlPoint(x: 0.129218458768961d, y: 0.22973679080469134d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15525226823135274d, y: 0.41031987320016383d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22186506660005367d, y: 0.7249536091067114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5710328470218178d, y: 0.7062638956773485d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5976447951472854d, y: 0.916692782718546d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9634062514109203d, y: 0.5583109209735545d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3498132060883543d, y: 0.5315944142220668d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5022438374552166d, y: 0.43034136579569604d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6031284788160337d, y: 0.7676616847901778d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8057686417097579d, y: 0.5608203762083539d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4991456906695527d, y: 0.9575187492571766d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42426960251184553d, y: 0.3115027587273903d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23647428657024894d, y: 0.5817959423567924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3800528766070509d, y: 0.6473087856103857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48805146931504384d, y: 0.2666821399729744d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2264069260320436d, y: 0.2624131250997459d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9341846725431401d, y: 0.20960136307515065d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7181050832687261d, y: 0.9981347629916842d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5969651248839388d, y: 0.30862625163779d),
new NpgsqlTypes.NpgsqlPoint(x: 0.519512267316933d, y: 0.32158495257304d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1436397903079346d, y: 0.8235826375048096d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4568280548799857d, y: 0.9157468490217302d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7551344868826925d, y: 0.006501193821969675d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8108068258136523d, y: 0.6518404197782404d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17093570109595313d, y: 0.45037232094352553d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28184719327112706d, y: 0.36947244786328004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4606182206120991d, y: 0.09985563005075682d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24457067740243976d, y: 0.6599452747647172d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6684479407605973d, y: 0.10331706647872285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20302046188292078d, y: 0.03396890085663884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.541213462939672d, y: 0.965794226810924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7864223354647969d, y: 0.9187082727829728d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0029337187379795404d, y: 0.58744990720776d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8675691313736409d, y: 0.2749988548003459d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8333299918610547d, y: 0.7726221446533109d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23144006269813244d, y: 0.258469872739284d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9242135731603566d, y: 0.9189185711758548d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4846680325532473d, y: 0.691333646740311d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8898190361791386d, y: 0.4424253942884737d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38512583535153844d, y: 0.5520479698457257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9065512868861868d, y: 0.8096840608725487d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9000425780429008d, y: 0.29043118511558963d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12691778281876132d, y: 0.954932924007284d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6736033405405037d, y: 0.28428204729002204d),
new NpgsqlTypes.NpgsqlPoint(x: 0.908142367129079d, y: 0.44788751766993895d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8437266726649506d, y: 0.037066346125140925d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34225995560335365d, y: 0.5617066489109516d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9567984382842375d, y: 0.777873142235407d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6522838735474531d, y: 0.22785150934493992d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7458278847222459d, y: 0.028487440833439237d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5908866092923145d, y: 0.09680241825253677d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9171676068115006d, y: 0.9721471813403884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7538657869014366d, y: 0.03837639644547752d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6392663308395551d, y: 0.7455028386658105d),
new NpgsqlTypes.NpgsqlPoint(x: 0.861506556784611d, y: 0.5180648964974691d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8852924648312533d, y: 0.7661035887954526d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27454022727229366d, y: 0.0457083138311245d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4272912354556986d, y: 0.12755910060464148d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14972739594780626d, y: 0.03317097054434481d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7871187863254714d, y: 0.2544048766257111d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1301690110645557d, y: 0.24708383410936807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3395848538698285d, y: 0.821962708784864d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8595417134797638d, y: 0.19218068260500354d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4223318869623809d, y: 0.10950854181977865d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10849300735648892d, y: 0.49330138036291105d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7121883824160204d, y: 0.5672966967224005d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06068049336621717d, y: 0.23851364263912656d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1548065660874164d, y: 0.4842878160923749d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5220625859310278d, y: 0.8185818723170206d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6386656238078215d, y: 0.3852244241402941d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9999016746658039d, y: 0.6488987343507631d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24521754438047372d, y: 0.31038166792735833d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05264745022297812d, y: 0.3129279499244485d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8936157377203549d, y: 0.988871352903951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.513019121299851d, y: 0.08328076912679883d),
new NpgsqlTypes.NpgsqlPoint(x: 0.944665509664111d, y: 0.14386146816232692d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.588848088635283d, y: 0.5003558104152052d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8854481733411177d, y: 0.464558383545711d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9650307773742876d, y: 0.29311737730261067d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9999335540108887d, y: 0.7684446851624411d),
new NpgsqlTypes.NpgsqlPoint(x: 0.427521049021349d, y: 0.1607307552296483d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3684816248754277d, y: 0.6132249355115824d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9370679453089448d, y: 0.6342708741806063d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01129873817896132d, y: 0.5101499977648208d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1859955743341687d, y: 0.8669388227758943d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5461527970468534d, y: 0.3476005074630425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.739731144467016d, y: 0.9014175392609143d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4866133485085118d, y: 0.7946741942525583d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4936463957868191d, y: 0.289840928183138d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5605574531783787d, y: 0.30053519995547184d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5319207972379674d, y: 0.5667258505799608d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9233415707848698d, y: 0.7160180817057843d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15570097575681552d, y: 0.3822751439679525d),
new NpgsqlTypes.NpgsqlPoint(x: 0.504919672528554d, y: 0.05499198327051247d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2454537638488289d, y: 0.8696933962851697d),
new NpgsqlTypes.NpgsqlPoint(x: 0.664408780318276d, y: 0.5024484244288927d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4334168748396816d, y: 0.41573909727057745d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4822167077967706d, y: 0.46825929446390446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09652572205798715d, y: 0.3190790055582938d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7794477310044581d, y: 0.5416492785878806d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4817109426526184d, y: 0.10843782519688505d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7204514604846927d, y: 0.09630364622518683d),
new NpgsqlTypes.NpgsqlPoint(x: 0.523739802611831d, y: 0.692810940340886d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9775276998845156d, y: 0.27336069019358755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7900253671231754d, y: 0.6662312251011037d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8731009399775325d, y: 0.47062419980554093d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2622653429364309d, y: 0.00246189792431617d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3858686598046599d, y: 0.027486298311094837d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11424316814068769d, y: 0.5990075977110513d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06387880639959775d, y: 0.0246398577184318d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7118371373293245d, y: 0.19778413611479462d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9361490719353626d, y: 0.8579120106520701d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7972560499683683d, y: 0.11723347075016421d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8491331842119194d, y: 0.3199108801879522d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9767079205785463d, y: 0.8041456306624771d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44867241389843293d, y: 0.1394853848012736d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9474185835264146d, y: 0.8633058868863059d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8566747857644794d, y: 0.5165667262179248d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49225291217817213d, y: 0.1297695507801785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37585700853257176d, y: 0.9480708371369109d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1197045343370099d, y: 0.8178518470326851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3860702505586866d, y: 0.19427127372788955d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37179782461235966d, y: 0.48550805320445845d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4050508856435032d, y: 0.10410899853481881d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10261115576800706d, y: 0.9905640901150279d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6007983941221711d, y: 0.8520438351168429d),
new NpgsqlTypes.NpgsqlPoint(x: 0.912068050023974d, y: 0.562077804488808d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27619637087361637d, y: 0.7080238009388036d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9822639644634044d, y: 0.1912799174822425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43963639144106137d, y: 0.025810234388826347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7465940453320393d, y: 0.6206031584267905d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5977146450719634d, y: 0.7645743278529755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06056853509583826d, y: 0.7666374483301295d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2901115499738276d, y: 0.08642921810040782d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18059460102875635d, y: 0.10333443614703608d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5244259927845025d, y: 0.47298985690885875d),
new NpgsqlTypes.NpgsqlPoint(x: 0.019485572499905235d, y: 0.7289134651036886d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46183617289050416d, y: 0.018822933841559863d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6549285631219518d, y: 0.6707770869049292d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5087260655550323d, y: 0.48352635465178306d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3555788336485103d, y: 0.4181666619347443d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12883472707217924d, y: 0.008247589141540557d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9614019899443225d, y: 0.08552122092929781d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5434190120083494d, y: 0.044008420213977884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21785526921190446d, y: 0.597049415676705d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07274651000818555d, y: 0.9811892757624951d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31102892381688374d, y: 0.17462801118245352d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6745625271530931d, y: 0.6058073467180104d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6669762220511866d, y: 0.6493284192039807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2103826449778935d, y: 0.2915547251788687d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9716361017162747d, y: 0.8453717300558694d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8377335352767663d, y: 0.3254975554756484d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05588049105389137d, y: 0.34363486385978814d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8864457104500099d, y: 0.4797155085717687d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9046787478381362d, y: 0.348682999626017d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7192047518458249d, y: 0.7377505827206133d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6329496123753132d, y: 0.42441293866887475d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2802690386812977d, y: 0.48300816954228076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12349711905321437d, y: 0.43294160708495755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7676596865016447d, y: 0.6415363535362485d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9563356053091889d, y: 0.8381416635444716d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14687985645467982d, y: 0.6590307520600321d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42506606080934517d, y: 0.6975500881614977d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3470841723297313d, y: 0.8047937373456845d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4311177936336089d, y: 0.39162140532623635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6302709594128273d, y: 0.2871644108732474d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21946066225180005d, y: 0.6024861311070377d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5061015557247701d, y: 0.8673140668467039d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5623800480972149d, y: 0.23166133117829124d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31102792245955446d, y: 0.2791463749695434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6092870704149701d, y: 0.7039794115754412d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3577595993584741d, y: 0.05781308876306257d),
new NpgsqlTypes.NpgsqlPoint(x: 3.589721542573976E-05d, y: 0.07869300913685662d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9672170891665854d, y: 0.6132821704572837d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5753329772733456d, y: 0.05115591487184468d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13408387098939722d, y: 0.9740932919582941d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7558394304842716d, y: 0.8244098022603141d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6299222545033595d, y: 0.5718055868327191d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7269723901766789d, y: 0.20175934469981305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5449607717121728d, y: 0.934021005491356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9568795854936082d, y: 0.7299260418712412d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20722524746433535d, y: 0.3245804840056502d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13032671654757144d, y: 0.4816850139239405d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2758578231499391d, y: 0.04681188187565788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7352368090192448d, y: 0.25576876889714106d),
new NpgsqlTypes.NpgsqlPoint(x: 0.056285572163805475d, y: 0.03876655457337563d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9769210993862534d, y: 0.5523236202220929d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5085805461013104d, y: 0.11589503172470583d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5477019629414638d, y: 0.7620464179121782d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5164556998370993d, y: 0.3343427437992663d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9974570559935206d, y: 0.25133753856766683d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36702303733622055d, y: 0.5424087086804228d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18574519517953914d, y: 0.724889272636548d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4962475538213146d, y: 0.7377682700352881d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6682827322028453d, y: 0.8294227581869936d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8333847410221438d, y: 0.7012529186777686d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6293161028062522d, y: 0.7332566257218995d),
}));
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 93, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 90, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 147, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 155, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 100, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 70, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 48, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 35, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[32], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[33], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[30], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[31], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[32], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[33], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI), typeof(NpgsqlPointpointArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                await ((INpgsqlPointArraypointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                ((INpgsqlPointArraypointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

