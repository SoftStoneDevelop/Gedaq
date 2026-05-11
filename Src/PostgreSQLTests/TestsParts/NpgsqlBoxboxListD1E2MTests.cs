

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
    internal partial interface INpgsqlBoxListboxListD1
    {
    }
    
    internal partial class NpgsqlBoxListboxListD1 : INpgsqlBoxListboxListD1
    {


#region TestData

        private readonly NpgsqlBoxboxListD1E2M[] _testData = new NpgsqlBoxboxListD1E2M[]
        {
            new NpgsqlBoxboxListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8175206143955859d,right: 0.41822145111000275d,bottom: 0.6342346563907146d,left: 0.06799252876031625d),

new NpgsqlTypes.NpgsqlBox(top: 0.7586831845116389d,right: 0.8152445883915507d,bottom: 0.2751767619648292d,left: 0.19994312543941306d),

new NpgsqlTypes.NpgsqlBox(top: 0.9735860355637516d,right: 0.8063347447229264d,bottom: 0.30811524930648304d,left: 0.7592345633405713d),

new NpgsqlTypes.NpgsqlBox(top: 0.2920433376244984d,right: 0.7727004465527033d,bottom: 0.2679553676391375d,left: 0.37274620420712956d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6755408980595852d,right: 0.24816156127263744d,bottom: 0.45278853797558727d,left: 0.11134468837433664d),

new NpgsqlTypes.NpgsqlBox(top: 0.7587280299081226d,right: 0.9643150036029132d,bottom: 0.3655140460502865d,left: 0.7958955053384124d),

new NpgsqlTypes.NpgsqlBox(top: 0.6160220156078327d,right: 0.8755609493381306d,bottom: 0.5746178479832404d,left: 0.3040395353235811d),

new NpgsqlTypes.NpgsqlBox(top: 0.7731356828740351d,right: 0.7708034039884274d,bottom: 0.7289847099629562d,left: 0.755303795580455d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22259200544776436d,right: 0.597999006910887d,bottom: 0.21901714031755914d,left: 0.5231176930133923d),

new NpgsqlTypes.NpgsqlBox(top: 0.6870427814500667d,right: 0.832538724833539d,bottom: 0.4570210932207528d,left: 0.6864645325688408d),

new NpgsqlTypes.NpgsqlBox(top: 0.4829531761638659d,right: 0.8473104963231471d,bottom: 0.22796985439689754d,left: 0.4567408029534501d),

new NpgsqlTypes.NpgsqlBox(top: 0.8817616687921312d,right: 0.8926460763993848d,bottom: 0.5549486644918553d,left: 0.7736547494244103d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5692740494716583d,right: 0.6514787641255493d,bottom: 0.5036466428615406d,left: 0.1790801475355558d),

new NpgsqlTypes.NpgsqlBox(top: 0.6822849182080821d,right: 0.6957622569756624d,bottom: 0.11938777833707592d,left: 0.6412700436893237d),

new NpgsqlTypes.NpgsqlBox(top: 0.9350074867236523d,right: 0.7760251942501007d,bottom: 0.8004032752445589d,left: 0.6239729000522246d),

new NpgsqlTypes.NpgsqlBox(top: 0.9792974881342027d,right: 0.9845066094008931d,bottom: 0.27209396832814603d,left: 0.8115771619763625d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.33992346171495713d,right: 0.8862625219843288d,bottom: 0.3059400997944155d,left: 0.04501260932108797d),

new NpgsqlTypes.NpgsqlBox(top: 0.7855137650352969d,right: 0.9424887600897519d,bottom: 0.6575503202515564d,left: 0.04808704857376933d),

new NpgsqlTypes.NpgsqlBox(top: 0.8722749490870509d,right: 0.9149637660152187d,bottom: 0.6504674507020223d,left: 0.677130290553336d),

new NpgsqlTypes.NpgsqlBox(top: 0.8842155085220949d,right: 0.7263002843801902d,bottom: 0.441285516550731d,left: 0.32051975540759314d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4966732769050234d,right: 0.4151703953532405d,bottom: 0.2817556511754009d,left: 0.11179237550501764d),

new NpgsqlTypes.NpgsqlBox(top: 0.9272023918237673d,right: 0.41427698415438297d,bottom: 0.8345325813321941d,left: 0.27717058767535596d),

new NpgsqlTypes.NpgsqlBox(top: 0.4984934808729865d,right: 0.62344663560775d,bottom: 0.3417692594516837d,left: 0.5455612862871408d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.834142730636342d,right: 0.8438677887481789d,bottom: 0.06589826097889628d,left: 0.45200151799950283d),

new NpgsqlTypes.NpgsqlBox(top: 0.7811060326574363d,right: 0.8240294936394559d,bottom: 0.32150829703163586d,left: 0.20598067201456005d),

new NpgsqlTypes.NpgsqlBox(top: 0.5678887133327739d,right: 0.7242489880106295d,bottom: 0.3388432364461226d,left: 0.2386974501596011d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.47563232466193317d,right: 0.42822027968273535d,bottom: 0.2376337955400626d,left: 0.30777615982310524d),

new NpgsqlTypes.NpgsqlBox(top: 0.39327130938834665d,right: 0.940444800475107d,bottom: 0.2736767518073623d,left: 0.0724082012729621d),

new NpgsqlTypes.NpgsqlBox(top: 0.720658311435327d,right: 0.9540307317101405d,bottom: 0.2657970297310345d,left: 0.6760749707398533d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8517460780534828d,right: 0.8705221707977242d,bottom: 0.6459597503391128d,left: 0.2054857979919782d),

new NpgsqlTypes.NpgsqlBox(top: 0.9504767371948951d,right: 0.8476422542781324d,bottom: 0.25477531807238407d,left: 0.8054156105940646d),

new NpgsqlTypes.NpgsqlBox(top: 0.9617649992315139d,right: 0.6317570727213653d,bottom: 0.11614050531761211d,left: 0.28196547940596883d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.17422505440979386d,right: 0.868952434780336d,bottom: 0.17054943982608073d,left: 0.5044873037941264d),

new NpgsqlTypes.NpgsqlBox(top: 0.7573162178004522d,right: 0.629978979934803d,bottom: 0.4941212474696728d,left: 0.4460692239192483d),

new NpgsqlTypes.NpgsqlBox(top: 0.7873527806083657d,right: 0.8633728228927847d,bottom: 0.7472904589073359d,left: 0.58907377081945d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1505175022712928d,right: 0.7481152764614775d,bottom: 0.08166700812209415d,left: 0.5736918767762389d),

new NpgsqlTypes.NpgsqlBox(top: 0.7746506619467033d,right: 0.9950687495691984d,bottom: 0.5127753227998398d,left: 0.7756725902878169d),

new NpgsqlTypes.NpgsqlBox(top: 0.32814634882126725d,right: 0.5691280119708312d,bottom: 0.21850636408033408d,left: 0.050654615506682044d),

new NpgsqlTypes.NpgsqlBox(top: 0.5676580677732566d,right: 0.5373169753163077d,bottom: 0.41823471048367d,left: 0.004155460199169236d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9271206239640611d,right: 0.4954203933776554d,bottom: 0.35345688131247566d,left: 0.2915452409810465d),

new NpgsqlTypes.NpgsqlBox(top: 0.4941286480621384d,right: 0.5609502467307759d,bottom: 0.48238852440844593d,left: 0.03202463422876922d),

new NpgsqlTypes.NpgsqlBox(top: 0.9124584935918552d,right: 0.9808300405652879d,bottom: 0.4322686346080308d,left: 0.19005854618093787d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9365502003067198d,right: 0.21347372385826835d,bottom: 0.14786137155380563d,left: 0.1277573968175728d),

new NpgsqlTypes.NpgsqlBox(top: 0.9432739008460551d,right: 0.5302086295092677d,bottom: 0.4069949298663207d,left: 0.11120737342748843d),

new NpgsqlTypes.NpgsqlBox(top: 0.45897835924548436d,right: 0.6375560928047234d,bottom: 0.33274140148031306d,left: 0.21932755665136072d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7947548647196261d,right: 0.5793928452290754d,bottom: 0.13243577509586413d,left: 0.20513889854096645d),

new NpgsqlTypes.NpgsqlBox(top: 0.8977712412292117d,right: 0.4031947105967002d,bottom: 0.8907542284110329d,left: 0.026717253280413522d),

new NpgsqlTypes.NpgsqlBox(top: 0.34294992518939316d,right: 0.8588712364099621d,bottom: 0.19850722500694118d,left: 0.319489452769379d),

new NpgsqlTypes.NpgsqlBox(top: 0.9063715382461162d,right: 0.9608747518662243d,bottom: 0.20656438813146272d,left: 0.47638810209953275d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3722687769344948d,right: 0.5163890145078103d,bottom: 0.3154121049851776d,left: 0.2715084789369687d),

new NpgsqlTypes.NpgsqlBox(top: 0.4780145546579315d,right: 0.5081906552453873d,bottom: 0.2592795221764115d,left: 0.18707343886528294d),

new NpgsqlTypes.NpgsqlBox(top: 0.8074777361798682d,right: 0.5751549245716274d,bottom: 0.7709406597535468d,left: 0.2273668496426796d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9013113639235342d,right: 0.22970015660610377d,bottom: 0.1404900132445398d,left: 0.024142445670394586d),

new NpgsqlTypes.NpgsqlBox(top: 0.9285771083782041d,right: 0.8783972574966367d,bottom: 0.8431885952927232d,left: 0.7699714189627419d),

new NpgsqlTypes.NpgsqlBox(top: 0.6651469908282114d,right: 0.8729360915368846d,bottom: 0.5184269914778264d,left: 0.2750496816917788d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5584828642929092d,right: 0.5376669143790046d,bottom: 0.025116667181009134d,left: 0.10210416750013929d),

new NpgsqlTypes.NpgsqlBox(top: 0.9557082239917329d,right: 0.9790346398977511d,bottom: 0.6366780094821463d,left: 0.490059587708497d),

new NpgsqlTypes.NpgsqlBox(top: 0.4681519041457539d,right: 0.2777279811174669d,bottom: 0.32422435342276d,left: 0.10480490348068283d),

new NpgsqlTypes.NpgsqlBox(top: 0.6137106231275847d,right: 0.6038958482164503d,bottom: 0.5638272791628561d,left: 0.428978692534272d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6908702133537514d,right: 0.24633376582733402d,bottom: 0.2625092859527306d,left: 0.17000441394928356d),

new NpgsqlTypes.NpgsqlBox(top: 0.7391601332858934d,right: 0.7398767363346714d,bottom: 0.43739906273062756d,left: 0.018746585113016967d),

new NpgsqlTypes.NpgsqlBox(top: 0.624814350661863d,right: 0.7316809828271457d,bottom: 0.2169694092558796d,left: 0.5270098468132053d),

new NpgsqlTypes.NpgsqlBox(top: 0.575716994190473d,right: 0.7692781131371451d,bottom: 0.5619638061148388d,left: 0.7532247822246522d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6469336600686078d,right: 0.982014053555805d,bottom: 0.4783806633067952d,left: 0.24824462468691966d),

new NpgsqlTypes.NpgsqlBox(top: 0.8418273337434788d,right: 0.09646574283408871d,bottom: 0.7558724239072973d,left: 0.04372809421532031d),

new NpgsqlTypes.NpgsqlBox(top: 0.8577337753457517d,right: 0.8519180582347685d,bottom: 0.12222837993012592d,left: 0.5787023349473114d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6021335876777992d,right: 0.7676539324483914d,bottom: 0.010666015067299583d,left: 0.7586218252624928d),

new NpgsqlTypes.NpgsqlBox(top: 0.8686942358306682d,right: 0.9359999009379317d,bottom: 0.45279287621513165d,left: 0.24651485121263828d),

new NpgsqlTypes.NpgsqlBox(top: 0.7231121090901589d,right: 0.8390109908524569d,bottom: 0.5259449920920627d,left: 0.19768504729280112d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1609988976064557d,right: 0.25155396775947014d,bottom: 0.02054354338705522d,left: 0.08093528397414385d),

new NpgsqlTypes.NpgsqlBox(top: 0.7209027268094392d,right: 0.9126128951899627d,bottom: 0.6942735192852812d,left: 0.3353797385361462d),

new NpgsqlTypes.NpgsqlBox(top: 0.4870518865150514d,right: 0.6875237371179126d,bottom: 0.3584241868953243d,left: 0.33883359333260743d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5820857725518839d,right: 0.7348265039184952d,bottom: 0.016640604163324246d,left: 0.4898986978475621d),

new NpgsqlTypes.NpgsqlBox(top: 0.6525614458730324d,right: 0.9686198694429382d,bottom: 0.32704754233242206d,left: 0.3533048235720012d),

new NpgsqlTypes.NpgsqlBox(top: 0.5852557759217484d,right: 0.8813842892658962d,bottom: 0.35810602751410525d,left: 0.15721064026214404d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4447499891090695d,right: 0.9481289052679248d,bottom: 0.0007685487612096864d,left: 0.08608464251271397d),

new NpgsqlTypes.NpgsqlBox(top: 0.6494873217584601d,right: 0.9709191142823203d,bottom: 0.6358862229909998d,left: 0.7074545077733624d),

new NpgsqlTypes.NpgsqlBox(top: 0.7295477620102017d,right: 0.26290064589999207d,bottom: 0.43364435477130636d,left: 0.12653930411177738d),

new NpgsqlTypes.NpgsqlBox(top: 0.7967413907087215d,right: 0.0799576797623035d,bottom: 0.27853948462807243d,left: 0.049139453983132464d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6558321446363294d,right: 0.5562931190245878d,bottom: 0.10236551750241363d,left: 0.14872520930962585d),

new NpgsqlTypes.NpgsqlBox(top: 0.11933095970757357d,right: 0.8610973690670527d,bottom: 0.06188867354740868d,left: 0.37203421988246144d),

new NpgsqlTypes.NpgsqlBox(top: 0.6099429026840697d,right: 0.38449508272635824d,bottom: 0.32835568707084306d,left: 0.22095705772559493d),

new NpgsqlTypes.NpgsqlBox(top: 0.958269101353743d,right: 0.9234676428739274d,bottom: 0.7647965691302635d,left: 0.8289552760081906d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.656852082835053d,right: 0.4508233194148151d,bottom: 0.08859434076342654d,left: 0.14267731702161301d),

new NpgsqlTypes.NpgsqlBox(top: 0.9910052770552441d,right: 0.5170447806286775d,bottom: 0.11050105630461049d,left: 0.2945545931663094d),

new NpgsqlTypes.NpgsqlBox(top: 0.4478293287067181d,right: 0.15045716732866365d,bottom: 0.3780327654466141d,left: 0.05509367461212111d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8253591172319354d,right: 0.9044119261243339d,bottom: 0.739088471940978d,left: 0.603896265340477d),

new NpgsqlTypes.NpgsqlBox(top: 0.4525944725253789d,right: 0.881081532053852d,bottom: 0.38107753903957287d,left: 0.4600790413621785d),

new NpgsqlTypes.NpgsqlBox(top: 0.5743686055551117d,right: 0.5644228952189961d,bottom: 0.10804740852350558d,left: 0.46814021024789376d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8985118390797181d,right: 0.7610710249657818d,bottom: 0.40190658710628946d,left: 0.6415897658335704d),

new NpgsqlTypes.NpgsqlBox(top: 0.7940340656769148d,right: 0.5274322244762457d,bottom: 0.4434651004518483d,left: 0.17871153613400503d),

new NpgsqlTypes.NpgsqlBox(top: 0.9276135843450986d,right: 0.8382188884447435d,bottom: 0.01171780982192705d,left: 0.20409062413278867d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37891872448242747d,right: 0.3847391063091735d,bottom: 0.33679651346335193d,left: 0.07385925190532627d),

new NpgsqlTypes.NpgsqlBox(top: 0.6669530581903502d,right: 0.6593368412423316d,bottom: 0.5391907172854675d,left: 0.05060872876918676d),

new NpgsqlTypes.NpgsqlBox(top: 0.7423199878948848d,right: 0.6001675638904689d,bottom: 0.22480120876460452d,left: 0.0500816407139455d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5795725281955831d,right: 0.7601248247440209d,bottom: 0.10891399806499658d,left: 0.22104999750274779d),

new NpgsqlTypes.NpgsqlBox(top: 0.7478502897590067d,right: 0.6340634559115343d,bottom: 0.31917268820314515d,left: 0.5302241692120937d),

new NpgsqlTypes.NpgsqlBox(top: 0.7767102530288964d,right: 0.8192493135153577d,bottom: 0.3070880258246049d,left: 0.706808705305822d),

new NpgsqlTypes.NpgsqlBox(top: 0.9431663185228795d,right: 0.3521248411757917d,bottom: 0.4603766044265475d,left: 0.30645830579156186d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9351515579111361d,right: 0.7361395296089709d,bottom: 0.6256999471969779d,left: 0.49695795934315357d),

new NpgsqlTypes.NpgsqlBox(top: 0.7454210306130357d,right: 0.9894560519222795d,bottom: 0.3708026352910758d,left: 0.9566809990101847d),

new NpgsqlTypes.NpgsqlBox(top: 0.5817273970587824d,right: 0.26933820690046006d,bottom: 0.09033976798816079d,left: 0.25099305614671485d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5961343713194687d,right: 0.8869391334882045d,bottom: 0.0360254112969548d,left: 0.11470600179512347d),

new NpgsqlTypes.NpgsqlBox(top: 0.18027712287153896d,right: 0.32986320159896887d,bottom: 0.036654193347568476d,left: 0.2718965385882902d),

new NpgsqlTypes.NpgsqlBox(top: 0.7802517260778873d,right: 0.8625955910752423d,bottom: 0.4596050447475236d,left: 0.7583922621848208d),

new NpgsqlTypes.NpgsqlBox(top: 0.5484847118652374d,right: 0.4374323445853142d,bottom: 0.3727261984410576d,left: 0.39789378624401783d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9578688955712312d,right: 0.8978448124441543d,bottom: 0.37234175568553163d,left: 0.39082461206472907d),

new NpgsqlTypes.NpgsqlBox(top: 0.7579459251620205d,right: 0.6616615015941911d,bottom: 0.6670514270232494d,left: 0.44547826308926464d),

new NpgsqlTypes.NpgsqlBox(top: 0.9847770713222415d,right: 0.19720874728177262d,bottom: 0.1572073259696828d,left: 0.13659502746766183d),

new NpgsqlTypes.NpgsqlBox(top: 0.7479760837060753d,right: 0.9430382324462847d,bottom: 0.5603928097185519d,left: 0.7540351694936316d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1610136659712963d,right: 0.9404599980140185d,bottom: 0.10412807254453005d,left: 0.6593226104251627d),

new NpgsqlTypes.NpgsqlBox(top: 0.33533753406061517d,right: 0.8019078708813097d,bottom: 0.289199557383208d,left: 0.09243909259230132d),

new NpgsqlTypes.NpgsqlBox(top: 0.9398851720502895d,right: 0.7883024445947894d,bottom: 0.8255691064898717d,left: 0.6906082897203794d),

new NpgsqlTypes.NpgsqlBox(top: 0.6646200806295783d,right: 0.8196174135789139d,bottom: 0.6616968742976438d,left: 0.6441608908008537d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7909480973997202d,right: 0.5972979129920841d,bottom: 0.07774675846560575d,left: 0.20169386978306325d),

new NpgsqlTypes.NpgsqlBox(top: 0.9000455807393266d,right: 0.9316286368551583d,bottom: 0.0039038290534633147d,left: 0.6363177416205185d),

new NpgsqlTypes.NpgsqlBox(top: 0.38329691434029733d,right: 0.8990247185352043d,bottom: 0.2754201023437953d,left: 0.2528624986182414d),

new NpgsqlTypes.NpgsqlBox(top: 0.37472860585748746d,right: 0.2764775141266336d,bottom: 0.16128896050831532d,left: 0.23794132497577758d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.03695354180541499d,right: 0.6812030959583912d,bottom: 0.00736521963029102d,left: 0.10826633617623127d),

new NpgsqlTypes.NpgsqlBox(top: 0.9039477408622564d,right: 0.5165450645542591d,bottom: 0.6525903708783041d,left: 0.5045703858606436d),

new NpgsqlTypes.NpgsqlBox(top: 0.538055199459817d,right: 0.28489447603361173d,bottom: 0.3291520077995612d,left: 0.1342304247384306d),

new NpgsqlTypes.NpgsqlBox(top: 0.3458488664072782d,right: 0.19717303914102746d,bottom: 0.1915693200968578d,left: 0.09156420713647018d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9780614567227797d,right: 0.18286547288087385d,bottom: 0.016019880075341053d,left: 0.03902247168745976d),

new NpgsqlTypes.NpgsqlBox(top: 0.7559787947181509d,right: 0.2704441729676279d,bottom: 0.47353907884197943d,left: 0.18949266998155256d),

new NpgsqlTypes.NpgsqlBox(top: 0.5103616999970839d,right: 0.4284200392224544d,bottom: 0.24518449708718615d,left: 0.21205564854398562d),

new NpgsqlTypes.NpgsqlBox(top: 0.3583251955573592d,right: 0.9793805339013119d,bottom: 0.19632752329389302d,left: 0.03851792095794726d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8135846559801734d,right: 0.907369887625239d,bottom: 0.20929188762563422d,left: 0.596025419043593d),

new NpgsqlTypes.NpgsqlBox(top: 0.19054426374642808d,right: 0.9528942627292464d,bottom: 0.027478051156143324d,left: 0.6380804303774171d),

new NpgsqlTypes.NpgsqlBox(top: 0.6452351555629937d,right: 0.6232038013977222d,bottom: 0.3699975093858079d,left: 0.5318960710634933d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.35695539548278465d,right: 0.6198075936486993d,bottom: 0.0996794911808302d,left: 0.1645383348282594d),

new NpgsqlTypes.NpgsqlBox(top: 0.9561517872390791d,right: 0.674717215125178d,bottom: 0.7942969014371227d,left: 0.4563082082736625d),

new NpgsqlTypes.NpgsqlBox(top: 0.6109784239259308d,right: 0.6266038221073849d,bottom: 0.43204813252063856d,left: 0.417223989085704d),

new NpgsqlTypes.NpgsqlBox(top: 0.7259955214694122d,right: 0.1789832228084045d,bottom: 0.7066797652980185d,left: 0.12360196819060243d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7117558525221996d,right: 0.3813743239359505d,bottom: 0.028871242612626524d,left: 0.2822016091592279d),

new NpgsqlTypes.NpgsqlBox(top: 0.6343519709433265d,right: 0.5300704017685789d,bottom: 0.5648920794192621d,left: 0.14309640307868665d),

new NpgsqlTypes.NpgsqlBox(top: 0.9214285608887846d,right: 0.9536158463803645d,bottom: 0.904575915629269d,left: 0.2972257924940016d),

new NpgsqlTypes.NpgsqlBox(top: 0.05819079548708461d,right: 0.23375423007832974d,bottom: 0.003096562071358777d,left: 0.1270272202366316d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42945414769078505d,right: 0.31270800497885176d,bottom: 0.13999326264825818d,left: 0.24537044101396344d),

new NpgsqlTypes.NpgsqlBox(top: 0.12899991124660404d,right: 0.41994975104763144d,bottom: 0.11526097122597023d,left: 0.16964823946693797d),

new NpgsqlTypes.NpgsqlBox(top: 0.8449957943134483d,right: 0.6019215554497892d,bottom: 0.6123793083355841d,left: 0.2469478569663659d),

new NpgsqlTypes.NpgsqlBox(top: 0.5050166717277045d,right: 0.6147108663816786d,bottom: 0.4841999928636619d,left: 0.3397422938693804d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5817057852927647d,right: 0.8654694969808511d,bottom: 0.31589807569876394d,left: 0.340326470182142d),

new NpgsqlTypes.NpgsqlBox(top: 0.970831600643203d,right: 0.23673285700877722d,bottom: 0.781301286089621d,left: 0.0853626018907141d),

new NpgsqlTypes.NpgsqlBox(top: 0.1957057467872978d,right: 0.7632207612723891d,bottom: 0.006543226403371127d,left: 0.4050575967250022d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5669475700400527d,right: 0.8919845425393795d,bottom: 0.22089723753799784d,left: 0.5734449732344373d),

new NpgsqlTypes.NpgsqlBox(top: 0.8191977390235092d,right: 0.6581923954465723d,bottom: 0.7246124745157067d,left: 0.10836388863668478d),

new NpgsqlTypes.NpgsqlBox(top: 0.8809913152203159d,right: 0.5253916268189268d,bottom: 0.3010737499856705d,left: 0.008755002682058866d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9581531206520201d,right: 0.39260129097231866d,bottom: 0.6370122579051201d,left: 0.3857072105479913d),

new NpgsqlTypes.NpgsqlBox(top: 0.6020142017573261d,right: 0.6938152555670574d,bottom: 0.15598497497820252d,left: 0.18291087878063228d),

new NpgsqlTypes.NpgsqlBox(top: 0.9784449926051824d,right: 0.5608389867957271d,bottom: 0.5806257117189265d,left: 0.41638195675451883d),

new NpgsqlTypes.NpgsqlBox(top: 0.38620748352613443d,right: 0.7809761631316517d,bottom: 0.37767387874610037d,left: 0.49277643672840543d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8860018462669514d,right: 0.3270314415266865d,bottom: 0.21113289496818632d,left: 0.250135698783124d),

new NpgsqlTypes.NpgsqlBox(top: 0.6111467448836189d,right: 0.570960888772094d,bottom: 0.552207749687293d,left: 0.3917002840219742d),

new NpgsqlTypes.NpgsqlBox(top: 0.5154880034879673d,right: 0.8659553584305523d,bottom: 0.3240807495367385d,left: 0.6375717367216561d),

new NpgsqlTypes.NpgsqlBox(top: 0.26848503350558206d,right: 0.48337207174593877d,bottom: 0.021986232221581914d,left: 0.32741352375561705d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7429970219377564d,right: 0.5660555115349905d,bottom: 0.21093294695073073d,left: 0.540559806781119d),

new NpgsqlTypes.NpgsqlBox(top: 0.8726475369623243d,right: 0.9074429927854388d,bottom: 0.0735776249087009d,left: 0.8929821688209696d),

new NpgsqlTypes.NpgsqlBox(top: 0.7478026036348975d,right: 0.5906289029824102d,bottom: 0.1759991415324511d,left: 0.5099463466321495d),

new NpgsqlTypes.NpgsqlBox(top: 0.8911323730598665d,right: 0.42392351979954335d,bottom: 0.4675687989984453d,left: 0.21335278093808174d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8299888444043129d,right: 0.5840371651756524d,bottom: 0.6530741620747282d,left: 0.09569701019229615d),

new NpgsqlTypes.NpgsqlBox(top: 0.9867763657747646d,right: 0.8048421227066432d,bottom: 0.2521689246798948d,left: 0.41335830462692635d),

new NpgsqlTypes.NpgsqlBox(top: 0.487822832816996d,right: 0.4130692915814953d,bottom: 0.055871781832378065d,left: 0.30513129619952606d),

new NpgsqlTypes.NpgsqlBox(top: 0.1730729197562676d,right: 0.5245803351439629d,bottom: 0.11782593472673497d,left: 0.2184159122690147d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8316109398375854d,right: 0.9565764006448657d,bottom: 0.7728459230458397d,left: 0.7312727651655933d),

new NpgsqlTypes.NpgsqlBox(top: 0.8792783279017918d,right: 0.8023306163613569d,bottom: 0.8601050611105574d,left: 0.1844504115549448d),

new NpgsqlTypes.NpgsqlBox(top: 0.9345504577418948d,right: 0.879642083705681d,bottom: 0.5413090725835497d,left: 0.2843363106004272d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8085718327091502d,right: 0.7364503835251868d,bottom: 0.15467291575434006d,left: 0.333838213311099d),

new NpgsqlTypes.NpgsqlBox(top: 0.3466473220598312d,right: 0.7085003959038734d,bottom: 0.051265070580249206d,left: 0.3905849007174881d),

new NpgsqlTypes.NpgsqlBox(top: 0.27202273129680976d,right: 0.6527038119239045d,bottom: 0.2516449567624226d,left: 0.07314399533546456d),

new NpgsqlTypes.NpgsqlBox(top: 0.9287034902422736d,right: 0.41581955615057853d,bottom: 0.1703332741407506d,left: 0.3336959936802554d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.39554650764616917d,right: 0.6653330355142446d,bottom: 0.23150956322972127d,left: 0.20596983322196394d),

new NpgsqlTypes.NpgsqlBox(top: 0.6236414821280164d,right: 0.4766175562510355d,bottom: 0.041478441933707644d,left: 0.4156784707295089d),

new NpgsqlTypes.NpgsqlBox(top: 0.4971233742974688d,right: 0.24814125051741565d,bottom: 0.49385076090541324d,left: 0.12339846359628592d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5112134196445485d,right: 0.9147689898386399d,bottom: 0.4823379855148082d,left: 0.6762412390346282d),

new NpgsqlTypes.NpgsqlBox(top: 0.32248559669208243d,right: 0.7606980211516834d,bottom: 0.28735520467019915d,left: 0.1752294577657546d),

new NpgsqlTypes.NpgsqlBox(top: 0.7851298779218735d,right: 0.3312636532844794d,bottom: 0.4019817913552206d,left: 0.12846075152318803d),

new NpgsqlTypes.NpgsqlBox(top: 0.5477811674373072d,right: 0.5131703560237785d,bottom: 0.3348338630896891d,left: 0.12824407017462247d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9561468460424546d,right: 0.9195005809152329d,bottom: 0.7961816388740586d,left: 0.029043565336228427d),

new NpgsqlTypes.NpgsqlBox(top: 0.6094502203022907d,right: 0.9662368183373752d,bottom: 0.15209810547318292d,left: 0.14753720263321157d),

new NpgsqlTypes.NpgsqlBox(top: 0.4638616830004283d,right: 0.3460458950944074d,bottom: 0.2692474136457409d,left: 0.05733243586139525d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5270249281168965d,right: 0.8649270226977581d,bottom: 0.4657170777398806d,left: 0.09602757849342602d),

new NpgsqlTypes.NpgsqlBox(top: 0.10114045235562263d,right: 0.3196581291349896d,bottom: 0.006659138630818018d,left: 0.14795013706294702d),

new NpgsqlTypes.NpgsqlBox(top: 0.8307791001123739d,right: 0.39490930730970697d,bottom: 0.6958715406673958d,left: 0.03371154523316977d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7682524837962506d,right: 0.9358845527226786d,bottom: 0.18760491180029837d,left: 0.9293980981751488d),

new NpgsqlTypes.NpgsqlBox(top: 0.9442968251078824d,right: 0.7323175286363389d,bottom: 0.33920455450727016d,left: 0.44810685356675506d),

new NpgsqlTypes.NpgsqlBox(top: 0.8961381065285725d,right: 0.7920132445373287d,bottom: 0.3459272033548926d,left: 0.2011022903641667d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6807261400992647d,right: 0.9543820037849639d,bottom: 0.4005342247593082d,left: 0.5133147578411172d),

new NpgsqlTypes.NpgsqlBox(top: 0.9962466322524084d,right: 0.9932977796581959d,bottom: 0.7696270431834725d,left: 0.5981323400605801d),

new NpgsqlTypes.NpgsqlBox(top: 0.7820068489795751d,right: 0.19060315722481136d,bottom: 0.03738715499320033d,left: 0.13074185475905276d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7287472784702228d,right: 0.7780170442010105d,bottom: 0.3520927521735502d,left: 0.24262882069626002d),

new NpgsqlTypes.NpgsqlBox(top: 0.32373035945483075d,right: 0.8732217862030498d,bottom: 0.25353181344069475d,left: 0.37088943800348695d),

new NpgsqlTypes.NpgsqlBox(top: 0.6728228751081784d,right: 0.9243220691887036d,bottom: 0.4513750751341302d,left: 0.2931880622971904d),

new NpgsqlTypes.NpgsqlBox(top: 0.7630949383934047d,right: 0.26640567013286454d,bottom: 0.39277701998311954d,left: 0.1957016413394802d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7800731663342586d,right: 0.1634867054953243d,bottom: 0.3071003747621246d,left: 0.08509315210247104d),

new NpgsqlTypes.NpgsqlBox(top: 0.9723642181976896d,right: 0.5984582548801536d,bottom: 0.6940250213522985d,left: 0.1977265390142996d),

new NpgsqlTypes.NpgsqlBox(top: 0.8782939408640658d,right: 0.5562246444932731d,bottom: 0.5715662156445737d,left: 0.3964422945924905d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.28845232904573426d,right: 0.9162423762673079d,bottom: 0.11494940596077563d,left: 0.09877923273152778d),

new NpgsqlTypes.NpgsqlBox(top: 0.7490071773341258d,right: 0.9839668764704705d,bottom: 0.6345391912375151d,left: 0.8393625922180432d),

new NpgsqlTypes.NpgsqlBox(top: 0.8136554433116228d,right: 0.5933878129369127d,bottom: 0.39458603858310537d,left: 0.4616309509181865d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8921188077595648d,right: 0.8880395346070666d,bottom: 0.25645185886958066d,left: 0.13939019899468574d),

new NpgsqlTypes.NpgsqlBox(top: 0.6452190231424255d,right: 0.6782798641606244d,bottom: 0.6311658544114845d,left: 0.060346396862991925d),

new NpgsqlTypes.NpgsqlBox(top: 0.4762180331398722d,right: 0.8988911218355264d,bottom: 0.37769137243233664d,left: 0.4713617032336258d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6610709837026141d,right: 0.9971419580097477d,bottom: 0.6529328407892689d,left: 0.36509785661744587d),

new NpgsqlTypes.NpgsqlBox(top: 0.7270255146505861d,right: 0.6129850961403568d,bottom: 0.24707294059166984d,left: 0.04291320846745639d),

new NpgsqlTypes.NpgsqlBox(top: 0.5065088433238408d,right: 0.7490097633108614d,bottom: 0.4486152028169177d,left: 0.6735227662599865d),

new NpgsqlTypes.NpgsqlBox(top: 0.8295275745497904d,right: 0.26567533344702376d,bottom: 0.7213086219359108d,left: 0.18934367463482615d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8937489990310673d,right: 0.6782678922414063d,bottom: 0.8178557582878297d,left: 0.5280665808133131d),

new NpgsqlTypes.NpgsqlBox(top: 0.8067098853973304d,right: 0.7437179658750709d,bottom: 0.10139262644958436d,left: 0.03730131578975038d),

new NpgsqlTypes.NpgsqlBox(top: 0.7064562111386654d,right: 0.7078315271614993d,bottom: 0.04460371830131127d,left: 0.6007231499820614d),

new NpgsqlTypes.NpgsqlBox(top: 0.9337680652391463d,right: 0.13453988400293937d,bottom: 0.4930528640671741d,left: 0.08268633282134075d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8456903856962629d,right: 0.31312064607903267d,bottom: 0.8294426844535743d,left: 0.16594938238099954d),

new NpgsqlTypes.NpgsqlBox(top: 0.3416348128662313d,right: 0.9349638270995373d,bottom: 0.008932196241211443d,left: 0.24058805704946895d),

new NpgsqlTypes.NpgsqlBox(top: 0.7486587188069515d,right: 0.48380578449461076d,bottom: 0.6849718157870365d,left: 0.29227392942439534d),

new NpgsqlTypes.NpgsqlBox(top: 0.23412637861402585d,right: 0.8938040572449019d,bottom: 0.1898362630295365d,left: 0.3633029864986479d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2825836425038537d,right: 0.778668758697114d,bottom: 0.06388650222169945d,left: 0.6161063098474138d),

new NpgsqlTypes.NpgsqlBox(top: 0.7275023004915299d,right: 0.8333822876062144d,bottom: 0.4088439927350128d,left: 0.15362316429106815d),

new NpgsqlTypes.NpgsqlBox(top: 0.6543126165965172d,right: 0.8771411526310485d,bottom: 0.12195790112123817d,left: 0.576000630362071d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9827741169726334d,right: 0.6804457299829254d,bottom: 0.9453571669819237d,left: 0.4626631825330999d),

new NpgsqlTypes.NpgsqlBox(top: 0.9214533237834436d,right: 0.2858003166992801d,bottom: 0.44753387394441957d,left: 0.053478083884237027d),

new NpgsqlTypes.NpgsqlBox(top: 0.41738357281888516d,right: 0.6301973908556161d,bottom: 0.215070469809575d,left: 0.43299606013904857d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8310264398547538d,right: 0.24800814132354543d,bottom: 0.7049182841563327d,left: 0.24096436070568572d),

new NpgsqlTypes.NpgsqlBox(top: 0.38930111108253185d,right: 0.8635696183662335d,bottom: 0.3745919591663589d,left: 0.5987412429051269d),

new NpgsqlTypes.NpgsqlBox(top: 0.9353702073503918d,right: 0.377817131134599d,bottom: 0.3763601339599457d,left: 0.33181840153505937d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.562715387288343d,right: 0.8391647338143696d,bottom: 0.3028284651224419d,left: 0.4988104628761014d),

new NpgsqlTypes.NpgsqlBox(top: 0.6119885081017219d,right: 0.8594128685632938d,bottom: 0.2687154728550871d,left: 0.33021973403304494d),

new NpgsqlTypes.NpgsqlBox(top: 0.36777981926398773d,right: 0.8598455658179325d,bottom: 0.2629080821293581d,left: 0.5743224850177802d),

new NpgsqlTypes.NpgsqlBox(top: 0.7115532679388064d,right: 0.331766175289654d,bottom: 0.1536745258403749d,left: 0.26624157242132807d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6878868930395102d,right: 0.9656585752413955d,bottom: 0.4086887164109222d,left: 0.8077212061564487d),

new NpgsqlTypes.NpgsqlBox(top: 0.7952079971024055d,right: 0.43594926986363425d,bottom: 0.3020245816555016d,left: 0.05306418596738449d),

new NpgsqlTypes.NpgsqlBox(top: 0.663273305773926d,right: 0.5388757307637558d,bottom: 0.4892911070864313d,left: 0.19089353779894414d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8601517818965543d,right: 0.27982477224056657d,bottom: 0.8484916417381576d,left: 0.24050809340437673d),

new NpgsqlTypes.NpgsqlBox(top: 0.8336601089394979d,right: 0.6329171805012033d,bottom: 0.21933286204329605d,left: 0.22883529352612608d),

new NpgsqlTypes.NpgsqlBox(top: 0.8690196824931121d,right: 0.6962470636249817d,bottom: 0.13113491430469826d,left: 0.17547333374167073d),

new NpgsqlTypes.NpgsqlBox(top: 0.1243288375571695d,right: 0.7933581567886145d,bottom: 0.09542149359068519d,left: 0.5218103344416035d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9446036116903784d,right: 0.5040557465780584d,bottom: 0.3045255694130924d,left: 0.43342357328272973d),

new NpgsqlTypes.NpgsqlBox(top: 0.8907640255982252d,right: 0.8413815970781809d,bottom: 0.6946476882408411d,left: 0.6819165929819726d),

new NpgsqlTypes.NpgsqlBox(top: 0.8869128940989022d,right: 0.9390813905205083d,bottom: 0.8552319371257737d,left: 0.128117311746755d),

new NpgsqlTypes.NpgsqlBox(top: 0.3667711478356217d,right: 0.522198931273401d,bottom: 0.0827025824152906d,left: 0.06295099207671673d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2174597787745991d,right: 0.18377970520780695d,bottom: 0.1866658277861759d,left: 0.08286944928174933d),

new NpgsqlTypes.NpgsqlBox(top: 0.9071878080642565d,right: 0.7409720454989428d,bottom: 0.30571464330037224d,left: 0.13888633582609933d),

new NpgsqlTypes.NpgsqlBox(top: 0.9412361425273358d,right: 0.44498950531554105d,bottom: 0.5891269318496549d,left: 0.393853548751273d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9679087897408373d,right: 0.9858804693847043d,bottom: 0.7657298044223684d,left: 0.5882168608241942d),

new NpgsqlTypes.NpgsqlBox(top: 0.24075710093135305d,right: 0.782826620006271d,bottom: 0.1680335577669657d,left: 0.10897097857124771d),

new NpgsqlTypes.NpgsqlBox(top: 0.20300629926889346d,right: 0.2677438620191077d,bottom: 0.17495670525702867d,left: 0.09697704310865729d),

new NpgsqlTypes.NpgsqlBox(top: 0.33450219937735237d,right: 0.8908141417393765d,bottom: 0.3023084830229622d,left: 0.6756319479693136d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5786750188289723d,right: 0.8584657623790974d,bottom: 0.26402162094266834d,left: 0.07551085248295986d),

new NpgsqlTypes.NpgsqlBox(top: 0.6220915377548965d,right: 0.6857605325706617d,bottom: 0.35302077323921033d,left: 0.6222288259962262d),

new NpgsqlTypes.NpgsqlBox(top: 0.4920487278140294d,right: 0.4830294806593871d,bottom: 0.4419998459690293d,left: 0.08754506190847089d),

new NpgsqlTypes.NpgsqlBox(top: 0.8628056085637483d,right: 0.3682189113380415d,bottom: 0.6411184573970149d,left: 0.061072951620731675d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8683725769617856d,right: 0.9504138566562751d,bottom: 0.7591448619959056d,left: 0.9500256288309342d),

new NpgsqlTypes.NpgsqlBox(top: 0.45247041943463895d,right: 0.3315495011116262d,bottom: 0.34201750803007225d,left: 0.18549365529516382d),

new NpgsqlTypes.NpgsqlBox(top: 0.9546124784714813d,right: 0.8754881832445843d,bottom: 0.6147049217117903d,left: 0.7764879073852352d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8832620514881995d,right: 0.39137347417125123d,bottom: 0.3623693322405348d,left: 0.2765919279893817d),

new NpgsqlTypes.NpgsqlBox(top: 0.5206035541988753d,right: 0.04566245787097767d,bottom: 0.4175401254901222d,left: 0.003986992089946129d),

new NpgsqlTypes.NpgsqlBox(top: 0.9889292768272488d,right: 0.28361796952195195d,bottom: 0.4733497481950194d,left: 0.11682433196693054d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7125755908972189d,right: 0.8276483891438693d,bottom: 0.630260781555596d,left: 0.13426929152765377d),

new NpgsqlTypes.NpgsqlBox(top: 0.33618429918871884d,right: 0.8684761539050655d,bottom: 0.30071057711342997d,left: 0.3436290977207167d),

new NpgsqlTypes.NpgsqlBox(top: 0.8351399888943701d,right: 0.9518508482952458d,bottom: 0.4805476878720677d,left: 0.4234680808631527d),

new NpgsqlTypes.NpgsqlBox(top: 0.6848603057077816d,right: 0.5751652695941677d,bottom: 0.20180513812236334d,left: 0.13819866440709838d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22208960075369133d,right: 0.6240858228164876d,bottom: 0.05440361298332441d,left: 0.2866632189144829d),

new NpgsqlTypes.NpgsqlBox(top: 0.7042295251373901d,right: 0.5753359509676128d,bottom: 0.041153952873756006d,left: 0.20255060879722508d),

new NpgsqlTypes.NpgsqlBox(top: 0.9569005408129132d,right: 0.8666296264908778d,bottom: 0.13696299243478527d,left: 0.3528550726992221d),

new NpgsqlTypes.NpgsqlBox(top: 0.8974384392699221d,right: 0.5511898164232139d,bottom: 0.34892224981708486d,left: 0.06834659572228485d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.19987557135962863d,right: 0.5147072638960515d,bottom: 0.1773468496808891d,left: 0.17256100638184158d),

new NpgsqlTypes.NpgsqlBox(top: 0.8779624318205967d,right: 0.3400182059137653d,bottom: 0.38626123763577636d,left: 0.08551221312065527d),

new NpgsqlTypes.NpgsqlBox(top: 0.8428218657768304d,right: 0.38402634907977173d,bottom: 0.8127721337835069d,left: 0.26029992200271856d),

new NpgsqlTypes.NpgsqlBox(top: 0.42309836057951933d,right: 0.3543505036788255d,bottom: 0.1431021789586816d,left: 0.09769727976996667d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37619334528100523d,right: 0.9293626857100439d,bottom: 0.32687519612957583d,left: 0.43849706602225746d),

new NpgsqlTypes.NpgsqlBox(top: 0.5808074413552915d,right: 0.5846952221147468d,bottom: 0.44467551067571587d,left: 0.023534705875158934d),

new NpgsqlTypes.NpgsqlBox(top: 0.9055378850135265d,right: 0.6383495884867111d,bottom: 0.8251207002585839d,left: 0.0923358540916892d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9329604677106719d,right: 0.536960873411902d,bottom: 0.7667747927283993d,left: 0.23056444026096956d),

new NpgsqlTypes.NpgsqlBox(top: 0.8143438880964948d,right: 0.6978715370575655d,bottom: 0.33625495316408494d,left: 0.4399912316103135d),

new NpgsqlTypes.NpgsqlBox(top: 0.7171072720832368d,right: 0.14626624907561292d,bottom: 0.02018533875203643d,left: 0.01677031478731006d),

new NpgsqlTypes.NpgsqlBox(top: 0.67979791337135d,right: 0.8096695672865148d,bottom: 0.41559128211185525d,left: 0.7569632760410747d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9457424190322985d,right: 0.6507097254946967d,bottom: 0.429249990621864d,left: 0.34241515114233045d),

new NpgsqlTypes.NpgsqlBox(top: 0.8684232969085849d,right: 0.8608617614006445d,bottom: 0.027435302600869793d,left: 0.4995021320846409d),

new NpgsqlTypes.NpgsqlBox(top: 0.9957532780895488d,right: 0.5261267503529756d,bottom: 0.6408697308274623d,left: 0.4707510254154592d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
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

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxlistd1e2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxListD1E2M> models = null;

                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxListD1E2M> models = null;

                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 71, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 125, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 150, query1, 69, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 147, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 149))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatch(connection, 26, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models = await ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[10], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[11], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[12], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[13], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[14], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[15], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[16], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[17], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[18], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[19], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[20], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[21], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[22], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[23], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[24], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[25], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[26], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[27], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MI),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxListD1E2M),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
FROM public.binary_npgsqlboxboxlistd1e2m m
LEFT JOIN public.binary_npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models =  ((INpgsqlBoxListboxListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI), typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models1 = new List<NpgsqlBoxboxListD1E2MI>();
                var models2 = new List<NpgsqlBoxboxListD1E2MI>();
                await ((INpgsqlBoxListboxListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MI>();
                var models2 = new List<NpgsqlBoxboxListD1E2MI>();
                ((INpgsqlBoxListboxListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

