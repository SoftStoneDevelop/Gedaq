

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IUInt64MArrayMArrayD2
    {
    }
    
    internal partial class UInt64MArrayMArrayD2 : IUInt64MArrayMArrayD2
    {


#region TestData

        private readonly UInt64MArrayD2E1M[] _testData = new UInt64MArrayD2E1M[]
        {
            new UInt64MArrayD2E1M
{
    Id = 9,
    Value = 
new System.UInt64[,] { { 8252844216347288566L, 6886374229288884420L, }, { 2262532060273333733L, 2891490291617507525L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 3,
    Value = 
new System.UInt64[,] { { 3318586539155506924L, 6731660561646441257L, }, { 8147095747940878797L, 7399558791066171013L, }, },
    NullableValue = 
new System.UInt64[,] { { 310310903845145824L, 7513146093873648243L, }, { 8708628072387948242L, 3148444155243670877L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 8483703946966421417L, 3979093828644365980L, }, { 3753429994814865168L, 8059387158751778197L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 16,
    Value = 
new System.UInt64[,] { { 2995148995252582269L, 2200708936049921102L, }, { 4336118723828137222L, 8744596883073313233L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 4,
    Value = 
new System.UInt64[,] { { 8924547392851433368L, 2464294854735530191L, }, { 1932604120646861670L, 9219710984701555938L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 5692627291040481386L, 5547104078026299034L, }, { 4812139085540183057L, 6394759347204542363L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 24,
    Value = 
new System.UInt64[,] { { 4246944727218893355L, 3916824322428641423L, }, { 7263904377905516482L, 611789289916653203L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 13,
    Value = 
new System.UInt64[,] { { 1433225343555605889L, 3861768818439740039L, }, { 6761790265079618865L, 7667529358259103385L, }, },
    NullableValue = 
new System.UInt64[,] { { 4121272514291826520L, 2088794048232791146L, }, { 6227083298110901916L, 3463881003460608138L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 6718686125061412640L, 7978875812999174256L, }, { 3846114988652480201L, 4932477955947846276L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 31,
    Value = 
new System.UInt64[,] { { 5292686232760503378L, 5562044262198098908L, }, { 7132382871813016222L, 7287538059672365343L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.UInt64[,] { { 8402784359203402210L, 2058256977258326596L, }, { 3946093408676576305L, 2369641987476569275L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 36,
    Value = 
new System.UInt64[,] { { 3849826846103788323L, 8509594274598265893L, }, { 2684964308529265547L, 5212093370230419158L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.UInt64[,] { { 8767096184511572048L, 690126311983382456L, }, { 3317902325695874767L, 8343283566392480660L, }, },
    NullableValue = 
new System.UInt64[,] { { 665056008893714794L, 3643227002380452502L, }, { 3238511293601479578L, 5818195107624030800L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 40,
    Value = 
new System.UInt64[,] { { 7426357049871061491L, 1072090279137823459L, }, { 1901933380200053226L, 8402882535767219053L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.UInt64[,] { { 7858958099567816047L, 1055397915693781682L, }, { 5883476745261507640L, 5292410519714517676L, }, },
    NullableValue = 
new System.UInt64[,] { { 8264637640876061084L, 4056546304105707836L, }, { 6280619404423856071L, 5970014969558806897L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 3629057896579569976L, 7067085618067369552L, }, { 6298614643321086139L, 1612977172496394642L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 48,
    Value = 
new System.UInt64[,] { { 3236350738881254109L, 4718713926791558265L, }, { 5972678953084697662L, 6066121059859960052L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 29,
    Value = 
new System.UInt64[,] { { 1668804640295818338L, 8159552116079225808L, }, { 6850278508083474761L, 7820407448443919346L, }, },
    NullableValue = 
new System.UInt64[,] { { 1839282592650429438L, 356580685738874904L, }, { 3399404102745387657L, 7162487546339660643L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 51,
    Value = 
new System.UInt64[,] { { 5859941856929885775L, 3413681588062520883L, }, { 8067796066749858758L, 3096372772319196321L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 30,
    Value = 
new System.UInt64[,] { { 4264163731228598726L, 3842723359291584707L, }, { 1429415374477106117L, 5303675205728568299L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 60,
    Value = 
new System.UInt64[,] { { 3470022868029672260L, 313971674365479179L, }, { 1146801026899256785L, 1586788101500468994L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.UInt64[,] { { 1796415827847007550L, 1492051834728795610L, }, { 1544850646772659134L, 6594667747307364040L, }, },
    NullableValue = 
new System.UInt64[,] { { 4092389127005721795L, 6224138826288069939L, }, { 2046180069357894987L, 6537758319652090412L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 6110553992029951651L, 629285249441544711L, }, { 7356977737358944020L, 1806611785795533351L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 63,
    Value = 
new System.UInt64[,] { { 285309354528637929L, 2287926580067407749L, }, { 4897033309996525526L, 128141993315144909L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 38,
    Value = 
new System.UInt64[,] { { 6454237877669741110L, 2132179036437576058L, }, { 7872839569832376310L, 8647973591088409755L, }, },
    NullableValue = 
new System.UInt64[,] { { 3959062696979933777L, 5622371979212252099L, }, { 9069793327208354669L, 1685007590589451718L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 66,
    Value = 
new System.UInt64[,] { { 8193561786137828360L, 8071776109259577196L, }, { 7143355935854617350L, 5304452802168846996L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.UInt64[,] { { 280465504923018328L, 7504004078931947342L, }, { 9098532816084304133L, 2719111409020950887L, }, },
    NullableValue = 
new System.UInt64[,] { { 5164994296460165779L, 3734971429543889072L, }, { 1125504711023415930L, 7057814694592782022L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 4409591260514337234L, 6452406034525280758L, }, { 237458790596665582L, 4902457168727192016L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 71,
    Value = 
new System.UInt64[,] { { 5776286264932331945L, 9185404542965702976L, }, { 3944329274633697610L, 4018782428103776418L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 46,
    Value = 
new System.UInt64[,] { { 2461875995808629523L, 1129268573229601397L, }, { 5505823500852783547L, 7045722574716534308L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 2717542398097733876L, 5233436891102135559L, }, { 7944156741405698713L, 7499533326088782351L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 78,
    Value = 
new System.UInt64[,] { { 6488317038486722881L, 4760291307476375470L, }, { 7602082512876525469L, 7515053688855336280L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.UInt64[,] { { 5981219388284394213L, 4243276689292582585L, }, { 6399224098195096489L, 6059854499361555879L, }, },
    NullableValue = 
new System.UInt64[,] { { 247545003826168803L, 1002247250472503431L, }, { 1533537976360195566L, 1099839372242284598L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2141227187619681537L, 3803443922494954658L, }, { 7399706818019127465L, 6346852144081653397L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 82,
    Value = 
new System.UInt64[,] { { 8062610135544077144L, 4605583660170307100L, }, { 8822903179097796329L, 2773839321531072384L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.UInt64[,] { { 4368261030009879898L, 3219607741274477751L, }, { 1391446822382064270L, 3198264566172031002L, }, },
    NullableValue = 
new System.UInt64[,] { { 299294589022958488L, 960034666316896311L, }, { 8583946169517622496L, 1373689336043011897L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2197483635611975174L, 1990110828213292453L, }, { 1347634028309876278L, 3675496058306563485L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 84,
    Value = 
new System.UInt64[,] { { 6144405351107339356L, 3544066850977673462L, }, { 2266139744365132376L, 7335543558631652133L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.UInt64[,] { { 2530876501126116024L, 5129103341425445429L, }, { 9087234741144813149L, 7196361555846511823L, }, },
    NullableValue = 
new System.UInt64[,] { { 8113665363087279199L, 5274384439511105196L, }, { 9130750932077097939L, 7203592492211227181L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 93,
    Value = 
new System.UInt64[,] { { 3340543492576707016L, 458140677113228461L, }, { 7411957900902965757L, 168938279389486510L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.UInt64[,] { { 5678699919926862764L, 4156268967512585303L, }, { 257005344538067626L, 8364363127402761382L, }, },
    NullableValue = 
new System.UInt64[,] { { 1403709394954644989L, 1764977197781579321L, }, { 122875288359503845L, 2774294745183879159L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 101,
    Value = 
new System.UInt64[,] { { 771387794981620462L, 1831845213044098173L, }, { 5872879696064578442L, 4070215514717677866L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 72,
    Value = 
new System.UInt64[,] { { 59297462636376824L, 2948439719240481020L, }, { 2989769357202718081L, 7444491056490208371L, }, },
    NullableValue = 
new System.UInt64[,] { { 5212980289831339093L, 3366683814197058041L, }, { 4984016749662543052L, 3055667705570558775L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 887174869159131334L, 2673838579578610441L, }, { 4472170931059650061L, 5621810076771222573L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt64[,] { { 2595610865087691880L, 1014671972159291105L, }, { 803621833151083749L, 5284856855715536346L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.UInt64[,] { { 376336797934128519L, 84978256868797617L, }, { 6212059866135362055L, 9152366953435942892L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 112,
    Value = 
new System.UInt64[,] { { 1649057464151953946L, 6931761828855356019L, }, { 7118663521393266437L, 244490352489715051L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 84,
    Value = 
new System.UInt64[,] { { 3280168680969836354L, 2705888286651381771L, }, { 7932295143166044455L, 1818792548035143539L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 119,
    Value = 
new System.UInt64[,] { { 6718546980331868687L, 7977707399563365719L, }, { 8674626079644752007L, 7674909684989673405L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 88,
    Value = 
new System.UInt64[,] { { 2664210972511092189L, 7297168368120071201L, }, { 140367353735980076L, 4188619478018382543L, }, },
    NullableValue = 
new System.UInt64[,] { { 4911102852600689918L, 6454234279909927802L, }, { 4732227001424792596L, 1766449984931160376L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 500836227216391910L, 3959228878094353193L, }, { 1899765436655721989L, 2686407597381461249L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 123,
    Value = 
new System.UInt64[,] { { 1379507849862195457L, 4130723432502785191L, }, { 4069698955108964584L, 4095079957287767759L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.UInt64[,] { { 3735240702642280100L, 56460428295129355L, }, { 9065736986655366190L, 8407159489227119108L, }, },
    NullableValue = 
new System.UInt64[,] { { 1000728878250640302L, 6151878115229809197L, }, { 9197225584489020066L, 1304785158118362131L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 131,
    Value = 
new System.UInt64[,] { { 6883073169158723621L, 5504195338589240920L, }, { 3271964173665599257L, 1880999698374727955L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt64[,] { { 679565436478592780L, 2709980173174736899L, }, { 4333999530452597189L, 4841214390140528266L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 6228613004029536979L, 1385716129371510062L, }, { 159093280937562595L, 1880102866287757218L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 138,
    Value = 
new System.UInt64[,] { { 8424172752349812291L, 3540824072792716458L, }, { 8855049925235880512L, 2323617457582069699L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 97,
    Value = 
new System.UInt64[,] { { 32172977884127060L, 3179208309478030479L, }, { 7765259940116287452L, 7676114401439684544L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 856429939854268951L, 5510649763262923013L, }, { 1325299428969657288L, 2349173585205599492L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 145,
    Value = 
new System.UInt64[,] { { 4763787251512760504L, 7359203918849008274L, }, { 7394148503863158978L, 317397285240649057L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.UInt64[,] { { 1609108930998293819L, 5391171941675275553L, }, { 7214231387396898073L, 7019417031486492211L, }, },
    NullableValue = 
new System.UInt64[,] { { 922317149515216030L, 3264055051088944653L, }, { 9040262252532762661L, 6830182311083668612L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 151,
    Value = 
new System.UInt64[,] { { 5652865184298687497L, 7220957187204104082L, }, { 116858989302840039L, 189158555673129324L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 108,
    Value = 
new System.UInt64[,] { { 2158506503286075413L, 7006340637379785398L, }, { 4173589584299804350L, 8803171381735618596L, }, },
    NullableValue = 
new System.UInt64[,] { { 2866221336435078452L, 8203285469845829060L, }, { 3265981192932843228L, 107070144258530375L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 1313745768031558907L, 1680071735216807816L, }, { 2192210675518120522L, 880658129603076375L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 160,
    Value = 
new System.UInt64[,] { { 5596668749325772538L, 4660587405532862390L, }, { 3295784031130008080L, 6074132668263893959L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.UInt64[,] { { 241760236391922035L, 4526189129959919960L, }, { 8032641019019607840L, 6753964472260302246L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 167,
    Value = 
new System.UInt64[,] { { 4690187357422885682L, 7835831022331639233L, }, { 796413156580461541L, 3662238279754420569L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.UInt64[,] { { 6349624562872000897L, 1016299489248658547L, }, { 9047958519636988413L, 3747069567123441685L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 4407496173740537028L, 131601777904918514L, }, { 46379161749613652L, 4628941251630799333L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 172,
    Value = 
new System.UInt64[,] { { 4107236791767802807L, 4352703568205113875L, }, { 107759171856688480L, 425416318897289520L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.UInt64[,] { { 8150960131243117683L, 5200052609160702822L, }, { 2339329380851080121L, 7273487166796899630L, }, },
    NullableValue = 
new System.UInt64[,] { { 918566018891556339L, 3995428589836474392L, }, { 4965233714477563299L, 1288177998569985179L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 180,
    Value = 
new System.UInt64[,] { { 2823446440005382573L, 9196791226221861650L, }, { 8554893690177651887L, 3517745566273900556L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 124,
    Value = 
new System.UInt64[,] { { 1581460909252006923L, 5207185710147840590L, }, { 7396315236256346719L, 2555189050250675693L, }, },
    NullableValue = 
new System.UInt64[,] { { 8517387410337998124L, 2305818664608731803L, }, { 4140331144639391804L, 1225057225199964293L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 187,
    Value = 
new System.UInt64[,] { { 2247142536171189136L, 5396185124083917380L, }, { 6571450644670738861L, 9073251830961321713L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.UInt64[,] { { 5961572930001327692L, 3962920158428318115L, }, { 319862375588956496L, 5356323467596175532L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 191,
    Value = 
new System.UInt64[,] { { 5189542070727365938L, 5976661174276512608L, }, { 7581874074966586918L, 1399191668208526659L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 133,
    Value = 
new System.UInt64[,] { { 7735311873437122292L, 9007608760459930745L, }, { 8641314381087024944L, 3419393586856997598L, }, },
    NullableValue = 
new System.UInt64[,] { { 6056052273150974874L, 6483754616963003961L, }, { 6336554134034528688L, 4580304638876274127L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 4622844928410114315L, 6222911124100338530L, }, { 4875124432750708972L, 2871633571807227073L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 192,
    Value = 
new System.UInt64[,] { { 5142125064422272614L, 1585869311078402629L, }, { 4741373333448577263L, 5155341295373906869L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 138,
    Value = 
new System.UInt64[,] { { 1372553796259821602L, 8364920606155218721L, }, { 7047631006293931008L, 4109372089208293434L, }, },
    NullableValue = 
new System.UInt64[,] { { 587410585803804393L, 8151557221053990737L, }, { 7033362861601855002L, 1351280874915654268L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 197,
    Value = 
new System.UInt64[,] { { 5560284877847659154L, 6324323386485557287L, }, { 3081304746577841857L, 3094084247401939280L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.UInt64[,] { { 7092559941990947901L, 8365608023738762884L, }, { 6800674449023605699L, 8841897512264648412L, }, },
    NullableValue = 
new System.UInt64[,] { { 8263445714050481527L, 4717853368952838604L, }, { 5692457033420254822L, 6072723364091690686L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 201,
    Value = 
new System.UInt64[,] { { 4974026935873978703L, 866863753690094967L, }, { 5038730930858481153L, 4226741602571473343L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.UInt64[,] { { 8705941478991846691L, 2169529150376925956L, }, { 8943437114831656363L, 9090056603002879072L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 6042251645084194620L, 3873360010494682148L, }, { 6322494167007141148L, 1457628271798281560L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 210,
    Value = 
new System.UInt64[,] { { 4586617841682120683L, 4223048311641971898L, }, { 6111987439209641260L, 4035666650801312105L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 154,
    Value = 
new System.UInt64[,] { { 1542420308079666443L, 2909155279941337538L, }, { 6528878153050150043L, 7831745773655391475L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 7189164881873007323L, 5786293217259640096L, }, { 8145025304059368862L, 6808048872720928937L, }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IUInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IUInt64MArrayMArrayD2)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.uint64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IUInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IUInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

