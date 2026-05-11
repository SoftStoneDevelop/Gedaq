

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
    internal partial interface INpgsqlBoxMArrayboxMMArrayD2
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMMArrayD2 : INpgsqlBoxMArrayboxMMArrayD2
    {


#region TestData

        private readonly NpgsqlBoxboxMMArrayD2E1M[] _testData = new NpgsqlBoxboxMMArrayD2E1M[]
        {
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7898336621145645d,right: 0.6880336571832111d,bottom: 0.7363668404202072d,left: 0.23533378706748154d), new NpgsqlTypes.NpgsqlBox(top: 0.36662741700559665d,right: 0.6160092544538882d,bottom: 0.2369561851737546d,left: 0.04303705565839788d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8185317157396563d,right: 0.4364678524427551d,bottom: 0.2442567762064557d,left: 0.2793831755553071d), new NpgsqlTypes.NpgsqlBox(top: 0.225992214139903d,right: 0.42766441683488665d,bottom: 0.08169112148577706d,left: 0.32215737584996007d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.31575733318834087d,right: 0.6749769257761921d,bottom: 0.20896434447578827d,left: 0.0957789377765671d), new NpgsqlTypes.NpgsqlBox(top: 0.7672715165425228d,right: 0.9809790652562533d,bottom: 0.15515628526617387d,left: 0.7456805045335152d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.14065048007170922d,right: 0.4557795794717109d,bottom: 0.10985511556028615d,left: 0.10209125009532216d), new NpgsqlTypes.NpgsqlBox(top: 0.9650594919901824d,right: 0.41648851493153494d,bottom: 0.6334613833114584d,left: 0.29319713075814147d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9479985116756006d,right: 0.8160253804679528d,bottom: 0.7052372723576549d,left: 0.7557126760965773d), new NpgsqlTypes.NpgsqlBox(top: 0.9407935162268727d,right: 0.9743955168796152d,bottom: 0.7177676863841155d,left: 0.4709534407400243d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6537249003692608d,right: 0.5776968657893059d,bottom: 0.22145367777598968d,left: 0.21617955955235346d), new NpgsqlTypes.NpgsqlBox(top: 0.4500459413321596d,right: 0.6618437290389425d,bottom: 0.10924793374352049d,left: 0.5923330796338238d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9075329469539642d,right: 0.8323102404677506d,bottom: 0.5857231638982217d,left: 0.8052004582646517d), new NpgsqlTypes.NpgsqlBox(top: 0.7233957282326454d,right: 0.9963365807316326d,bottom: 0.6790810032516156d,left: 0.9426906479495133d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.1813300931662427d,right: 0.6609572517571239d,bottom: 0.1017394186968349d,left: 0.31652832182002033d), new NpgsqlTypes.NpgsqlBox(top: 0.5446726645804483d,right: 0.6704596488926005d,bottom: 0.4337112210890558d,left: 0.48249354884520235d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.49835023806103707d,right: 0.7617586910064734d,bottom: 0.12733562094108197d,left: 0.580220284789883d), new NpgsqlTypes.NpgsqlBox(top: 0.8141478461479265d,right: 0.13865130218352784d,bottom: 0.7210194323100291d,left: 0.10017471466402883d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7989998387356659d,right: 0.9107568310019567d,bottom: 0.5612108553389489d,left: 0.6367873418095601d), new NpgsqlTypes.NpgsqlBox(top: 0.6968251293718742d,right: 0.714625474438705d,bottom: 0.06283687088864387d,left: 0.018565494150121653d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9491407883515267d,right: 0.5255546337604144d,bottom: 0.28217191186167556d,left: 0.19375693520723536d), new NpgsqlTypes.NpgsqlBox(top: 0.21297303977042759d,right: 0.987865861246919d,bottom: 0.14641249379982213d,left: 0.06895155860429025d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7433476693595737d,right: 0.3144259246618599d,bottom: 0.539803134808438d,left: 0.15744449503049296d), new NpgsqlTypes.NpgsqlBox(top: 0.9232040801579999d,right: 0.8545841697773204d,bottom: 0.3017901456677381d,left: 0.6294308956298464d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8832770351621158d,right: 0.9401414561970726d,bottom: 0.27411674726744706d,left: 0.4028744807278869d), new NpgsqlTypes.NpgsqlBox(top: 0.9779944987235846d,right: 0.677437262893594d,bottom: 0.9716321733997398d,left: 0.11348400165289041d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.2396929961669968d,right: 0.5237715273425578d,bottom: 0.06317130044594899d,left: 0.3301119467011996d), new NpgsqlTypes.NpgsqlBox(top: 0.8633671834513793d,right: 0.5044908891107315d,bottom: 0.7738470866127837d,left: 0.3006653922248408d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.1246147484576482d,right: 0.7448654587328707d,bottom: 0.12304247867163565d,left: 0.537293340841921d), new NpgsqlTypes.NpgsqlBox(top: 0.7480091202389015d,right: 0.9915530124775301d,bottom: 0.264857789413548d,left: 0.010029842296864988d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3833848118900366d,right: 0.3076332559486653d,bottom: 0.2967756432068419d,left: 0.09017817293105179d), new NpgsqlTypes.NpgsqlBox(top: 0.3954211100039615d,right: 0.6899060799719701d,bottom: 0.08813441051837634d,left: 0.16851596048637374d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7661126855449043d,right: 0.34283687328742696d,bottom: 0.37658094182104895d,left: 0.31152345120244207d), new NpgsqlTypes.NpgsqlBox(top: 0.643821790832801d,right: 0.9277309699176236d,bottom: 0.3565652389800682d,left: 0.08620229350955588d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9052217925867914d,right: 0.3695359985477854d,bottom: 0.22264520312148617d,left: 0.11109511764878821d), new NpgsqlTypes.NpgsqlBox(top: 0.9139867245892372d,right: 0.6076491456985315d,bottom: 0.8854021385984104d,left: 0.052317395278494994d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9424018614657287d,right: 0.8307197447687764d,bottom: 0.5092831860353493d,left: 0.055147716998257934d), new NpgsqlTypes.NpgsqlBox(top: 0.4849967107450084d,right: 0.7652461706608626d,bottom: 0.31339849425304056d,left: 0.5882154116113588d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.039140608735979465d,right: 0.856222011500188d,bottom: 0.02538723568144141d,left: 0.8244500305745593d), new NpgsqlTypes.NpgsqlBox(top: 0.25990377986664304d,right: 0.9656055509363689d,bottom: 0.1723507220006797d,left: 0.27495284743454773d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.13634407522384417d,right: 0.40972640034289887d,bottom: 0.03907924862661549d,left: 0.2713832298277783d), new NpgsqlTypes.NpgsqlBox(top: 0.657157838560266d,right: 0.603741600911631d,bottom: 0.12253349811738123d,left: 0.23400877130828257d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5229844053631405d,right: 0.15675792873755823d,bottom: 0.4370279779724121d,left: 0.01113609685944772d), new NpgsqlTypes.NpgsqlBox(top: 0.97022535484278d,right: 0.5631195328082307d,bottom: 0.8223182599472484d,left: 0.11637561851702827d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4132337760727771d,right: 0.9003677988130064d,bottom: 0.03890206853676459d,left: 0.4260794561925453d), new NpgsqlTypes.NpgsqlBox(top: 0.6425916570272643d,right: 0.7710950625272603d,bottom: 0.5249156640854572d,left: 0.4188794126626718d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5293093519143178d,right: 0.2612085244019725d,bottom: 0.012892128128160318d,left: 0.06289773195917447d), new NpgsqlTypes.NpgsqlBox(top: 0.7138288522297727d,right: 0.7280346334510819d,bottom: 0.3478596710282926d,left: 0.20418200784803375d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8338972753301372d,right: 0.9465394838030792d,bottom: 0.30252149341814893d,left: 0.46724844266706267d), new NpgsqlTypes.NpgsqlBox(top: 0.2575374340028104d,right: 0.6837081755641581d,bottom: 0.04282376010676048d,left: 0.2994261157234116d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8513932888731081d,right: 0.6847540986216021d,bottom: 0.7598438533172671d,left: 0.36775997734388444d), new NpgsqlTypes.NpgsqlBox(top: 0.9212960735945992d,right: 0.41506452374484537d,bottom: 0.4416462764942509d,left: 0.08214538913848568d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8160249759171885d,right: 0.30505222079253436d,bottom: 0.7109562436425719d,left: 0.16990597691757348d), new NpgsqlTypes.NpgsqlBox(top: 0.47840933088281967d,right: 0.27968671393410516d,bottom: 0.18877916797541372d,left: 0.25768776094266443d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9275813727582227d,right: 0.6346959567410422d,bottom: 0.4126427721365262d,left: 0.2782788642347317d), new NpgsqlTypes.NpgsqlBox(top: 0.512108860001707d,right: 0.145398879370517d,bottom: 0.02512166039115693d,left: 0.03847066855135883d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9054390857596168d,right: 0.9249917145703398d,bottom: 0.45870840464864415d,left: 0.048049508628066895d), new NpgsqlTypes.NpgsqlBox(top: 0.7402186665348386d,right: 0.9185703154224762d,bottom: 0.3902504806626108d,left: 0.6649099975892998d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6846141686566661d,right: 0.30072853712267045d,bottom: 0.16169554729875546d,left: 0.17985243711865506d), new NpgsqlTypes.NpgsqlBox(top: 0.9309720837829315d,right: 0.601957236017068d,bottom: 0.19783647422654282d,left: 0.29176168045036854d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8202998067209091d,right: 0.8966462201366955d,bottom: 0.3628047138731213d,left: 0.321910898438299d), new NpgsqlTypes.NpgsqlBox(top: 0.9900226694048498d,right: 0.5302638448871014d,bottom: 0.1741607261557755d,left: 0.16189792864575858d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6140863806110565d,right: 0.7704496998380956d,bottom: 0.07403694642925407d,left: 0.36989057057197317d), new NpgsqlTypes.NpgsqlBox(top: 0.909785274681906d,right: 0.3777010849091963d,bottom: 0.7018546965351607d,left: 0.20582296576935433d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9960660515557614d,right: 0.7466904242540395d,bottom: 0.11655120816251019d,left: 0.6232187432849795d), new NpgsqlTypes.NpgsqlBox(top: 0.5388223649065235d,right: 0.816855350580791d,bottom: 0.5024070209100319d,left: 0.6406205431760549d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.873001882485963d,right: 0.5932562503474011d,bottom: 0.3491498534964237d,left: 0.5486192746850911d), new NpgsqlTypes.NpgsqlBox(top: 0.8828980910975183d,right: 0.8866503726939028d,bottom: 0.7953366265309805d,left: 0.6694019100359172d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.507724092968546d,right: 0.9798622638435549d,bottom: 0.31825440702481533d,left: 0.4771779407924527d), new NpgsqlTypes.NpgsqlBox(top: 0.5984862514910985d,right: 0.5262566359684514d,bottom: 0.4792172744412333d,left: 0.17871308995037016d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9438222358627467d,right: 0.9904618480302828d,bottom: 0.2297583298286503d,left: 0.15869403821991634d), new NpgsqlTypes.NpgsqlBox(top: 0.3959835526678759d,right: 0.5388093887688605d,bottom: 0.17869507204726487d,left: 0.30763231222920306d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8962097113623856d,right: 0.7250156445321981d,bottom: 0.027580889423200916d,left: 0.4654575707222198d), new NpgsqlTypes.NpgsqlBox(top: 0.9047531537913682d,right: 0.9047430855549357d,bottom: 0.3507536346852711d,left: 0.7623699568032856d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6992329405899707d,right: 0.2191088637318963d,bottom: 0.17554441323327896d,left: 0.07278021895907039d), new NpgsqlTypes.NpgsqlBox(top: 0.7396675620821137d,right: 0.35471719197892304d,bottom: 0.47920886087978787d,left: 0.3406385831248011d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9007005415038986d,right: 0.6462759720035455d,bottom: 0.10567529814000087d,left: 0.3502058139463111d), new NpgsqlTypes.NpgsqlBox(top: 0.8429289556774928d,right: 0.8406414739985306d,bottom: 0.5646515306692031d,left: 0.3592172346560786d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.02057650723150095d,right: 0.8314188817429337d,bottom: 0.011668995735973575d,left: 0.6671408223654101d), new NpgsqlTypes.NpgsqlBox(top: 0.8208716427099372d,right: 0.43517637668922127d,bottom: 0.08502589630319846d,left: 0.08964036046255386d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6686631126796798d,right: 0.7850822160878625d,bottom: 0.2468759705303899d,left: 0.7775436446879833d), new NpgsqlTypes.NpgsqlBox(top: 0.6198192278764406d,right: 0.3743340461080995d,bottom: 0.359287433677972d,left: 0.3677049304328246d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.16526188993508428d,right: 0.18334446328598386d,bottom: 0.12272628925980755d,left: 0.12986847533199541d), new NpgsqlTypes.NpgsqlBox(top: 0.9651689529939167d,right: 0.3899213728854545d,bottom: 0.3261700961061599d,left: 0.18823010709003785d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7814654168866447d,right: 0.4188261064992411d,bottom: 0.7376515508792696d,left: 0.17783708645724094d), new NpgsqlTypes.NpgsqlBox(top: 0.45375211928158d,right: 0.5393694707730156d,bottom: 0.4115847435116581d,left: 0.17147575066204657d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.965781628237469d,right: 0.7238449561628048d,bottom: 0.5582408383974445d,left: 0.5598498434811262d), new NpgsqlTypes.NpgsqlBox(top: 0.2345359907370992d,right: 0.21196430872636607d,bottom: 0.14778262426196453d,left: 0.12096107116695243d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7901701889728641d,right: 0.6322727728222943d,bottom: 0.47111139675586955d,left: 0.6303160908429868d), new NpgsqlTypes.NpgsqlBox(top: 0.3710800931848247d,right: 0.919791776909642d,bottom: 0.13451634785031918d,left: 0.3998187699277158d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5522675904505796d,right: 0.957704747436756d,bottom: 0.2078986592276435d,left: 0.17440382023504775d), new NpgsqlTypes.NpgsqlBox(top: 0.4868032992475111d,right: 0.22628595297028886d,bottom: 0.17422489180327316d,left: 0.15153745770693683d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6306568820093108d,right: 0.8682786864178249d,bottom: 0.200139656347181d,left: 0.31168307907899273d), new NpgsqlTypes.NpgsqlBox(top: 0.8612412702729563d,right: 0.826639564754779d,bottom: 0.3225884142318445d,left: 0.012573755716499657d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5722492744756892d,right: 0.8429197179423414d,bottom: 0.021917869350728036d,left: 0.46615083296231885d), new NpgsqlTypes.NpgsqlBox(top: 0.8502402203443469d,right: 0.34182319547592377d,bottom: 0.11628707902873503d,left: 0.2338602836976036d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5858459762494365d,right: 0.6139257836994609d,bottom: 0.1748498631323081d,left: 0.2499841686298807d), new NpgsqlTypes.NpgsqlBox(top: 0.7132016550640489d,right: 0.8875064247608522d,bottom: 0.518009757644266d,left: 0.8066748045111648d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6672781555493792d,right: 0.9132488584627322d,bottom: 0.1778126325792655d,left: 0.0339646285240377d), new NpgsqlTypes.NpgsqlBox(top: 0.7151216686657119d,right: 0.6109057379982376d,bottom: 0.04648246159111513d,left: 0.5326967526335147d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.70107839124058d,right: 0.5706715476740849d,bottom: 0.016639167715134517d,left: 0.3480641336102893d), new NpgsqlTypes.NpgsqlBox(top: 0.2702874919096302d,right: 0.7870674098001573d,bottom: 0.21204112200916636d,left: 0.015263327984632924d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6826759301704757d,right: 0.8759623066315849d,bottom: 0.5802002854682303d,left: 0.8487455589211068d), new NpgsqlTypes.NpgsqlBox(top: 0.9459927660692783d,right: 0.9659462480300895d,bottom: 0.060730477369355995d,left: 0.09703599919164985d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9650200063717567d,right: 0.3481378167073147d,bottom: 0.8082874732624081d,left: 0.15413785461694762d), new NpgsqlTypes.NpgsqlBox(top: 0.8651469482695174d,right: 0.7983551396384952d,bottom: 0.6239814866038372d,left: 0.3755409522807771d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7850627928364641d,right: 0.6205774070715186d,bottom: 0.6738647715800368d,left: 0.30843038891974606d), new NpgsqlTypes.NpgsqlBox(top: 0.9812292474432561d,right: 0.4988677159552378d,bottom: 0.6041240807705401d,left: 0.2543108022890118d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.755759371261685d,right: 0.688958530215905d,bottom: 0.4291820117267947d,left: 0.16579216391271234d), new NpgsqlTypes.NpgsqlBox(top: 0.43395060754257053d,right: 0.39512837173384974d,bottom: 0.10885372391482617d,left: 0.1414971718870227d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4684595356861382d,right: 0.7724602714645249d,bottom: 0.02378859171948633d,left: 0.27102880565498877d), new NpgsqlTypes.NpgsqlBox(top: 0.8981680980190367d,right: 0.5049775061862367d,bottom: 0.4817572231844516d,left: 0.0865824586073154d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.505780728711044d,right: 0.6950542668157905d,bottom: 0.09307028607550316d,left: 0.4012402522210976d), new NpgsqlTypes.NpgsqlBox(top: 0.8356045359773684d,right: 0.9104144089011197d,bottom: 0.1743192311301488d,left: 0.6299736640987396d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8285774694961626d,right: 0.9193692624005552d,bottom: 0.02758867955296751d,left: 0.6661057893255464d), new NpgsqlTypes.NpgsqlBox(top: 0.7744466516447949d,right: 0.5885345733538193d,bottom: 0.1843377912110883d,left: 0.29817472039571125d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.516202918646301d,right: 0.45249657359483797d,bottom: 0.3723256776810211d,left: 0.14194450923068058d), new NpgsqlTypes.NpgsqlBox(top: 0.5802585018779074d,right: 0.626216319241697d,bottom: 0.09259772249641762d,left: 0.012993174576098387d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7152790260878911d,right: 0.8794605559735605d,bottom: 0.3876193548129304d,left: 0.1780323026803532d), new NpgsqlTypes.NpgsqlBox(top: 0.9670176374361354d,right: 0.782263751455171d,bottom: 0.4354566831605936d,left: 0.7458627283710189d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4219106431748265d,right: 0.8255936286888974d,bottom: 0.002070362817869875d,left: 0.020077169718633714d), new NpgsqlTypes.NpgsqlBox(top: 0.9957140053827741d,right: 0.8024756413966442d,bottom: 0.8321568880475387d,left: 0.66847713464144d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7211739716912341d,right: 0.9935274505852415d,bottom: 0.5746353193967988d,left: 0.9891882054526664d), new NpgsqlTypes.NpgsqlBox(top: 0.7798514837645638d,right: 0.7673535100561387d,bottom: 0.5507688236908328d,left: 0.07095713288766403d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7717918214608772d,right: 0.6621226493736898d,bottom: 0.02168556441009495d,left: 0.154812902914926d), new NpgsqlTypes.NpgsqlBox(top: 0.8357630055736963d,right: 0.81207486151982d,bottom: 0.34725654812114526d,left: 0.6297164650947055d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.15135359834607998d,right: 0.6354635517181402d,bottom: 0.09251052702116536d,left: 0.23139181542431653d), new NpgsqlTypes.NpgsqlBox(top: 0.5497044638117484d,right: 0.7159692359946259d,bottom: 0.21493645318460763d,left: 0.3162005151563505d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3331636703912254d,right: 0.5856004249638153d,bottom: 0.1971637480180385d,left: 0.44468125623455934d), new NpgsqlTypes.NpgsqlBox(top: 0.9422271377828406d,right: 0.5559588746289139d,bottom: 0.010400098419086179d,left: 0.4960875698230002d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7132905389524595d,right: 0.3337002434125521d,bottom: 0.294098538397349d,left: 0.035876534688701334d), new NpgsqlTypes.NpgsqlBox(top: 0.5321052218183794d,right: 0.7748453241138018d,bottom: 0.4303333771055664d,left: 0.23385949794879735d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7999301260002201d,right: 0.6190935087006657d,bottom: 0.14815949108446924d,left: 0.4645200436314767d), new NpgsqlTypes.NpgsqlBox(top: 0.5435072003460623d,right: 0.3793096112582123d,bottom: 0.03421857712108245d,left: 0.1708748168578087d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5335011025087306d,right: 0.4367640181342195d,bottom: 0.3742360453712038d,left: 0.3075648916994882d), new NpgsqlTypes.NpgsqlBox(top: 0.8701349763119333d,right: 0.5105597947812278d,bottom: 0.3443780576161485d,left: 0.4249666493750054d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5978344897587529d,right: 0.8696436052120112d,bottom: 0.028065903288187033d,left: 0.439728420086807d), new NpgsqlTypes.NpgsqlBox(top: 0.3181888922395144d,right: 0.7561373222803689d,bottom: 0.02067043708870464d,left: 0.3445250814590285d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3418462644535095d,right: 0.9329583421651392d,bottom: 0.01234849386327952d,left: 0.27218591989438734d), new NpgsqlTypes.NpgsqlBox(top: 0.8833921530396082d,right: 0.9706671547654718d,bottom: 0.46082352151433514d,left: 0.61600039597099d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.18664245140612734d,right: 0.5176254031776284d,bottom: 0.1496546653278561d,left: 0.33926661681214854d), new NpgsqlTypes.NpgsqlBox(top: 0.8806796612161235d,right: 0.24068449530374492d,bottom: 0.22547358122575d,left: 0.04805812197854309d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5063035504765744d,right: 0.9307258689902344d,bottom: 0.4899754805818757d,left: 0.016486679547559113d), new NpgsqlTypes.NpgsqlBox(top: 0.7390081099255036d,right: 0.9527972800328793d,bottom: 0.08300457952397378d,left: 0.6551665712657022d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.41506040923705556d,right: 0.8827283170503709d,bottom: 0.33387946625067866d,left: 0.7892817131451634d), new NpgsqlTypes.NpgsqlBox(top: 0.6481924953603375d,right: 0.8202898414735852d,bottom: 0.5676831754311379d,left: 0.3152154428429752d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6436729232715351d,right: 0.7366185106945025d,bottom: 0.1575480097866805d,left: 0.4072150033538039d), new NpgsqlTypes.NpgsqlBox(top: 0.7341041318239482d,right: 0.7315812007293527d,bottom: 0.3479159599099082d,left: 0.211095598652133d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9446959393246237d,right: 0.7373353386105324d,bottom: 0.8044255947286747d,left: 0.17221637488319141d), new NpgsqlTypes.NpgsqlBox(top: 0.5292495014649288d,right: 0.7478359783414363d,bottom: 0.45205197623266036d,left: 0.44532919978148044d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7074744894081132d,right: 0.6915895511524242d,bottom: 0.10550222240464335d,left: 0.1537143925262443d), new NpgsqlTypes.NpgsqlBox(top: 0.8660787016587199d,right: 0.29011196487021795d,bottom: 0.5994408524720737d,left: 0.22393020055079982d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9054936035253612d,right: 0.2696982756843461d,bottom: 0.802559330096646d,left: 0.10779304260954181d), new NpgsqlTypes.NpgsqlBox(top: 0.7869118324060098d,right: 0.997111945538962d,bottom: 0.490742281475402d,left: 0.5809248189594163d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8896412511474872d,right: 0.3463773820494549d,bottom: 0.883556619004739d,left: 0.20071992983511222d), new NpgsqlTypes.NpgsqlBox(top: 0.9657038544798349d,right: 0.7659270380071541d,bottom: 0.5015927720828952d,left: 0.039786182999005826d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9266910798438436d,right: 0.9162834665289008d,bottom: 0.167499029582187d,left: 0.6553345470365659d), new NpgsqlTypes.NpgsqlBox(top: 0.6355271066475705d,right: 0.6766424598746522d,bottom: 0.261765005468625d,left: 0.5121368660442883d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3580538750398746d,right: 0.8571811668688134d,bottom: 0.06039312132982155d,left: 0.02861174979289094d), new NpgsqlTypes.NpgsqlBox(top: 0.8167108362178029d,right: 0.9673317035857276d,bottom: 0.6049459315442032d,left: 0.44067666276430995d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.37109875262818626d,right: 0.13506167328177798d,bottom: 0.1671515871081677d,left: 0.005871434156093702d), new NpgsqlTypes.NpgsqlBox(top: 0.526016143534355d,right: 0.8919730714763447d,bottom: 0.3821757138407609d,left: 0.03680112865039309d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9665933165663692d,right: 0.6497900284432526d,bottom: 0.4407919464861335d,left: 0.3327606146055103d), new NpgsqlTypes.NpgsqlBox(top: 0.6746640697287998d,right: 0.7988925873011127d,bottom: 0.06718964126124827d,left: 0.1035439607747084d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8979195890755717d,right: 0.9635901745414328d,bottom: 0.816698938537948d,left: 0.11334026975543954d), new NpgsqlTypes.NpgsqlBox(top: 0.33057160501036364d,right: 0.7327547008500693d,bottom: 0.1339032024435325d,left: 0.12741184434479547d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3686944344509321d,right: 0.9204368321019324d,bottom: 0.35351782405332766d,left: 0.6504844163926904d), new NpgsqlTypes.NpgsqlBox(top: 0.9111996384474691d,right: 0.6176843170575258d,bottom: 0.08306116847934542d,left: 0.5664619349034098d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9574447914628365d,right: 0.9871739366488442d,bottom: 0.16229853840362995d,left: 0.6144283167297747d), new NpgsqlTypes.NpgsqlBox(top: 0.7701917730379554d,right: 0.44711911749214495d,bottom: 0.06891613587013024d,left: 0.0264370790342342d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6022873076821408d,right: 0.4125758315089262d,bottom: 0.4675913882054623d,left: 0.18802443944665803d), new NpgsqlTypes.NpgsqlBox(top: 0.5274445776461948d,right: 0.46046666342746445d,bottom: 0.19121025887316323d,left: 0.04687219022106737d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.851852007988296d,right: 0.8766119217581028d,bottom: 0.57237805721772d,left: 0.07770086418482347d), new NpgsqlTypes.NpgsqlBox(top: 0.9322029472101282d,right: 0.21725592305438413d,bottom: 0.8677473764266316d,left: 0.04403675202587887d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3980421072870338d,right: 0.886467858720547d,bottom: 0.3121544560149888d,left: 0.48268458370471723d), new NpgsqlTypes.NpgsqlBox(top: 0.9804728246065076d,right: 0.9253520834952815d,bottom: 0.47838602271282993d,left: 0.9155486428379799d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4267959117392267d,right: 0.8649118396909568d,bottom: 0.328234469562921d,left: 0.014116120545050626d), new NpgsqlTypes.NpgsqlBox(top: 0.7498000051609002d,right: 0.8111722107040324d,bottom: 0.01401362469254519d,left: 0.4459238575844474d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9189173943165589d,right: 0.21898201968220599d,bottom: 0.4454072774286221d,left: 0.20711642650361606d), new NpgsqlTypes.NpgsqlBox(top: 0.9176093396692754d,right: 0.8736370440826463d,bottom: 0.5738396718302781d,left: 0.36869136703541394d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7584168318961774d,right: 0.618610161393658d,bottom: 0.6402470647813324d,left: 0.1370103671282048d), new NpgsqlTypes.NpgsqlBox(top: 0.7464897420464802d,right: 0.9965347482020683d,bottom: 0.19043506043735392d,left: 0.455046887123402d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7308828846126572d,right: 0.7572758612386974d,bottom: 0.5887889141099986d,left: 0.7343454975999666d), new NpgsqlTypes.NpgsqlBox(top: 0.5988801329867942d,right: 0.8111594890202557d,bottom: 0.0705574213621144d,left: 0.3957253415636097d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7097338705817304d,right: 0.5693666723656734d,bottom: 0.275074253043191d,left: 0.05169573416600559d), new NpgsqlTypes.NpgsqlBox(top: 0.9319190452978849d,right: 0.9597150938977635d,bottom: 0.7613860867030507d,left: 0.8485237987854869d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7074960366357383d,right: 0.5546073164925108d,bottom: 0.3759091545314337d,left: 0.24665424684804138d), new NpgsqlTypes.NpgsqlBox(top: 0.9278737203434307d,right: 0.2166599727500499d,bottom: 0.13792849545459585d,left: 0.20964539583171327d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8074547654409577d,right: 0.5926456582775197d,bottom: 0.3536941944198805d,left: 0.32047535832034457d), new NpgsqlTypes.NpgsqlBox(top: 0.44399818826657045d,right: 0.9240392475321751d,bottom: 0.12342569261355918d,left: 0.1468842473660934d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5143472410553437d,right: 0.3532678086441282d,bottom: 0.3935637965111458d,left: 0.20423807742229694d), new NpgsqlTypes.NpgsqlBox(top: 0.6979928124325466d,right: 0.5892884010076602d,bottom: 0.01894565338052212d,left: 0.38583631147705066d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6839664442363165d,right: 0.20088528582229515d,bottom: 0.6120398051815561d,left: 0.17896253922840355d), new NpgsqlTypes.NpgsqlBox(top: 0.7470315980470005d,right: 0.9842109578268978d,bottom: 0.09556164929564981d,left: 0.8685155659933402d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8403593717544529d,right: 0.7877101296973366d,bottom: 0.2321915300299774d,left: 0.6012380283776115d), new NpgsqlTypes.NpgsqlBox(top: 0.7020821427427322d,right: 0.7499909805649261d,bottom: 0.6044321808007983d,left: 0.07543051102392662d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9634906508667364d,right: 0.8541172685926394d,bottom: 0.8695486484125466d,left: 0.817359676914312d), new NpgsqlTypes.NpgsqlBox(top: 0.7566824853434575d,right: 0.8377456237185752d,bottom: 0.15711446529912376d,left: 0.5073993261395212d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8202691367855673d,right: 0.49748157610021393d,bottom: 0.698582794108885d,left: 0.4237647270969658d), new NpgsqlTypes.NpgsqlBox(top: 0.7117721883361791d,right: 0.5511369352850243d,bottom: 0.5288823636804724d,left: 0.2685547161018004d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8051625539763538d,right: 0.22423098112282824d,bottom: 0.483610569373491d,left: 0.15704829856325153d), new NpgsqlTypes.NpgsqlBox(top: 0.25235919448296196d,right: 0.675518687103423d,bottom: 0.22138284237506645d,left: 0.4838757422199568d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5759484112047277d,right: 0.5324630804122118d,bottom: 0.13276138655816283d,left: 0.02325533748052866d), new NpgsqlTypes.NpgsqlBox(top: 0.9252415633856829d,right: 0.800076745086705d,bottom: 0.5431385850316662d,left: 0.39271539176784076d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5350592174240382d,right: 0.47173307074336046d,bottom: 0.17364911425642826d,left: 0.21962103289100254d), new NpgsqlTypes.NpgsqlBox(top: 0.5433646108458388d,right: 0.3920594248716667d,bottom: 0.418403505695363d,left: 0.39151499355722863d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8993206455075948d,right: 0.28283223472968466d,bottom: 0.5587449789196969d,left: 0.08936833782758291d), new NpgsqlTypes.NpgsqlBox(top: 0.7931804219040048d,right: 0.6355663716209896d,bottom: 0.6353761534262518d,left: 0.3201927203449778d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9958668473495876d,right: 0.9086461756002546d,bottom: 0.4955623399067187d,left: 0.6599037804192383d), new NpgsqlTypes.NpgsqlBox(top: 0.8964915071516327d,right: 0.31490226431111357d,bottom: 0.5174397207178308d,left: 0.15086998860054868d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.43334274674885787d,right: 0.8190639297492058d,bottom: 0.1554806120930018d,left: 0.6633279791191363d), new NpgsqlTypes.NpgsqlBox(top: 0.2683825682783618d,right: 0.806681508772471d,bottom: 0.021345210795185032d,left: 0.09013172265597857d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7184574136769167d,right: 0.08080262390517678d,bottom: 0.5051438243466132d,left: 0.049610308999944897d), new NpgsqlTypes.NpgsqlBox(top: 0.8216108380116075d,right: 0.9593745068077322d,bottom: 0.575389023656102d,left: 0.6078874036852991d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5587818934053976d,right: 0.4205789616530151d,bottom: 0.4474874245817193d,left: 0.22333542178927335d), new NpgsqlTypes.NpgsqlBox(top: 0.7045268782499728d,right: 0.9588892583541427d,bottom: 0.6522225840556977d,left: 0.559779350105483d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6286689772022248d,right: 0.6488638770848304d,bottom: 0.19772451084849185d,left: 0.531355235510352d), new NpgsqlTypes.NpgsqlBox(top: 0.3828398536705715d,right: 0.19051418663749675d,bottom: 0.3080573431130206d,left: 0.009588175611424776d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6167464931641222d,right: 0.9215711704196937d,bottom: 0.6100607044237961d,left: 0.8947790575482945d), new NpgsqlTypes.NpgsqlBox(top: 0.9735608906800883d,right: 0.5582509629946847d,bottom: 0.8079640825828909d,left: 0.535629773069915d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5274325095606254d,right: 0.6385598666502285d,bottom: 0.453222243631469d,left: 0.4192317985606109d), new NpgsqlTypes.NpgsqlBox(top: 0.8862573993288619d,right: 0.9547183282373836d,bottom: 0.5645123914670144d,left: 0.37956734837890116d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.923573541387784d,right: 0.9226384647615382d,bottom: 0.7619024077090738d,left: 0.496434534384273d), new NpgsqlTypes.NpgsqlBox(top: 0.7205767674142433d,right: 0.5015426134219462d,bottom: 0.26075217401709117d,left: 0.3765410075434028d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.16766940897181082d,right: 0.8604888131969107d,bottom: 0.14559821808748763d,left: 0.6568695554914854d), new NpgsqlTypes.NpgsqlBox(top: 0.9737686347686154d,right: 0.3164364154610796d,bottom: 0.302706120646571d,left: 0.029960538873618603d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5171809460105553d,right: 0.6391291168954938d,bottom: 0.49932340509881745d,left: 0.5519406146348923d), new NpgsqlTypes.NpgsqlBox(top: 0.5900187017244555d,right: 0.23646088632967077d,bottom: 0.07120156016957224d,left: 0.013708706481517008d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8629829463454269d,right: 0.9762394088155006d,bottom: 0.16765320132210937d,left: 0.4297324064779493d), new NpgsqlTypes.NpgsqlBox(top: 0.9767861377591425d,right: 0.5274751532378597d,bottom: 0.9103168712482673d,left: 0.26622802814460644d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5322676571640792d,right: 0.4227653237158784d,bottom: 0.39401474223401856d,left: 0.33933253607105895d), new NpgsqlTypes.NpgsqlBox(top: 0.8411635102325649d,right: 0.3799668806154747d,bottom: 0.3791498260094849d,left: 0.25625915750545214d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9923327918532799d,right: 0.9836516762549602d,bottom: 0.8864383161926491d,left: 0.31963755400138627d), new NpgsqlTypes.NpgsqlBox(top: 0.9369028703923389d,right: 0.4239788045188443d,bottom: 0.29464226286957795d,left: 0.21683164536424115d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9688444182269965d,right: 0.5796679010415658d,bottom: 0.4759550876387003d,left: 0.2887901435827558d), new NpgsqlTypes.NpgsqlBox(top: 0.7353991562950707d,right: 0.3101716131635466d,bottom: 0.03662813406811283d,left: 0.21557952731285268d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.818258089443751d,right: 0.4536767317593905d,bottom: 0.6839770377514826d,left: 0.10792070017927802d), new NpgsqlTypes.NpgsqlBox(top: 0.4215241408862338d,right: 0.7457388183531883d,bottom: 0.30861914274098545d,left: 0.6604726824559185d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8554445200064962d,right: 0.34962173657946094d,bottom: 0.8229952694395741d,left: 0.28053129507539376d), new NpgsqlTypes.NpgsqlBox(top: 0.9798904325526263d,right: 0.8631735130089785d,bottom: 0.7804684020628634d,left: 0.40422214713649196d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.46670299304898677d,right: 0.4132143295369133d,bottom: 0.23323380553723194d,left: 0.18454133527758387d), new NpgsqlTypes.NpgsqlBox(top: 0.7577319133840299d,right: 0.6577853590828343d,bottom: 0.49580206242554725d,left: 0.3751566579386768d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8416644479101992d,right: 0.9349038827810493d,bottom: 0.7653362310003252d,left: 0.7338367941757865d), new NpgsqlTypes.NpgsqlBox(top: 0.4342455897931049d,right: 0.43616943879776837d,bottom: 0.250323628785056d,left: 0.07826531505338208d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9733562266080886d,right: 0.5940955953715004d,bottom: 0.43422038182399914d,left: 0.11503403068771823d), new NpgsqlTypes.NpgsqlBox(top: 0.9979786709175621d,right: 0.9600093591013933d,bottom: 0.05322848960993609d,left: 0.11271172337795599d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.39230212022968436d,right: 0.3981249279779461d,bottom: 0.3712149376747834d,left: 0.189430378575298d), new NpgsqlTypes.NpgsqlBox(top: 0.2692402323570461d,right: 0.5101168434499453d,bottom: 0.22264166094441107d,left: 0.10344771092517291d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9143128582577683d,right: 0.733152468223275d,bottom: 0.2191831405748622d,left: 0.7268436954804095d), new NpgsqlTypes.NpgsqlBox(top: 0.30315409524881387d,right: 0.7842962729904452d,bottom: 0.28933897545687737d,left: 0.07295431035330302d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7392437423807833d,right: 0.9969669986329012d,bottom: 0.38108200028701067d,left: 0.872930376108792d), new NpgsqlTypes.NpgsqlBox(top: 0.2828056628953718d,right: 0.43194219158344205d,bottom: 0.14027259002804982d,left: 0.367775573098717d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.49318951901347063d,right: 0.7968246095056637d,bottom: 0.08886511644242256d,left: 0.4364289882162571d), new NpgsqlTypes.NpgsqlBox(top: 0.38025666722663964d,right: 0.7714354117386253d,bottom: 0.1493419719222432d,left: 0.22575770369892856d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7526566579220576d,right: 0.9776645112879637d,bottom: 0.0632527293780627d,left: 0.536762819710603d), new NpgsqlTypes.NpgsqlBox(top: 0.8108119629491092d,right: 0.7133234098479868d,bottom: 0.3202074066307641d,left: 0.08805369246844608d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3943527882624821d,right: 0.746355798573858d,bottom: 0.2561571197758985d,left: 0.4823122669963116d), new NpgsqlTypes.NpgsqlBox(top: 0.7892443762441206d,right: 0.8547147872725877d,bottom: 0.07079794790274363d,left: 0.688468656153441d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5597116451937313d,right: 0.7080632444545301d,bottom: 0.5378836026633503d,left: 0.28468430915173937d), new NpgsqlTypes.NpgsqlBox(top: 0.7532748340625165d,right: 0.9090824752621284d,bottom: 0.04031638678121252d,left: 0.7765610531175264d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7455918694034288d,right: 0.5049466275328038d,bottom: 0.12280467349564617d,left: 0.20576238227713606d), new NpgsqlTypes.NpgsqlBox(top: 0.7837426509224632d,right: 0.6737750193600016d,bottom: 0.7706773904036522d,left: 0.18707647349423973d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.29049543724229d,right: 0.6313767208630167d,bottom: 0.2751194206552968d,left: 0.6031570066890682d), new NpgsqlTypes.NpgsqlBox(top: 0.8988599211951744d,right: 0.8928656125645874d,bottom: 0.2772018779434807d,left: 0.10011920457860046d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6353561530014756d,right: 0.8264744779725408d,bottom: 0.05637356615902267d,left: 0.7766431979871841d), new NpgsqlTypes.NpgsqlBox(top: 0.8094682116000118d,right: 0.5519172578654602d,bottom: 0.6300841054035339d,left: 0.4111363260456131d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7437218521146504d,right: 0.5054345791804679d,bottom: 0.03622081369167096d,left: 0.43009743681938484d), new NpgsqlTypes.NpgsqlBox(top: 0.9409196247430798d,right: 0.3469420879889964d,bottom: 0.7242770430349015d,left: 0.08453295834866226d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.15569214253388175d,right: 0.8013842532357663d,bottom: 0.08874975279286157d,left: 0.3159504723929193d), new NpgsqlTypes.NpgsqlBox(top: 0.7733394388394994d,right: 0.9498181859764167d,bottom: 0.33440435960136516d,left: 0.22894839096596864d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.901836123071108d,right: 0.8558787171635149d,bottom: 0.6175065925942788d,left: 0.8296995281050654d), new NpgsqlTypes.NpgsqlBox(top: 0.554425120292145d,right: 0.4847407576619397d,bottom: 0.41528665765980644d,left: 0.13361842290470838d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5167716625627983d,right: 0.5359224835688605d,bottom: 0.31197674437095757d,left: 0.10409989204429693d), new NpgsqlTypes.NpgsqlBox(top: 0.870397142457593d,right: 0.6697303380330959d,bottom: 0.30352910473392913d,left: 0.17903995958845453d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7487227014540143d,right: 0.5322852830790725d,bottom: 0.2822938503672301d,left: 0.07337153883316638d), new NpgsqlTypes.NpgsqlBox(top: 0.6120755033365318d,right: 0.5024765119176359d,bottom: 0.2738428604812251d,left: 0.37505622369391967d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.47640848042428297d,right: 0.8135152661947795d,bottom: 0.47290181575413004d,left: 0.38565936888766017d), new NpgsqlTypes.NpgsqlBox(top: 0.74517200910578d,right: 0.810025967660014d,bottom: 0.7083272607350725d,left: 0.4816210068365828d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8329424549634996d,right: 0.9783221335912855d,bottom: 0.6409499078098825d,left: 0.3164847963018026d), new NpgsqlTypes.NpgsqlBox(top: 0.2638401987502045d,right: 0.924180963767947d,bottom: 0.1541586199987346d,left: 0.8544477351953244d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8085338304030987d,right: 0.9429165672320071d,bottom: 0.4940762688800837d,left: 0.21365211910893767d), new NpgsqlTypes.NpgsqlBox(top: 0.9072494913806823d,right: 0.9493382421209227d,bottom: 0.3306585199831693d,left: 0.05032625871507013d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.31127077467513353d,right: 0.42311432706719354d,bottom: 0.22248578191879853d,left: 0.3486920449583061d), new NpgsqlTypes.NpgsqlBox(top: 0.5518321076054113d,right: 0.26365445439525803d,bottom: 0.2208388756600096d,left: 0.1933661198025899d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5407757283449476d,right: 0.5990899230057226d,bottom: 0.24828862537866414d,left: 0.06518457105837161d), new NpgsqlTypes.NpgsqlBox(top: 0.9587795774647933d,right: 0.6288798123257457d,bottom: 0.6718266179397975d,left: 0.18415478177107303d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5882090986494075d,right: 0.6321890443857113d,bottom: 0.4163989434335279d,left: 0.567567091161773d), new NpgsqlTypes.NpgsqlBox(top: 0.982092153151275d,right: 0.9343637953612938d,bottom: 0.39590067290548725d,left: 0.36470071114308955d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8294310632325415d,right: 0.7464608133600358d,bottom: 0.8020751076483587d,left: 0.30316442753403905d), new NpgsqlTypes.NpgsqlBox(top: 0.43849791687169026d,right: 0.8810298467918147d,bottom: 0.35372950889557775d,left: 0.05118740632997987d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8376042161355634d,right: 0.5165397132142999d,bottom: 0.5347233150679674d,left: 0.07220493178665377d), new NpgsqlTypes.NpgsqlBox(top: 0.9566491834464824d,right: 0.8149635147258882d,bottom: 0.0835122374906817d,left: 0.7455628522818947d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7549971998872d,right: 0.8505279683910547d,bottom: 0.4131009147665027d,left: 0.6757459431842445d), new NpgsqlTypes.NpgsqlBox(top: 0.3735706863077253d,right: 0.7964256974927791d,bottom: 0.13081247550882547d,left: 0.1976874833824679d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6565675397248926d,right: 0.7212086342673945d,bottom: 0.2992180944066626d,left: 0.6811782427686204d), new NpgsqlTypes.NpgsqlBox(top: 0.6268873049299868d,right: 0.8400227173181889d,bottom: 0.6118644365136884d,left: 0.4349435921854632d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7745222911516002d,right: 0.9579357681559729d,bottom: 0.13602565078263051d,left: 0.9091767642717187d), new NpgsqlTypes.NpgsqlBox(top: 0.5740960943103727d,right: 0.9098652617682925d,bottom: 0.1538976910319544d,left: 0.13528482717766854d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6843886261284486d,right: 0.5814865508786747d,bottom: 0.2899885768698116d,left: 0.4884226673993879d), new NpgsqlTypes.NpgsqlBox(top: 0.8629040774064868d,right: 0.1964071488650876d,bottom: 0.11297472322825886d,left: 0.14816965756916967d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8763392959770707d,right: 0.3792203432395578d,bottom: 0.049612991226053005d,left: 0.3463687751841793d), new NpgsqlTypes.NpgsqlBox(top: 0.13663121055384664d,right: 0.6401287644752437d,bottom: 0.13222341859554199d,left: 0.08268551265974577d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.596491119825726d,right: 0.5154876035396302d,bottom: 0.5182948249322311d,left: 0.4217794595995388d), new NpgsqlTypes.NpgsqlBox(top: 0.35922663667268284d,right: 0.7740685172549288d,bottom: 0.1796098771619259d,left: 0.3495529142093199d), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8338972753301372d,right: 0.9465394838030792d,bottom: 0.30252149341814893d,left: 0.46724844266706267d), new NpgsqlTypes.NpgsqlBox(top: 0.2575374340028104d,right: 0.6837081755641581d,bottom: 0.04282376010676048d,left: 0.2994261157234116d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8513932888731081d,right: 0.6847540986216021d,bottom: 0.7598438533172671d,left: 0.36775997734388444d), new NpgsqlTypes.NpgsqlBox(top: 0.9212960735945992d,right: 0.41506452374484537d,bottom: 0.4416462764942509d,left: 0.08214538913848568d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9960660515557614d,right: 0.7466904242540395d,bottom: 0.11655120816251019d,left: 0.6232187432849795d), new NpgsqlTypes.NpgsqlBox(top: 0.5388223649065235d,right: 0.816855350580791d,bottom: 0.5024070209100319d,left: 0.6406205431760549d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.873001882485963d,right: 0.5932562503474011d,bottom: 0.3491498534964237d,left: 0.5486192746850911d), new NpgsqlTypes.NpgsqlBox(top: 0.8828980910975183d,right: 0.8866503726939028d,bottom: 0.7953366265309805d,left: 0.6694019100359172d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8962097113623856d,right: 0.7250156445321981d,bottom: 0.027580889423200916d,left: 0.4654575707222198d), new NpgsqlTypes.NpgsqlBox(top: 0.9047531537913682d,right: 0.9047430855549357d,bottom: 0.3507536346852711d,left: 0.7623699568032856d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6992329405899707d,right: 0.2191088637318963d,bottom: 0.17554441323327896d,left: 0.07278021895907039d), new NpgsqlTypes.NpgsqlBox(top: 0.7396675620821137d,right: 0.35471719197892304d,bottom: 0.47920886087978787d,left: 0.3406385831248011d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7814654168866447d,right: 0.4188261064992411d,bottom: 0.7376515508792696d,left: 0.17783708645724094d), new NpgsqlTypes.NpgsqlBox(top: 0.45375211928158d,right: 0.5393694707730156d,bottom: 0.4115847435116581d,left: 0.17147575066204657d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.965781628237469d,right: 0.7238449561628048d,bottom: 0.5582408383974445d,left: 0.5598498434811262d), new NpgsqlTypes.NpgsqlBox(top: 0.2345359907370992d,right: 0.21196430872636607d,bottom: 0.14778262426196453d,left: 0.12096107116695243d), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD2E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD2E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 94, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 143, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 100, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 50, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 17, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 140, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 104, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 66, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
FROM public.binary_npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI), typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

