

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
    internal partial interface INpgsqlLineMArraylineMMArrayD2
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD2 : INpgsqlLineMArraylineMMArrayD2
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD2E1M[] _testData = new NpgsqlLinelineMMArrayD2E1M[]
        {
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9874362343820052d, b: 0.20813237138763796d, c: 0.8216604059942061d), new NpgsqlTypes.NpgsqlLine(a: 0.43024678665996796d, b: 0.5013579640089112d, c: 0.45054200247490084d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8331974039489106d, b: 0.6863238526041996d, c: 0.5560956238861688d), new NpgsqlTypes.NpgsqlLine(a: 0.04166646620335979d, b: 0.26775926721618026d, c: 0.01962535351785555d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8654641050482621d, b: 0.8054224612316551d, c: 0.2789631194629698d), new NpgsqlTypes.NpgsqlLine(a: 0.5926954188843429d, b: 0.19001005791104986d, c: 0.24274432495835807d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.41607988436672927d, b: 0.23266448796386985d, c: 0.35386563973839336d), new NpgsqlTypes.NpgsqlLine(a: 0.06192043497682198d, b: 0.6453706150659241d, c: 0.33359873809707585d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6200894782158348d, b: 0.6449604449221019d, c: 0.08272165371001883d), new NpgsqlTypes.NpgsqlLine(a: 0.3088605665392433d, b: 0.13426082899777114d, c: 0.48511280583157845d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8271663470853359d, b: 0.0378406716602806d, c: 0.4948374997949915d), new NpgsqlTypes.NpgsqlLine(a: 0.8006498579205252d, b: 0.03958384862530728d, c: 0.43111543825727827d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5140744194614197d, b: 0.2258581354496012d, c: 0.9152696002899073d), new NpgsqlTypes.NpgsqlLine(a: 0.06927890133605386d, b: 0.003248687047495702d, c: 0.47585256317729796d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2222610106420072d, b: 0.433493111293517d, c: 0.9295056590417674d), new NpgsqlTypes.NpgsqlLine(a: 0.23290264273287242d, b: 0.1320243807423096d, c: 0.3824095993689164d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.31057240321288027d, b: 0.8598315908537373d, c: 0.14019337078780325d), new NpgsqlTypes.NpgsqlLine(a: 0.6916324850565402d, b: 0.48111701125362083d, c: 0.1968359148943707d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.06779006999612358d, b: 0.7341891255744608d, c: 0.32431948668053423d), new NpgsqlTypes.NpgsqlLine(a: 0.3831240485498272d, b: 0.7609111830862979d, c: 0.7095342335519698d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.697803879146606d, b: 0.3506376799227734d, c: 0.9561587565749077d), new NpgsqlTypes.NpgsqlLine(a: 0.9028720205558124d, b: 0.5147657976164861d, c: 0.8022294942240749d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7950203662304838d, b: 0.7481800429688047d, c: 0.26479541194938094d), new NpgsqlTypes.NpgsqlLine(a: 0.6030784019756656d, b: 0.41116197174682223d, c: 0.7261946572194948d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4776109090442391d, b: 0.26937331766526074d, c: 0.69748834348657d), new NpgsqlTypes.NpgsqlLine(a: 0.41564499841988467d, b: 0.3474180251016272d, c: 0.7908259903125298d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7197137581810297d, b: 0.19480247103303372d, c: 0.47950387704925557d), new NpgsqlTypes.NpgsqlLine(a: 0.5119177520129055d, b: 0.7761287244430217d, c: 0.1610360139009518d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.06368568610397907d, b: 0.862644792507351d, c: 0.8860118240632161d), new NpgsqlTypes.NpgsqlLine(a: 0.34203132339219655d, b: 0.8240858967011653d, c: 0.19799452803024498d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.1544389676833069d, b: 0.32719885846691965d, c: 0.7796590018937448d), new NpgsqlTypes.NpgsqlLine(a: 0.03760127038543304d, b: 0.301776636301587d, c: 0.5510368304964492d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4882963501057229d, b: 0.8438827402642881d, c: 0.033806640143106303d), new NpgsqlTypes.NpgsqlLine(a: 0.843691858606967d, b: 0.4435773446176029d, c: 0.2516130298458943d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.15474004064115843d, b: 0.9245060688390114d, c: 0.17169929986827992d), new NpgsqlTypes.NpgsqlLine(a: 0.04686599456956242d, b: 0.8902288038296724d, c: 0.4355509132843507d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7672514843946872d, b: 0.5599514501513855d, c: 0.02238164730984271d), new NpgsqlTypes.NpgsqlLine(a: 0.5396017530773093d, b: 0.9862009291403866d, c: 0.5280140572060036d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3786761468373048d, b: 0.17467679328408936d, c: 0.45710406941551596d), new NpgsqlTypes.NpgsqlLine(a: 0.7627926978551058d, b: 0.9200877065173881d, c: 0.8744720869986904d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5549153594251123d, b: 0.2154982443539265d, c: 0.2670300429017275d), new NpgsqlTypes.NpgsqlLine(a: 0.07700038255662378d, b: 0.5332483142589315d, c: 0.5710585791556448d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.14455213026001978d, b: 0.16715145370519913d, c: 0.4117898174485244d), new NpgsqlTypes.NpgsqlLine(a: 0.18967303844813665d, b: 0.07756252302413391d, c: 0.021792683372237165d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3534127800489021d, b: 0.9613207513097289d, c: 0.8299009835071754d), new NpgsqlTypes.NpgsqlLine(a: 0.09961844024649413d, b: 0.3837607478786481d, c: 0.23620782682268648d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7330991535180218d, b: 0.4023592130119825d, c: 0.9819547442282108d), new NpgsqlTypes.NpgsqlLine(a: 0.055818024528568655d, b: 0.21437338205912626d, c: 0.19462888118506838d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3815375158364783d, b: 0.3239904719678206d, c: 0.07927767319723977d), new NpgsqlTypes.NpgsqlLine(a: 0.8385279496720242d, b: 0.6878311288975979d, c: 0.5420517549072372d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.09517014061833406d, b: 0.1612466874878966d, c: 0.7440636648443214d), new NpgsqlTypes.NpgsqlLine(a: 0.39131248756836756d, b: 0.7128875150242754d, c: 0.18444230247877746d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4087075705772485d, b: 0.13708845371879108d, c: 0.6765284370941166d), new NpgsqlTypes.NpgsqlLine(a: 0.7610326306168146d, b: 0.8947160980831811d, c: 0.17425509982829457d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8442471236433293d, b: 0.4120186731103811d, c: 0.608033856676809d), new NpgsqlTypes.NpgsqlLine(a: 0.3128665557060839d, b: 0.03547860187366181d, c: 0.4009329138717279d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.30345795389465147d, b: 0.6083688112638367d, c: 0.01932797118431928d), new NpgsqlTypes.NpgsqlLine(a: 0.9974799833180609d, b: 0.7146379171868017d, c: 0.44543278562083655d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4311156394656801d, b: 0.28147202983377784d, c: 0.8628864233342763d), new NpgsqlTypes.NpgsqlLine(a: 0.002253095332715893d, b: 0.460952779011535d, c: 0.5090383205392326d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5326479074553501d, b: 0.8007867637148464d, c: 0.856456918239763d), new NpgsqlTypes.NpgsqlLine(a: 0.9543725076711134d, b: 0.626386251154769d, c: 0.7609917672107829d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.279780192391038d, b: 0.022643187086201944d, c: 0.3359218161505012d), new NpgsqlTypes.NpgsqlLine(a: 0.14454834474791367d, b: 0.5577647729068443d, c: 0.949086093058319d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.14543634906909986d, b: 0.7373501583922639d, c: 0.10188219687887723d), new NpgsqlTypes.NpgsqlLine(a: 0.8082738686424812d, b: 0.12600776096023059d, c: 0.3600340746202143d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.378296874634658d, b: 0.6576868807066203d, c: 0.6366268074526842d), new NpgsqlTypes.NpgsqlLine(a: 0.11562841355765296d, b: 0.08926421642485183d, c: 0.3311122718190729d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7657604624520458d, b: 0.07626699728414543d, c: 0.9122732025748069d), new NpgsqlTypes.NpgsqlLine(a: 0.18517483679920765d, b: 0.07695079851764997d, c: 0.14141197016280416d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8165883418609258d, b: 0.4757082243823382d, c: 0.3361972956655933d), new NpgsqlTypes.NpgsqlLine(a: 0.5160190077000645d, b: 0.3310398056776518d, c: 0.08201472027793799d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.27636161617479105d, b: 0.23595025804024006d, c: 0.4717270175799386d), new NpgsqlTypes.NpgsqlLine(a: 0.24599415412392933d, b: 0.6828269901720413d, c: 0.37125662312409136d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.06992914858052335d, b: 0.4150221434118804d, c: 0.1822550174267592d), new NpgsqlTypes.NpgsqlLine(a: 0.8990265741129798d, b: 0.3033536803272674d, c: 0.7591164136635554d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12746526362529287d, b: 0.5772983267518504d, c: 0.37399607851430905d), new NpgsqlTypes.NpgsqlLine(a: 0.572492006115751d, b: 0.2839680298857191d, c: 0.8489182953184995d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.33370447371109935d, b: 0.8603445351028517d, c: 0.9350200636318307d), new NpgsqlTypes.NpgsqlLine(a: 0.12074679075587713d, b: 0.5114424260301084d, c: 0.24026652941267512d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5857127957727268d, b: 0.7125715420821428d, c: 0.7158264492599931d), new NpgsqlTypes.NpgsqlLine(a: 0.660275298232529d, b: 0.4070773817931227d, c: 0.7141858688000221d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6094731223515703d, b: 0.17774572245988496d, c: 0.9912701788925651d), new NpgsqlTypes.NpgsqlLine(a: 0.5458748413176636d, b: 0.446973180184129d, c: 0.04604163906951375d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.665710940275945d, b: 0.34389750212398273d, c: 0.04497255404311051d), new NpgsqlTypes.NpgsqlLine(a: 0.3555286213310056d, b: 0.4372176994764507d, c: 0.9691080053988793d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9398726507420223d, b: 0.39362858933094d, c: 0.19628897175407078d), new NpgsqlTypes.NpgsqlLine(a: 0.3817116588662316d, b: 0.9825477559926895d, c: 0.09202281846160043d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.050973119401769074d, b: 0.31947463416198063d, c: 0.9788941482922946d), new NpgsqlTypes.NpgsqlLine(a: 0.404600132135697d, b: 0.12545838189887304d, c: 0.889260091896898d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7801845911122689d, b: 0.23005461310916941d, c: 0.2100793341441557d), new NpgsqlTypes.NpgsqlLine(a: 0.8005640127671882d, b: 0.05595931710242685d, c: 0.3808515053216852d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6263979823461825d, b: 0.24940490345535282d, c: 0.4966243950575392d), new NpgsqlTypes.NpgsqlLine(a: 0.4276577857015499d, b: 0.3834409488488818d, c: 0.48939348178187003d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.06136461718824848d, b: 0.8462161558884821d, c: 0.31469161209011953d), new NpgsqlTypes.NpgsqlLine(a: 0.6388534587013227d, b: 0.12389330789059638d, c: 0.03361519965558957d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.32952479750383057d, b: 0.2660376257704755d, c: 0.7675548727870014d), new NpgsqlTypes.NpgsqlLine(a: 0.6917563302103672d, b: 0.5595716393870684d, c: 0.14934542728912936d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8206369483840661d, b: 0.758587708045232d, c: 0.7112035955284429d), new NpgsqlTypes.NpgsqlLine(a: 0.15142060686671555d, b: 0.39479988442606295d, c: 0.959716342153737d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.686962938737763d, b: 0.6057984182225588d, c: 0.6924585314958656d), new NpgsqlTypes.NpgsqlLine(a: 0.7342589389652777d, b: 0.5454153618784849d, c: 0.4511087187315822d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.04752325038121208d, b: 0.5671885306520129d, c: 0.6494086508025738d), new NpgsqlTypes.NpgsqlLine(a: 0.5156077077473193d, b: 0.21350203323843087d, c: 0.7576523737759236d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.0325712445276124d, b: 0.4293858386517453d, c: 0.3630859277565389d), new NpgsqlTypes.NpgsqlLine(a: 0.1584720026984412d, b: 0.041775848430833484d, c: 0.10210721202337525d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.632508346334146d, b: 0.1251925383169349d, c: 0.3122993798520983d), new NpgsqlTypes.NpgsqlLine(a: 0.7012495834864199d, b: 0.576139957788436d, c: 0.25393921386144547d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.30017357356910734d, b: 0.2206641212164816d, c: 0.819347091551495d), new NpgsqlTypes.NpgsqlLine(a: 0.0774797730774871d, b: 0.006260965934837048d, c: 0.7692513159655716d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8877100917125377d, b: 0.3512033202788135d, c: 0.8264152936205945d), new NpgsqlTypes.NpgsqlLine(a: 0.5573859410804567d, b: 0.8673114522984645d, c: 0.3342171254225501d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9056890379436824d, b: 0.6613465281402237d, c: 0.21454171319644522d), new NpgsqlTypes.NpgsqlLine(a: 0.5547548028216183d, b: 0.28225524279932157d, c: 0.5226454832149424d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.10955074475646986d, b: 0.772920126676377d, c: 0.15614321218372562d), new NpgsqlTypes.NpgsqlLine(a: 0.7115789867038098d, b: 0.13639666193011402d, c: 0.6789252683226508d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.30880618090487744d, b: 0.4751836768442087d, c: 0.6997884999010695d), new NpgsqlTypes.NpgsqlLine(a: 0.5423260514994976d, b: 0.5151498675891418d, c: 0.6652494684612564d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6425212798442449d, b: 0.7767551640133379d, c: 0.10088566129379117d), new NpgsqlTypes.NpgsqlLine(a: 0.6411106351110318d, b: 0.8134645991992157d, c: 0.6767839931607404d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8356493770763828d, b: 0.9426061705054589d, c: 0.21618493465466038d), new NpgsqlTypes.NpgsqlLine(a: 0.8618568844121993d, b: 0.6520474941138046d, c: 0.0687768295009088d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3987624544290008d, b: 0.1846710913359847d, c: 0.2166654134918976d), new NpgsqlTypes.NpgsqlLine(a: 0.48391479087544564d, b: 0.6992544748467204d, c: 0.8807260849567111d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6032023492263561d, b: 0.15289882828259094d, c: 0.18089020643246811d), new NpgsqlTypes.NpgsqlLine(a: 0.10277601305094863d, b: 0.7831431468178973d, c: 0.3677089615380986d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7881406514932646d, b: 0.4212320655899885d, c: 0.6315311600729953d), new NpgsqlTypes.NpgsqlLine(a: 0.05670778058921988d, b: 0.8172584726370897d, c: 0.4099482761988491d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4019998936845802d, b: 0.01570071194231737d, c: 0.13411636124604775d), new NpgsqlTypes.NpgsqlLine(a: 0.5820668105449064d, b: 0.822462917126876d, c: 0.7689195427112405d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.1247187423681293d, b: 0.11856959896437202d, c: 0.1835476873069969d), new NpgsqlTypes.NpgsqlLine(a: 0.1146581466344414d, b: 0.40397306949337675d, c: 0.17787585865264743d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2672566989894478d, b: 0.926918582601114d, c: 0.9490214280882643d), new NpgsqlTypes.NpgsqlLine(a: 0.752257865909563d, b: 0.7669025853568324d, c: 0.7639125172832208d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7787260552880358d, b: 0.46070179331756234d, c: 0.7692758155548508d), new NpgsqlTypes.NpgsqlLine(a: 0.4883551530663537d, b: 0.6216376846840113d, c: 0.5755954939690187d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5090508635942778d, b: 0.5298721220194191d, c: 0.7564551239034984d), new NpgsqlTypes.NpgsqlLine(a: 0.7666902347012207d, b: 0.7573441262636661d, c: 0.17077813199999547d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.49652199250684537d, b: 0.5298800653724172d, c: 0.1098639907643495d), new NpgsqlTypes.NpgsqlLine(a: 0.11571251479892386d, b: 0.6465779195197379d, c: 0.19743522572739525d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.35155356667767235d, b: 0.9147553604056876d, c: 0.4116539100567491d), new NpgsqlTypes.NpgsqlLine(a: 0.9219106553301661d, b: 0.06359660725312621d, c: 0.1830573027680612d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.32700937078122183d, b: 0.1033444381164802d, c: 0.8272944019080376d), new NpgsqlTypes.NpgsqlLine(a: 0.5147745013699242d, b: 0.050178901018054334d, c: 0.67079823595223d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8262732491068131d, b: 0.7555916732527654d, c: 0.7411398319236341d), new NpgsqlTypes.NpgsqlLine(a: 0.7820045602234235d, b: 0.5429665095593641d, c: 0.5157664182850277d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3702582811868874d, b: 0.7940457905366035d, c: 0.3525115487083462d), new NpgsqlTypes.NpgsqlLine(a: 0.1414364604186512d, b: 0.501586099705201d, c: 0.576255088256526d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2693925312522195d, b: 0.444129167377449d, c: 0.014224053206930765d), new NpgsqlTypes.NpgsqlLine(a: 0.5315921430628494d, b: 0.15526465767507003d, c: 0.092854447332539d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.49960733763397613d, b: 0.596551022553815d, c: 0.5134226347786026d), new NpgsqlTypes.NpgsqlLine(a: 0.2333282460599171d, b: 0.5613985670836924d, c: 0.07058127189335306d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8724056726138736d, b: 0.827036192267936d, c: 0.992820095509744d), new NpgsqlTypes.NpgsqlLine(a: 0.3532978964596757d, b: 0.5979814407920641d, c: 0.6067640649198326d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7861268860567054d, b: 0.7033613087813995d, c: 0.973319571717312d), new NpgsqlTypes.NpgsqlLine(a: 0.4493425715165099d, b: 0.9298984624449484d, c: 0.03611366532048055d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5602892705967427d, b: 0.8327000157629869d, c: 0.1445419135400844d), new NpgsqlTypes.NpgsqlLine(a: 0.8733248032351852d, b: 0.3653538899401978d, c: 0.6401145779502907d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.052770591922969734d, b: 0.5701220049543239d, c: 0.3192282260991126d), new NpgsqlTypes.NpgsqlLine(a: 0.8744758428375236d, b: 0.7846884334712402d, c: 0.025016764154599413d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5526736430366588d, b: 0.7000122006074609d, c: 0.5211568919832356d), new NpgsqlTypes.NpgsqlLine(a: 0.005391305161248194d, b: 0.22514475203751083d, c: 0.13777812683875912d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2240708811306813d, b: 0.17015041604376924d, c: 0.7328703842501708d), new NpgsqlTypes.NpgsqlLine(a: 0.7921891919396097d, b: 0.8523631318291514d, c: 0.38356897821365776d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9652059881359363d, b: 0.6605341880361386d, c: 0.9114474469561132d), new NpgsqlTypes.NpgsqlLine(a: 0.5386734348648975d, b: 0.33780102674229573d, c: 0.08363065084305488d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7830469708762235d, b: 0.16618308239892166d, c: 0.31609655404188375d), new NpgsqlTypes.NpgsqlLine(a: 0.7984919292962946d, b: 0.7242889773403387d, c: 0.2406368821921926d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.0013416784580633223d, b: 0.7367110648159633d, c: 0.7697133004406034d), new NpgsqlTypes.NpgsqlLine(a: 0.29298365114286695d, b: 0.9467642036023789d, c: 0.2824111877658305d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4212087133524922d, b: 0.438603697983564d, c: 0.9940694489150851d), new NpgsqlTypes.NpgsqlLine(a: 0.8417197135218639d, b: 0.7578826191819624d, c: 0.545065595788524d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.25857900397732225d, b: 0.8143711963651098d, c: 0.5178212099637234d), new NpgsqlTypes.NpgsqlLine(a: 0.9637926079826529d, b: 0.9607693930271737d, c: 0.08632517601782363d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7150529891368314d, b: 0.4688979992478717d, c: 0.8408057564077313d), new NpgsqlTypes.NpgsqlLine(a: 0.5138745340999379d, b: 0.04686485016568154d, c: 0.17843005462012118d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.050291667691362396d, b: 0.30176661865095755d, c: 0.5061370406298138d), new NpgsqlTypes.NpgsqlLine(a: 0.4803155397130352d, b: 0.9280822413859946d, c: 0.3731940737301348d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6498846003658635d, b: 0.9282619417416171d, c: 0.19115215409538844d), new NpgsqlTypes.NpgsqlLine(a: 0.5251918632958122d, b: 0.7350787174661373d, c: 0.9165327657392827d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.032560961374930586d, b: 0.7838862668884504d, c: 0.9998092704687945d), new NpgsqlTypes.NpgsqlLine(a: 0.346393184452892d, b: 0.8505064700308654d, c: 0.2931909227521191d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.740952131902916d, b: 0.32599629827261356d, c: 0.13575834065368841d), new NpgsqlTypes.NpgsqlLine(a: 0.30031727809888187d, b: 0.9624971480296041d, c: 0.32060919858561476d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5225949608264421d, b: 0.5893722322691358d, c: 0.6378675173884922d), new NpgsqlTypes.NpgsqlLine(a: 0.6888638772821946d, b: 0.6274180636878607d, c: 0.5085132873135666d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.10886960493361852d, b: 0.7565903695022825d, c: 0.05232650941555983d), new NpgsqlTypes.NpgsqlLine(a: 0.16249916985067614d, b: 0.33371535113250184d, c: 0.7034227328769604d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8446984494560716d, b: 0.5056340988040527d, c: 0.2216674482356099d), new NpgsqlTypes.NpgsqlLine(a: 0.22164462336286805d, b: 0.17157860106097955d, c: 0.9715434546720961d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3971614218011513d, b: 0.574419851594405d, c: 0.9231837941450116d), new NpgsqlTypes.NpgsqlLine(a: 0.415844875375857d, b: 0.8811874290370209d, c: 0.8790990555145638d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.26012780899390764d, b: 0.20078730140594037d, c: 0.3848115230814133d), new NpgsqlTypes.NpgsqlLine(a: 0.6569243139512816d, b: 0.39736222942055643d, c: 0.2004603090207019d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8210731600267298d, b: 0.9658961934461135d, c: 0.6326333171610363d), new NpgsqlTypes.NpgsqlLine(a: 0.2069886642749431d, b: 0.9497895462478138d, c: 0.9001510580055674d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8205708115655315d, b: 0.9856302333791578d, c: 0.16451857250063262d), new NpgsqlTypes.NpgsqlLine(a: 0.6447557871820414d, b: 0.966688229198996d, c: 0.3995717672151782d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.41811287878009584d, b: 0.958362556077163d, c: 0.7164090311378942d), new NpgsqlTypes.NpgsqlLine(a: 0.5716891830023638d, b: 0.7190395344309539d, c: 0.9926875378514833d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6508598936943393d, b: 0.2998129016815416d, c: 0.31407728591011574d), new NpgsqlTypes.NpgsqlLine(a: 0.7302855634379805d, b: 0.5300241026448143d, c: 0.13077220013711366d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7329455282228519d, b: 0.003863947301801285d, c: 0.2484248741639492d), new NpgsqlTypes.NpgsqlLine(a: 0.6955791286973152d, b: 0.07794729646113863d, c: 0.24342049049333336d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9753017729892156d, b: 0.923727361152746d, c: 0.008774720097392441d), new NpgsqlTypes.NpgsqlLine(a: 0.7287475963715921d, b: 0.41610611801344133d, c: 0.025053223651876122d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6703380255877351d, b: 0.5826228476647906d, c: 0.12238546668284422d), new NpgsqlTypes.NpgsqlLine(a: 0.34941166072702035d, b: 0.6159851069774803d, c: 0.9196283623714092d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.907198404277711d, b: 0.13913247990811717d, c: 0.016452620331796175d), new NpgsqlTypes.NpgsqlLine(a: 0.5351979136496698d, b: 0.9591628997415463d, c: 0.040538094966212856d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23766749924775488d, b: 0.14597388507783549d, c: 0.2941463189576553d), new NpgsqlTypes.NpgsqlLine(a: 0.5105328593586914d, b: 0.7072955469948113d, c: 0.7012109197227522d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.38665211643144015d, b: 0.022041611110499626d, c: 0.2831221655196806d), new NpgsqlTypes.NpgsqlLine(a: 0.8325883846677267d, b: 0.2233255125489989d, c: 0.52256663748278d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9081762105696769d, b: 0.540787133397823d, c: 0.3363277492989286d), new NpgsqlTypes.NpgsqlLine(a: 0.4814795623865512d, b: 0.05092866250529038d, c: 0.8233130256498995d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9172675275459878d, b: 0.25727599967859416d, c: 0.1743368261552084d), new NpgsqlTypes.NpgsqlLine(a: 0.2677900777006751d, b: 0.7563650748721132d, c: 0.7865668655104613d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7489141695955086d, b: 0.7219152335552875d, c: 0.7198285672321898d), new NpgsqlTypes.NpgsqlLine(a: 0.782474140118195d, b: 0.4345218446568392d, c: 0.9122769460158419d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7046424735445936d, b: 0.7662112922932276d, c: 0.5799932484640519d), new NpgsqlTypes.NpgsqlLine(a: 0.9485670904462759d, b: 0.8817962262186939d, c: 0.4403178769427154d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5620730735914036d, b: 0.5885545756956566d, c: 0.6870860232499792d), new NpgsqlTypes.NpgsqlLine(a: 0.04728610921604104d, b: 0.176442639642318d, c: 0.8663063686880255d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.1037570890534475d, b: 0.561339182671641d, c: 0.9967819808554961d), new NpgsqlTypes.NpgsqlLine(a: 0.06744335019688841d, b: 0.6552102548470619d, c: 0.7331561626448517d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2623900040492433d, b: 0.9027685460202522d, c: 0.5445131516527952d), new NpgsqlTypes.NpgsqlLine(a: 0.2038211316148053d, b: 0.8143878776236396d, c: 0.8642663854415117d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8916853411872961d, b: 0.021052112456841132d, c: 0.7057271542976071d), new NpgsqlTypes.NpgsqlLine(a: 0.11764775925900584d, b: 0.3757731125385416d, c: 0.07943822299851866d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8272067374636437d, b: 0.19438665067791938d, c: 0.3609402415088888d), new NpgsqlTypes.NpgsqlLine(a: 0.4923938918092662d, b: 0.3279634786956035d, c: 0.7687360839695647d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8040381015799043d, b: 0.4585507299550424d, c: 0.01854775916073559d), new NpgsqlTypes.NpgsqlLine(a: 0.8364635423141651d, b: 0.9280937644699258d, c: 0.14706456024950787d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4104460581034661d, b: 0.30918014146440687d, c: 0.42447697034793164d), new NpgsqlTypes.NpgsqlLine(a: 0.26514846190638286d, b: 0.3219268858306933d, c: 0.9167428746768157d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7649353108726752d, b: 0.7906572465236745d, c: 0.5395271391123166d), new NpgsqlTypes.NpgsqlLine(a: 0.9234890485821796d, b: 0.913271123855544d, c: 0.022199116405421715d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4793855233396398d, b: 0.3922497066228263d, c: 0.9993658899982398d), new NpgsqlTypes.NpgsqlLine(a: 0.42267354884604114d, b: 0.09630966420614917d, c: 0.505579971979619d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.16939211891819062d, b: 0.3245751988445297d, c: 0.44265495846374736d), new NpgsqlTypes.NpgsqlLine(a: 0.4835469881693075d, b: 0.8568491498879527d, c: 0.15855399146803462d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8546479661824532d, b: 0.8174057934950271d, c: 0.5732291352934608d), new NpgsqlTypes.NpgsqlLine(a: 0.7428653665659073d, b: 0.8694389650262772d, c: 0.12642140311393468d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.44318960076405656d, b: 0.9822303099332752d, c: 0.584701072663813d), new NpgsqlTypes.NpgsqlLine(a: 0.5097798273570863d, b: 0.4360906298088081d, c: 0.7865292631909859d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6058903888781696d, b: 0.05288891971387344d, c: 0.9542796812665246d), new NpgsqlTypes.NpgsqlLine(a: 0.7162192488356921d, b: 0.42539930169240314d, c: 0.7368757118422746d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.17098762880137064d, b: 0.4287979142207934d, c: 0.5049716484686168d), new NpgsqlTypes.NpgsqlLine(a: 0.48111582517161067d, b: 0.37878517662385924d, c: 0.4172567908240167d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3930202849976774d, b: 0.13424017506758634d, c: 0.8073794384394553d), new NpgsqlTypes.NpgsqlLine(a: 0.8711415887996514d, b: 0.12665763119139406d, c: 0.5519173147036728d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8348693207136616d, b: 0.9840125053246882d, c: 0.7973083911244635d), new NpgsqlTypes.NpgsqlLine(a: 0.6279545383277315d, b: 0.5913070212580195d, c: 0.16001491438527393d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.0801573860209831d, b: 0.8887162804418064d, c: 0.6028772994418703d), new NpgsqlTypes.NpgsqlLine(a: 0.808305926435185d, b: 0.12233620137205536d, c: 0.8149971644537407d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.11655985269306224d, b: 0.5300174824174325d, c: 0.978082609008423d), new NpgsqlTypes.NpgsqlLine(a: 0.019875572310183443d, b: 0.8003247398443502d, c: 0.9830425455388807d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9183134674869675d, b: 0.3287922293886605d, c: 0.1931150907825645d), new NpgsqlTypes.NpgsqlLine(a: 0.8426764416764119d, b: 0.9455286553708822d, c: 0.2769032893273483d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9951244280924356d, b: 0.966335745890612d, c: 0.2587643751208907d), new NpgsqlTypes.NpgsqlLine(a: 0.33910128345025947d, b: 0.03587514026768468d, c: 0.03936576126004021d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.16779323607317265d, b: 0.9378262200208871d, c: 0.5359313821515534d), new NpgsqlTypes.NpgsqlLine(a: 0.6447948131757093d, b: 0.10035011512653391d, c: 0.41763072776864285d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.0880901158134424d, b: 0.9239199599995257d, c: 0.885142984873437d), new NpgsqlTypes.NpgsqlLine(a: 0.8669233068939697d, b: 0.3105743115093792d, c: 0.2058446036511763d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.419621181739792d, b: 0.3767321740768612d, c: 0.9404250843628349d), new NpgsqlTypes.NpgsqlLine(a: 0.32285721189444416d, b: 0.41131301559549993d, c: 0.22875876225264413d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12787909319657254d, b: 0.8569474208560668d, c: 0.9233879275706475d), new NpgsqlTypes.NpgsqlLine(a: 0.23618708678569944d, b: 0.7748495574469018d, c: 0.82299654381982d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.00612477299187697d, b: 0.7836502121842387d, c: 0.5931309382788096d), new NpgsqlTypes.NpgsqlLine(a: 0.026536791873399412d, b: 0.6518821425288356d, c: 0.5399141006896526d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9996093781949289d, b: 0.7558116706691269d, c: 0.5497390951693426d), new NpgsqlTypes.NpgsqlLine(a: 0.41042902530609804d, b: 0.9849744993975571d, c: 0.8151053078487531d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23458642655633033d, b: 0.9055456104660775d, c: 0.9332779945490456d), new NpgsqlTypes.NpgsqlLine(a: 0.9377428935240618d, b: 0.3725929735529695d, c: 0.9083485907389048d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.10375127564146724d, b: 0.8568514475049308d, c: 0.016782285621465887d), new NpgsqlTypes.NpgsqlLine(a: 0.7158994014895659d, b: 0.6963422143350815d, c: 0.9955672667944501d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.14143962354775097d, b: 0.17139227507066013d, c: 0.5655135895495715d), new NpgsqlTypes.NpgsqlLine(a: 0.11730181635240455d, b: 0.09582998185533331d, c: 0.9131285152494033d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7997794259385117d, b: 0.8873231538336279d, c: 0.6147658478596385d), new NpgsqlTypes.NpgsqlLine(a: 0.8128493620800895d, b: 0.3714472503897909d, c: 0.8275314626823503d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.536108227454676d, b: 0.3135900473980473d, c: 0.3699425348359575d), new NpgsqlTypes.NpgsqlLine(a: 0.9328168106462659d, b: 0.5942780079072432d, c: 0.3003348864868325d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9340111144171819d, b: 0.309275801853236d, c: 0.3029557576445545d), new NpgsqlTypes.NpgsqlLine(a: 0.544764093223872d, b: 0.04134071933426564d, c: 0.6675173858906772d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.12929599594050734d, b: 0.17428648946568615d, c: 0.6061335385313773d), new NpgsqlTypes.NpgsqlLine(a: 0.9568002589865965d, b: 0.5502162185767195d, c: 0.23981927556264226d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2863083166299085d, b: 0.02443816482599037d, c: 0.36368656412318756d), new NpgsqlTypes.NpgsqlLine(a: 0.9521022259772275d, b: 0.9445857172932773d, c: 0.2756677576702232d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9175442686317883d, b: 0.6773343995039312d, c: 0.7212345090261048d), new NpgsqlTypes.NpgsqlLine(a: 0.8288727267922477d, b: 0.454769555481805d, c: 0.4251135993757319d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9156808990903718d, b: 0.48945420074984347d, c: 0.7528154539007313d), new NpgsqlTypes.NpgsqlLine(a: 0.6013139942021981d, b: 0.972351759637085d, c: 0.09827409806672216d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.0808050175118018d, b: 0.9035560998854498d, c: 0.4710225575709497d), new NpgsqlTypes.NpgsqlLine(a: 0.06762407562421457d, b: 0.13921696734162836d, c: 0.07011346431509191d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.35161935520945053d, b: 0.26884004273690265d, c: 0.21109770572808506d), new NpgsqlTypes.NpgsqlLine(a: 0.28254415698893787d, b: 0.11335022514675308d, c: 0.72963906958857d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4300464313541067d, b: 0.5922636393911089d, c: 0.36367534864227147d), new NpgsqlTypes.NpgsqlLine(a: 0.036992284087005056d, b: 0.32380931419714576d, c: 0.3981998585134111d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2545140026894587d, b: 0.49003727347907555d, c: 0.0469347555519567d), new NpgsqlTypes.NpgsqlLine(a: 0.4605233953085178d, b: 0.4053942815702727d, c: 0.9020784039683332d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.92546867602288d, b: 0.6736186912454744d, c: 0.22832249511560587d), new NpgsqlTypes.NpgsqlLine(a: 0.008627572810783746d, b: 0.485754860110748d, c: 0.17425448604196037d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8432647681128281d, b: 0.9717887207688501d, c: 0.6281029232891647d), new NpgsqlTypes.NpgsqlLine(a: 0.5039671084746062d, b: 0.3752049330497864d, c: 0.8059014703916374d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.028993737865855795d, b: 0.08728992848419648d, c: 0.24983180851313713d), new NpgsqlTypes.NpgsqlLine(a: 0.2519791865992457d, b: 0.5060567514732842d, c: 0.2234645490353031d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 175,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.011186336462602031d, b: 0.5531856855547306d, c: 0.1762408316945212d), new NpgsqlTypes.NpgsqlLine(a: 0.17036462223439186d, b: 0.6614175888651393d, c: 0.0211686432214393d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.39130187679976125d, b: 0.6717405729154071d, c: 0.7676821378296032d), new NpgsqlTypes.NpgsqlLine(a: 0.126046286370865d, b: 0.8935365533591269d, c: 0.9278852637577781d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2011378193245048d, b: 0.3937013086990584d, c: 0.7242552424664315d), new NpgsqlTypes.NpgsqlLine(a: 0.09567531239716542d, b: 0.14666395865796444d, c: 0.9339864020865575d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9942391924549321d, b: 0.6342564057842583d, c: 0.4943355712127768d), new NpgsqlTypes.NpgsqlLine(a: 0.21593866378308124d, b: 0.1814052522169174d, c: 0.018231070862530396d), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5549153594251123d, b: 0.2154982443539265d, c: 0.2670300429017275d), new NpgsqlTypes.NpgsqlLine(a: 0.07700038255662378d, b: 0.5332483142589315d, c: 0.5710585791556448d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.14455213026001978d, b: 0.16715145370519913d, c: 0.4117898174485244d), new NpgsqlTypes.NpgsqlLine(a: 0.18967303844813665d, b: 0.07756252302413391d, c: 0.021792683372237165d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.30345795389465147d, b: 0.6083688112638367d, c: 0.01932797118431928d), new NpgsqlTypes.NpgsqlLine(a: 0.9974799833180609d, b: 0.7146379171868017d, c: 0.44543278562083655d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4311156394656801d, b: 0.28147202983377784d, c: 0.8628864233342763d), new NpgsqlTypes.NpgsqlLine(a: 0.002253095332715893d, b: 0.460952779011535d, c: 0.5090383205392326d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.14543634906909986d, b: 0.7373501583922639d, c: 0.10188219687887723d), new NpgsqlTypes.NpgsqlLine(a: 0.8082738686424812d, b: 0.12600776096023059d, c: 0.3600340746202143d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.378296874634658d, b: 0.6576868807066203d, c: 0.6366268074526842d), new NpgsqlTypes.NpgsqlLine(a: 0.11562841355765296d, b: 0.08926421642485183d, c: 0.3311122718190729d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5857127957727268d, b: 0.7125715420821428d, c: 0.7158264492599931d), new NpgsqlTypes.NpgsqlLine(a: 0.660275298232529d, b: 0.4070773817931227d, c: 0.7141858688000221d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6094731223515703d, b: 0.17774572245988496d, c: 0.9912701788925651d), new NpgsqlTypes.NpgsqlLine(a: 0.5458748413176636d, b: 0.446973180184129d, c: 0.04604163906951375d), }, }));
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.686962938737763d, b: 0.6057984182225588d, c: 0.6924585314958656d), new NpgsqlTypes.NpgsqlLine(a: 0.7342589389652777d, b: 0.5454153618784849d, c: 0.4511087187315822d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.04752325038121208d, b: 0.5671885306520129d, c: 0.6494086508025738d), new NpgsqlTypes.NpgsqlLine(a: 0.5156077077473193d, b: 0.21350203323843087d, c: 0.7576523737759236d), }, }));
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9056890379436824d, b: 0.6613465281402237d, c: 0.21454171319644522d), new NpgsqlTypes.NpgsqlLine(a: 0.5547548028216183d, b: 0.28225524279932157d, c: 0.5226454832149424d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.10955074475646986d, b: 0.772920126676377d, c: 0.15614321218372562d), new NpgsqlTypes.NpgsqlLine(a: 0.7115789867038098d, b: 0.13639666193011402d, c: 0.6789252683226508d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 132, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 116, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 138, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 42, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 58, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 162, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 163, query1, 92, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 55, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 67, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 163);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
FROM public.binary_npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI), typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

