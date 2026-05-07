

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
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30363378541561936d, y: 0.5001060573898499d),
new NpgsqlTypes.NpgsqlPoint(x: 0.005649154849406313d, y: 0.5512530555363896d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7454491555679751d, y: 0.792231124533168d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45103626188936263d, y: 0.6013889124858469d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9883738768036369d, y: 0.6545590606597999d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9241881773089925d, y: 0.16753523847623253d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6362127873724821d, y: 0.24260588149717754d),
new NpgsqlTypes.NpgsqlPoint(x: 0.74603381852707d, y: 0.7781951751862297d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7677387350703786d, y: 0.6898938270584453d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3837637153933193d, y: 0.33316912963250067d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7123437606651454d, y: 0.8438131909691287d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31918654323197126d, y: 0.9796250378315811d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9437386957848543d, y: 0.0044003943110266786d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9465098777534571d, y: 0.9172454874474243d),
new NpgsqlTypes.NpgsqlPoint(x: 0.964520900035006d, y: 0.03229754770692128d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7096697743081416d, y: 0.9273584120316157d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6525511394213174d, y: 0.4167078889468382d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3487633975546922d, y: 0.8729141902739624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39860683706768296d, y: 0.17866509640310546d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3867290381054591d, y: 0.3670942245948653d),
new NpgsqlTypes.NpgsqlPoint(x: 0.700696310154874d, y: 0.6857927983080805d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05179517084585472d, y: 0.27012669677360723d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49931830407471767d, y: 0.8963130976783342d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47333949472942416d, y: 0.8797372996371897d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6477334112896955d, y: 0.9598500814095682d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7920130369648181d, y: 0.8411320762938715d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48292802516892064d, y: 0.8723735105481809d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9885437402281558d, y: 0.7215136545973633d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9393147281978741d, y: 0.4486336787286642d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16258123211287379d, y: 0.13293421104710368d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3826386681138684d, y: 0.4561482824424866d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18993610946212935d, y: 0.8808720087237789d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7158319106620229d, y: 0.7315791285754779d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4373495137812532d, y: 0.4165064745900492d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19856303194072977d, y: 0.7643832318687802d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6791099660230888d, y: 0.6608727117041182d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3495172953898681d, y: 0.20892609657238093d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7429110720848597d, y: 0.6353671719906828d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7962632784427898d, y: 0.8839004957333663d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5425804098019963d, y: 0.3397723029145796d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32020237154543174d, y: 0.7390064760665653d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10853692907567147d, y: 0.6155825924928359d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07211022309883064d, y: 0.004512625155177141d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10554941294852005d, y: 0.5227310721538634d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42241871584074464d, y: 0.5204083454717559d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6394577300411725d, y: 0.9830823699646063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7477941157710452d, y: 0.38351275086362d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5502887448184441d, y: 0.9925093195192255d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7004221549868022d, y: 0.12052882086941308d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5225746846165802d, y: 0.5458579935882848d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7943698585244959d, y: 0.48573768248564697d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7288818276976061d, y: 0.6855759534868351d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4881632588866165d, y: 0.1613893390592238d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9899387089762665d, y: 0.745214838132611d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35177413254448375d, y: 0.45487604238134305d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05494857305142975d, y: 0.21255149410483953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.574995243440349d, y: 0.06717525366534682d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8901581749523956d, y: 0.9403301428749516d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7517871011545464d, y: 0.4956176718503037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4927777664287428d, y: 0.44373019804876257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9680070426152731d, y: 0.2070899707307805d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7939591337722267d, y: 0.8013644833024367d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8135388187086474d, y: 0.022401750045402458d),
new NpgsqlTypes.NpgsqlPoint(x: 0.998208153301361d, y: 0.569361576610637d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27568692655385374d, y: 0.9958634636215203d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5470032112429374d, y: 0.5887117037107361d),
new NpgsqlTypes.NpgsqlPoint(x: 0.64620471519268d, y: 0.8019998720891597d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09553496409414486d, y: 0.7051219449136095d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7685288886494688d, y: 0.1392817814992977d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23627964022285097d, y: 0.7237644022336667d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8385840328927835d, y: 0.09582404046249693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5814960517534705d, y: 0.510722830203552d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8446590285312314d, y: 0.02925031503602149d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4049302771803944d, y: 0.7965016929918964d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4432802276643846d, y: 0.45216183948430866d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12978730068994915d, y: 0.3509178240940056d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3556819934071742d, y: 0.5438955369189961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.888674469865876d, y: 0.05948194983453048d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9377896925377702d, y: 0.8481626362598128d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6470944532878529d, y: 0.6490967538218717d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8583528376202875d, y: 0.12479058097581619d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04346470904388666d, y: 0.25698538482215905d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07356035439429631d, y: 0.979368763897248d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25847940707917705d, y: 0.2573167909225843d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07124881086852186d, y: 0.95227473503616d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9595142162499933d, y: 0.5718765432402947d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10360605809455892d, y: 0.9086400955990186d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8955857508396994d, y: 0.8794135884312724d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12429876011560914d, y: 0.034915346376718004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2890730270765236d, y: 0.2882979878663049d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29265435951135677d, y: 0.6876182604468786d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08273286531093393d, y: 0.29322625045105444d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8208105992327827d, y: 0.7292434180545493d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2600955497654267d, y: 0.7933120719463355d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8046173135681629d, y: 0.5046611548094958d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7211796040977502d, y: 0.07653762401134467d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1818210720997766d, y: 0.7983979782294389d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8208491540137983d, y: 0.37344978551398733d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6827474661413827d, y: 0.6902258708065233d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5270137659339232d, y: 0.2467403701008224d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02962870646037119d, y: 0.698823875354828d),
new NpgsqlTypes.NpgsqlPoint(x: 0.036197528535726775d, y: 0.28222764589958627d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9326717125724281d, y: 0.8049685150295589d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4097873455563802d, y: 0.42453872862360564d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8466614863068305d, y: 0.06780266227245846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.686228949687194d, y: 0.11377544545253793d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18516890889593307d, y: 0.2287105306324143d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.607441126113979d, y: 0.08194692387020008d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6764554264882051d, y: 0.3149716801412109d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2486034913564149d, y: 0.9591278396553815d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.688886379854316d, y: 0.22957137100695868d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03828769414474398d, y: 0.9446146330868486d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8603186236370263d, y: 0.7084339866373441d),
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
new NpgsqlTypes.NpgsqlPoint(x: 0.9162674722750304d, y: 0.01836697152614375d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0771645545174332d, y: 0.5665265276881825d),
new NpgsqlTypes.NpgsqlPoint(x: 0.085281469255717d, y: 0.0686725326616856d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2851253321527595d, y: 0.2891660340615544d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1491334501185172d, y: 0.9898499882675479d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4322824253926161d, y: 0.5609212301695558d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8531101465500961d, y: 0.39383341907312897d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.044892916203402966d, y: 0.041350326373478685d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47113549241528796d, y: 0.2962308479547249d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20818959431814976d, y: 0.7734642958119017d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6569239436699558d, y: 0.7599239610234312d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5681349445547936d, y: 0.7201461785577302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5566087390518744d, y: 0.18292242642216072d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26261214559290513d, y: 0.7581412623756346d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41101476374058077d, y: 0.4938029048189261d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18598714516590287d, y: 0.7614177154601285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7538869850468387d, y: 0.9552522899710013d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7774178106902803d, y: 0.20638783612494271d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9845069577535476d, y: 0.5277062389592354d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19182640044005306d, y: 0.35172580784525076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8581430592792372d, y: 0.622093676931291d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4182989243688596d, y: 0.7752118072021216d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9107011776541494d, y: 0.16788748030079537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4508604200780464d, y: 0.8323723566923004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8474519107742349d, y: 0.8764004887074535d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06294497013726585d, y: 0.9785194954366493d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33097632053422055d, y: 0.7708219263452183d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23962831223722036d, y: 0.9887032564941598d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9889584981218306d, y: 0.40879661739587314d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0840526339760077d, y: 0.9675303332205514d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42683224941112685d, y: 0.1259566593842809d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7261461285633213d, y: 0.37633454333108485d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5661123961938728d, y: 0.5182141844874782d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04305215091257919d, y: 0.5844611679796338d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32053738836956347d, y: 0.24958812601391445d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7244043200122954d, y: 0.5094590356949098d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11374229509377021d, y: 0.34363173220206944d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15049171034118025d, y: 0.9360207665873741d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9779634310152244d, y: 0.2595418754075841d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6507744812522186d, y: 0.8819498173040102d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09134313282958251d, y: 0.330500873529865d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7564638587316046d, y: 0.9065247070160122d),
new NpgsqlTypes.NpgsqlPoint(x: 0.851078480490741d, y: 0.14847163461708401d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16052795130266362d, y: 0.2917271473512898d),
new NpgsqlTypes.NpgsqlPoint(x: 9.854120182983817E-05d, y: 0.7850214445769188d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1463628243753342d, y: 0.13700295926076367d),
new NpgsqlTypes.NpgsqlPoint(x: 0.276909087665566d, y: 0.1251400357567789d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2835642458177847d, y: 0.45200726433249483d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07217164296406686d, y: 0.40664162678723825d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6350640114304452d, y: 0.7055116002110164d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39730203806444786d, y: 0.08240771765392363d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5049301039439421d, y: 0.9271978169448872d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6512376468175652d, y: 0.16893382183117311d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19097337392131386d, y: 0.35471462383627284d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3957096419559767d, y: 0.17199853976688217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.041432377422779165d, y: 0.38575873409172745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5062068364375997d, y: 0.8415608626710473d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09868844020214063d, y: 0.44254895831519026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9195309121624121d, y: 0.22181128683020424d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0738242478342388d, y: 0.5713580864036866d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5930978894285199d, y: 0.025389850368950917d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48643208721924536d, y: 0.4688243928827851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35312032186226494d, y: 0.8486843663092366d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21426068331179104d, y: 0.9969651781247978d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36286046862432764d, y: 0.085099397780807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8964602602350382d, y: 0.8517703182562355d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6466954522582677d, y: 0.8233015169206064d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5393237124693482d, y: 0.15942506719758176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7026548113190345d, y: 0.37732577595396855d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4563716138723589d, y: 0.32948768522356986d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9439290529318958d, y: 0.002283710148858198d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9649327176198119d, y: 0.4476903552726367d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0035190838768921484d, y: 0.11758839297598478d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6614469146322993d, y: 0.7774778900278699d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6333651359576031d, y: 0.33948745353520215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5593315730354829d, y: 0.7553844598439295d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8062290416648022d, y: 0.9466843416252605d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07598895667766814d, y: 0.13943282092613607d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49058812022910914d, y: 0.44569382664348545d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15249962207845613d, y: 0.5201826798886505d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8270757315884286d, y: 0.6038394599606294d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8265769305559558d, y: 0.6161931786542636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8124325207394101d, y: 0.42374969292822395d),
new NpgsqlTypes.NpgsqlPoint(x: 0.022623092068500772d, y: 0.968792905797544d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05817241922573457d, y: 0.9568749913112222d),
new NpgsqlTypes.NpgsqlPoint(x: 0.817659223655229d, y: 0.057756596679296446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7581557862604488d, y: 0.393683490744692d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4874122706613887d, y: 0.6135072426757481d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7362335551141267d, y: 0.6890022201314162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7191302340174792d, y: 0.6546640041358137d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5681251056168177d, y: 0.8033037742079293d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8203453434681038d, y: 0.4595248019245476d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40351473473822497d, y: 0.36314538555167797d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22614914419366372d, y: 0.887237149360245d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2425284971836068d, y: 0.16773374809343278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7731326037390567d, y: 0.7166480072127912d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6622537450270812d, y: 0.6728807303725438d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20906628848748376d, y: 0.6556245015894121d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4826855229431338d, y: 0.8288630660736909d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07293660259795132d, y: 0.05963318254529193d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6081988650914492d, y: 0.584288257416026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6635196387403085d, y: 0.480805089690415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4002442245242732d, y: 0.13391965365378022d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5908071610692116d, y: 0.693649473746047d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38318789037930256d, y: 0.6902885355199324d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10590693426229836d, y: 0.8491452135660593d),
new NpgsqlTypes.NpgsqlPoint(x: 0.938716913088745d, y: 0.005280967556971161d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5878728835118396d, y: 0.0690429523607593d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35951136377800075d, y: 0.4806864138899771d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04417075996464015d, y: 0.5310338913049585d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22449578781977086d, y: 0.6597657739358067d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7999131962610975d, y: 0.37920654144211174d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8851464519972124d, y: 0.18113506260996193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8550341798195364d, y: 0.9172132464263323d),
new NpgsqlTypes.NpgsqlPoint(x: 0.691372000212574d, y: 0.5276552725990739d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8308481598648898d, y: 0.4326602985655317d),
new NpgsqlTypes.NpgsqlPoint(x: 0.923881541641217d, y: 0.6738533862898503d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05553939400605157d, y: 0.1284383040303979d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7512486852278788d, y: 0.9415200955791901d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8851706666971534d, y: 0.4667307994266645d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5673288725833722d, y: 0.7891898848296515d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2085788047166588d, y: 0.6138362563361657d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9856918498362321d, y: 0.18307108414269058d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10840455909237534d, y: 0.8603266520590724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7140021425298251d, y: 0.7440605922326347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9193148188830625d, y: 0.3091076991893841d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.52197890478733d, y: 0.5969666588088759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26875237639365035d, y: 0.7718088859084702d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11859734413306178d, y: 0.53305724821935d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6269040573261964d, y: 0.22725223823467655d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8304417479878338d, y: 0.8203076161337889d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07595384235605895d, y: 0.2866111034091149d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6555090508767659d, y: 0.47539583076464975d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8874603006658376d, y: 0.8002238031892118d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0444711563955591d, y: 0.8434323213829755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.023119927210355384d, y: 0.34477140838647136d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3903297635764017d, y: 0.45251542174970794d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7383439989705591d, y: 0.29557813090294294d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19633790338307489d, y: 0.36943797111898613d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5334138097304785d, y: 0.782082389529569d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09969366345454767d, y: 0.4312404756026398d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21434366603358035d, y: 0.1496281322093106d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9486872073468742d, y: 0.1438026595067602d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7416515982706533d, y: 0.735390472054993d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 173,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8419494356866286d, y: 0.9582643933622873d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8322783187456407d, y: 0.061504766835179914d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24512818302653971d, y: 0.1247233465726445d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2034362456744624d, y: 0.24258227738944227d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5409065177979705d, y: 0.6791146985968392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6655416272917216d, y: 0.3120587901111549d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05843734217195928d, y: 0.23826181211000486d),
},
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlPoint(x: 0.7288818276976061d, y: 0.6855759534868351d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4881632588866165d, y: 0.1613893390592238d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9899387089762665d, y: 0.745214838132611d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35177413254448375d, y: 0.45487604238134305d),
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7685288886494688d, y: 0.1392817814992977d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23627964022285097d, y: 0.7237644022336667d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8385840328927835d, y: 0.09582404046249693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5814960517534705d, y: 0.510722830203552d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3556819934071742d, y: 0.5438955369189961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.888674469865876d, y: 0.05948194983453048d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9377896925377702d, y: 0.8481626362598128d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12429876011560914d, y: 0.034915346376718004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2890730270765236d, y: 0.2882979878663049d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29265435951135677d, y: 0.6876182604468786d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08273286531093393d, y: 0.29322625045105444d),
}));
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 59, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 18, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 80, query1, 35, query2))
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 116, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 142, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 78, query1, 142, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 78, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 90, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 165);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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

