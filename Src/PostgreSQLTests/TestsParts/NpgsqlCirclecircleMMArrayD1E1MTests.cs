

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
    internal partial interface INpgsqlCircleMArraycircleMMArrayD1
    {
    }
    
    internal partial class NpgsqlCircleMArraycircleMMArrayD1 : INpgsqlCircleMArraycircleMMArrayD1
    {


#region TestData

        private readonly NpgsqlCirclecircleMMArrayD1E1M[] _testData = new NpgsqlCirclecircleMMArrayD1E1M[]
        {
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6931873401695967d, y: 0.3264401744599972d), radius: 0.2864602811049989d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4957555308970365d, y: 0.039247048632699344d), radius: 0.3625593495046283d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5697786385956657d, y: 0.7154609049479306d), radius: 0.49335153482627114d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11523961339865785d, y: 0.47696045427730693d), radius: 0.2532481831083292d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48726163409319245d, y: 0.10464710534993116d), radius: 0.17045872642098125d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9023468247718446d, y: 0.5061807612343503d), radius: 0.7566304937906512d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13214761117707063d, y: 0.3877376759863176d), radius: 0.24915519017713506d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11267119021961713d, y: 0.5878465081620654d), radius: 0.8859771034778581d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7957154210287314d, y: 0.14633185899825762d), radius: 0.4319928651521162d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.039848557338886814d, y: 0.7758589068642835d), radius: 0.6952591059462454d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6056541296320065d, y: 0.2152104645754267d), radius: 0.8389011122245909d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48148106731894447d, y: 0.666353528185008d), radius: 0.6224155834832771d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25832620087961267d, y: 0.3689429726499741d), radius: 0.6062260409350874d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02963115120762938d, y: 0.5579314749398082d), radius: 0.8891500760389475d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2431704605530498d, y: 0.3854400233999724d), radius: 0.9876853670633559d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48176472042854335d, y: 0.484371892796704d), radius: 0.27596990044077596d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8649877222448804d, y: 0.49882262007218325d), radius: 0.8442611026411675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8257553274795695d, y: 0.25215500006656943d), radius: 0.1279856401016205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9202685460114842d, y: 0.8954881531235044d), radius: 0.9204467544253688d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.033314109548737925d, y: 0.6955250716582346d), radius: 0.18869441321769265d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1631414434166515d, y: 0.6265998147767534d), radius: 0.3205695881653694d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5722526231617194d, y: 0.8563050441988291d), radius: 0.9402903059143412d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06504114250358717d, y: 0.9171312809371689d), radius: 0.6425056084018448d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5054434486956452d, y: 0.008217707810066699d), radius: 0.19574351147623892d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3594632698363397d, y: 0.9403700581334482d), radius: 0.4395118923032947d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9933159867843041d, y: 0.7033761409884407d), radius: 0.15182358971817211d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17046389230761994d, y: 0.9597607410225862d), radius: 0.5014988289006859d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26630563034274246d, y: 0.9124574255964604d), radius: 0.16050583973325938d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2452363896962111d, y: 0.23475078162781982d), radius: 0.6491740106100853d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3635667420897454d, y: 0.08737871956317178d), radius: 0.2637411227666877d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3538085820748922d, y: 0.3364512776003279d), radius: 0.06532234374001789d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8961070111449018d, y: 0.10797199381283984d), radius: 0.34966676360321725d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8506082983607037d, y: 0.5493802690610615d), radius: 0.7674272559028976d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24812755347576554d, y: 0.4933908294271616d), radius: 0.8778140316458705d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7270904159367984d, y: 0.700298059773105d), radius: 0.4919912865834949d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5580087811132667d, y: 0.44048743680460767d), radius: 0.5482218594203416d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7256579571726336d, y: 0.05213278483924866d), radius: 0.9348481162075144d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.176634825795975d, y: 0.8325361449490893d), radius: 0.9380265136474711d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7781180985297138d, y: 0.15217084238902356d), radius: 0.6403375642648986d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11819395124202325d, y: 0.585353126644109d), radius: 0.6324674720381127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9469088006169836d, y: 0.40806224852223827d), radius: 0.19893344462085505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2030967186394178d, y: 0.7536955213798742d), radius: 0.09374553594930946d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7267693712479837d, y: 0.746033226450303d), radius: 0.038233621641530435d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15703924250998846d, y: 0.3433686863055282d), radius: 0.7592105447332806d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7956840117607539d, y: 0.6174685956410682d), radius: 0.27602584174976674d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.70205720844666d, y: 0.03902386306162575d), radius: 0.8319726683263081d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18131631840639983d, y: 0.4844764442731124d), radius: 0.5399064094931849d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8210964875374442d, y: 0.3670178876722777d), radius: 0.7029925084434477d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18053974039003928d, y: 0.42966436381982054d), radius: 0.16682732132374578d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9951058765314544d, y: 0.27396647259479334d), radius: 0.6266784642719937d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7421180247230872d, y: 0.6300785726793214d), radius: 0.5420345063851947d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6585214082120873d, y: 0.2006802547289288d), radius: 0.8303107205792902d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7568762066191134d, y: 0.871553895458062d), radius: 0.11364276193452483d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8091916621037804d, y: 0.06205915780172133d), radius: 0.9441156434010181d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46020149486906947d, y: 0.7141995689220039d), radius: 0.21716702973548674d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023851829612624664d, y: 0.8298894210019354d), radius: 0.4978147818259482d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7566458659845525d, y: 0.043623135201533714d), radius: 0.9991419643736151d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8238009856835448d, y: 0.09134676153609789d), radius: 0.5344735580455985d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5945627719861802d, y: 0.6950100673943104d), radius: 0.21738584765241875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8295916816396532d, y: 0.5737351421960961d), radius: 0.2896202946819585d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4343931227141834d, y: 0.9700151722354439d), radius: 0.3648081011183598d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7598026953330523d, y: 0.24329418173464235d), radius: 0.6194714684684073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08019770235993007d, y: 0.0905883057825424d), radius: 0.9094629208919671d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9863600219505302d, y: 0.7943236459755769d), radius: 0.23682966382045012d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9326329306591519d, y: 0.2789696430803036d), radius: 0.2373665103528937d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49515399227254453d, y: 0.9678041529389989d), radius: 0.6931101341981306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8328928183889333d, y: 0.057994349223612573d), radius: 0.007057798614543809d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5528077069312499d, y: 0.6471608673710403d), radius: 0.9805130520555762d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0008108347801240035d, y: 0.7948154034058716d), radius: 0.22534485168495544d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5595430835050613d, y: 0.3320765551276511d), radius: 0.9547688250542125d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9677164476093909d, y: 0.8112851016394761d), radius: 0.6931353696704728d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2805344985514838d, y: 0.23377317862269698d), radius: 0.06382181819926103d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12442869997568207d, y: 0.1727507187791626d), radius: 0.701876896947886d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7285097076029785d, y: 0.22792351413768808d), radius: 0.25477978217284025d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3544489858217801d, y: 0.3581575283913555d), radius: 0.0917368517154119d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1626078200934309d, y: 0.6423274062954816d), radius: 0.42220790703027977d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8179113670232233d, y: 0.7284027547283928d), radius: 0.5940026834134473d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7826823117336472d, y: 0.7820807797482444d), radius: 0.5988021819782551d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.526623214231734d, y: 0.3610683273113624d), radius: 0.6524160890023136d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6768715813653019d, y: 0.9115874785574871d), radius: 0.7130832315960227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45114064390299957d, y: 0.924706356171622d), radius: 0.5699010374217924d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8941755859269015d, y: 0.2899671606338593d), radius: 0.5225272614508502d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7846970629348404d, y: 0.422489513465398d), radius: 0.434228124955244d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16525903491548732d, y: 0.8666673908638539d), radius: 0.8876440412243971d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30695819319642714d, y: 0.4687167059238422d), radius: 0.20249992375571313d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12940162075229555d, y: 0.24235340566277186d), radius: 0.03285656953278937d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31023055769545715d, y: 0.9559952128722415d), radius: 0.01753884968828634d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3198735064355802d, y: 0.0671698794969523d), radius: 0.653356663206185d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2575598554038312d, y: 0.8058671674636144d), radius: 0.014243303109163663d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7018071440268723d, y: 0.5483015910171211d), radius: 0.49265635632695404d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7873872537700439d, y: 0.21634668466168117d), radius: 0.1822944427170139d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3765194524260683d, y: 0.3716761038911077d), radius: 0.0660359520903272d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17948013713735034d, y: 0.48732350111161027d), radius: 0.5160314009612134d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7614674837951793d, y: 0.9016263790659478d), radius: 0.2837662116049362d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3989083490383377d, y: 0.17544257679219077d), radius: 0.8149279976482479d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7143122930054774d, y: 0.5787492092446366d), radius: 0.23726692261338644d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6396864698218893d, y: 0.4264491612985195d), radius: 0.2622599804477084d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9288025446774737d, y: 0.5234275203054107d), radius: 0.6161461799155558d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5669126998280203d, y: 0.23655727152689165d), radius: 0.2849948152394519d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.813241005489547d, y: 0.7705924325334554d), radius: 0.5703658821853941d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6521280168283737d, y: 0.6342115785923943d), radius: 0.41563363244046614d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8523873762027565d, y: 0.09705851021333367d), radius: 0.9328500245740341d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.897850385693835d, y: 0.19475489826889625d), radius: 0.6126820444269918d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4628596243078894d, y: 0.8650013470024672d), radius: 0.40579099626804294d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07250540892890822d, y: 0.22491098490321848d), radius: 0.34738251845034274d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26153678301400274d, y: 0.08609387118615108d), radius: 0.001871207105659578d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.693508798931289d, y: 0.8920983469600203d), radius: 0.11822663595188443d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13316873839823617d, y: 0.9854621645611347d), radius: 0.00812258805439281d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8002561453819549d, y: 0.8456993524817932d), radius: 0.9089267671024975d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8843348064883392d, y: 0.1296961637514602d), radius: 0.01675406413756164d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9055263434936877d, y: 0.4931691406836657d), radius: 0.9779245659301101d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7166090692926316d, y: 0.8662375866174793d), radius: 0.3821436537279326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33681473545885565d, y: 0.2989652116781327d), radius: 0.32031905933677707d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5659056405125236d, y: 0.24127232520590336d), radius: 0.6182076286032266d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9231377198167853d, y: 0.7509981246262815d), radius: 0.3813807768941063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11576103275072824d, y: 0.2949320550255111d), radius: 0.2844184976286406d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06946929641762023d, y: 0.9679429932050981d), radius: 0.9105022071230601d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6252262922783168d, y: 0.2811016586287952d), radius: 0.7429005250445856d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6286283035971044d, y: 0.16250181763938276d), radius: 0.24329300247113517d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3184640071273406d, y: 0.9933793795423472d), radius: 0.022736029094488575d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2522245344375993d, y: 0.6023347187312512d), radius: 0.1542891154215128d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6063111191072194d, y: 0.8980866725593045d), radius: 0.9179866502585342d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34129535936537925d, y: 0.8046152495828193d), radius: 0.17103242461967882d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.057976677273167576d, y: 0.020064033385096658d), radius: 0.8824944652163917d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6488438879779856d, y: 0.29817708099306084d), radius: 0.2966045219388017d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8024033226506947d, y: 0.08108707261604908d), radius: 0.17665931785896227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43751169677270685d, y: 0.3489462729753693d), radius: 0.12992925036477831d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3055220518075614d, y: 0.22391686393544596d), radius: 0.7300236821717493d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7688973908622511d, y: 0.27319141629085797d), radius: 0.8709663320977095d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30119382993862964d, y: 0.6832807629535375d), radius: 0.8137289093259913d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8596405645849199d, y: 0.02468285454132524d), radius: 0.6089556114489948d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15958924772165095d, y: 0.6174422584011718d), radius: 0.09235024687050952d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8432690202588069d, y: 0.6493723763784311d), radius: 0.7614164457392663d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14788875110998612d, y: 0.3813234842726707d), radius: 0.2153670608542625d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11718514658190482d, y: 0.989833315089019d), radius: 0.06861279078907245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8943763544960448d, y: 0.9527997845468592d), radius: 0.7051997743401577d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2847685221735542d, y: 0.78823882248055d), radius: 0.19023885641892946d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3291421384253682d, y: 0.6645906498222711d), radius: 0.6666306624244432d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8871543563833261d, y: 0.9542807987590386d), radius: 0.7150004325086302d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772425410521659d, y: 0.36077748215638095d), radius: 0.40541183248596135d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13524476450904332d, y: 0.0052186038904806775d), radius: 0.8659111659626089d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.576568666855525d, y: 0.9093446523325447d), radius: 0.9231558723003351d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9669570583664605d, y: 0.016421876848423445d), radius: 0.4548302183501063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14940991685729033d, y: 0.6317882390844862d), radius: 0.42776936795840026d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3074972101188266d, y: 0.4441680392897569d), radius: 0.9545067796283851d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8813248869194027d, y: 0.36165788105451d), radius: 0.21909111451995789d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.283762179505907d, y: 0.1595297321458613d), radius: 0.7835932280261173d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9163688908845227d, y: 0.4620501508927424d), radius: 0.12457826228317537d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.76052818504016d, y: 0.8935911326106152d), radius: 0.9531206878956474d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022875792015741303d, y: 0.49380271134559006d), radius: 0.2274092453170583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41902946584137524d, y: 0.9480090208721708d), radius: 0.32776058467298985d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6490652581160091d, y: 0.04338860946067369d), radius: 0.27767426898638736d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8858328520457309d, y: 0.9090085106489831d), radius: 0.5810384597296642d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09192364090147276d, y: 0.9064366880920889d), radius: 0.8506476363973953d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6086707156542265d, y: 0.8799230880682396d), radius: 0.9791098659776459d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4680365592664131d, y: 0.5281836030826115d), radius: 0.5163082901487622d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4150374792213767d, y: 0.6788958642491804d), radius: 0.34631842354705944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8494596255904687d, y: 0.053573332757749226d), radius: 0.3761089432129209d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6781798517349712d, y: 0.16961725316294174d), radius: 0.4828286772178866d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4992593514030731d, y: 0.5868300137144079d), radius: 0.3003751196395047d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5205257155995067d, y: 0.25200473681569013d), radius: 0.5075791734737067d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6778169652691235d, y: 0.981288923744075d), radius: 0.28454790447732825d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12231865322421032d, y: 0.9064462149307255d), radius: 0.09496291468675322d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8349237004783954d, y: 0.2586256630790067d), radius: 0.8330262770848545d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9670929320002914d, y: 0.4284308593700231d), radius: 0.4146009120287665d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3794580433948056d, y: 0.4995312190885516d), radius: 0.0499087717250285d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25066806579887646d, y: 0.6747289828524056d), radius: 0.3621192034451405d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8874689550757494d, y: 0.422972357909848d), radius: 0.20498936303938609d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23362669176272588d, y: 0.5502175766172113d), radius: 0.4838782828815118d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03755785597380157d, y: 0.2623892831316853d), radius: 0.37590271970825284d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6450132930752445d, y: 0.0006345971526988681d), radius: 0.9655615299395828d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2241872027951839d, y: 0.5173365028112558d), radius: 0.9061878539947318d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9214045343863705d, y: 0.6035806403114059d), radius: 0.43505833977834263d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.273563830280936d, y: 0.3132530078563015d), radius: 0.40063355623822294d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.395184480142185d, y: 0.6664584368035906d), radius: 0.1214855295117796d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1050320829184912d, y: 0.36570151482863067d), radius: 0.042316045163978244d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1307946021233336d, y: 0.8090144411551135d), radius: 0.5351477911302522d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34624099993024127d, y: 0.07198256057234764d), radius: 0.5417147625972292d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3391971322264954d, y: 0.051537443359724655d), radius: 0.4773797049461501d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7599118533023952d, y: 0.782970875582149d), radius: 0.2582714993718903d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6050610449581917d, y: 0.15216885402856084d), radius: 0.6052675874612249d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6468257325254017d, y: 0.7537242942421493d), radius: 0.9300648184641166d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3247061303247152d, y: 0.41597970801802864d), radius: 0.3421826384423948d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43358415229706015d, y: 0.7030331411906916d), radius: 0.7636791422816047d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3642849315055289d, y: 0.8560043637038391d), radius: 0.34005651278826454d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22874281885990788d, y: 0.5417609387702017d), radius: 0.8720681259248364d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9031089722656067d, y: 0.20337774508465878d), radius: 0.7559004573848903d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8472183144597002d, y: 0.6813313036120819d), radius: 0.6326749895194906d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28203911983766183d, y: 0.009615919476432366d), radius: 0.9438556578497006d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9140450274947677d, y: 0.14714923704322969d), radius: 0.978596859129569d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08867889289632724d, y: 0.20776733618767784d), radius: 0.46943689455618687d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8941096535992938d, y: 0.5448690034447807d), radius: 0.2623709537642658d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6390084098664033d, y: 0.11375076736176593d), radius: 0.018046296849882015d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6928299515301617d, y: 0.04157265165946633d), radius: 0.09485411809006383d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7839309832986493d, y: 0.4606038190204832d), radius: 0.026753646781777607d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4887937824957981d, y: 0.49379704164295046d), radius: 0.6969257428300526d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07160392270502747d, y: 0.7647108966606294d), radius: 0.744714258199903d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8596975249921823d, y: 0.46988276109127025d), radius: 0.9822610171330094d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7311790369410471d, y: 0.13304214730764197d), radius: 0.19013660044089642d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11729833342869045d, y: 0.32825287577134177d), radius: 0.47200551163165116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13065238579146876d, y: 0.9922117360746522d), radius: 0.3726453429985631d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15152384984140221d, y: 0.03048955560091915d), radius: 0.38370680045979d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8849119083068212d, y: 0.7107602113468743d), radius: 0.7372081358767044d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2648786778860889d, y: 0.09050613700442134d), radius: 0.7748632604037267d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35691928593867994d, y: 0.15930840685579784d), radius: 0.565674098956643d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14637295184653654d, y: 0.0463093349454905d), radius: 0.9411775105250924d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23185505563129283d, y: 0.022437768743875486d), radius: 0.7230058996969413d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06639368486985808d, y: 0.6483444425728562d), radius: 0.6452964207494641d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23897546639186829d, y: 0.16641685195436207d), radius: 0.9326195009110512d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9505768615178337d, y: 0.46954801067613783d), radius: 0.6719666078659727d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12766283804189305d, y: 0.6841214825424708d), radius: 0.011699951201381675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04512616077146836d, y: 0.23665630043555885d), radius: 0.018753902287303448d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3158447819931711d, y: 0.08442991122460075d), radius: 0.9089188121991074d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4611287883257106d, y: 0.6670335700408834d), radius: 0.7459368718679407d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1628687387356078d, y: 0.013510701604480535d), radius: 0.29672608684572954d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6367171688815764d, y: 0.06965575673980173d), radius: 0.620056197488639d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39910495703008686d, y: 0.9675664587948131d), radius: 0.40581282602391533d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3210175326258874d, y: 0.7099024440185199d), radius: 0.48356072259122784d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26879968358913187d, y: 0.23121919863498197d), radius: 0.2421631850678706d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2717622068370986d, y: 0.5571141747573995d), radius: 0.6535274206855625d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.678842294357647d, y: 0.4174255565346733d), radius: 0.5204374239843077d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.889679991096891d, y: 0.7513850136398892d), radius: 0.17444900139851993d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.579366901398344d, y: 0.4923955687012982d), radius: 0.5130524169146166d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3713403756772933d, y: 0.680254179759249d), radius: 0.2846175689745649d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8479149088437316d, y: 0.8651324871579722d), radius: 0.9117725307763483d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46454420835958254d, y: 0.3590165966683646d), radius: 0.48052710530588905d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37023440002983443d, y: 0.9967606679446414d), radius: 0.09989330364199622d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39322240388993523d, y: 0.34048029023330795d), radius: 0.5708272937679248d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12309078287210384d, y: 0.7560362389153298d), radius: 0.3629587054311655d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.703193475171294d, y: 0.27741280422517156d), radius: 0.8769186422067925d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03438623413257158d, y: 0.8015091501339654d), radius: 0.39351719224851456d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03155743350975204d, y: 0.48356235289974203d), radius: 0.1523556818105003d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7156194600197797d, y: 0.7447316607003143d), radius: 0.25081250615575645d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19520221518004643d, y: 0.2384288109530447d), radius: 0.3687574245028723d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5605001924242361d, y: 0.5311772058046378d), radius: 0.6308682312018445d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23183218862785382d, y: 0.6292180277840772d), radius: 0.710173334691533d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4080949934651086d, y: 0.3654969456234731d), radius: 0.6879688445233705d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6067812564661282d, y: 0.46216901494026974d), radius: 0.5178651802256429d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9598066590271501d, y: 0.6848246120481369d), radius: 0.45578000074542135d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15257280932731032d, y: 0.5533196693010944d), radius: 0.8656427935741002d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3043892957235943d, y: 0.32199371286102973d), radius: 0.5583479437285265d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.719403982010077d, y: 0.9677470618400278d), radius: 0.9725259709805d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4877743724199848d, y: 0.1819178448081501d), radius: 0.9301827690993055d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9563927038956522d, y: 0.9469274497723341d), radius: 0.23669595834831492d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8492625696044738d, y: 0.11729834395505079d), radius: 0.8219173614833669d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2881114283330808d, y: 0.3060407961167677d), radius: 0.9030965658590848d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5956078976656636d, y: 0.80607179090838d), radius: 0.6744915994422672d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10654510213692314d, y: 0.9221559270102493d), radius: 0.5268640928971757d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6773530514257847d, y: 0.7648146680088846d), radius: 0.5225721021454348d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7718179417054217d, y: 0.5370379521436788d), radius: 0.06576110570542926d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8151278538604507d, y: 0.32241295978307405d), radius: 0.29905132525291245d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2792046028622741d, y: 0.4066129867977962d), radius: 0.1819743866050162d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9790219667180966d, y: 0.7139013308252494d), radius: 0.6020601952841924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4926961345348031d, y: 0.42664423916151795d), radius: 0.8925900057040478d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7245756409551287d, y: 0.17452433657348765d), radius: 0.841070436813894d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7868072032583858d, y: 0.06695728360200615d), radius: 0.06375800882779037d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7880008391282535d, y: 0.743025040801325d), radius: 0.03470764456693354d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1545725430268008d, y: 0.3779936348749924d), radius: 0.868339393469655d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2382274696903588d, y: 0.161217114872924d), radius: 0.6152973694601076d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22936052417226094d, y: 0.25925946765010066d), radius: 0.8047863902571539d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8301433224522906d, y: 0.621274320615223d), radius: 0.653342464860099d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04508474770982507d, y: 0.20245442414442327d), radius: 0.12440194314704989d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008697090086540848d, y: 0.20036750672977133d), radius: 0.22143047703162055d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6760149650785636d, y: 0.0204526397304009d), radius: 0.7793673189377087d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3109558300711197d, y: 0.2744199456750547d), radius: 0.07109262875708777d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6976693181338289d, y: 0.004870569393095381d), radius: 0.08253482125850653d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6865665400720194d, y: 0.2597602452440092d), radius: 0.7998283493890281d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6851293710895511d, y: 0.3371011934616217d), radius: 0.5548148217585743d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4243395432925441d, y: 0.649960827966714d), radius: 0.44368123144874694d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40973775143945523d, y: 0.09075513437559446d), radius: 0.3012200091989766d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05818642800901597d, y: 0.6062693806112258d), radius: 0.6837375345966064d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9207539079468612d, y: 0.5308269214304157d), radius: 0.19502649090088198d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9908929861916561d, y: 0.9930280953629363d), radius: 0.9886172212560851d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.325325084694143d, y: 0.16918468223975835d), radius: 0.39938209167311034d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04424920825506107d, y: 0.043038805095627075d), radius: 0.7468438426575498d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2641286478654389d, y: 0.4307023218994409d), radius: 0.17234812971609648d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05312338591485066d, y: 0.8862116429374688d), radius: 0.32572961733801675d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd1e1mi_id
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
    npgsqlcirclecirclemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8210964875374442d, y: 0.3670178876722777d), radius: 0.7029925084434477d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18053974039003928d, y: 0.42966436381982054d), radius: 0.16682732132374578d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9951058765314544d, y: 0.27396647259479334d), radius: 0.6266784642719937d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7421180247230872d, y: 0.6300785726793214d), radius: 0.5420345063851947d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7598026953330523d, y: 0.24329418173464235d), radius: 0.6194714684684073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08019770235993007d, y: 0.0905883057825424d), radius: 0.9094629208919671d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9863600219505302d, y: 0.7943236459755769d), radius: 0.23682966382045012d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd1e1mi_id
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
    npgsqlcirclecirclemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.526623214231734d, y: 0.3610683273113624d), radius: 0.6524160890023136d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6768715813653019d, y: 0.9115874785574871d), radius: 0.7130832315960227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45114064390299957d, y: 0.924706356171622d), radius: 0.5699010374217924d),
}));
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD1E1M> models = null;

                models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD1E1M> models = null;

                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 126;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 106;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 148, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 158, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 162, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 52, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 162, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 52, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 152, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 161, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 161, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 64, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleMArraycircleMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleMArraycircleMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclemmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.binary_npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclemmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA), typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
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
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
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
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA), typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
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
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
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
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MI), typeof(NpgsqlCirclecircleMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MI>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MI>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA), typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

